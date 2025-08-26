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
        this.lblKeyboardInterval = new System.Windows.Forms.Label();
        this.nudKeyboardInterval = new System.Windows.Forms.NumericUpDown();
        this.btnSaveSettings = new System.Windows.Forms.Button();
        this.btnResetSettings = new System.Windows.Forms.Button();
        this.lblStatus = new System.Windows.Forms.Label();
        this.pnlMouse.SuspendLayout();
        this.pnlKeyboard.SuspendLayout();
        this.pnlSettings.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)(this.nudMouseInterval)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.nudKeyboardInterval)).BeginInit();
        this.SuspendLayout();
        
        // lblTitle
        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
        this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 122, 255);
        this.lblTitle.Location = new System.Drawing.Point(130, 15);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(160, 32);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "HookAutoFire";
        
        // pnlMouse
        this.pnlMouse.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
        this.pnlMouse.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlMouse.Controls.Add(this.lblMouseTitle);
        this.pnlMouse.Controls.Add(this.btnLeftMouse);
        this.pnlMouse.Controls.Add(this.btnRightMouse);
        this.pnlMouse.Controls.Add(this.btnMiddleMouse);
        this.pnlMouse.Controls.Add(this.btnXButton1);
        this.pnlMouse.Location = new System.Drawing.Point(40, 70);
        this.pnlMouse.Name = "pnlMouse";
        this.pnlMouse.Size = new System.Drawing.Size(160, 170);
        this.pnlMouse.TabIndex = 1;
        
        // lblMouseTitle
        this.lblMouseTitle.AutoSize = true;
        this.lblMouseTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        this.lblMouseTitle.ForeColor = System.Drawing.Color.White;
        this.lblMouseTitle.Location = new System.Drawing.Point(55, 10);
        this.lblMouseTitle.Name = "lblMouseTitle";
        this.lblMouseTitle.Size = new System.Drawing.Size(50, 20);
        this.lblMouseTitle.TabIndex = 0;
        this.lblMouseTitle.Text = "Mouse";
        
        // btnLeftMouse
        this.btnLeftMouse.BackColor = System.Drawing.Color.FromArgb(70, 70, 74);
        this.btnLeftMouse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(100, 100, 100);
        this.btnLeftMouse.FlatAppearance.BorderSize = 1;
        this.btnLeftMouse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(50, 50, 54);
        this.btnLeftMouse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(80, 80, 84);
        this.btnLeftMouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnLeftMouse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.btnLeftMouse.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
        this.btnLeftMouse.Location = new System.Drawing.Point(20, 45);
        this.btnLeftMouse.Name = "btnLeftMouse";
        this.btnLeftMouse.Size = new System.Drawing.Size(35, 45);
        this.btnLeftMouse.TabIndex = 1;
        this.btnLeftMouse.TabStop = false;
        this.btnLeftMouse.Text = "L";
        this.btnLeftMouse.UseVisualStyleBackColor = false;
        this.btnLeftMouse.Enabled = false;
        
        // btnRightMouse
        this.btnRightMouse.BackColor = System.Drawing.Color.FromArgb(70, 70, 74);
        this.btnRightMouse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(100, 100, 100);
        this.btnRightMouse.FlatAppearance.BorderSize = 1;
        this.btnRightMouse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(50, 50, 54);
        this.btnRightMouse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(80, 80, 84);
        this.btnRightMouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnRightMouse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.btnRightMouse.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
        this.btnRightMouse.Location = new System.Drawing.Point(105, 45);
        this.btnRightMouse.Name = "btnRightMouse";
        this.btnRightMouse.Size = new System.Drawing.Size(35, 45);
        this.btnRightMouse.TabIndex = 2;
        this.btnRightMouse.TabStop = false;
        this.btnRightMouse.Text = "R";
        this.btnRightMouse.UseVisualStyleBackColor = false;
        this.btnRightMouse.Enabled = false;
        
        // btnMiddleMouse
        this.btnMiddleMouse.BackColor = System.Drawing.Color.FromArgb(70, 70, 74);
        this.btnMiddleMouse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(100, 100, 100);
        this.btnMiddleMouse.FlatAppearance.BorderSize = 1;
        this.btnMiddleMouse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(50, 50, 54);
        this.btnMiddleMouse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(80, 80, 84);
        this.btnMiddleMouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnMiddleMouse.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
        this.btnMiddleMouse.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
        this.btnMiddleMouse.Location = new System.Drawing.Point(65, 35);
        this.btnMiddleMouse.Name = "btnMiddleMouse";
        this.btnMiddleMouse.Size = new System.Drawing.Size(30, 18);
        this.btnMiddleMouse.TabIndex = 3;
        this.btnMiddleMouse.TabStop = false;
        this.btnMiddleMouse.Text = "M";
        this.btnMiddleMouse.UseVisualStyleBackColor = false;
        this.btnMiddleMouse.Enabled = false;
        
        // btnXButton1
        this.btnXButton1.BackColor = System.Drawing.Color.FromArgb(70, 70, 74);
        this.btnXButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(100, 100, 100);
        this.btnXButton1.FlatAppearance.BorderSize = 1;
        this.btnXButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(50, 50, 54);
        this.btnXButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(80, 80, 84);
        this.btnXButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnXButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.btnXButton1.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
        this.btnXButton1.Location = new System.Drawing.Point(30, 110);
        this.btnXButton1.Name = "btnXButton1";
        this.btnXButton1.Size = new System.Drawing.Size(100, 30);
        this.btnXButton1.TabIndex = 4;
        this.btnXButton1.TabStop = false;
        this.btnXButton1.Text = "X1 (Side)";
        this.btnXButton1.UseVisualStyleBackColor = false;
        this.btnXButton1.Enabled = false;
        
        // pnlKeyboard
        this.pnlKeyboard.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
        this.pnlKeyboard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlKeyboard.Controls.Add(this.lblKeyboardTitle);
        this.pnlKeyboard.Controls.Add(this.btnSpace);
        this.pnlKeyboard.Location = new System.Drawing.Point(220, 70);
        this.pnlKeyboard.Name = "pnlKeyboard";
        this.pnlKeyboard.Size = new System.Drawing.Size(160, 170);
        this.pnlKeyboard.TabIndex = 2;
        
        // lblKeyboardTitle
        this.lblKeyboardTitle.AutoSize = true;
        this.lblKeyboardTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        this.lblKeyboardTitle.ForeColor = System.Drawing.Color.White;
        this.lblKeyboardTitle.Location = new System.Drawing.Point(40, 10);
        this.lblKeyboardTitle.Name = "lblKeyboardTitle";
        this.lblKeyboardTitle.Size = new System.Drawing.Size(75, 20);
        this.lblKeyboardTitle.TabIndex = 0;
        this.lblKeyboardTitle.Text = "Keyboard";
        
        // btnSpace
        this.btnSpace.BackColor = System.Drawing.Color.FromArgb(70, 70, 74);
        this.btnSpace.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(100, 100, 100);
        this.btnSpace.FlatAppearance.BorderSize = 1;
        this.btnSpace.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(50, 50, 54);
        this.btnSpace.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(80, 80, 84);
        this.btnSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnSpace.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
        this.btnSpace.ForeColor = System.Drawing.Color.FromArgb(240, 240, 240);
        this.btnSpace.Location = new System.Drawing.Point(20, 110);
        this.btnSpace.Name = "btnSpace";
        this.btnSpace.Size = new System.Drawing.Size(120, 35);
        this.btnSpace.TabIndex = 1;
        this.btnSpace.TabStop = false;
        this.btnSpace.Text = "SPACE";
        this.btnSpace.UseVisualStyleBackColor = false;
        this.btnSpace.Enabled = false;
        
        // pnlSettings
        this.pnlSettings.BackColor = System.Drawing.Color.FromArgb(37, 37, 38);
        this.pnlSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.pnlSettings.Controls.Add(this.lblSettingsTitle);
        this.pnlSettings.Controls.Add(this.lblMouseInterval);
        this.pnlSettings.Controls.Add(this.nudMouseInterval);
        this.pnlSettings.Controls.Add(this.lblKeyboardInterval);
        this.pnlSettings.Controls.Add(this.nudKeyboardInterval);
        this.pnlSettings.Controls.Add(this.btnSaveSettings);
        this.pnlSettings.Controls.Add(this.btnResetSettings);
        this.pnlSettings.Location = new System.Drawing.Point(40, 260);
        this.pnlSettings.Name = "pnlSettings";
        this.pnlSettings.Size = new System.Drawing.Size(340, 120);
        this.pnlSettings.TabIndex = 3;
        
        // lblSettingsTitle
        this.lblSettingsTitle.AutoSize = true;
        this.lblSettingsTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
        this.lblSettingsTitle.ForeColor = System.Drawing.Color.White;
        this.lblSettingsTitle.Location = new System.Drawing.Point(140, 10);
        this.lblSettingsTitle.Name = "lblSettingsTitle";
        this.lblSettingsTitle.Size = new System.Drawing.Size(60, 20);
        this.lblSettingsTitle.TabIndex = 0;
        this.lblSettingsTitle.Text = "설정";
        
        // lblMouseInterval
        this.lblMouseInterval.AutoSize = true;
        this.lblMouseInterval.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblMouseInterval.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200);
        this.lblMouseInterval.Location = new System.Drawing.Point(15, 40);
        this.lblMouseInterval.Name = "lblMouseInterval";
        this.lblMouseInterval.Size = new System.Drawing.Size(120, 15);
        this.lblMouseInterval.TabIndex = 1;
        this.lblMouseInterval.Text = "마우스 간격 (ms):";
        
        // nudMouseInterval
        this.nudMouseInterval.BackColor = System.Drawing.Color.FromArgb(70, 70, 74);
        this.nudMouseInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.nudMouseInterval.ForeColor = System.Drawing.Color.White;
        this.nudMouseInterval.Location = new System.Drawing.Point(150, 38);
        this.nudMouseInterval.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        this.nudMouseInterval.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        this.nudMouseInterval.Name = "nudMouseInterval";
        this.nudMouseInterval.Size = new System.Drawing.Size(60, 23);
        this.nudMouseInterval.TabIndex = 2;
        this.nudMouseInterval.Value = new decimal(new int[] { 1, 0, 0, 0 });
        
        // lblKeyboardInterval
        this.lblKeyboardInterval.AutoSize = true;
        this.lblKeyboardInterval.Font = new System.Drawing.Font("Segoe UI", 9F);
        this.lblKeyboardInterval.ForeColor = System.Drawing.Color.FromArgb(200, 200, 200);
        this.lblKeyboardInterval.Location = new System.Drawing.Point(15, 70);
        this.lblKeyboardInterval.Name = "lblKeyboardInterval";
        this.lblKeyboardInterval.Size = new System.Drawing.Size(130, 15);
        this.lblKeyboardInterval.TabIndex = 3;
        this.lblKeyboardInterval.Text = "키보드 간격 (ms):";
        
        // nudKeyboardInterval
        this.nudKeyboardInterval.BackColor = System.Drawing.Color.FromArgb(70, 70, 74);
        this.nudKeyboardInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.nudKeyboardInterval.ForeColor = System.Drawing.Color.White;
        this.nudKeyboardInterval.Location = new System.Drawing.Point(150, 68);
        this.nudKeyboardInterval.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        this.nudKeyboardInterval.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
        this.nudKeyboardInterval.Name = "nudKeyboardInterval";
        this.nudKeyboardInterval.Size = new System.Drawing.Size(60, 23);
        this.nudKeyboardInterval.TabIndex = 4;
        this.nudKeyboardInterval.Value = new decimal(new int[] { 100, 0, 0, 0 });
        
        // btnSaveSettings
        this.btnSaveSettings.BackColor = System.Drawing.Color.FromArgb(0, 122, 255);
        this.btnSaveSettings.FlatAppearance.BorderSize = 0;
        this.btnSaveSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnSaveSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.btnSaveSettings.ForeColor = System.Drawing.Color.White;
        this.btnSaveSettings.Location = new System.Drawing.Point(230, 40);
        this.btnSaveSettings.Name = "btnSaveSettings";
        this.btnSaveSettings.Size = new System.Drawing.Size(80, 25);
        this.btnSaveSettings.TabIndex = 5;
        this.btnSaveSettings.Text = "저장";
        this.btnSaveSettings.UseVisualStyleBackColor = false;
        
        // btnResetSettings
        this.btnResetSettings.BackColor = System.Drawing.Color.FromArgb(120, 120, 120);
        this.btnResetSettings.FlatAppearance.BorderSize = 0;
        this.btnResetSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnResetSettings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
        this.btnResetSettings.ForeColor = System.Drawing.Color.White;
        this.btnResetSettings.Location = new System.Drawing.Point(230, 70);
        this.btnResetSettings.Name = "btnResetSettings";
        this.btnResetSettings.Size = new System.Drawing.Size(80, 25);
        this.btnResetSettings.TabIndex = 6;
        this.btnResetSettings.Text = "초기화";
        this.btnResetSettings.UseVisualStyleBackColor = false;
        
        // lblStatus
        this.lblStatus.AutoSize = true;
        this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
        this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
        this.lblStatus.Location = new System.Drawing.Point(40, 390);
        this.lblStatus.MaximumSize = new System.Drawing.Size(340, 0);
        this.lblStatus.Name = "lblStatus";
        this.lblStatus.Size = new System.Drawing.Size(340, 38);
        this.lblStatus.TabIndex = 4;
        this.lblStatus.Text = "Status: Hold X1 + SPACE for space auto-click, X1 + mouse for mouse auto-click";
        
        // frmMain
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.FromArgb(45, 45, 48);
        this.ClientSize = new System.Drawing.Size(420, 450);
        this.Controls.Add(this.lblStatus);
        this.Controls.Add(this.pnlSettings);
        this.Controls.Add(this.pnlKeyboard);
        this.Controls.Add(this.pnlMouse);
        this.Controls.Add(this.lblTitle);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        this.MaximizeBox = false;
        this.Name = "Form1";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "HookAutoFire";
        this.pnlMouse.ResumeLayout(false);
        this.pnlMouse.PerformLayout();
        this.pnlKeyboard.ResumeLayout(false);
        this.pnlKeyboard.PerformLayout();
        this.pnlSettings.ResumeLayout(false);
        this.pnlSettings.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.nudMouseInterval)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.nudKeyboardInterval)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion
    
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
    private System.Windows.Forms.Label lblKeyboardInterval;
    private System.Windows.Forms.NumericUpDown nudKeyboardInterval;
    private System.Windows.Forms.Button btnSaveSettings;
    private System.Windows.Forms.Button btnResetSettings;
    private System.Windows.Forms.Label lblStatus;
}
