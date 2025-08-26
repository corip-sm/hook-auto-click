using System;
using System.Diagnostics;
using System.Threading;
using HookAutoFire.Models;
using HookAutoFire.Native;
using static HookAutoFire.Native.Win32Api;
using static HookAutoFire.Native.Win32Constants;

namespace HookAutoFire.Services
{
    public class AutoFireService : IDisposable
    {
        private readonly MouseButtonState buttonState;
        private readonly MouseInputSimulator inputSimulator;
        private readonly KeyboardInputSimulator keyboardSimulator;
        private Thread? autoFireThread;
        private Thread? keyboardThread;
        private volatile bool shouldStop = false;
        
        // 설정 가능한 인터벌
        public int MouseInterval { get; set; } = 1;
        public int KeyboardInterval { get; set; } = 100;
        public int KeyboardDownLatency { get; set; } = 55; // DOWN 후 간격
        public int KeyboardUpLatency { get; set; } = 55; // UP 후 간격

        // 고정밀 타이머
        private readonly Stopwatch globalTimer = Stopwatch.StartNew();
        
        // 각 버튼별 다음 실행 시간 (밀리초)
        private double nextLeftMouseTime = 0;
        private double nextRightMouseTime = 0;
        private double nextMiddleMouseTime = 0;
        private double nextSpaceTime = 0;
        
        // 키보드 실행 중 플래그
        private volatile bool isSpaceExecuting = false;

        public AutoFireService(MouseButtonState buttonState, MouseInputSimulator inputSimulator)
        {
            this.buttonState = buttonState;
            this.inputSimulator = inputSimulator;
            this.keyboardSimulator = new KeyboardInputSimulator();
        }

        public void Start()
        {
            // 이미 실행 중이면 리턴
            if (autoFireThread != null && autoFireThread.IsAlive)
                return;
            if (keyboardThread != null && keyboardThread.IsAlive)
                return;

            shouldStop = false;
            
            // 타이머 리셋 (재시작 시 시간 초기화)
            globalTimer.Restart();
            
            // 다음 실행 시간 초기화
            nextLeftMouseTime = 0;
            nextRightMouseTime = 0;
            nextMiddleMouseTime = 0;
            nextSpaceTime = 0;
            
            // 마우스 처리 스레드
            autoFireThread = new Thread(AutoFireLoop)
            {
                IsBackground = true,
                Name = "AutoFireThread",
                Priority = ThreadPriority.Highest
            };
            autoFireThread.Start();
            
            // 키보드 처리 스레드
            keyboardThread = new Thread(KeyboardLoop)
            {
                IsBackground = true,
                Name = "KeyboardThread",
                Priority = ThreadPriority.Highest
            };
            keyboardThread.Start();
        }

        public void Stop()
        {
            shouldStop = true;

            if (autoFireThread != null && autoFireThread.IsAlive)
            {
                autoFireThread.Join(1000);
            }
            
            if (keyboardThread != null && keyboardThread.IsAlive)
            {
                keyboardThread.Join(1000);
            }
        }

        private void AutoFireLoop()
        {
            while (!shouldStop)
            {
                double currentTime = globalTimer.Elapsed.TotalMilliseconds;
                bool isXButton1Down = IsKeyPressed(VK_XBUTTON1);

                // X1 버튼이 눌렸을 때만 마우스 처리
                if (isXButton1Down)
                {
                    ProcessMouseAutoFire(currentTime);
                    Thread.Yield(); // CPU 양보
                }
                else
                {
                    Thread.Sleep(1); // X1이 안 눌렸을 때는 Sleep
                }
            }
        }
        
        private void KeyboardLoop()
        {
            while (!shouldStop)
            {
                double currentTime = globalTimer.Elapsed.TotalMilliseconds;
                
                // SPACE 키 자동 클릭 처리
                bool processed = ProcessKeyboardAutoFire(currentTime);
                
                if (processed)
                {
                    Thread.Yield(); // 처리했으면 CPU 양보
                }
                else
                {
                    Thread.Sleep(1); // 처리 안했으면 Sleep
                }
            }
        }

        private void ProcessAutoFire(MouseButton button)
        {
            // 참조 코드 스타일: 더 나은 반응성을 위해 UP 다음 DOWN
            inputSimulator.SimulateButtonUp(button);
            inputSimulator.SimulateButtonDown(button);
        }

        private void ProcessSpaceAutoFire()
        {
            ExecuteSpacePress();
        }

