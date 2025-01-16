namespace MotorDrivingSchool.Screens.Trainees
{
    partial class frmTraineesMainScreen
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
            this.dgvTrainees = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtboxPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTrainees
            // 
            this.dgvTrainees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrainees.Location = new System.Drawing.Point(12, 67);
            this.dgvTrainees.Name = "dgvTrainees";
            this.dgvTrainees.Size = new System.Drawing.Size(644, 437);
            this.dgvTrainees.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Search:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MotorDrivingSchool.Properties.Resources.MainBackround;
            this.pictureBox1.Location = new System.Drawing.Point(-4, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(698, 535);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtboxPhoneNumber
            // 
            this.txtboxPhoneNumber.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtboxPhoneNumber.Location = new System.Drawing.Point(93, 31);
            this.txtboxPhoneNumber.Name = "txtboxPhoneNumber";
            this.txtboxPhoneNumber.Size = new System.Drawing.Size(137, 20);
            this.txtboxPhoneNumber.TabIndex = 18;
            this.txtboxPhoneNumber.Text = "Phone Number";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.Image = global::MotorDrivingSchool.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(236, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(29, 25);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSearch.TabIndex = 19;
            this.btnSearch.TabStop = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmTraineesMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 533);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtboxPhoneNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTrainees);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmTraineesMainScreen";
            this.Text = "Tainees";
            this.Load += new System.EventHandler(this.frmTraineesMainScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvTrainees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxPhoneNumber;
        private System.Windows.Forms.PictureBox btnSearch;
    }
}