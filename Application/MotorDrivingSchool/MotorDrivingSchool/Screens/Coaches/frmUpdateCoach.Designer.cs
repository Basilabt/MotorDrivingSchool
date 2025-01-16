namespace MotorDrivingSchool.Screens.Coaches
{
    partial class frmUpdateCoach
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
            this.ctrNewPersonInfo1 = new MotorDrivingSchool.Controls.ctrNewPersonInfo();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ctrNewPersonInfo1
            // 
            this.ctrNewPersonInfo1.BackColor = System.Drawing.Color.Black;
            this.ctrNewPersonInfo1.Location = new System.Drawing.Point(12, 12);
            this.ctrNewPersonInfo1.Name = "ctrNewPersonInfo1";
            this.ctrNewPersonInfo1.Size = new System.Drawing.Size(837, 298);
            this.ctrNewPersonInfo1.TabIndex = 2;
            this.ctrNewPersonInfo1.title = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MotorDrivingSchool.Properties.Resources.MainBackround;
            this.pictureBox1.Location = new System.Drawing.Point(-36, -24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(908, 387);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(290, 316);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(256, 28);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmUpdateCoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 359);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.ctrNewPersonInfo1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmUpdateCoach";
            this.Text = "Update Coach";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Controls.ctrNewPersonInfo ctrNewPersonInfo1;
        private System.Windows.Forms.Button btnUpdate;
    }
}