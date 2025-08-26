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
            var input = new INPUT
            {
                type = SendInputEventType.InputKeyboard,
                ui = new InputUnion
                {
                    ki = new KeyboardInput
                    {
                        wVk = (ushort)virtualKeyCode,
                        wScan = 0,
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
            var input = new INPUT
            {
                type = SendInputEventType.InputKeyboard,
                ui = new InputUnion
                {
                    ki = new KeyboardInput
                    {
                        wVk = (ushort)virtualKeyCode,
                        wScan = 0,
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
            SendKeyUp(virtualKeyCode);
        }
    }
}