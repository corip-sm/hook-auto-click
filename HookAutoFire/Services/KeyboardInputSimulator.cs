using System;
using System.Runtime.InteropServices;
using HookAutoFire.Native;
using static HookAutoFire.Native.Win32Api;
using static HookAutoFire.Native.Win32Constants;

namespace HookAutoFire.Services
{
    public class KeyboardInputSimulator
    {
        [DllImport("user32.dll")]
        private static extern uint MapVirtualKey(uint uCode, uint uMapType);

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

            SendInput(1, new[] { input }, Marshal.SizeOf<INPUT>());
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

            SendInput(1, new[] { input }, Marshal.SizeOf<INPUT>());
        }

        public void SendKeyPress(int virtualKeyCode)
        {
            SendKeyDown(virtualKeyCode);
            System.Threading.Thread.Sleep(1); // 짧은 딜레이 추가
            SendKeyUp(virtualKeyCode);
        }
    }
}