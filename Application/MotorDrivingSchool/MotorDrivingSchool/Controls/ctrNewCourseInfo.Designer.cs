namespace MotorDrivingSchool.Controls
{
    partial class ctrNewCourseInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboboxCoaches = new System.Windows.Forms.ComboBox();
            this.groupboxPersonInfo = new System.Windows.Forms.GroupBox();
            this.comboboxLicenseTypes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupboxPersonInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Coach:";
            // 
            // comboboxCoaches
            // 
            this.comboboxCoaches.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxCoaches.ForeColor = System.Drawing.Color.DimGray;
            this.comboboxCoaches.FormattingEnabled = true;
            this.comboboxCoaches.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboboxCoaches.Location = new System.Drawing.Point(71, 45);
            this.comboboxCoaches.Name = "comboboxCoaches";
            this.comboboxCoaches.Size = new System.Drawing.Size(242, 28);
            this.comboboxCoaches.TabIndex = 15;
            // 
            // groupboxPersonInfo
            // 
            this.groupboxPersonInfo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupboxPersonInfo.Controls.Add(this.label2);
            this.groupboxPersonInfo.Controls.Add(this.comboboxLicenseTypes);
            this.groupboxPersonInfo.Controls.Add(this.label1);
            this.groupboxPersonInfo.Controls.Add(this.comboboxCoaches);
            this.groupboxPersonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupboxPersonInfo.ForeColor = System.Drawing.Color.White;
            this.groupboxPersonInfo.Location = new System.Drawing.Point(3, 3);
            this.groupboxPersonInfo.Name = "groupboxPersonInfo";
            this.groupboxPersonInfo.Size = new System.Drawing.Size(820, 112);
            this.groupboxPersonInfo.TabIndex = 18;
            this.groupboxPersonInfo.TabStop = false;
            this.groupboxPersonInfo.Text = "Course Info";
            // 
            // comboboxLicenseTypes
            // 
            this.comboboxLicenseTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxLicenseTypes.ForeColor = System.Drawing.Color.DimGray;
            this.comboboxLicenseTypes.FormattingEnabled = true;
            this.comboboxLicenseTypes.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboboxLicenseTypes.Location = new System.Drawing.Point(520, 45);
            this.comboboxLicenseTypes.Name = "comboboxLicenseTypes";
            this.comboboxLicenseTypes.Size = new System.Drawing.Size(242, 28);
            this.comboboxLicenseTypes.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(397, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "License Type:";
            // 
            // ctrNewCourseInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.groupboxPersonInfo);
            this.Name = "ctrNewCourseInfo";
            this.Size = new System.Drawing.Size(840, 125);
            this.Load += new System.EventHandler(this.ctrNewCourseInfo_Load);
            this.groupboxPersonInfo.ResumeLayout(false);
            this.groupboxPersonInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboboxCoaches;
        private System.Windows.Forms.GroupBox groupboxPersonInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboboxLicenseTypes;
    }
}
