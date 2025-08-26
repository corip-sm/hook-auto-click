namespace HookAutoFire;

partial class frmMain
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.tabControl = new System.Windows.Forms.TabControl();
        this.tabMain = new System.Windows.Forms.TabPage();
        this.tabLog = new System.Windows.Forms.TabPage();
        this.txtLog = new System.Windows.Forms.TextBox();
        this.btnClearLog = new System.Windows.Forms.Button();
        this.lblTitle = new System.Windows.Forms.Label();
        this.pnlMouse = new System.Windows.Forms.Panel();
        this.lblMouseTitle = new System.Windows.Forms.Label();
        this.btnLeftMouse = new System.Windows.Forms.Button();
        this.btnRightMouse = new System.Windows.Forms.Button();
        this.btnMiddleMouse = new System.Windows.Forms.Button();
        this.btnXButton1 = new System.Windows.Forms.Button();
        this.pnlKeyboard = new System.Windows.Forms.Panel();
        this.lblKeyboardTitle = new System.Windows.Forms.Label();
        this.btnSpace = new System.Windows.Forms.Button();
        this.pnlSettings = new System.Windows.Forms.Panel();
        this.lblSettingsTitle = new System.Windows.Forms.Label();
        this.lblMouseInterval = new System.Windows.Forms.Label();
        this.nudMouseInterval = new System.Windows.Forms.NumericUpDown();
        this.lblMouseDownLatency = new System.Windows.Forms.Label();
        this.nudMouseDownLatency = new System.Windows.Forms.NumericUpDown();
        this.lblMouseUpLatency = new System.Windows.Forms.Label();
        this.nudMouseUpLatency = new System.Windows.Forms.NumericUpDown();
        this.lblKeyboardInterval = new System.Windows.Forms.Label();
        this.nudKeyboardInterval = new System.Windows.Forms.NumericUpDown();
        this.lblKeyboardDownLatency = new System.Windows.Forms.Label();
        this.nudKeyboardDownLatency = new System.Windows.Forms.NumericUpDown();
        this.lblKeyboardUpLatency = new System.Windows.Forms.Label();
        this.nudKeyboardUpLatency = new System.Windows.Forms.NumericUpDown();
        this.btnSaveSettings = new System.Windows.Forms.Button();
        this.btnResetSettings = new System.Windows.Forms.Button();
        this.lblStatus = new System.Windows.Forms.Label();
        this.tabControl.SuspendLayout();
        this.tabMain.SuspendLayout();
        this.tabLog.SuspendLayout();
        this.pnlMouse.SuspendLayout();
        this.pnlKeyboard.SuspendLayout();
        this.pnlSettings.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.nudMouseInterval)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.nudMouseDownLatency)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.nudMouseUpLatency)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.nudKeyboardInterval)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.nudKeyboardDownLatency)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.nudKeyboardUpLatency)).BeginInit();
        this.SuspendLayout();
        
        // tabControl
        this.tabControl.Controls.Add(this.tabMain);
        this.tabControl.Controls.Add(this.tabLog);
        this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
        this.tabControl.Location = new System.Drawing.Point(0, 0);
        this.tabControl.Name = "tabControl";
        this.tabControl.SelectedIndex = 0;
        this.tabControl.Size = new System.Drawing.Size(570, 600);
        this.tabControl.TabIndex = 0;
        
        // tabMain
        this.tabMain.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
        this.tabMain.Controls.Add(this.lblTitle);
        this.tabMain.Controls.Add(this.pnlMouse);
        this.tabMain.Controls.Add(this.pnlKeyboard);
        this.tabMain.Controls.Add(this.pnlSettings);
        this.tabMain.Controls.Add(this.lblStatus);
        this.tabMain.Location = new System.Drawing.Point(4, 24);
        this.tabMain.Name = "tabMain";
        this.tabMain.Padding = new System.Windows.Forms.Padding(3);
        this.tabMain.Size = new System.Drawing.Size(562, 572);
        this.tabMain.TabIndex = 0;
        this.tabMain.Text = "Main";
        
        // tabLog
        this.tabLog.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
        this.tabLog.Controls.Add(this.txtLog);
        this.tabLog.Controls.Add(this.btnClearLog);
        this.tabLog.Location = new System.Drawing.Point(4, 24);
        this.tabLog.Name = "tabLog";
        this.tabLog.Padding = new System.Windows.Forms.Padding(3);
        this.tabLog.Size = new System.Drawing.Size(562, 572);
        this.tabLog.TabIndex = 1;
        this.tabLog.Text = "Debug Log";
        
        // txtLog
        this.txtLog.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
        this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtLog.Font = new System.Drawing.Font("Consolas", 9F);
        this.txtLog.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200);
        this.txtLog.Location = new System.Drawing.Point(6, 6);
        this.txtLog.Multiline = true;
        this.txtLog.Name = "txtLog";
        this.txtLog.ReadOnly = true;
        this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
        this.txtLog.Size = new System.Drawing.Size(550, 520);
        this.txtLog.TabIndex = 0;
        
        // btnClearLog
        this.btnClearLog.BackColor = System.Drawing.Color.FromArgb(70, 70, 74);
        this.btnClearLog.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(100, 100, 100);
        this.btnClearLog.FlatAppearance.BorderSize = 1;
        this.btnClearLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnClearLog.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.btnClearLog.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
        this.btnClearLog.Location = new System.Drawing.Point(481, 532);
        this.btnClearLog.Name = "btnClearLog";
        this.btnClearLog.Size = new System.Drawing.Size(75, 30);
        this.btnClearLog.TabIndex = 1;
        this.btnClearLog.Text = "Clear";
        this.btnClearLog.UseVisualStyleBackColor = false;
        
        // lblTitle
        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
        this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 174, 255);
        this.lblTitle.Location = new System.Drawing.Point(180, 20);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(200, 37);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "HookAutoFire";
        
        // pnlMouse
        this.pnlMouse.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
        this.pnlMouse.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.pnlMouse.Controls.Add(this.lblMouseTitle);
        this.pnlMouse.Controls.Add(this.btnLeftMouse);
        this.pnlMouse.Controls.Add(this.btnRightMouse);
        this.pnlMouse.Controls.Add(this.btnMiddleMouse);
        this.pnlMouse.Controls.Add(this.btnXButton1);
        this.pnlMouse.Location = new System.Drawing.Point(30, 70);
        this.pnlMouse.Name = "pnlMouse";
        this.pnlMouse.Size = new System.Drawing.Size(200, 200);
        this.pnlMouse.TabIndex = 1;
        
        // lblMouseTitle
        this.lblMouseTitle.AutoSize = true;
        this.lblMouseTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        this.lblMouseTitle.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
        this.lblMouseTitle.Location = new System.Drawing.Point(20, 15);
        this.lblMouseTitle.Name = "lblMouseTitle";
        this.lblMouseTitle.Size = new System.Drawing.Size(150, 21);
        this.lblMouseTitle.TabIndex = 0;
        this.lblMouseTitle.Text = "🖱️ Mouse Controls";
        
        // btnLeftMouse
        this.btnLeftMouse.BackColor = System.Drawing.Color.FromArgb(60, 60, 65);
        this.btnLeftMouse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(120, 120, 125);
        this.btnLeftMouse.FlatAppearance.BorderSize = 2;
        this.btnLeftMouse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(40, 40, 45);
        this.btnLeftMouse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(80, 80, 85);
        this.btnLeftMouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnLeftMouse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.btnLeftMouse.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
        this.btnLeftMouse.Location = new System.Drawing.Point(20, 50);
        this.btnLeftMouse.Name = "btnLeftMouse";
        this.btnLeftMouse.Size = new System.Drawing.Size(50, 45);
        this.btnLeftMouse.TabIndex = 1;
        this.btnLeftMouse.TabStop = false;
        this.btnLeftMouse.Text = "LEFT";
        this.btnLeftMouse.UseVisualStyleBackColor = false;
        this.btnLeftMouse.Enabled = false;
        
        // btnRightMouse
        this.btnRightMouse.BackColor = System.Drawing.Color.FromArgb(60, 60, 65);
        this.btnRightMouse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(120, 120, 125);
        this.btnRightMouse.FlatAppearance.BorderSize = 2;
        this.btnRightMouse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(40, 40, 45);
        this.btnRightMouse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(80, 80, 85);
        this.btnRightMouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnRightMouse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.btnRightMouse.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
        this.btnRightMouse.Location = new System.Drawing.Point(130, 50);
        this.btnRightMouse.Name = "btnRightMouse";
        this.btnRightMouse.Size = new System.Drawing.Size(50, 45);
        this.btnRightMouse.TabIndex = 2;
        this.btnRightMouse.TabStop = false;
        this.btnRightMouse.Text = "RIGHT";
        this.btnRightMouse.UseVisualStyleBackColor = false;
        this.btnRightMouse.Enabled = false;
        
        // btnMiddleMouse
        this.btnMiddleMouse.BackColor = System.Drawing.Color.FromArgb(60, 60, 65);
        this.btnMiddleMouse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(120, 120, 125);
        this.btnMiddleMouse.FlatAppearance.BorderSize = 2;
        this.btnMiddleMouse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(40, 40, 45);
        this.btnMiddleMouse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(80, 80, 85);
        this.btnMiddleMouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnMiddleMouse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.btnMiddleMouse.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
        this.btnMiddleMouse.Location = new System.Drawing.Point(75, 35);
        this.btnMiddleMouse.Name = "btnMiddleMouse";
        this.btnMiddleMouse.Size = new System.Drawing.Size(50, 25);
        this.btnMiddleMouse.TabIndex = 3;
        this.btnMiddleMouse.TabStop = false;
        this.btnMiddleMouse.Text = "MID";
        this.btnMiddleMouse.UseVisualStyleBackColor = false;
        this.btnMiddleMouse.Enabled = false;
        
        // btnXButton1
        this.btnXButton1.BackColor = System.Drawing.Color.FromArgb(50, 120, 200);
        this.btnXButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(100, 150, 220);
        this.btnXButton1.FlatAppearance.BorderSize = 2;
        this.btnXButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(30, 90, 160);
        this.btnXButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(70, 140, 220);
        this.btnXButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnXButton1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        this.btnXButton1.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
        this.btnXButton1.Location = new System.Drawing.Point(20, 110);
        this.btnXButton1.Name = "btnXButton1";
        this.btnXButton1.Size = new System.Drawing.Size(160, 40);
        this.btnXButton1.TabIndex = 4;
        this.btnXButton1.TabStop = false;
        this.btnXButton1.Text = "⚡ X1 TRIGGER";
        this.btnXButton1.UseVisualStyleBackColor = false;
        this.btnXButton1.Enabled = false;
        
        // pnlKeyboard
        this.pnlKeyboard.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
        this.pnlKeyboard.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.pnlKeyboard.Controls.Add(this.lblKeyboardTitle);
        this.pnlKeyboard.Controls.Add(this.btnSpace);
        this.pnlKeyboard.Location = new System.Drawing.Point(250, 70);
        this.pnlKeyboard.Name = "pnlKeyboard";
        this.pnlKeyboard.Size = new System.Drawing.Size(200, 200);
        this.pnlKeyboard.TabIndex = 2;
        
        // lblKeyboardTitle
        this.lblKeyboardTitle.AutoSize = true;
        this.lblKeyboardTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        this.lblKeyboardTitle.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
        this.lblKeyboardTitle.Location = new System.Drawing.Point(20, 15);
        this.lblKeyboardTitle.Name = "lblKeyboardTitle";
        this.lblKeyboardTitle.Size = new System.Drawing.Size(160, 21);
        this.lblKeyboardTitle.TabIndex = 0;
        this.lblKeyboardTitle.Text = "⌨️ Keyboard Controls";
        
        // btnSpace
        this.btnSpace.BackColor = System.Drawing.Color.FromArgb(60, 60, 65);
        this.btnSpace.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(120, 120, 125);
        this.btnSpace.FlatAppearance.BorderSize = 2;
        this.btnSpace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(40, 40, 45);
        this.btnSpace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(80, 80, 85);
        this.btnSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnSpace.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        this.btnSpace.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
        this.btnSpace.Location = new System.Drawing.Point(20, 55);
        this.btnSpace.Name = "btnSpace";
        this.btnSpace.Size = new System.Drawing.Size(160, 40);
        this.btnSpace.TabIndex = 1;
        this.btnSpace.TabStop = false;
        this.btnSpace.Text = "🚀 SPACEBAR";
        this.btnSpace.UseVisualStyleBackColor = false;
        this.btnSpace.Enabled = false;
        
        // pnlSettings
        this.pnlSettings.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
        this.pnlSettings.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.pnlSettings.Controls.Add(this.lblSettingsTitle);
        this.pnlSettings.Controls.Add(this.lblMouseInterval);
        this.pnlSettings.Controls.Add(this.nudMouseInterval);
        this.pnlSettings.Controls.Add(this.lblMouseDownLatency);
        this.pnlSettings.Controls.Add(this.nudMouseDownLatency);
        this.pnlSettings.Controls.Add(this.lblMouseUpLatency);
        this.pnlSettings.Controls.Add(this.nudMouseUpLatency);
        this.pnlSettings.Controls.Add(this.lblKeyboardInterval);
        this.pnlSettings.Controls.Add(this.nudKeyboardInterval);
        this.pnlSettings.Controls.Add(this.lblKeyboardDownLatency);
        this.pnlSettings.Controls.Add(this.nudKeyboardDownLatency);
        this.pnlSettings.Controls.Add(this.lblKeyboardUpLatency);
        this.pnlSettings.Controls.Add(this.nudKeyboardUpLatency);
        this.pnlSettings.Controls.Add(this.btnSaveSettings);
        this.pnlSettings.Controls.Add(this.btnResetSettings);
        this.pnlSettings.Location = new System.Drawing.Point(30, 290);
        this.pnlSettings.Name = "pnlSettings";
        this.pnlSettings.Size = new System.Drawing.Size(500, 250);
        this.pnlSettings.TabIndex = 3;
        
        // lblSettingsTitle
        this.lblSettingsTitle.AutoSize = true;
        this.lblSettingsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        this.lblSettingsTitle.ForeColor = System.Drawing.Color.FromArgb(255, 255, 255);
        this.lblSettingsTitle.Location = new System.Drawing.Point(20, 15);
        this.lblSettingsTitle.Name = "lblSettingsTitle";
        this.lblSettingsTitle.Size = new System.Drawing.Size(160, 21);
        this.lblSettingsTitle.TabIndex = 0;
        this.lblSettingsTitle.Text = "⚙️ Timing Settings";
        
        // lblMouseInterval
        this.lblMouseInterval.AutoSize = true;
        this.lblMouseInterval.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblMouseInterval.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200);
        this.lblMouseInterval.Location = new System.Drawing.Point(20, 50);
        this.lblMouseInterval.Name = "lblMouseInterval";
        this.lblMouseInterval.Size = new System.Drawing.Size(120, 15);
        this.lblMouseInterval.TabIndex = 1;
        this.lblMouseInterval.Text = "마우스 간격 (ms):";
        
        // nudMouseInterval
        this.nudMouseInterval.BackColor = System.Drawing.Color.FromArgb(70, 70, 74);
        this.nudMouseInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.nudMouseInterval.ForeColor = System.Drawing.Color.White;
        this.nudMouseInterval.Location = new System.Drawing.Point(160, 48);
        this.nudMouseInterval.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        this.nudMouseInterval.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        this.nudMouseInterval.Name = "nudMouseInterval";
        this.nudMouseInterval.Size = new System.Drawing.Size(60, 23);
        this.nudMouseInterval.TabIndex = 2;
        this.nudMouseInterval.Value = new decimal(new int[] { 1, 0, 0, 0 });
        
        // lblMouseDownLatency
        this.lblMouseDownLatency.AutoSize = true;
        this.lblMouseDownLatency.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblMouseDownLatency.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200);
        this.lblMouseDownLatency.Location = new System.Drawing.Point(20, 80);
        this.lblMouseDownLatency.Name = "lblMouseDownLatency";
        this.lblMouseDownLatency.Size = new System.Drawing.Size(115, 15);
        this.lblMouseDownLatency.TabIndex = 5;
        this.lblMouseDownLatency.Text = "마우스 DOWN (ms):";
        
        // nudMouseDownLatency
        this.nudMouseDownLatency.BackColor = System.Drawing.Color.FromArgb(70, 70, 74);
        this.nudMouseDownLatency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.nudMouseDownLatency.ForeColor = System.Drawing.Color.White;
        this.nudMouseDownLatency.Location = new System.Drawing.Point(160, 78);
        this.nudMouseDownLatency.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
        this.nudMouseDownLatency.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
        this.nudMouseDownLatency.Name = "nudMouseDownLatency";
        this.nudMouseDownLatency.Size = new System.Drawing.Size(60, 23);
        this.nudMouseDownLatency.TabIndex = 6;
        this.nudMouseDownLatency.Value = new decimal(new int[] { 1, 0, 0, 0 });
        
        // lblMouseUpLatency
        this.lblMouseUpLatency.AutoSize = true;
        this.lblMouseUpLatency.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblMouseUpLatency.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200);
        this.lblMouseUpLatency.Location = new System.Drawing.Point(20, 110);
        this.lblMouseUpLatency.Name = "lblMouseUpLatency";
        this.lblMouseUpLatency.Size = new System.Drawing.Size(105, 15);
        this.lblMouseUpLatency.TabIndex = 7;
        this.lblMouseUpLatency.Text = "마우스 UP (ms):";
        
        // nudMouseUpLatency
        this.nudMouseUpLatency.BackColor = System.Drawing.Color.FromArgb(70, 70, 74);
        this.nudMouseUpLatency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.nudMouseUpLatency.ForeColor = System.Drawing.Color.White;
        this.nudMouseUpLatency.Location = new System.Drawing.Point(160, 108);
        this.nudMouseUpLatency.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
        this.nudMouseUpLatency.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
        this.nudMouseUpLatency.Name = "nudMouseUpLatency";
        this.nudMouseUpLatency.Size = new System.Drawing.Size(60, 23);
        this.nudMouseUpLatency.TabIndex = 8;
        this.nudMouseUpLatency.Value = new decimal(new int[] { 1, 0, 0, 0 });
        
        // lblKeyboardInterval
        this.lblKeyboardInterval.AutoSize = true;
        this.lblKeyboardInterval.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblKeyboardInterval.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200);
        this.lblKeyboardInterval.Location = new System.Drawing.Point(260, 50);
        this.lblKeyboardInterval.Name = "lblKeyboardInterval";
        this.lblKeyboardInterval.Size = new System.Drawing.Size(130, 15);
        this.lblKeyboardInterval.TabIndex = 9;
        this.lblKeyboardInterval.Text = "키보드 간격 (ms):";
        
        // nudKeyboardInterval
        this.nudKeyboardInterval.BackColor = System.Drawing.Color.FromArgb(70, 70, 74);
        this.nudKeyboardInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.nudKeyboardInterval.ForeColor = System.Drawing.Color.White;
        this.nudKeyboardInterval.Location = new System.Drawing.Point(400, 48);
        this.nudKeyboardInterval.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        this.nudKeyboardInterval.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        this.nudKeyboardInterval.Name = "nudKeyboardInterval";
        this.nudKeyboardInterval.Size = new System.Drawing.Size(60, 23);
        this.nudKeyboardInterval.TabIndex = 10;
        this.nudKeyboardInterval.Value = new decimal(new int[] { 1, 0, 0, 0 });
        
        // lblKeyboardDownLatency
        this.lblKeyboardDownLatency.AutoSize = true;
        this.lblKeyboardDownLatency.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblKeyboardDownLatency.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200);
        this.lblKeyboardDownLatency.Location = new System.Drawing.Point(260, 80);
        this.lblKeyboardDownLatency.Name = "lblKeyboardDownLatency";
        this.lblKeyboardDownLatency.Size = new System.Drawing.Size(125, 15);
        this.lblKeyboardDownLatency.TabIndex = 11;
        this.lblKeyboardDownLatency.Text = "키보드 DOWN (ms):";
        
        // nudKeyboardDownLatency
        this.nudKeyboardDownLatency.BackColor = System.Drawing.Color.FromArgb(70, 70, 74);
        this.nudKeyboardDownLatency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.nudKeyboardDownLatency.ForeColor = System.Drawing.Color.White;
        this.nudKeyboardDownLatency.Location = new System.Drawing.Point(400, 78);
        this.nudKeyboardDownLatency.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
        this.nudKeyboardDownLatency.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        this.nudKeyboardDownLatency.Name = "nudKeyboardDownLatency";
        this.nudKeyboardDownLatency.Size = new System.Drawing.Size(60, 23);
        this.nudKeyboardDownLatency.TabIndex = 12;
        this.nudKeyboardDownLatency.Value = new decimal(new int[] { 1, 0, 0, 0 });
        
        // lblKeyboardUpLatency
        this.lblKeyboardUpLatency.AutoSize = true;
        this.lblKeyboardUpLatency.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblKeyboardUpLatency.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200);
        this.lblKeyboardUpLatency.Location = new System.Drawing.Point(260, 110);
        this.lblKeyboardUpLatency.Name = "lblKeyboardUpLatency";
        this.lblKeyboardUpLatency.Size = new System.Drawing.Size(115, 15);
        this.lblKeyboardUpLatency.TabIndex = 13;
        this.lblKeyboardUpLatency.Text = "키보드 UP (ms):";
        
        // nudKeyboardUpLatency
        this.nudKeyboardUpLatency.BackColor = System.Drawing.Color.FromArgb(70, 70, 74);
        this.nudKeyboardUpLatency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.nudKeyboardUpLatency.ForeColor = System.Drawing.Color.White;
        this.nudKeyboardUpLatency.Location = new System.Drawing.Point(400, 108);
        this.nudKeyboardUpLatency.Maximum = new decimal(new int[] { 200, 0, 0, 0 });
        this.nudKeyboardUpLatency.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        this.nudKeyboardUpLatency.Name = "nudKeyboardUpLatency";
        this.nudKeyboardUpLatency.Size = new System.Drawing.Size(60, 23);
        this.nudKeyboardUpLatency.TabIndex = 14;
        this.nudKeyboardUpLatency.Value = new decimal(new int[] { 1, 0, 0, 0 });
        
        // btnSaveSettings
        this.btnSaveSettings.BackColor = System.Drawing.Color.FromArgb(0, 122, 255);
        this.btnSaveSettings.FlatAppearance.BorderSize = 0;
        this.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnSaveSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.btnSaveSettings.ForeColor = System.Drawing.Color.White;
        this.btnSaveSettings.Location = new System.Drawing.Point(180, 160);
        this.btnSaveSettings.Name = "btnSaveSettings";
        this.btnSaveSettings.Size = new System.Drawing.Size(80, 25);
        this.btnSaveSettings.TabIndex = 15;
        this.btnSaveSettings.Text = "저장";
        this.btnSaveSettings.UseVisualStyleBackColor = false;
        
        // btnResetSettings
        this.btnResetSettings.BackColor = System.Drawing.Color.FromArgb(120, 120, 120);
        this.btnResetSettings.FlatAppearance.BorderSize = 0;
        this.btnResetSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnResetSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.btnResetSettings.ForeColor = System.Drawing.Color.White;
        this.btnResetSettings.Location = new System.Drawing.Point(280, 160);
        this.btnResetSettings.Name = "btnResetSettings";
        this.btnResetSettings.Size = new System.Drawing.Size(80, 25);
        this.btnResetSettings.TabIndex = 16;
        this.btnResetSettings.Text = "초기화";
        this.btnResetSettings.UseVisualStyleBackColor = false;
        
        // lblStatus
        this.lblStatus.AutoSize = true;
        this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200);
        this.lblStatus.Location = new System.Drawing.Point(30, 550);
        this.lblStatus.MaximumSize = new System.Drawing.Size(500, 0);
        this.lblStatus.Name = "lblStatus";
        this.lblStatus.Size = new System.Drawing.Size(480, 20);
        this.lblStatus.TabIndex = 4;
        this.lblStatus.Text = "💡 Hold X1 + SPACE for spacebar auto-click, X1 + mouse for mouse auto-click";
        
        // frmMain
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
        this.ClientSize = new System.Drawing.Size(580, 630);
        this.Controls.Add(this.tabControl);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.Name = "frmMain";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "HookAutoFire v1.0";
        this.tabControl.ResumeLayout(false);
        this.tabMain.ResumeLayout(false);
        this.tabMain.PerformLayout();
        this.tabLog.ResumeLayout(false);
        this.tabLog.PerformLayout();
        this.pnlMouse.ResumeLayout(false);
        this.pnlMouse.PerformLayout();
        this.pnlKeyboard.ResumeLayout(false);
        this.pnlKeyboard.PerformLayout();
        this.pnlSettings.ResumeLayout(false);
        this.pnlSettings.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.nudMouseInterval)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.nudMouseDownLatency)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.nudMouseUpLatency)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.nudKeyboardInterval)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.nudKeyboardDownLatency)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.nudKeyboardUpLatency)).EndInit();
        this.ResumeLayout(false);
    }

    #endregion
    
    private System.Windows.Forms.TabControl tabControl;
    private System.Windows.Forms.TabPage tabMain;
    private System.Windows.Forms.TabPage tabLog;
    private System.Windows.Forms.TextBox txtLog;
    private System.Windows.Forms.Button btnClearLog;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Panel pnlMouse;
    private System.Windows.Forms.Label lblMouseTitle;
    private System.Windows.Forms.Button btnLeftMouse;
    private System.Windows.Forms.Button btnRightMouse;
    private System.Windows.Forms.Button btnMiddleMouse;
    private System.Windows.Forms.Button btnXButton1;
    private System.Windows.Forms.Panel pnlKeyboard;
    private System.Windows.Forms.Label lblKeyboardTitle;
    private System.Windows.Forms.Button btnSpace;
    private System.Windows.Forms.Panel pnlSettings;
    private System.Windows.Forms.Label lblSettingsTitle;
    private System.Windows.Forms.Label lblMouseInterval;
    private System.Windows.Forms.NumericUpDown nudMouseInterval;
    private System.Windows.Forms.Label lblMouseDownLatency;
    private System.Windows.Forms.NumericUpDown nudMouseDownLatency;
    private System.Windows.Forms.Label lblMouseUpLatency;
    private System.Windows.Forms.NumericUpDown nudMouseUpLatency;
    private System.Windows.Forms.Label lblKeyboardInterval;
    private System.Windows.Forms.NumericUpDown nudKeyboardInterval;
    private System.Windows.Forms.Label lblKeyboardDownLatency;
    private System.Windows.Forms.NumericUpDown nudKeyboardDownLatency;
    private System.Windows.Forms.Label lblKeyboardUpLatency;
    private System.Windows.Forms.NumericUpDown nudKeyboardUpLatency;
    private System.Windows.Forms.Button btnSaveSettings;
    private System.Windows.Forms.Button btnResetSettings;
    private System.Windows.Forms.Label lblStatus;
}
