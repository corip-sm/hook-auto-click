using System;
using System.Runtime.InteropServices;
using HookAutoFire.Models;
using HookAutoFire.Native;

namespace HookAutoFire.Services
{
    public class MouseInputSimulator
    {
        private readonly INPUT[] mouseInput;
        private readonly INPUT[] doubleInput;

        public MouseInputSimulator()
        {
            mouseInput = new INPUT[1];
            mouseInput[0].type = SendInputEventType.InputMouse;
            
            // Pre-allocate for double operations
            doubleInput = new INPUT[2];
            doubleInput[0].type = SendInputEventType.InputMouse;
            doubleInput[1].type = SendInputEventType.InputMouse;
        }

        public void SimulateClick(MouseButton button)
        {
            var (upFlag, downFlag) = GetMouseEventFlags(button);
            SimulateMouseClick(upFlag, downFlag);
        }

        public void SimulateButtonUp(MouseButton button)
        {
            var (upFlag, _) = GetMouseEventFlags(button);
            PrepareMouseInput();
            mouseInput[0].ui.mi.dwFlags = upFlag;
            Win32Api.SendInput(1, mouseInput, Marshal.SizeOf(typeof(INPUT)));
        }

        public void SimulateButtonDown(MouseButton button)
        {
            var (_, downFlag) = GetMouseEventFlags(button);
            PrepareMouseInput();
            mouseInput[0].ui.mi.dwFlags = downFlag;
            Win32Api.SendInput(1, mouseInput, Marshal.SizeOf(typeof(INPUT)));
        }

        public void ForceReleaseAllButtons(MouseButtonState buttonState)
        {
            // Single release for each button that was active
            if (buttonState.GetAutoFireState(MouseButton.Left))
            {
                SimulateButtonUp(MouseButton.Left);
            }

            if (buttonState.GetAutoFireState(MouseButton.Right))
            {
                SimulateButtonUp(MouseButton.Right);
            }

            if (buttonState.GetAutoFireState(MouseButton.Middle))
            {
                SimulateButtonUp(MouseButton.Middle);
            }
        }

        private void SimulateMouseClick(MouseEventFlags upFlag, MouseEventFlags downFlag)
        {
            // MVP style: separate UP and DOWN calls like the original
            PrepareMouseInput();
            mouseInput[0].ui.mi.dwFlags = upFlag;
            Win32Api.SendInput(1, mouseInput, Marshal.SizeOf(typeof(INPUT)));
            
            PrepareMouseInput();
            mouseInput[0].ui.mi.dwFlags = downFlag;
            Win32Api.SendInput(1, mouseInput, Marshal.SizeOf(typeof(INPUT)));
        }

        private void PrepareMouseInput()
        {
            mouseInput[0].ui.mi.dx = 0;
            mouseInput[0].ui.mi.dy = 0;
            mouseInput[0].ui.mi.mouseData = 0;
            mouseInput[0].ui.mi.time = 0;
            mouseInput[0].ui.mi.dwExtraInfo = IntPtr.Zero;
        }

        private (MouseEventFlags upFlag, MouseEventFlags downFlag) GetMouseEventFlags(MouseButton button)
        {
            return button switch
            {
                MouseButton.Left => (MouseEventFlags.MOUSEEVENTF_LEFTUP, MouseEventFlags.MOUSEEVENTF_LEFTDOWN),
                MouseButton.Right => (MouseEventFlags.MOUSEEVENTF_RIGHTUP, MouseEventFlags.MOUSEEVENTF_RIGHTDOWN),
                MouseButton.Middle => (MouseEventFlags.MOUSEEVENTF_MIDDLEUP, MouseEventFlags.MOUSEEVENTF_MIDDLEDOWN),
                _ => (0, 0)
            };
        }
    }
}