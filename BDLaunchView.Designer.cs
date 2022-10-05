namespace BDLaunch
{
    partial class BDLaunchView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BDLaunchView));
            this.btnExit = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnHide = new System.Windows.Forms.Button();
            this.chkRemember = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServerState = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnSound = new System.Windows.Forms.Button();
            this.chkLaunchClose = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::BDLaunch.Properties.Resources.x_normal;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(802, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 28);
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(596, 73);
            this.txtUser.Name = "txtUser";
            this.txtUser.PlaceholderText = "User Name";
            this.txtUser.Size = new System.Drawing.Size(200, 27);
            this.txtUser.TabIndex = 1;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(596, 106);
            this.txtPass.Name = "txtPass";
            this.txtPass.PlaceholderText = "Password";
            this.txtPass.Size = new System.Drawing.Size(200, 27);
            this.txtPass.TabIndex = 2;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // btnHide
            // 
            this.btnHide.BackColor = System.Drawing.Color.Transparent;
            this.btnHide.BackgroundImage = global::BDLaunch.Properties.Resources.nosee;
            this.btnHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHide.FlatAppearance.BorderSize = 0;
            this.btnHide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHide.Location = new System.Drawing.Point(802, 109);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(32, 21);
            this.btnHide.TabIndex = 3;
            this.btnHide.UseVisualStyleBackColor = false;
            this.btnHide.MouseEnter += new System.EventHandler(this.btnHide_MouseEnter);
            this.btnHide.MouseLeave += new System.EventHandler(this.btnHide_MouseLeave);
            // 
            // chkRemember
            // 
            this.chkRemember.AutoSize = true;
            this.chkRemember.BackColor = System.Drawing.Color.Transparent;
            this.chkRemember.Location = new System.Drawing.Point(596, 139);
            this.chkRemember.Name = "chkRemember";
            this.chkRemember.Size = new System.Drawing.Size(145, 24);
            this.chkRemember.TabIndex = 4;
            this.chkRemember.Text = "Remember Login";
            this.chkRemember.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(588, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login Server Is ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtServerState
            // 
            this.txtServerState.AutoSize = true;
            this.txtServerState.BackColor = System.Drawing.Color.Transparent;
            this.txtServerState.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtServerState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtServerState.Location = new System.Drawing.Point(728, 14);
            this.txtServerState.Name = "txtServerState";
            this.txtServerState.Size = new System.Drawing.Size(57, 23);
            this.txtServerState.TabIndex = 6;
            this.txtServerState.Text = "Down";
            this.txtServerState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPlay
            // 
            this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImage = global::BDLaunch.Properties.Resources.playBtn;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Location = new System.Drawing.Point(624, 232);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(125, 131);
            this.btnPlay.TabIndex = 7;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Visible = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // worker
            // 
            this.worker.WorkerSupportsCancellation = true;
            this.worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker_DoWork);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnSound
            // 
            this.btnSound.BackColor = System.Drawing.Color.Transparent;
            this.btnSound.BackgroundImage = global::BDLaunch.Properties.Resources.soundOn;
            this.btnSound.FlatAppearance.BorderSize = 0;
            this.btnSound.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSound.Location = new System.Drawing.Point(12, 11);
            this.btnSound.Name = "btnSound";
            this.btnSound.Size = new System.Drawing.Size(36, 24);
            this.btnSound.TabIndex = 9;
            this.btnSound.UseVisualStyleBackColor = false;
            this.btnSound.Click += new System.EventHandler(this.btnSound_Click);
            // 
            // chkLaunchClose
            // 
            this.chkLaunchClose.AutoSize = true;
            this.chkLaunchClose.BackColor = System.Drawing.Color.Transparent;
            this.chkLaunchClose.Location = new System.Drawing.Point(596, 169);
            this.chkLaunchClose.Name = "chkLaunchClose";
            this.chkLaunchClose.Size = new System.Drawing.Size(154, 24);
            this.chkLaunchClose.TabIndex = 10;
            this.chkLaunchClose.Text = "Close After Launch";
            this.chkLaunchClose.UseVisualStyleBackColor = false;
            // 
            // BDLaunchView
            // 
            this.AcceptButton = this.btnExit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(849, 458);
            this.ControlBox = false;
            this.Controls.Add(this.chkLaunchClose);
            this.Controls.Add(this.btnSound);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.txtServerState);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkRemember);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.btnExit);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BDLaunchView";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.MistyRose;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BDLaunchView_FormClosing);
            this.Load += new System.EventHandler(this.BDLaunchView_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BDLaunchView_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnExit;
        private TextBox txtUser;
        private TextBox txtPass;
        private Button btnHide;
        private CheckBox chkRemember;
        private Label label1;
        private Label txtServerState;
        private Button btnPlay;
        private System.ComponentModel.BackgroundWorker worker;
        private System.Windows.Forms.Timer timer;
        private Button btnSound;
        private CheckBox chkLaunchClose;
    }
}