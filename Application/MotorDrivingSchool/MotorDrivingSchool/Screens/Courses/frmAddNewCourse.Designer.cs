namespace MotorDrivingSchool.Screens.Courses
{
    partial class frmAddNewCourse
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.ctrNewCourseInfo1 = new MotorDrivingSchool.Controls.ctrNewCourseInfo();
            this.ctrNewPersonInfo1 = new MotorDrivingSchool.Controls.ctrNewPersonInfo();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MotorDrivingSchool.Properties.Resources.MainBackround;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(869, 531);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(302, 487);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(256, 28);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ctrNewCourseInfo1
            // 
            this.ctrNewCourseInfo1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ctrNewCourseInfo1.Location = new System.Drawing.Point(22, 328);
            this.ctrNewCourseInfo1.Name = "ctrNewCourseInfo1";
            this.ctrNewCourseInfo1.Size = new System.Drawing.Size(833, 125);
            this.ctrNewCourseInfo1.TabIndex = 2;
            // 
            // ctrNewPersonInfo1
            // 
            this.ctrNewPersonInfo1.BackColor = System.Drawing.Color.Black;
            this.ctrNewPersonInfo1.Location = new System.Drawing.Point(12, 12);
            this.ctrNewPersonInfo1.Name = "ctrNewPersonInfo1";
            this.ctrNewPersonInfo1.Size = new System.Drawing.Size(845, 298);
            this.ctrNewPersonInfo1.TabIndex = 1;
            this.ctrNewPersonInfo1.title = null;
            // 
            // frmAddNewCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 527);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.ctrNewCourseInfo1);
            this.Controls.Add(this.ctrNewPersonInfo1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmAddNewCourse";
            this.Text = "Add New Course";
            this.Load += new System.EventHandler(this.frmAddNewCourse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Controls.ctrNewPersonInfo ctrNewPersonInfo1;
        private Controls.ctrNewCourseInfo ctrNewCourseInfo1;
        private System.Windows.Forms.Button btnAdd;
    }
}