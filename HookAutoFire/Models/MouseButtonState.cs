namespace HookAutoFire.Models
{
    public class MouseButtonState
    {
        private bool isLeftButtonAutoFire = false;
        private bool isRightButtonAutoFire = false;
        private bool isMiddleButtonAutoFire = false;
        private bool isSpaceAutoFire = false;
        
        private bool wasLeftButtonAutoFire = false;
        private bool wasRightButtonAutoFire = false;
        private bool wasMiddleButtonAutoFire = false;
        private bool wasSpaceAutoFire = false;
        
        private readonly object stateLock = new object();

        public bool GetAutoFireState(MouseButton button)
        {
            lock (stateLock)
            {
                return button switch
                {
                    MouseButton.Left => isLeftButtonAutoFire,
                    MouseButton.Right => isRightButtonAutoFire,
                    MouseButton.Middle => isMiddleButtonAutoFire,
                    _ => false
                };
            }
        }

        public void SetAutoFireState(MouseButton button, bool state)
        {
            lock (stateLock)
            {
                switch (button)
                {
                    case MouseButton.Left:
                        wasLeftButtonAutoFire = isLeftButtonAutoFire;
                        isLeftButtonAutoFire = state;
                        break;
                    case MouseButton.Right:
                        wasRightButtonAutoFire = isRightButtonAutoFire;
                        isRightButtonAutoFire = state;
                        break;
                    case MouseButton.Middle:
                        wasMiddleButtonAutoFire = isMiddleButtonAutoFire;
                        isMiddleButtonAutoFire = state;
                        break;
                }
            }
        }
        
        public bool WasAutoFiring(MouseButton button)
        {
            lock (stateLock)
            {
                return button switch
                {
                    MouseButton.Left => wasLeftButtonAutoFire,
                    MouseButton.Right => wasRightButtonAutoFire,
                    MouseButton.Middle => wasMiddleButtonAutoFire,
                    _ => false
                };
            }
        }

        public bool GetSpaceAutoFire()
        {
            lock (stateLock)
            {
                return isSpaceAutoFire;
            }
        }

        public void SetSpaceAutoFire(bool state)
        {
            lock (stateLock)
            {
                wasSpaceAutoFire = isSpaceAutoFire;
                isSpaceAutoFire = state;
            }
        }

        public bool WasSpaceAutoFiring()
        {
            lock (stateLock)
            {
                return wasSpaceAutoFire;
            }
        }


        public void ResetAll()
        {
            lock (stateLock)
            {
                isLeftButtonAutoFire = false;
                isRightButtonAutoFire = false;
                isMiddleButtonAutoFire = false;
                isSpaceAutoFire = false;
            }
        }

        public bool IsAnyButtonActive()
        {
            lock (stateLock)
            {
                return isLeftButtonAutoFire || isRightButtonAutoFire || isMiddleButtonAutoFire;
            }
        }

        public bool IsAnyActive()
        {
            lock (stateLock)
            {
                return isLeftButtonAutoFire || isRightButtonAutoFire || isMiddleButtonAutoFire || isSpaceAutoFire;
            }
        }
    }
}