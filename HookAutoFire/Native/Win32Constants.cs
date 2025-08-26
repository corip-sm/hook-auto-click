namespace HookAutoFire.Native
{
    public static class Win32Constants
    {
        #region Hook Types
        
        public const int WH_MOUSE_LL = 14;
        public const int WH_KEYBOARD_LL = 13;
        
        #endregion

        #region Mouse Messages
        
        public const int WM_LBUTTONDOWN = 0x0201;
        public const int WM_LBUTTONUP = 0x0202;
        public const int WM_RBUTTONDOWN = 0x0204;
        public const int WM_RBUTTONUP = 0x0205;
        public const int WM_MBUTTONDOWN = 0x0207;
        public const int WM_MBUTTONUP = 0x0208;
        public const int WM_XBUTTONDOWN = 0x020B;
        public const int WM_XBUTTONUP = 0x020C;
        
        #endregion

        #region Virtual Key Codes
        
        public const int VK_LBUTTON = 0x01;
        public const int VK_RBUTTON = 0x02;
        public const int VK_MBUTTON = 0x04;
        public const int VK_XBUTTON1 = 0x05;
        public const int VK_SPACE = 0x20;
        public const int XBUTTON1 = 0x0001;
        
        #endregion

        #region Keyboard Messages
        
        public const int WM_KEYDOWN = 0x0100;
        public const int WM_KEYUP = 0x0101;
        public const int WM_SYSKEYDOWN = 0x0104;
        public const int WM_SYSKEYUP = 0x0105;
        
        #endregion

        #region Flags
        
        public const int INJECTED_FLAG = 0x01;
        public const int KEY_PRESSED = 0x8000;
        
        #endregion
    }
}