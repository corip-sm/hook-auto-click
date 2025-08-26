using System;
using System.Runtime.InteropServices;
using HookAutoFire.Native;
using static HookAutoFire.Native.Win32Api;
using static HookAutoFire.Native.Win32Constants;

namespace HookAutoFire.Services
{
    public class KeyboardInputSimulator
    {
        public void SendKeyDown(int virtualKeyCode)
        {
            uint scanCode = MapVirtualKey((uint)virtualKeyCode, 0);
            
            var input = new INPUT
            {
                type = SendInputEventType.InputKeyboard,
                ui = new InputUnion
                {
                    ki = new KeyboardInput
                    {
                        wVk = (ushort)virtualKeyCode,
                        wScan = (ushort)scanCode,
                        dwFlags = 0, // Key down
                        time = 0,
                        dwExtraInfo = IntPtr.Zero
                    }
                }
            };

            uint result = SendInput(1, new[] { input }, Marshal.SizeOf<INPUT>());
            if (result == 0)
            {
                // SendInput 실패 시 - 일단 조용히 무시 (로그 제거된 상태이므로)
            }
        }

        public void SendKeyUp(int virtualKeyCode)
        {
            uint scanCode = MapVirtualKey((uint)virtualKeyCode, 0);
            
            var input = new INPUT
            {
                type = SendInputEventType.InputKeyboard,
                ui = new InputUnion
                {
                    ki = new KeyboardInput
                    {
                        wVk = (ushort)virtualKeyCode,
                        wScan = (ushort)scanCode,
                        dwFlags = KeyboardEventFlags.KEYEVENTF_KEYUP,
                        time = 0,
                        dwExtraInfo = IntPtr.Zero
                    }
                }
            };

            uint result = SendInput(1, new[] { input }, Marshal.SizeOf<INPUT>());
            if (result == 0)
            {
                // SendInput 실패 시 - 일단 조용히 무시 (로그 제거된 상태이므로)
            }
        }

        public void SendKeyPress(int virtualKeyCode)
        {
            uint scanCode = MapVirtualKey((uint)virtualKeyCode, 0);

            var inputs = new INPUT[2];
            
            // DOWN 이벤트
            inputs[0] = new INPUT
            {
                type = SendInputEventType.InputKeyboard,
                ui = new InputUnion
                {
                    ki = new KeyboardInput
                    {
                        wVk = (ushort)virtualKeyCode,
                        wScan = (ushort)scanCode,
                        dwFlags = 0, // Key down
                        time = 0,
                        dwExtraInfo = IntPtr.Zero
                    }
                }
            };

            // UP 이벤트
            inputs[1] = new INPUT
            {
                type = SendInputEventType.InputKeyboard,
                ui = new InputUnion
                {
                    ki = new KeyboardInput
                    {
                        wVk = (ushort)virtualKeyCode,
                        wScan = (ushort)scanCode,
                        dwFlags = KeyboardEventFlags.KEYEVENTF_KEYUP,
                        time = 0,
                        dwExtraInfo = IntPtr.Zero
                    }
                }
            };

            // 두 이벤트를 한번에 전송
            uint result = SendInput(2, inputs, Marshal.SizeOf<INPUT>());
        }
    }
}