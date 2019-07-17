namespace DeepRacer
{
    partial class FrmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbReward1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbShowOptimal = new System.Windows.Forms.CheckBox();
            this.cbShowWaypoint = new System.Windows.Forms.CheckBox();
            this.cbFollowOptimal = new System.Windows.Forms.CheckBox();
            this.cbFollowTrack = new System.Windows.Forms.CheckBox();
            this.lblDistanceFromOptimal = new System.Windows.Forms.Label();
            this.lblOptimalDirectionDiff = new System.Windows.Forms.Label();
            this.lblClosestOwp = new System.Windows.Forms.Label();
            this.lblMouse = new System.Windows.Forms.Label();
            this.chkReverse = new System.Windows.Forms.CheckBox();
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblProgress = new System.Windows.Forms.Label();
            this.tbProgress = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.btnResetScale = new System.Windows.Forms.Button();
            this.lblDistanceFromCenter = new System.Windows.Forms.Label();
            this.lblTrackDirectionDiff = new System.Windows.Forms.Label();
            this.lblClosestWp = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblTotalReward = new System.Windows.Forms.Label();
            this.lblReward3 = new System.Windows.Forms.Label();
            this.lblReward2 = new System.Windows.Forms.Label();
            this.lblReward1 = new System.Windows.Forms.Label();
            this.lbHeading = new System.Windows.Forms.Label();
            this.lbSteer = new System.Windows.Forms.Label();
            this.lbThrottle = new System.Windows.Forms.Label();
            this.tbHeading = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pbTotalReward = new System.Windows.Forms.ProgressBar();
            this.lblReward3Name = new System.Windows.Forms.Label();
            this.pbReward3 = new System.Windows.Forms.ProgressBar();
            this.lblReward2Name = new System.Windows.Forms.Label();
            this.pbReward2 = new System.Windows.Forms.ProgressBar();
            this.lblReward1Name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSteer = new System.Windows.Forms.TrackBar();
            this.tbThrottle = new System.Windows.Forms.TrackBar();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHeading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSteer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbThrottle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // pbReward1
            // 
            this.pbReward1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbReward1.Location = new System.Drawing.Point(550, 48);
            this.pbReward1.Name = "pbReward1";
            this.pbReward1.Size = new System.Drawing.Size(218, 15);
            this.pbReward1.TabIndex = 0;
            this.pbReward1.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cbShowOptimal);
            this.panel1.Controls.Add(this.cbShowWaypoint);
            this.panel1.Controls.Add(this.cbFollowOptimal);
            this.panel1.Controls.Add(this.cbFollowTrack);
            this.panel1.Controls.Add(this.lblDistanceFromOptimal);
            this.panel1.Controls.Add(this.lblOptimalDirectionDiff);
            this.panel1.Controls.Add(this.lblClosestOwp);
            this.panel1.Controls.Add(this.lblMouse);
            this.panel1.Controls.Add(this.chkReverse);
            this.panel1.Controls.Add(this.btnSettings);
            this.panel1.Controls.Add(this.lblProgress);
            this.panel1.Controls.Add(this.tbProgress);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnResetScale);
            this.panel1.Controls.Add(this.lblDistanceFromCenter);
            this.panel1.Controls.Add(this.lblTrackDirectionDiff);
            this.panel1.Controls.Add(this.lblClosestWp);
            this.panel1.Controls.Add(this.lblPosition);
            this.panel1.Controls.Add(this.lblTotalReward);
            this.panel1.Controls.Add(this.lblReward3);
            this.panel1.Controls.Add(this.lblReward2);
            this.panel1.Controls.Add(this.lblReward1);
            this.panel1.Controls.Add(this.lbHeading);
            this.panel1.Controls.Add(this.lbSteer);
            this.panel1.Controls.Add(this.lbThrottle);
            this.panel1.Controls.Add(this.tbHeading);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pbTotalReward);
            this.panel1.Controls.Add(this.lblReward3Name);
            this.panel1.Controls.Add(this.pbReward3);
            this.panel1.Controls.Add(this.lblReward2Name);
            this.panel1.Controls.Add(this.pbReward2);
            this.panel1.Controls.Add(this.lblReward1Name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbSteer);
            this.panel1.Controls.Add(this.tbThrottle);
            this.panel1.Controls.Add(this.pbReward1);
            this.panel1.Location = new System.Drawing.Point(12, 553);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 298);
            this.panel1.TabIndex = 1;
            // 
            // cbShowOptimal
            // 
            this.cbShowOptimal.AutoSize = true;
            this.cbShowOptimal.Location = new System.Drawing.Point(451, 270);
            this.cbShowOptimal.Name = "cbShowOptimal";
            this.cbShowOptimal.Size = new System.Drawing.Size(103, 16);
            this.cbShowOptimal.TabIndex = 38;
            this.cbShowOptimal.Text = "Show Optimal";
            this.cbShowOptimal.UseVisualStyleBackColor = true;
            this.cbShowOptimal.CheckedChanged += new System.EventHandler(this.cbShowOptimal_CheckedChanged);
            // 
            // cbShowWaypoint
            // 
            this.cbShowWaypoint.AutoSize = true;
            this.cbShowWaypoint.Checked = true;
            this.cbShowWaypoint.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbShowWaypoint.Location = new System.Drawing.Point(311, 270);
            this.cbShowWaypoint.Name = "cbShowWaypoint";
            this.cbShowWaypoint.Size = new System.Drawing.Size(111, 16);
            this.cbShowWaypoint.TabIndex = 37;
            this.cbShowWaypoint.Text = "Show Waypoint";
            this.cbShowWaypoint.UseVisualStyleBackColor = true;
            this.cbShowWaypoint.CheckedChanged += new System.EventHandler(this.cbShowWaypoint_CheckedChanged);
            // 
            // cbFollowOptimal
            // 
            this.cbFollowOptimal.AutoSize = true;
            this.cbFollowOptimal.Location = new System.Drawing.Point(158, 270);
            this.cbFollowOptimal.Name = "cbFollowOptimal";
            this.cbFollowOptimal.Size = new System.Drawing.Size(108, 16);
            this.cbFollowOptimal.TabIndex = 36;
            this.cbFollowOptimal.Text = "Follow Optimal";
            this.cbFollowOptimal.UseVisualStyleBackColor = true;
            this.cbFollowOptimal.CheckedChanged += new System.EventHandler(this.cbFollowOptimal_CheckedChanged);
            // 
            // cbFollowTrack
            // 
            this.cbFollowTrack.AutoSize = true;
            this.cbFollowTrack.Checked = true;
            this.cbFollowTrack.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFollowTrack.Location = new System.Drawing.Point(27, 270);
            this.cbFollowTrack.Name = "cbFollowTrack";
            this.cbFollowTrack.Size = new System.Drawing.Size(97, 16);
            this.cbFollowTrack.TabIndex = 35;
            this.cbFollowTrack.Text = "Follow Track";
            this.cbFollowTrack.UseVisualStyleBackColor = true;
            this.cbFollowTrack.CheckedChanged += new System.EventHandler(this.cbFollowTrack_CheckedChanged);
            // 
            // lblDistanceFromOptimal
            // 
            this.lblDistanceFromOptimal.AutoSize = true;
            this.lblDistanceFromOptimal.Location = new System.Drawing.Point(612, 242);
            this.lblDistanceFromOptimal.Name = "lblDistanceFromOptimal";
            this.lblDistanceFromOptimal.Size = new System.Drawing.Size(53, 12);
            this.lblDistanceFromOptimal.TabIndex = 34;
            this.lblDistanceFromOptimal.Text = "distance";
            // 
            // lblOptimalDirectionDiff
            // 
            this.lblOptimalDirectionDiff.AutoSize = true;
            this.lblOptimalDirectionDiff.Location = new System.Drawing.Point(345, 242);
            this.lblOptimalDirectionDiff.Name = "lblOptimalDirectionDiff";
            this.lblOptimalDirectionDiff.Size = new System.Drawing.Size(36, 12);
            this.lblOptimalDirectionDiff.TabIndex = 33;
            this.lblOptimalDirectionDiff.Text = "angle";
            // 
            // lblClosestOwp
            // 
            this.lblClosestOwp.AutoSize = true;
            this.lblClosestOwp.Location = new System.Drawing.Point(181, 242);
            this.lblClosestOwp.Name = "lblClosestOwp";
            this.lblClosestOwp.Size = new System.Drawing.Size(63, 12);
            this.lblClosestOwp.TabIndex = 32;
            this.lblClosestOwp.Text = "closestWp";
            // 
            // lblMouse
            // 
            this.lblMouse.AutoSize = true;
            this.lblMouse.Location = new System.Drawing.Point(28, 242);
            this.lblMouse.Name = "lblMouse";
            this.lblMouse.Size = new System.Drawing.Size(44, 12);
            this.lblMouse.TabIndex = 31;
            this.lblMouse.Text = "mouse";
            // 
            // chkReverse
            // 
            this.chkReverse.AutoSize = true;
            this.chkReverse.Location = new System.Drawing.Point(467, 151);
            this.chkReverse.Name = "chkReverse";
            this.chkReverse.Size = new System.Drawing.Size(70, 16);
            this.chkReverse.TabIndex = 30;
            this.chkReverse.Text = "Reverse";
            this.chkReverse.UseVisualStyleBackColor = true;
            this.chkReverse.CheckedChanged += new System.EventHandler(this.chkReverse_CheckedChanged);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(652, 147);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 29;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(383, 147);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(55, 12);
            this.lblProgress.TabIndex = 28;
            this.lblProgress.Text = "progress";
            // 
            // tbProgress
            // 
            this.tbProgress.Location = new System.Drawing.Point(81, 147);
            this.tbProgress.Maximum = 100;
            this.tbProgress.Name = "tbProgress";
            this.tbProgress.Size = new System.Drawing.Size(284, 45);
            this.tbProgress.TabIndex = 27;
            this.tbProgress.Value = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 12);
            this.label4.TabIndex = 26;
            this.label4.Text = "Progress";
            // 
            // btnResetScale
            // 
            this.btnResetScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetScale.Location = new System.Drawing.Point(752, 147);
            this.btnResetScale.Name = "btnResetScale";
            this.btnResetScale.Size = new System.Drawing.Size(110, 23);
            this.btnResetScale.TabIndex = 25;
            this.btnResetScale.Text = "Reset Scale";
            this.btnResetScale.UseVisualStyleBackColor = true;
            this.btnResetScale.Click += new System.EventHandler(this.btnResetScale_Click);
            // 
            // lblDistanceFromCenter
            // 
            this.lblDistanceFromCenter.AutoSize = true;
            this.lblDistanceFromCenter.Location = new System.Drawing.Point(612, 216);
            this.lblDistanceFromCenter.Name = "lblDistanceFromCenter";
            this.lblDistanceFromCenter.Size = new System.Drawing.Size(53, 12);
            this.lblDistanceFromCenter.TabIndex = 24;
            this.lblDistanceFromCenter.Text = "distance";
            // 
            // lblTrackDirectionDiff
            // 
            this.lblTrackDirectionDiff.AutoSize = true;
            this.lblTrackDirectionDiff.Location = new System.Drawing.Point(345, 216);
            this.lblTrackDirectionDiff.Name = "lblTrackDirectionDiff";
            this.lblTrackDirectionDiff.Size = new System.Drawing.Size(36, 12);
            this.lblTrackDirectionDiff.TabIndex = 23;
            this.lblTrackDirectionDiff.Text = "angle";
            // 
            // lblClosestWp
            // 
            this.lblClosestWp.AutoSize = true;
            this.lblClosestWp.Location = new System.Drawing.Point(181, 216);
            this.lblClosestWp.Name = "lblClosestWp";
            this.lblClosestWp.Size = new System.Drawing.Size(63, 12);
            this.lblClosestWp.TabIndex = 22;
            this.lblClosestWp.Text = "closestWp";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(26, 216);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(49, 12);
            this.lblPosition.TabIndex = 21;
            this.lblPosition.Text = "position";
            // 
            // lblTotalReward
            // 
            this.lblTotalReward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalReward.AutoSize = true;
            this.lblTotalReward.Location = new System.Drawing.Point(785, 15);
            this.lblTotalReward.Name = "lblTotalReward";
            this.lblTotalReward.Size = new System.Drawing.Size(89, 12);
            this.lblTotalReward.TabIndex = 20;
            this.lblTotalReward.Text = "lblTotalReward";
            // 
            // lblReward3
            // 
            this.lblReward3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReward3.AutoSize = true;
            this.lblReward3.Location = new System.Drawing.Point(785, 111);
            this.lblReward3.Name = "lblReward3";
            this.lblReward3.Size = new System.Drawing.Size(50, 12);
            this.lblReward3.TabIndex = 19;
            this.lblReward3.Text = "reward3";
            this.lblReward3.Visible = false;
            // 
            // lblReward2
            // 
            this.lblReward2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReward2.AutoSize = true;
            this.lblReward2.Location = new System.Drawing.Point(785, 78);
            this.lblReward2.Name = "lblReward2";
            this.lblReward2.Size = new System.Drawing.Size(50, 12);
            this.lblReward2.TabIndex = 18;
            this.lblReward2.Text = "reward2";
            this.lblReward2.Visible = false;
            // 
            // lblReward1
            // 
            this.lblReward1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReward1.AutoSize = true;
            this.lblReward1.Location = new System.Drawing.Point(785, 48);
            this.lblReward1.Name = "lblReward1";
            this.lblReward1.Size = new System.Drawing.Size(50, 12);
            this.lblReward1.TabIndex = 17;
            this.lblReward1.Text = "reward1";
            this.lblReward1.Visible = false;
            // 
            // lbHeading
            // 
            this.lbHeading.AutoSize = true;
            this.lbHeading.Location = new System.Drawing.Point(383, 97);
            this.lbHeading.Name = "lbHeading";
            this.lbHeading.Size = new System.Drawing.Size(50, 12);
            this.lbHeading.TabIndex = 16;
            this.lbHeading.Text = "heading";
            // 
            // lbSteer
            // 
            this.lbSteer.AutoSize = true;
            this.lbSteer.Location = new System.Drawing.Point(383, 51);
            this.lbSteer.Name = "lbSteer";
            this.lbSteer.Size = new System.Drawing.Size(33, 12);
            this.lbSteer.TabIndex = 15;
            this.lbSteer.Text = "steer";
            // 
            // lbThrottle
            // 
            this.lbThrottle.AutoSize = true;
            this.lbThrottle.Location = new System.Drawing.Point(383, 17);
            this.lbThrottle.Name = "lbThrottle";
            this.lbThrottle.Size = new System.Drawing.Size(42, 12);
            this.lbThrottle.TabIndex = 14;
            this.lbThrottle.Text = "throttle";
            // 
            // tbHeading
            // 
            this.tbHeading.Location = new System.Drawing.Point(81, 97);
            this.tbHeading.Maximum = 180;
            this.tbHeading.Minimum = -180;
            this.tbHeading.Name = "tbHeading";
            this.tbHeading.Size = new System.Drawing.Size(284, 45);
            this.tbHeading.TabIndex = 13;
            this.tbHeading.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "Heading";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(438, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total Reward";
            // 
            // pbTotalReward
            // 
            this.pbTotalReward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbTotalReward.Location = new System.Drawing.Point(550, 15);
            this.pbTotalReward.Name = "pbTotalReward";
            this.pbTotalReward.Size = new System.Drawing.Size(218, 15);
            this.pbTotalReward.TabIndex = 10;
            // 
            // lblReward3Name
            // 
            this.lblReward3Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReward3Name.AutoSize = true;
            this.lblReward3Name.Location = new System.Drawing.Point(438, 114);
            this.lblReward3Name.Name = "lblReward3Name";
            this.lblReward3Name.Size = new System.Drawing.Size(82, 12);
            this.lblReward3Name.TabIndex = 9;
            this.lblReward3Name.Text = "reward3name";
            this.lblReward3Name.Visible = false;
            // 
            // pbReward3
            // 
            this.pbReward3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbReward3.Location = new System.Drawing.Point(550, 111);
            this.pbReward3.Name = "pbReward3";
            this.pbReward3.Size = new System.Drawing.Size(218, 15);
            this.pbReward3.TabIndex = 8;
            this.pbReward3.Visible = false;
            // 
            // lblReward2Name
            // 
            this.lblReward2Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReward2Name.AutoSize = true;
            this.lblReward2Name.Location = new System.Drawing.Point(438, 81);
            this.lblReward2Name.Name = "lblReward2Name";
            this.lblReward2Name.Size = new System.Drawing.Size(82, 12);
            this.lblReward2Name.TabIndex = 7;
            this.lblReward2Name.Text = "reward2name";
            this.lblReward2Name.Visible = false;
            // 
            // pbReward2
            // 
            this.pbReward2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbReward2.Location = new System.Drawing.Point(550, 78);
            this.pbReward2.Name = "pbReward2";
            this.pbReward2.Size = new System.Drawing.Size(218, 15);
            this.pbReward2.TabIndex = 6;
            this.pbReward2.Visible = false;
            // 
            // lblReward1Name
            // 
            this.lblReward1Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblReward1Name.AutoSize = true;
            this.lblReward1Name.Location = new System.Drawing.Point(438, 51);
            this.lblReward1Name.Name = "lblReward1Name";
            this.lblReward1Name.Size = new System.Drawing.Size(82, 12);
            this.lblReward1Name.TabIndex = 5;
            this.lblReward1Name.Text = "reward1name";
            this.lblReward1Name.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Steer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Throttle";
            // 
            // tbSteer
            // 
            this.tbSteer.LargeChange = 1;
            this.tbSteer.Location = new System.Drawing.Point(81, 51);
            this.tbSteer.Maximum = 2;
            this.tbSteer.Minimum = -2;
            this.tbSteer.Name = "tbSteer";
            this.tbSteer.Size = new System.Drawing.Size(284, 45);
            this.tbSteer.TabIndex = 2;
            this.tbSteer.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // tbThrottle
            // 
            this.tbThrottle.LargeChange = 1;
            this.tbThrottle.Location = new System.Drawing.Point(81, 9);
            this.tbThrottle.Maximum = 3;
            this.tbThrottle.Name = "tbThrottle";
            this.tbThrottle.Size = new System.Drawing.Size(284, 45);
            this.tbThrottle.TabIndex = 1;
            this.tbThrottle.Value = 1;
            this.tbThrottle.ValueChanged += new System.EventHandler(this.ValueChanged);
            // 
            // canvas
            // 
            this.canvas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Location = new System.Drawing.Point(12, 12);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(862, 529);
            this.canvas.TabIndex = 2;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 863);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "FrmMain";
            this.Text = "DeepRacer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbHeading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSteer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbThrottle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbReward1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbSteer;
        private System.Windows.Forms.TrackBar tbThrottle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar pbTotalReward;
        private System.Windows.Forms.Label lblReward3Name;
        private System.Windows.Forms.ProgressBar pbReward3;
        private System.Windows.Forms.Label lblReward2Name;
        private System.Windows.Forms.ProgressBar pbReward2;
        private System.Windows.Forms.Label lblReward1Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbHeading;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Label lbHeading;
        private System.Windows.Forms.Label lbSteer;
        private System.Windows.Forms.Label lbThrottle;
        private System.Windows.Forms.Label lblTotalReward;
        private System.Windows.Forms.Label lblReward3;
        private System.Windows.Forms.Label lblReward2;
        private System.Windows.Forms.Label lblReward1;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblClosestWp;
        private System.Windows.Forms.Label lblTrackDirectionDiff;
        private System.Windows.Forms.Label lblDistanceFromCenter;
        private System.Windows.Forms.Button btnResetScale;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.TrackBar tbProgress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.CheckBox chkReverse;
        private System.Windows.Forms.Label lblMouse;
        private System.Windows.Forms.Label lblOptimalDirectionDiff;
        private System.Windows.Forms.Label lblClosestOwp;
        private System.Windows.Forms.Label lblDistanceFromOptimal;
        private System.Windows.Forms.CheckBox cbShowOptimal;
        private System.Windows.Forms.CheckBox cbShowWaypoint;
        private System.Windows.Forms.CheckBox cbFollowOptimal;
        private System.Windows.Forms.CheckBox cbFollowTrack;
    }
}

