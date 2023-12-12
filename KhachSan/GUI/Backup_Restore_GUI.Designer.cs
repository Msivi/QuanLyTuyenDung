namespace KhachSan.GUI
{
    partial class Backup_Restore_GUI
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
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btn_phuc_hoi = new System.Windows.Forms.Button();
            this.btn_saoluu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.guna2CirclePictureBox1.Image = global::KhachSan.Properties.Resources.profile;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(358, 0);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(496, 143);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 4;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2PictureBox1.Image = global::KhachSan.Properties.Resources.background_hotel;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(360, 470);
            this.guna2PictureBox1.TabIndex = 5;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btn_phuc_hoi
            // 
            this.btn_phuc_hoi.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_phuc_hoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_phuc_hoi.Location = new System.Drawing.Point(652, 220);
            this.btn_phuc_hoi.Name = "btn_phuc_hoi";
            this.btn_phuc_hoi.Size = new System.Drawing.Size(134, 57);
            this.btn_phuc_hoi.TabIndex = 22;
            this.btn_phuc_hoi.Text = "Phục Hồi";
            this.btn_phuc_hoi.UseVisualStyleBackColor = false;
            this.btn_phuc_hoi.Click += new System.EventHandler(this.btn_phuc_hoi_Click_1);
            // 
            // btn_saoluu
            // 
            this.btn_saoluu.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_saoluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saoluu.Location = new System.Drawing.Point(425, 220);
            this.btn_saoluu.Name = "btn_saoluu";
            this.btn_saoluu.Size = new System.Drawing.Size(140, 57);
            this.btn_saoluu.TabIndex = 21;
            this.btn_saoluu.Text = "Sao Lưu";
            this.btn_saoluu.UseVisualStyleBackColor = false;
            this.btn_saoluu.Click += new System.EventHandler(this.btn_saoluu_Click_1);
            // 
            // Backup_Restore_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 470);
            this.Controls.Add(this.btn_phuc_hoi);
            this.Controls.Add(this.btn_saoluu);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Backup_Restore_GUI";
            this.Text = "Backup_Restore";
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Button btn_phuc_hoi;
        private System.Windows.Forms.Button btn_saoluu;
    }
}