using KhachSan.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KhachSan.GUI
{
    public partial class TrangChu_GUI : Form
    {
        private DangNhap_GUI logForm = null;
        public TrangChu_GUI(DangNhap_GUI log)
        {
            this.logForm = log;
            InitializeComponent();
            OpenChildForm(new TongQuan());
            this.StartPosition = FormStartPosition.CenterScreen;

        }
        public void HideBtnBackupRestore()
        {
            btn_backup_restore.Visible = false;
        }

        public void HideBtnRoom()
        {
            btn_room.Visible = false;
        }
        private Form currentformchild;
        private void OpenChildForm(Form child)
        {
            if (currentformchild != null)
                currentformchild.Close();
            currentformchild = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            bunifuPanel_child.Controls.Add(child);
            bunifuPanel_child.Width = child.Width;
            bunifuPanel_child.Height = child.Height;
            bunifuPanel_title.Width = child.Width;
            this.Width = bunifuPanel_menu.Width + bunifuPanel_child.Width + 10;
            this.Height = bunifuPanel_child.Height + bunifuPanel_title.Height + 40;
            bunifuPanel_child.BringToFront();
            child.Show();
            this.StartPosition = FormStartPosition.CenterScreen;
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

            DialogResult h = MessageBox.Show
            ("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
            {
                this.logForm.Show();
                Application.Exit();
            }
        }

   

        private void btn_room_Click(object sender, EventArgs e)
        {
            btn_room.Top = ((Control)sender).Top;
            OpenChildForm(new ViTriTuyenDung_GUI());
            label1.Text = "VỊ TRÍ ĐANG TUYỂN";
        }

        private void btn_logout_Click_1(object sender, EventArgs e)
        {
           
          
            DialogResult h = MessageBox.Show
           ("Bạn có chắc muốn đăng xuất không?", "Thông báo", MessageBoxButtons.OKCancel);
           
            if (h == DialogResult.OK)
            {

                this.logForm.Show();
                this.Close();
             }
        }

        private void btn_khachhang_Click(object sender, EventArgs e)
        {
           btn_khachhang.Top = ((Control)sender).Top;
            OpenChildForm(new PhongVan_GUI());
            label1.Text = "PHỎNG VẤN";
        }

        private void btn_nhanvien_Click(object sender, EventArgs e)
        {
            btn_nhanvien.Top = ((Control)sender).Top;
            OpenChildForm(new UngTuyen_GUI());
            label1.Text = "ỨNG TUYỂN";
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {

        }

        private void btn_backup_restore_Click(object sender, EventArgs e)
        {
            btn_backup_restore.Top = ((Control)sender).Top;
            OpenChildForm(new Backup_Restore_GUI());
            label1.Text = "SAO LƯU VÀ PHỤC HỒI";
        }
    }
}
