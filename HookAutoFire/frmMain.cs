using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using HookAutoFire.Models;
using HookAutoFire.Services;

namespace HookAutoFire
{
    public partial class frmMain : Form
    {
        private readonly MouseButtonState buttonState;
        private readonly MouseHookManager hookManager;
        private readonly KeyboardHookManager keyboardHookManager;
        private readonly MouseInputSimulator inputSimulator;
        private readonly AutoFireService autoFireService;

        public frmMain()
        {
            InitializeComponent();
            ConfigureForm();
            
            // 서비스 초기화
            buttonState = new MouseButtonState();
            inputSimulator = new MouseInputSimulator();
            hookManager = new MouseHookManager(buttonState);
            keyboardHookManager = new KeyboardHookManager(buttonState, inputSimulator);
            autoFireService = new AutoFireService(buttonState, inputSimulator);
            
            InitializeServices();
        }

        private void ConfigureForm()
        {
            // 폼 속성은 이제 디자이너에서 설정됨
        }

        private void InitializeServices()
        {
            // 마우스 후킹 이벤트 설정
            hookManager.XButton1Released += OnXButton1Released;
            hookManager.MouseButtonDown += OnMouseButtonDown;
            hookManager.MouseButtonUp += OnMouseButtonUp;
            
            // 키보드 후킹 이벤트 설정
            keyboardHookManager.KeyDown += OnKeyDown;
            keyboardHookManager.KeyUp += OnKeyUp;
            
            // 마우스 후킹 설치
            if (!hookManager.InstallHook())
            {
                MessageBox.Show("마우스 후킹 설치 실패", "오류", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }
            
            // 키보드 후킹 설치
            if (!keyboardHookManager.InstallHook())
            {
                MessageBox.Show("키보드 후킹 설치 실패", "오류", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
                return;
            }
            
            // 자동 클릭 서비스 시작
            autoFireService.Start();
            
            // X버튼1 상태 업데이트
            UpdateXButton1Status();
        }

        private void OnXButton1Released(object? sender, EventArgs e)
        {
            // 모든 활성 버튼 즉시 해제
            inputSimulator.ForceReleaseAllButtons(buttonState);
            
            // 모든 버튼 상태 초기화
            buttonState.ResetAll();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Cleanup();
        }

        private void OnMouseButtonDown(object? sender, MouseButton button)
        {
            if (InvokeRequired)
            {
                Invoke(() => UpdateMouseButtonState(button, true));
            }
            else
            {
                UpdateMouseButtonState(button, true);
            }
        }

        private void OnMouseButtonUp(object? sender, MouseButton button)
        {
            if (InvokeRequired)
            {
                Invoke(() => UpdateMouseButtonState(button, false));
            }
            else
            {
                UpdateMouseButtonState(button, false);
            }
        }

        private void OnKeyDown(object? sender, int vkCode)
        {
            if (InvokeRequired)
            {
                Invoke(() => UpdateKeyState(vkCode, true));
            }
            else
            {
                UpdateKeyState(vkCode, true);
            }
        }

        private void OnKeyUp(object? sender, int vkCode)
        {
            if (InvokeRequired)
            {
                Invoke(() => UpdateKeyState(vkCode, false));
            }
            else
            {
                UpdateKeyState(vkCode, false);
            }
        }

        private void UpdateMouseButtonState(MouseButton button, bool isPressed)
        {
            var color = isPressed ? Color.FromArgb(220, 50, 50) : Color.FromArgb(70, 70, 74);
            
            switch (button)
            {
                case MouseButton.Left:
                    btnLeftMouse.BackColor = color;
                    btnLeftMouse.Enabled = false; // 항상 비활성화 상태 유지
                    break;
                case MouseButton.Right:
                    btnRightMouse.BackColor = color;
                    btnRightMouse.Enabled = false; // 항상 비활성화 상태 유지
                    break;
                case MouseButton.Middle:
                    btnMiddleMouse.BackColor = color;
                    btnMiddleMouse.Enabled = false; // 항상 비활성화 상태 유지
                    break;
            }

            UpdateStatusLabel();
        }

        private void UpdateKeyState(int vkCode, bool isPressed)
        {
            if (vkCode == 0x20) // VK_SPACE
            {
                btnSpace.BackColor = isPressed ? Color.FromArgb(50, 180, 50) : Color.FromArgb(70, 70, 74);
                btnSpace.Enabled = false; // 항상 비활성화 상태 유지
                UpdateStatusLabel();
            }
        }

        private void UpdateXButton1Status()
        {
            // X버튼1 상태를 확인하는 타이머
            var timer = new System.Windows.Forms.Timer();
            timer.Interval = 100; // 100ms마다 확인
            timer.Tick += (s, e) =>
            {
                bool isPressed = (Native.Win32Api.GetKeyState(0x05) & 0x8000) != 0; // VK_XBUTTON1
                btnXButton1.BackColor = isPressed ? Color.FromArgb(50, 120, 220) : Color.FromArgb(70, 70, 74);
                btnXButton1.Enabled = false; // 항상 비활성화 상태 유지
                UpdateStatusLabel(); // X1 버튼 상태 변경 시 상태 업데이트
            };
            timer.Start();
        }

        private void UpdateStatusLabel()
        {
            bool leftMouseActive = btnLeftMouse.BackColor == Color.FromArgb(220, 50, 50);
            bool rightMouseActive = btnRightMouse.BackColor == Color.FromArgb(220, 50, 50);
            bool middleMouseActive = btnMiddleMouse.BackColor == Color.FromArgb(220, 50, 50);
            bool spaceActive = btnSpace.BackColor == Color.FromArgb(50, 180, 50);
            bool xButton1Active = btnXButton1.BackColor == Color.FromArgb(50, 120, 220);

            if (xButton1Active && (leftMouseActive || rightMouseActive || middleMouseActive || spaceActive))
            {
                var activeInputs = new List<string>();
                if (spaceActive) activeInputs.Add("SPACE");
                if (leftMouseActive) activeInputs.Add("LEFT MOUSE");
                if (rightMouseActive) activeInputs.Add("RIGHT MOUSE");
                if (middleMouseActive) activeInputs.Add("MIDDLE MOUSE");

                lblStatus.Text = $"Status: AUTO-CLICKING {string.Join(" + ", activeInputs)}!";
                lblStatus.ForeColor = Color.FromArgb(255, 80, 80);
            }
            else if (xButton1Active)
            {
                lblStatus.Text = "Status: X1 pressed - Press SPACE or click mouse for auto-fire";
                lblStatus.ForeColor = Color.FromArgb(255, 165, 0);
            }
            else
            {
                lblStatus.Text = "Status: Hold X1 + SPACE for space auto-click, X1 + mouse for mouse auto-click";
                lblStatus.ForeColor = Color.FromArgb(200, 200, 200);
            }
        }

        private void Cleanup()
        {
            autoFireService?.Dispose();
            keyboardHookManager?.Dispose();
            hookManager?.Dispose();
        }
    }
}