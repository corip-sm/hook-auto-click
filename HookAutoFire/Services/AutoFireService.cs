using System;
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
        private volatile bool shouldStop = false;

        public AutoFireService(MouseButtonState buttonState, MouseInputSimulator inputSimulator)
        {
            this.buttonState = buttonState;
            this.inputSimulator = inputSimulator;
            this.keyboardSimulator = new KeyboardInputSimulator();
        }

        public void Start()
        {
            if (autoFireThread != null && autoFireThread.IsAlive)
                return;

            shouldStop = false;
            autoFireThread = new Thread(AutoFireLoop)
            {
                IsBackground = true,
                Name = "AutoFireThread"
            };
            autoFireThread.Start();
        }

        public void Stop()
        {
            shouldStop = true;

            if (autoFireThread != null && autoFireThread.IsAlive)
            {
                autoFireThread.Join(1000);
            }
        }

        private void AutoFireLoop()
        {
            bool isXButton1Down;
            bool isLButtonDown;
            bool isRButtonDown;
            bool isMButtonDown;
            bool isSpaceDown;

            while (!shouldStop)
            {
                try
                {
                    isXButton1Down = IsKeyPressed(VK_XBUTTON1);
                    isLButtonDown = IsKeyPressed(VK_LBUTTON);
                    isRButtonDown = IsKeyPressed(VK_RBUTTON);
                    isMButtonDown = IsKeyPressed(VK_MBUTTON);
                    isSpaceDown = IsKeyPressed(VK_SPACE);

                    if (isXButton1Down)
                    {
                        // 맄우스 자동 클릭
                        if (isLButtonDown && buttonState.GetAutoFireState(MouseButton.Left))
                        {
                            ProcessAutoFire(MouseButton.Left);
                        }
                        
                        if (isRButtonDown && buttonState.GetAutoFireState(MouseButton.Right))
                        {
                            ProcessAutoFire(MouseButton.Right);
                        }

                        if (isMButtonDown && buttonState.GetAutoFireState(MouseButton.Middle))
                        {
                            ProcessAutoFire(MouseButton.Middle);
                        }

                        // SPACE 키 자동 클릭
                        if (isSpaceDown && buttonState.GetSpaceAutoFire())
                        {
                            ProcessSpaceAutoFire();
                        }
                    }

                    Thread.Sleep(1);
                }
                catch (Exception)
                {
                    Thread.Sleep(10);
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
            // 동일한 패턴: 더 나은 반응성을 위해 UP 다음 DOWN
            keyboardSimulator.SendKeyUp(VK_SPACE);
            keyboardSimulator.SendKeyDown(VK_SPACE);
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