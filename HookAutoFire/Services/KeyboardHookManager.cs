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

                // 주입되지 않은 키보드 이벤트만 처리 (마우스 후킹과 유사)
                if ((hookStruct->flags & 0x01) == 0x00)
                {
                    switch (keyEvent)
                    {
                        case WM_KEYDOWN:
                        case WM_SYSKEYDOWN:
                            if (vkCode == VK_SPACE)
                            {
                                // SPACE 키에 대해 항상 시각적 피드백 트리거
                                KeyDown?.Invoke(this, vkCode);
                                
                                // 자동 클릭 기능을 위해 XBUTTON1이 눌렸는지 확인
                                if (IsKeyPressed(VK_XBUTTON1))
                                {
                                    // SPACE 키 자동 클릭 시작 (마우스가 아님!)
                                    buttonState.SetSpaceAutoFire(true);
                                }
                            }
                            break;
                        case WM_KEYUP:
                        case WM_SYSKEYUP:
                            if (vkCode == VK_SPACE)
                            {
                                // SPACE 키에 대해 항상 시각적 피드백 트리거
                                KeyUp?.Invoke(this, vkCode);
                                
                                // SPACE가 해제되면 항상 SPACE 자동 클릭 중지
                                buttonState.SetSpaceAutoFire(false);
                            }
                            break;
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