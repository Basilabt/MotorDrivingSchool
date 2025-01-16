namespace MotorDrivingSchool.Screens.Motors
{
    partial class frmAddNewMotor
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
            this.txtboxChassisNumber = new System.Windows.Forms.TextBox();
            this.txtboxModel = new System.Windows.Forms.TextBox();
            this.comboboxCapacity = new System.Windows.Forms.ComboBox();
            this.txtboxImagePath = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MotorDrivingSchool.Properties.Resources.MainBackround;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(552, 283);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtboxChassisNumber
            // 
            this.txtboxChassisNumber.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtboxChassisNumber.Location = new System.Drawing.Point(7, 60);
            this.txtboxChassisNumber.Name = "txtboxChassisNumber";
            this.txtboxChassisNumber.Size = new System.Drawing.Size(242, 20);
            this.txtboxChassisNumber.TabIndex = 2;
            this.txtboxChassisNumber.Text = "Chassis Number";
            // 
            // txtboxModel
            // 
            this.txtboxModel.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtboxModel.Location = new System.Drawing.Point(7, 96);
            this.txtboxModel.Name = "txtboxModel";
            this.txtboxModel.Size = new System.Drawing.Size(242, 20);
            this.txtboxModel.TabIndex = 3;
            this.txtboxModel.Text = "Model";
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
            this.comboboxCapacity.Location = new System.Drawing.Point(7, 132);
            this.comboboxCapacity.Name = "comboboxCapacity";
            this.comboboxCapacity.Size = new System.Drawing.Size(242, 21);
            this.comboboxCapacity.TabIndex = 7;
            // 
            // txtboxImagePath
            // 
            this.txtboxImagePath.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtboxImagePath.Location = new System.Drawing.Point(7, 169);
            this.txtboxImagePath.Name = "txtboxImagePath";
            this.txtboxImagePath.Size = new System.Drawing.Size(242, 20);
            this.txtboxImagePath.TabIndex = 8;
            this.txtboxImagePath.Text = "Image Path";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = global::MotorDrivingSchool.Properties.Resources.black_hole__3_;
            this.btnAdd.Location = new System.Drawing.Point(65, 205);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 25);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 33);
            this.label1.TabIndex = 10;
            this.label1.Text = "New Motor Info:";
            // 
            // frmAddNewMotor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 278);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtboxImagePath);
            this.Controls.Add(this.comboboxCapacity);
            this.Controls.Add(this.txtboxModel);
            this.Controls.Add(this.txtboxChassisNumber);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAddNewMotor";
            this.Text = "Add New Motor";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtboxChassisNumber;
        private System.Windows.Forms.TextBox txtboxModel;
        private System.Windows.Forms.ComboBox comboboxCapacity;
        private System.Windows.Forms.TextBox txtboxImagePath;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
    }
}