namespace MotorDrivingSchool.Screens.Certificates
{
    partial class frmCertificatesView
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
            this.dgvCertificatees = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.PictureBox();
            this.txtboxPhoneNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCertificatees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MotorDrivingSchool.Properties.Resources.MainBackround;
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(802, 452);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvCertificatees
            // 
            this.dgvCertificatees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCertificatees.Location = new System.Drawing.Point(12, 89);
            this.dgvCertificatees.Name = "dgvCertificatees";
            this.dgvCertificatees.Size = new System.Drawing.Size(776, 336);
            this.dgvCertificatees.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.Image = global::MotorDrivingSchool.Properties.Resources.search;
            this.btnSearch.Location = new System.Drawing.Point(243, 44);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(29, 25);
            this.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSearch.TabIndex = 22;
            this.btnSearch.TabStop = false;
            // 
            // txtboxPhoneNumber
            // 
            this.txtboxPhoneNumber.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtboxPhoneNumber.Location = new System.Drawing.Point(100, 49);
            this.txtboxPhoneNumber.Name = "txtboxPhoneNumber";
            this.txtboxPhoneNumber.Size = new System.Drawing.Size(137, 20);
            this.txtboxPhoneNumber.TabIndex = 21;
            this.txtboxPhoneNumber.Text = "Phone Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Search:";
            // 
            // frmCertificatesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtboxPhoneNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCertificatees);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmCertificatesView";
            this.Text = "Certificates";
            this.Load += new System.EventHandler(this.frmCertificatesView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCertificatees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvCertificatees;
        private System.Windows.Forms.PictureBox btnSearch;
        private System.Windows.Forms.TextBox txtboxPhoneNumber;
        private System.Windows.Forms.Label label1;
    }
}