namespace MotorDrivingSchool.Screens.Coaches
{
    partial class frmAddNewCoach
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.ctrNewPersonInfo1 = new MotorDrivingSchool.Controls.ctrNewPersonInfo();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(268, 304);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(256, 28);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ctrNewPersonInfo1
            // 
            this.ctrNewPersonInfo1.BackColor = System.Drawing.Color.Black;
            this.ctrNewPersonInfo1.Location = new System.Drawing.Point(2, 3);
            this.ctrNewPersonInfo1.Name = "ctrNewPersonInfo1";
            this.ctrNewPersonInfo1.Size = new System.Drawing.Size(838, 299);
            this.ctrNewPersonInfo1.TabIndex = 1;
            // 
            // frmAddNewCoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(847, 344);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ctrNewPersonInfo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmAddNewCoach";
            this.Text = "Add New Coach";
            this.Load += new System.EventHandler(this.frmAddNewCoach_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.ctrNewPersonInfo ctrNewPersonInfo1;
        private System.Windows.Forms.Button btnAdd;
    }
}