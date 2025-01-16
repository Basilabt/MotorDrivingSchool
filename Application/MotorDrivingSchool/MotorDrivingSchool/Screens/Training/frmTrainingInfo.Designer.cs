namespace MotorDrivingSchool.Screens.Training
{
    partial class frmTrainingInfo
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRemainingTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxPhoneNumber = new System.Windows.Forms.TextBox();
            this.comboboxDurration = new System.Windows.Forms.ComboBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MotorDrivingSchool.Properties.Resources.MainBackround;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblRemainingTime
            // 
            this.lblRemainingTime.AutoSize = true;
            this.lblRemainingTime.BackColor = System.Drawing.Color.Black;
            this.lblRemainingTime.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainingTime.ForeColor = System.Drawing.Color.White;
            this.lblRemainingTime.Location = new System.Drawing.Point(12, 40);
            this.lblRemainingTime.Name = "lblRemainingTime";
            this.lblRemainingTime.Size = new System.Drawing.Size(140, 23);
            this.lblRemainingTime.TabIndex = 6;
            this.lblRemainingTime.Text = "Phone Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Durration:";
            // 
            // txtboxPhoneNumber
            // 
            this.txtboxPhoneNumber.Location = new System.Drawing.Point(16, 76);
            this.txtboxPhoneNumber.Name = "txtboxPhoneNumber";
            this.txtboxPhoneNumber.Size = new System.Drawing.Size(208, 20);
            this.txtboxPhoneNumber.TabIndex = 8;
            // 
            // comboboxDurration
            // 
            this.comboboxDurration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxDurration.ForeColor = System.Drawing.Color.DimGray;
            this.comboboxDurration.FormattingEnabled = true;
            this.comboboxDurration.Items.AddRange(new object[] {
            "0.5",
            "1.0",
            "1.5",
            "2.0",
            "2.5",
            "3.0",
            "3.5",
            "4.0"});
            this.comboboxDurration.Location = new System.Drawing.Point(16, 159);
            this.comboboxDurration.Name = "comboboxDurration";
            this.comboboxDurration.Size = new System.Drawing.Size(208, 21);
            this.comboboxDurration.TabIndex = 9;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Black;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Location = new System.Drawing.Point(153, 200);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(110, 31);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click_1);
            // 
            // frmTrainingInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 243);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.comboboxDurration);
            this.Controls.Add(this.txtboxPhoneNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRemainingTime);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmTrainingInfo";
            this.Text = "Training Info";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRemainingTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxPhoneNumber;
        private System.Windows.Forms.ComboBox comboboxDurration;
        private System.Windows.Forms.Button btnConfirm;
    }
}