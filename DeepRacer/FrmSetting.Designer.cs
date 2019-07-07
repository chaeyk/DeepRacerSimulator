namespace DeepRacer
{
    partial class FrmSetting
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbMaxSteer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSteerSteps = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMaxSpeed = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbSpeedSteps = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Steer";
            // 
            // tbMaxSteer
            // 
            this.tbMaxSteer.Location = new System.Drawing.Point(112, 25);
            this.tbMaxSteer.Name = "tbMaxSteer";
            this.tbMaxSteer.Size = new System.Drawing.Size(100, 21);
            this.tbMaxSteer.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "SteerStep";
            // 
            // cbSteerSteps
            // 
            this.cbSteerSteps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSteerSteps.FormattingEnabled = true;
            this.cbSteerSteps.Items.AddRange(new object[] {
            "3",
            "5",
            "7"});
            this.cbSteerSteps.Location = new System.Drawing.Point(112, 59);
            this.cbSteerSteps.Name = "cbSteerSteps";
            this.cbSteerSteps.Size = new System.Drawing.Size(100, 20);
            this.cbSteerSteps.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Speed";
            // 
            // tbMaxSpeed
            // 
            this.tbMaxSpeed.Location = new System.Drawing.Point(112, 91);
            this.tbMaxSpeed.Name = "tbMaxSpeed";
            this.tbMaxSpeed.Size = new System.Drawing.Size(100, 21);
            this.tbMaxSpeed.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "SpeedStep";
            // 
            // cbSpeedSteps
            // 
            this.cbSpeedSteps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSpeedSteps.FormattingEnabled = true;
            this.cbSpeedSteps.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cbSpeedSteps.Location = new System.Drawing.Point(112, 124);
            this.cbSpeedSteps.Name = "cbSpeedSteps";
            this.cbSpeedSteps.Size = new System.Drawing.Size(100, 20);
            this.cbSpeedSteps.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(43, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 26);
            this.button1.TabIndex = 8;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(131, 162);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 25);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FrmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 201);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbSpeedSteps);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMaxSpeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSteerSteps);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMaxSteer);
            this.Controls.Add(this.label1);
            this.Name = "FrmSetting";
            this.Text = "Setting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMaxSteer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMaxSpeed;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbSpeedSteps;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbSteerSteps;
    }
}