using System;
using System.Runtime.InteropServices;
using HookAutoFire.Models;
using HookAutoFire.Native;
using static HookAutoFire.Native.Win32Api;
using static HookAutoFire.Native.Win32Constants;

namespace HookAutoFire.Services
{
    public unsafe class KeyboardHookManager : IDisposable
    {
        private LowLevelKeyboardProc? keyboardHookProc;
        private IntPtr keyboardHookId;
        private readonly MouseButtonState buttonState;
        private readonly MouseInputSimulator inputSimulator;
        private bool isSpacePressed = false; // SPACE 키가 눌려있는 상태인지 추적
        
        public event EventHandler<int>? KeyDown;
        public event EventHandler<int>? KeyUp;

        public KeyboardHookManager(MouseButtonState buttonState, MouseInputSimulator inputSimulator)
        {
            this.buttonState = buttonState;
            this.inputSimulator = inputSimulator;
        }

        public bool InstallHook()
        {
            keyboardHookProc = KeyboardHookCallback;
            keyboardHookId = SetWindowsHookEx(WH_KEYBOARD_LL, keyboardHookProc, IntPtr.Zero, 0);
            return keyboardHookId != IntPtr.Zero;
        }

        public void UninstallHook()
        {
            if (keyboardHookId != IntPtr.Zero)
            {
                UnhookWindowsHookEx(keyboardHookId);
                keyboardHookId = IntPtr.Zero;
            }
        }

        private IntPtr KeyboardHookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                var hookStruct = (KBDLLHOOKSTRUCT*)lParam;
                int keyEvent = (int)wParam;
                int vkCode = (int)hookStruct->vkCode;

                bool isInjected = (hookStruct->flags & 0x10) != 0x00;
                
                // SPACE 키 처리
                if (vkCode == VK_SPACE)
                {
                    // 시뮬레이션된 입력은 그대로 통과
                    if (isInjected)
                    {
                        return CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam);
                    }
                    
                    // 하드웨어 입력만 처리
                    bool isXButton1Pressed = IsKeyPressed(VK_XBUTTON1);
                    
                    switch (keyEvent)
                    {
                        case WM_KEYDOWN:
                        case WM_SYSKEYDOWN:
                            KeyDown?.Invoke(this, vkCode);
                            
                            // 최초 DOWN일 때만 처리 (키 반복 무시)
                            if (!isSpacePressed)
                            {
                                isSpacePressed = true;
                                
                                // X1+SPACE 조합에서만 자동 클릭 시작하고 차단
                                if (isXButton1Pressed)
                                {
                                    buttonState.SetSpaceAutoFire(true);
                                    return (IntPtr)1; // X1+SPACE 조합일 때만 차단
                                }
                            }
                            else if (isXButton1Pressed)
                            {
                                // 키 반복이지만 X1이 눌려있다면 차단
                                return (IntPtr)1;
                            }
                            break; // 일반 SPACE는 통과
                            
                        case WM_KEYUP:
                        case WM_SYSKEYUP:
                            KeyUp?.Invoke(this, vkCode);
                            
                            // SPACE UP 상태로 변경
                            isSpacePressed = false;
                            
                            // SPACE UP이면 자동 클릭 중지
                            buttonState.SetSpaceAutoFire(false);
                            
                            // X1+SPACE 조합이었다면 UP도 차단
                            if (isXButton1Pressed)
                            {
                                return (IntPtr)1;
                            }
                            break; // 일반 SPACE UP은 통과
                    }
                }
            }

            return CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam);
        }

        private bool IsKeyPressed(int virtualKeyCode)
        {
            return (GetKeyState(virtualKeyCode) & KEY_PRESSED) != 0;
        }


        public void Dispose()
        {
            UninstallHook();
        }
    }
}