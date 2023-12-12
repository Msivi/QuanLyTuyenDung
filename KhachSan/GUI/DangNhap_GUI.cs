using KhachSan.GUI;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KhachSan.DAO;

namespace KhachSan.DTO
{
    public partial class DangNhap_GUI : Form
    {
        
        public DangNhap_GUI()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    
        
        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            DialogResult h = MessageBox.Show
             ("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (h == DialogResult.OK)
                Application.Exit();
            
        }


        private void enter_login()
        {

            TaiKhoanUngDung tk = (TaiKhoanUngDung)db.TaiKhoanUngDung.findOne(txt_username.Text, txt_password.Text);
            if (tk == null)
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txt_password.Text = "";

                if (tk.QuyenHan == "NhanVien")
                {
                    TrangChu_GUI trangChu = new TrangChu_GUI(this);
                    trangChu.HideBtnBackupRestore(); 
                    trangChu.HideBtnRoom(); 
                    trangChu.Show();
                }
                else
                {
                    new TrangChu_GUI(this).Show();
                }

                this.Hide();
            }
        }

        private void btn_signin_Click(object sender, EventArgs e)
        {

            this.enter_login();
        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            if (txt_password.PasswordChar == '*')
            {
                txt_password.PasswordChar = '\0';
                guna2PictureBox4.Image = Properties.Resources.view;
            }
            else
            {
                txt_password.PasswordChar = '*';
                guna2PictureBox4.Image = Properties.Resources.hide;
            }
        }
        const int WM_NCHITTEST = 0x84;
        const int HTCLIENT = 0x1;
        const int HTCAPTION = 0x2;


        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }

        private void txt_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            char[] vietnameseSigns = new char[] { 'ắ', 'ằ', 'ẳ', 'ẵ', 'ặ', 'ấ', 'ầ', 'ẩ', 'ẫ', 'ậ', 'ế', 'ề', 'ể', 'ễ', 'ệ', 'ố', 'ồ', 'ổ', 'ỗ', 'ộ', 'ớ', 'ờ', 'ở', 'ỡ', 'ợ', 'ứ', 'ừ', 'ử', 'ữ', 'ự', 'ắ', 'ằ', 'ẳ', 'ẵ', 'ặ', 'đ', 'Đ' };

           
            if (vietnameseSigns.Contains(e.KeyChar))
            {
               
                e.Handled = true;
            }
        }

        private void txt_username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.enter_login();
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