        private void ExecuteSpacePress()
        {
            // 이미 실행 중이면 리턴
            if (isSpaceExecuting) return;
            
            try
            {
                isSpaceExecuting = true;
                
                keyboardSimulator.SendKeyDown(VK_SPACE);
                
                // 정밀한 대기를 위한 SpinWait와 Sleep 조합
                if (KeyboardDownLatency > 0)
                {
                    PreciseWait(KeyboardDownLatency);
                }
                
                keyboardSimulator.SendKeyUp(VK_SPACE);
                
                if (KeyboardUpLatency > 0)
                {
                    PreciseWait(KeyboardUpLatency);
                }
            }
            finally
            {
                isSpaceExecuting = false;
            }
        }
        
        private void PreciseWait(int milliseconds)
        {
            if (milliseconds <= 0) return;
            
            // 1ms 이하면 SpinWait만 사용
            if (milliseconds == 1)
            {
                Thread.SpinWait(10000);
                return;
            }
            
            // 더 긴 시간은 Sleep과 SpinWait 조합
            var stopwatch = Stopwatch.StartNew();
            
            // 대부분의 시간은 Sleep으로
            if (milliseconds > 10)
            {
                Thread.Sleep(milliseconds - 10);
            }
            
            // 나머지는 정밀한 SpinWait로
            while (stopwatch.ElapsedMilliseconds < milliseconds)
            {
                Thread.SpinWait(100);
            }
        }

        private void ProcessMouseAutoFire(double currentTime)
        {
            // 각 마우스 버튼을 독립적으로 처리
            // AutoFire 상태를 먼저 확인하여 불필요한 Win32 API 호출 줄이기
            bool leftAutoFire = buttonState.GetAutoFireState(MouseButton.Left);
            bool rightAutoFire = buttonState.GetAutoFireState(MouseButton.Right);
            bool middleAutoFire = buttonState.GetAutoFireState(MouseButton.Middle);
            
            bool leftActive = leftAutoFire && IsKeyPressed(VK_LBUTTON);
            bool rightActive = rightAutoFire && IsKeyPressed(VK_RBUTTON);
            bool middleActive = middleAutoFire && IsKeyPressed(VK_MBUTTON);

            // 왼쪽 마우스
            if (leftActive)
            {
                if (nextLeftMouseTime == 0)
                {
                    // 첫 실행
                    ProcessAutoFire(MouseButton.Left);
                    nextLeftMouseTime = currentTime + MouseInterval;
                }
                else if (currentTime >= nextLeftMouseTime)
                {
                    ProcessAutoFire(MouseButton.Left);
                    nextLeftMouseTime += MouseInterval; // 정확한 간격 유지
                }
            }
            else
            {
                nextLeftMouseTime = 0; // 리셋
            }

            // 오른쪽 마우스
            if (rightActive)
            {
                if (nextRightMouseTime == 0)
                {
                    ProcessAutoFire(MouseButton.Right);
                    nextRightMouseTime = currentTime + MouseInterval;
                }
                else if (currentTime >= nextRightMouseTime)
                {
                    ProcessAutoFire(MouseButton.Right);
                    nextRightMouseTime += MouseInterval;
                }
            }
            else
            {
                nextRightMouseTime = 0;
            }

            // 가운데 마우스
            if (middleActive)
            {
                if (nextMiddleMouseTime == 0)
                {
                    ProcessAutoFire(MouseButton.Middle);
                    nextMiddleMouseTime = currentTime + MouseInterval;
                }
                else if (currentTime >= nextMiddleMouseTime)
                {
                    ProcessAutoFire(MouseButton.Middle);
                    nextMiddleMouseTime += MouseInterval;
                }
            }
            else
            {
                nextMiddleMouseTime = 0;
            }
        }

        private bool ProcessKeyboardAutoFire(double currentTime)
        {
            bool spaceAutoFire = buttonState.GetSpaceAutoFire();
            
            if (spaceAutoFire)
            {
                // 실행 중이면 대기 (DOWN-UP 사이클이 완료되어야 함)
                if (isSpaceExecuting)
                {
                    return false;
                }
                
                if (nextSpaceTime == 0)
                {
                    // 첫 실행
                    ProcessSpaceAutoFire();
                    nextSpaceTime = currentTime + KeyboardInterval;
                    return true;
                }
                else if (currentTime >= nextSpaceTime && !isSpaceExecuting)
                {
                    // 이전 실행이 완료되었고 시간이 되었을 때만
                    ProcessSpaceAutoFire();
                    nextSpaceTime += KeyboardInterval; // 정확한 간격 유지
                    return true;
                }
                return false; // 대기 중
            }
            else
            {
                nextSpaceTime = 0; // 리셋
                isSpaceExecuting = false; // 안전을 위해 리셋
                return false;
            }
        }

        private bool IsKeyPressed(int virtualKeyCode)
        {
            return (GetKeyState(virtualKeyCode) & 0x8000) != 0;
        }

        public void Dispose()
        {
            Stop();
        }
    }
}