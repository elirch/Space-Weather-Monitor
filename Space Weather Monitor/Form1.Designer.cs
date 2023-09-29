namespace Space_Weather_Monitor
{
    partial class pnlWeatherOverview
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.solarFlareActivity = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.notificationTimer = new System.Windows.Forms.Timer(this.components);
            this.notificationsTextBox = new System.Windows.Forms.TextBox();
            this.btnApod = new System.Windows.Forms.Button();
            this.pictureBoxApod = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelIPSInfo = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelMPCInfo = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelRBEInfo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxApod)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.solarFlareActivity);
            this.groupBox1.Font = new System.Drawing.Font("Narkisim", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(41, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 276);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solar Flares";
            // 
            // solarFlareActivity
            // 
            this.solarFlareActivity.AutoSize = true;
            this.solarFlareActivity.ForeColor = System.Drawing.Color.OrangeRed;
            this.solarFlareActivity.Location = new System.Drawing.Point(6, 82);
            this.solarFlareActivity.Name = "solarFlareActivity";
            this.solarFlareActivity.Size = new System.Drawing.Size(204, 16);
            this.solarFlareActivity.TabIndex = 0;
            this.solarFlareActivity.Text = "Latest Solar Flare Activity";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblStartTime);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Narkisim", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(486, 480);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 276);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Geomagnetic Storms";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblStartTime.Location = new System.Drawing.Point(3, 173);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(50, 16);
            this.lblStartTime.TabIndex = 5;
            this.lblStartTime.Text = "label4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(3, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Geomagnetic Activity Over Time";
            // 
            // notificationTimer
            // 
            this.notificationTimer.Interval = 5000;
            // 
            // notificationsTextBox
            // 
            this.notificationsTextBox.BackColor = System.Drawing.Color.Lavender;
            this.notificationsTextBox.Font = new System.Drawing.Font("Narkisim", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationsTextBox.ForeColor = System.Drawing.Color.Brown;
            this.notificationsTextBox.Location = new System.Drawing.Point(41, 31);
            this.notificationsTextBox.Multiline = true;
            this.notificationsTextBox.Name = "notificationsTextBox";
            this.notificationsTextBox.ReadOnly = true;
            this.notificationsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notificationsTextBox.Size = new System.Drawing.Size(1401, 89);
            this.notificationsTextBox.TabIndex = 3;
            // 
            // btnApod
            // 
            this.btnApod.Location = new System.Drawing.Point(1057, 158);
            this.btnApod.Name = "btnApod";
            this.btnApod.Size = new System.Drawing.Size(204, 31);
            this.btnApod.TabIndex = 4;
            this.btnApod.Text = "Picture of the Day";
            this.btnApod.UseVisualStyleBackColor = true;
            // 
            // pictureBoxApod
            // 
            this.pictureBoxApod.Location = new System.Drawing.Point(974, 195);
            this.pictureBoxApod.Name = "pictureBoxApod";
            this.pictureBoxApod.Size = new System.Drawing.Size(371, 195);
            this.pictureBoxApod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxApod.TabIndex = 5;
            this.pictureBoxApod.TabStop = false;
            this.pictureBoxApod.Click += new System.EventHandler(this.pictureBoxApod_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelIPSInfo);
            this.groupBox3.Font = new System.Drawing.Font("Narkisim", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(486, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(385, 276);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Interplanetary Shock";
            // 
            // labelIPSInfo
            // 
            this.labelIPSInfo.AutoSize = true;
            this.labelIPSInfo.Location = new System.Drawing.Point(3, 82);
            this.labelIPSInfo.Name = "labelIPSInfo";
            this.labelIPSInfo.Size = new System.Drawing.Size(215, 16);
            this.labelIPSInfo.TabIndex = 0;
            this.labelIPSInfo.Text = " Interplanetary Shock (IPS) ";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelMPCInfo);
            this.groupBox4.Font = new System.Drawing.Font("Narkisim", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox4.Location = new System.Drawing.Point(41, 480);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(374, 282);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Magnetopause Crossing";
            // 
            // labelMPCInfo
            // 
            this.labelMPCInfo.AutoSize = true;
            this.labelMPCInfo.Location = new System.Drawing.Point(6, 73);
            this.labelMPCInfo.Name = "labelMPCInfo";
            this.labelMPCInfo.Size = new System.Drawing.Size(225, 16);
            this.labelMPCInfo.TabIndex = 0;
            this.labelMPCInfo.Text = "Magnetopause Crossing event";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelRBEInfo);
            this.groupBox5.Font = new System.Drawing.Font("Narkisim", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox5.Location = new System.Drawing.Point(928, 480);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(442, 282);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Radiation Belt";
            // 
            // labelRBEInfo
            // 
            this.labelRBEInfo.AutoSize = true;
            this.labelRBEInfo.Font = new System.Drawing.Font("Narkisim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRBEInfo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelRBEInfo.Location = new System.Drawing.Point(6, 81);
            this.labelRBEInfo.Name = "labelRBEInfo";
            this.labelRBEInfo.Size = new System.Drawing.Size(252, 20);
            this.labelRBEInfo.TabIndex = 0;
            this.labelRBEInfo.Text = "Radiation Belt Enhancement";
            // 
            // pnlWeatherOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(1491, 800);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBoxApod);
            this.Controls.Add(this.btnApod);
            this.Controls.Add(this.notificationsTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "pnlWeatherOverview";
            this.Text = "    ";
            this.Load += new System.EventHandler(this.pnlWeatherOverview_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxApod)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label solarFlareActivity;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Timer notificationTimer;
        private System.Windows.Forms.TextBox notificationsTextBox;
        private System.Windows.Forms.Button btnApod;
        private System.Windows.Forms.PictureBox pictureBoxApod;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelIPSInfo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label labelMPCInfo;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label labelRBEInfo;
    }
}

