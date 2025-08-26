using System;
using System.Runtime.InteropServices;
using HookAutoFire.Models;
using HookAutoFire.Native;
using static HookAutoFire.Native.Win32Api;
using static HookAutoFire.Native.Win32Constants;

namespace HookAutoFire.Services
{
    public unsafe class MouseHookManager : IDisposable
    {
        private LowLevelMouseProc? mouseHookProc;
        private IntPtr mouseHookId;
        private readonly MouseButtonState buttonState;
        private readonly MouseInputSimulator inputSimulator;
        
        public event EventHandler<MouseButton>? MouseButtonDown;
        public event EventHandler<MouseButton>? MouseButtonUp;
        public event EventHandler? XButton1Released;
        
        public static Action<string>? LogMessageCallback;

        public MouseHookManager(MouseButtonState buttonState)
        {
            this.buttonState = buttonState;
            this.inputSimulator = new MouseInputSimulator();
        }

        public bool InstallHook()
        {
            mouseHookProc = MouseHookCallback;
            mouseHookId = SetWindowsHookEx(WH_MOUSE_LL, mouseHookProc, IntPtr.Zero, 0);
            return mouseHookId != IntPtr.Zero;
        }

        public void UninstallHook()
        {
            if (mouseHookId != IntPtr.Zero)
            {
                UnhookWindowsHookEx(mouseHookId);
                mouseHookId = IntPtr.Zero;
            }
        }

        private IntPtr MouseHookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                var hookStruct = (MSLLHOOKSTRUCT*)lParam;
                int mouseEvent = (int)wParam;

                // XButton1 해제 처리 - 정리를 위해 중요함
                if (mouseEvent == WM_XBUTTONUP && IsXButton1(hookStruct->mouseData))
                {
                    // 모든 버튼 상태를 즉시 강제 리셋
                    buttonState.ResetAll();
                    XButton1Released?.Invoke(this, EventArgs.Empty);
                }

                // 주입되지 않은 마우스 이벤트만 처리 (참조 코드는 0x01 플래그 체크 사용)
                if ((hookStruct->flags & 0x01) == 0x00)
                {
                    bool isXButton1Pressed = IsKeyPressed(VK_XBUTTON1);
                    
                    switch (mouseEvent)
                    {
                        case WM_LBUTTONDOWN:
                        case WM_RBUTTONDOWN:
                        case WM_MBUTTONDOWN:
                            var button = GetMouseButtonFromEvent(mouseEvent);
                            MouseButtonDown?.Invoke(this, button);
                            
                            // 디버깅 로그
                            LogMessageCallback?.Invoke($"마우스 DOWN - 버튼: {button}, X1 상태: {isXButton1Pressed}");
                            
                            // X1+마우스 조합일 때만 자동클릭 시작하고 원본 차단
                            if (isXButton1Pressed)
                            {
                                LogMessageCallback?.Invoke($"X1+{button} 자동클릭 시작!");
                                buttonState.SetAutoFireState(button, true);
                                return (IntPtr)1;
                            }
                            break; // 일반 마우스 DOWN은 통과
                            
                        case WM_LBUTTONUP:
                        case WM_RBUTTONUP:
                        case WM_MBUTTONUP:
                            var buttonUp = GetMouseButtonFromEvent(mouseEvent);
                            MouseButtonUp?.Invoke(this, buttonUp);
                            
                            // 마우스 UP이면 자동 클릭 중지
                            buttonState.SetAutoFireState(buttonUp, false);
                            
                            // X1+마우스 조합이었다면 UP도 차단
                            if (isXButton1Pressed)
                            {
                                return (IntPtr)1;
                            }
                            break; // 일반 마우스 UP은 통과
                    }
                }
            }

            return CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam);
        }


        private bool IsValidMouseButtonEvent(int mouseEvent)
        {
            return mouseEvent == WM_LBUTTONDOWN || mouseEvent == WM_LBUTTONUP ||
                   mouseEvent == WM_RBUTTONDOWN || mouseEvent == WM_RBUTTONUP ||
                   mouseEvent == WM_MBUTTONDOWN || mouseEvent == WM_MBUTTONUP;
        }

        private bool IsXButton1(uint mouseData)
        {
            return (mouseData >> 16) == XBUTTON1;
        }

        private bool IsKeyPressed(int virtualKeyCode)
        {
            int keyState = GetKeyState(virtualKeyCode);
            bool pressed = (keyState & KEY_PRESSED) != 0;
            return pressed;
        }

        private MouseButton GetMouseButtonFromEvent(int mouseEvent)
        {
            return mouseEvent switch
            {
                WM_LBUTTONDOWN or WM_LBUTTONUP => MouseButton.Left,
                WM_RBUTTONDOWN or WM_RBUTTONUP => MouseButton.Right,
                WM_MBUTTONDOWN or WM_MBUTTONUP => MouseButton.Middle,
                _ => throw new ArgumentException($"Invalid mouse event: {mouseEvent}")
            };
        }

        private bool IsMouseDownEvent(int mouseEvent)
        {
            return mouseEvent == WM_LBUTTONDOWN || 
                   mouseEvent == WM_RBUTTONDOWN || 
                   mouseEvent == WM_MBUTTONDOWN;
        }

        public void Dispose()
        {
            UninstallHook();
        }
    }
}