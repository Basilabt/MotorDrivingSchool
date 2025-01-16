namespace MotorDrivingSchool.Screens.Motors
{
    partial class frmUpdateMotor
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxImagePath = new System.Windows.Forms.TextBox();
            this.comboboxCapacity = new System.Windows.Forms.ComboBox();
            this.txtboxModel = new System.Windows.Forms.TextBox();
            this.txtboxChassisNumber = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MotorDrivingSchool.Properties.Resources.MainBackround;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(545, 289);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 33);
            this.label1.TabIndex = 15;
            this.label1.Text = "New Motor Info:";
            // 
            // txtboxImagePath
            // 
            this.txtboxImagePath.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtboxImagePath.Location = new System.Drawing.Point(12, 170);
            this.txtboxImagePath.Name = "txtboxImagePath";
            this.txtboxImagePath.Size = new System.Drawing.Size(242, 20);
            this.txtboxImagePath.TabIndex = 14;
            this.txtboxImagePath.Text = "Image Path";
            // 
            // comboboxCapacity
            // 
            this.comboboxCapacity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxCapacity.ForeColor = System.Drawing.Color.DimGray;
            this.comboboxCapacity.FormattingEnabled = true;
            this.comboboxCapacity.Items.AddRange(new object[] {
            "100",
            "125",
            "150",
            "180",
            "190",
            "200",
            "250",
            "300",
            "350",
            "400",
            "450",
            "600"});
            this.comboboxCapacity.Location = new System.Drawing.Point(12, 133);
            this.comboboxCapacity.Name = "comboboxCapacity";
            this.comboboxCapacity.Size = new System.Drawing.Size(242, 21);
            this.comboboxCapacity.TabIndex = 13;
            // 
            // txtboxModel
            // 
            this.txtboxModel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtboxModel.Location = new System.Drawing.Point(12, 97);
            this.txtboxModel.Name = "txtboxModel";
            this.txtboxModel.Size = new System.Drawing.Size(242, 20);
            this.txtboxModel.TabIndex = 12;
            this.txtboxModel.Text = "Model";
            // 
            // txtboxChassisNumber
            // 
            this.txtboxChassisNumber.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtboxChassisNumber.Location = new System.Drawing.Point(12, 61);
            this.txtboxChassisNumber.Name = "txtboxChassisNumber";
            this.txtboxChassisNumber.Size = new System.Drawing.Size(242, 20);
            this.txtboxChassisNumber.TabIndex = 11;
            this.txtboxChassisNumber.Text = "Chassis Number";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = global::MotorDrivingSchool.Properties.Resources.black_hole__3_;
            this.btnUpdate.Location = new System.Drawing.Point(69, 207);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(126, 25);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmUpdateMotor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 285);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxImagePath);
            this.Controls.Add(this.comboboxCapacity);
            this.Controls.Add(this.txtboxModel);
            this.Controls.Add(this.txtboxChassisNumber);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmUpdateMotor";
            this.Text = "Update Motor";
            this.Load += new System.EventHandler(this.frmUpdateMotor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxImagePath;
        private System.Windows.Forms.ComboBox comboboxCapacity;
        private System.Windows.Forms.TextBox txtboxModel;
        private System.Windows.Forms.TextBox txtboxChassisNumber;
        private System.Windows.Forms.Button btnUpdate;
    }
}