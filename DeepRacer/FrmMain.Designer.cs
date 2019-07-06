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
            this.pbPositionReward = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalReward = new System.Windows.Forms.Label();
            this.lblSpeedReward = new System.Windows.Forms.Label();
            this.lblHeadingReward = new System.Windows.Forms.Label();
            this.lblPositionReward = new System.Windows.Forms.Label();
            this.lbHeading = new System.Windows.Forms.Label();
            this.lbSteer = new System.Windows.Forms.Label();
            this.lbThrottle = new System.Windows.Forms.Label();
            this.tbHeading = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pbTotalReward = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.pbSpeedReward = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.pbHeadingReward = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSteer = new System.Windows.Forms.TrackBar();
            this.tbThrottle = new System.Windows.Forms.TrackBar();
            this.canvas = new System.Windows.Forms.PictureBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.lblClosestWp = new System.Windows.Forms.Label();
            this.lblAngle = new System.Windows.Forms.Label();
            this.lblDistanceFromCenter = new System.Windows.Forms.Label();
            this.btnResetScale = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbHeading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSteer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbThrottle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPositionReward
            // 
            this.pbPositionReward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPositionReward.Location = new System.Drawing.Point(564, 13);
            this.pbPositionReward.Name = "pbPositionReward";
            this.pbPositionReward.Size = new System.Drawing.Size(218, 15);
            this.pbPositionReward.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnResetScale);
            this.panel1.Controls.Add(this.lblDistanceFromCenter);
            this.panel1.Controls.Add(this.lblAngle);
            this.panel1.Controls.Add(this.lblClosestWp);
            this.panel1.Controls.Add(this.lblPosition);
            this.panel1.Controls.Add(this.lblTotalReward);
            this.panel1.Controls.Add(this.lblSpeedReward);
            this.panel1.Controls.Add(this.lblHeadingReward);
            this.panel1.Controls.Add(this.lblPositionReward);
            this.panel1.Controls.Add(this.lbHeading);
            this.panel1.Controls.Add(this.lbSteer);
            this.panel1.Controls.Add(this.lbThrottle);
            this.panel1.Controls.Add(this.tbHeading);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.pbTotalReward);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.pbSpeedReward);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pbHeadingReward);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tbSteer);
            this.panel1.Controls.Add(this.tbThrottle);
            this.panel1.Controls.Add(this.pbPositionReward);
            this.panel1.Location = new System.Drawing.Point(12, 556);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 218);
            this.panel1.TabIndex = 1;
            // 
            // lblTotalReward
            // 
            this.lblTotalReward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalReward.AutoSize = true;
            this.lblTotalReward.Location = new System.Drawing.Point(799, 109);
            this.lblTotalReward.Name = "lblTotalReward";
            this.lblTotalReward.Size = new System.Drawing.Size(89, 12);
            this.lblTotalReward.TabIndex = 20;
            this.lblTotalReward.Text = "lblTotalReward";
            // 
            // lblSpeedReward
            // 
            this.lblSpeedReward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpeedReward.AutoSize = true;
            this.lblSpeedReward.Location = new System.Drawing.Point(799, 76);
            this.lblSpeedReward.Name = "lblSpeedReward";
            this.lblSpeedReward.Size = new System.Drawing.Size(97, 12);
            this.lblSpeedReward.TabIndex = 19;
            this.lblSpeedReward.Text = "lblSpeedReward";
            // 
            // lblHeadingReward
            // 
            this.lblHeadingReward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeadingReward.AutoSize = true;
            this.lblHeadingReward.Location = new System.Drawing.Point(799, 42);
            this.lblHeadingReward.Name = "lblHeadingReward";
            this.lblHeadingReward.Size = new System.Drawing.Size(107, 12);
            this.lblHeadingReward.TabIndex = 18;
            this.lblHeadingReward.Text = "lblHeadingReward";
            // 
            // lblPositionReward
            // 
            this.lblPositionReward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPositionReward.AutoSize = true;
            this.lblPositionReward.Location = new System.Drawing.Point(799, 13);
            this.lblPositionReward.Name = "lblPositionReward";
            this.lblPositionReward.Size = new System.Drawing.Size(106, 12);
            this.lblPositionReward.TabIndex = 17;
            this.lblPositionReward.Text = "lblPositionReward";
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
            this.label6.Location = new System.Drawing.Point(452, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total Reward";
            // 
            // pbTotalReward
            // 
            this.pbTotalReward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbTotalReward.Location = new System.Drawing.Point(564, 109);
            this.pbTotalReward.Name = "pbTotalReward";
            this.pbTotalReward.Size = new System.Drawing.Size(218, 15);
            this.pbTotalReward.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "Speed Reward";
            // 
            // pbSpeedReward
            // 
            this.pbSpeedReward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSpeedReward.Location = new System.Drawing.Point(564, 76);
            this.pbSpeedReward.Name = "pbSpeedReward";
            this.pbSpeedReward.Size = new System.Drawing.Size(218, 15);
            this.pbSpeedReward.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "Heading Reward";
            // 
            // pbHeadingReward
            // 
            this.pbHeadingReward.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbHeadingReward.Location = new System.Drawing.Point(564, 43);
            this.pbHeadingReward.Name = "pbHeadingReward";
            this.pbHeadingReward.Size = new System.Drawing.Size(218, 15);
            this.pbHeadingReward.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Position Reward";
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
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.Location = new System.Drawing.Point(12, 12);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(837, 525);
            this.canvas.TabIndex = 2;
            this.canvas.TabStop = false;
            this.canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.canvas_Paint);
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(27, 134);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(49, 12);
            this.lblPosition.TabIndex = 21;
            this.lblPosition.Text = "position";
            // 
            // lblClosestWp
            // 
            this.lblClosestWp.AutoSize = true;
            this.lblClosestWp.Location = new System.Drawing.Point(182, 134);
            this.lblClosestWp.Name = "lblClosestWp";
            this.lblClosestWp.Size = new System.Drawing.Size(63, 12);
            this.lblClosestWp.TabIndex = 22;
            this.lblClosestWp.Text = "closestWp";
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.Location = new System.Drawing.Point(387, 134);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(36, 12);
            this.lblAngle.TabIndex = 23;
            this.lblAngle.Text = "angle";
            // 
            // lblDistanceFromCenter
            // 
            this.lblDistanceFromCenter.AutoSize = true;
            this.lblDistanceFromCenter.Location = new System.Drawing.Point(27, 158);
            this.lblDistanceFromCenter.Name = "lblDistanceFromCenter";
            this.lblDistanceFromCenter.Size = new System.Drawing.Size(53, 12);
            this.lblDistanceFromCenter.TabIndex = 24;
            this.lblDistanceFromCenter.Text = "distance";
            // 
            // btnResetScale
            // 
            this.btnResetScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetScale.Location = new System.Drawing.Point(752, 134);
            this.btnResetScale.Name = "btnResetScale";
            this.btnResetScale.Size = new System.Drawing.Size(110, 23);
            this.btnResetScale.TabIndex = 25;
            this.btnResetScale.Text = "Reset Scale";
            this.btnResetScale.UseVisualStyleBackColor = true;
            this.btnResetScale.Click += new System.EventHandler(this.btnResetScale_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 786);
            this.Controls.Add(this.canvas);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMain";
            this.Text = "DeepRacer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbHeading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSteer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbThrottle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbPositionReward;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tbSteer;
        private System.Windows.Forms.TrackBar tbThrottle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar pbTotalReward;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar pbSpeedReward;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar pbHeadingReward;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbHeading;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Label lbHeading;
        private System.Windows.Forms.Label lbSteer;
        private System.Windows.Forms.Label lbThrottle;
        private System.Windows.Forms.Label lblTotalReward;
        private System.Windows.Forms.Label lblSpeedReward;
        private System.Windows.Forms.Label lblHeadingReward;
        private System.Windows.Forms.Label lblPositionReward;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblClosestWp;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.Label lblDistanceFromCenter;
        private System.Windows.Forms.Button btnResetScale;
    }
}

