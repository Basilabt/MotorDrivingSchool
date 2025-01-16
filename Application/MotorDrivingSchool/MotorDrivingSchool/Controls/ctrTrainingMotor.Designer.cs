namespace MotorDrivingSchool.Controls
{
    partial class ctrTrainingMotor
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPause = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRemainingTime = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Black;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.ForeColor = System.Drawing.Color.White;
            this.btnPause.Location = new System.Drawing.Point(13, 160);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(110, 26);
            this.btnPause.TabIndex = 2;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click_1);
            // 
            // btnEnd
            // 
            this.btnEnd.BackColor = System.Drawing.Color.Black;
            this.btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnd.ForeColor = System.Drawing.Color.White;
            this.btnEnd.Location = new System.Drawing.Point(13, 192);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(110, 27);
            this.btnEnd.TabIndex = 3;
            this.btnEnd.Text = "End";
            this.btnEnd.UseVisualStyleBackColor = false;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click_1);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Black;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(8, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(185, 25);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Basel Abu Taleb";
            // 
            // lblRemainingTime
            // 
            this.lblRemainingTime.AutoSize = true;
            this.lblRemainingTime.BackColor = System.Drawing.Color.Black;
            this.lblRemainingTime.Font = new System.Drawing.Font("Microsoft YaHei Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingTime.ForeColor = System.Drawing.Color.White;
            this.lblRemainingTime.Location = new System.Drawing.Point(15, 62);
            this.lblRemainingTime.Name = "lblRemainingTime";
            this.lblRemainingTime.Size = new System.Drawing.Size(127, 38);
            this.lblRemainingTime.TabIndex = 5;
            this.lblRemainingTime.Text = "00:00:00";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MotorDrivingSchool.Properties.Resources.MainBackround;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(446, 273);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Black;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(13, 128);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(110, 26);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // ctrTrainingMotor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblRemainingTime);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ctrTrainingMotor";
            this.Size = new System.Drawing.Size(446, 273);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRemainingTime;
        private System.Windows.Forms.Button btnStart;
    }
}
