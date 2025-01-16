namespace MotorDrivingSchool.Screens.Coaches
{
    partial class frmCoachesScreen
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
            this.dgvCoaches = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoaches)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCoaches
            // 
            this.dgvCoaches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoaches.Location = new System.Drawing.Point(25, 24);
            this.dgvCoaches.Name = "dgvCoaches";
            this.dgvCoaches.Size = new System.Drawing.Size(656, 437);
            this.dgvCoaches.TabIndex = 7;
            this.dgvCoaches.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCoaches_CellDoubleClick);
            this.dgvCoaches.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dgvCoaches_MouseDoubleClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::MotorDrivingSchool.Properties.Resources.black_hole__3_;
            this.btnDelete.Location = new System.Drawing.Point(698, 249);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 35);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.ForeColor = System.Drawing.Color.White;
            this.btnAddNew.Image = global::MotorDrivingSchool.Properties.Resources.black_hole__3_;
            this.btnAddNew.Location = new System.Drawing.Point(698, 190);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(126, 35);
            this.btnAddNew.TabIndex = 8;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MotorDrivingSchool.Properties.Resources.MainBackround;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(872, 498);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmCoachesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 492);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.dgvCoaches);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmCoachesScreen";
            this.Text = "Coaches";
            this.Load += new System.EventHandler(this.frmCoachesScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoaches)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.DataGridView dgvCoaches;
    }
}