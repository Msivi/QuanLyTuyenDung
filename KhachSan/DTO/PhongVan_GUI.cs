
using KhachSan.DAO;
using KhachSan.DTO;
using MongoDB.Bson;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KhachSan.GUI
{
    
    public partial class PhongVan_GUI : Form
    {

        public PhongVan_GUI()
        {
            InitializeComponent();
            txt_id.Enabled = false;
            txt_name.Enabled = false;
         
        }

        private void define_Column_Table()
        {
            table_employee.ColumnCount = 4;
            table_employee.Columns[0].HeaderText = "Tên vị trí";
            table_employee.Columns[1].HeaderText = "Mã thí sinh";
            table_employee.Columns[2].HeaderText = "Người phỏng vấn";
            table_employee.Columns[3].HeaderText = "Ngày phỏng vấn";
            //table_employee.Columns[4].HeaderText = "Nhận xét";



        }

        public void loadCbNV()
        {

            List<DTO.NhanVienPhongVan> nhanViens = (List<DTO.NhanVienPhongVan>)db.NhanVienPhongVan.find();
            cbb_nv.DisplayMember = "HoTen";
            cbb_nv.ValueMember = "_id";
            cbb_nv.DataSource = nhanViens;
            

        }



        private void load_data()
        {
            //Thêm dữ liệu vào bảng
            List<DTO.Custom> viTriTuyenDungs = (List<Custom>)db.ThiSinhTrungTuyen.find();
            foreach(DTO.Custom viTriTuyenDung in viTriTuyenDungs)               
            {
                if (viTriTuyenDung.ThiSinhTrungTuyen.PhongVan == null)
                {
                    table_employee.Rows.Add(viTriTuyenDung.TenViTri,
                    viTriTuyenDung.ThiSinhTrungTuyen.MaThiSinh);

                }
                else
                {
                    table_employee.Rows.Add(viTriTuyenDung.TenViTri,
                        viTriTuyenDung.ThiSinhTrungTuyen.MaThiSinh,
                        viTriTuyenDung.ThiSinhTrungTuyen.PhongVan.NhanVienPhongVan.ToString() != "000000000000000000000000" ? loadTenNV(viTriTuyenDung.ThiSinhTrungTuyen.PhongVan.NhanVienPhongVan.ToString()) : "",
                        viTriTuyenDung.ThiSinhTrungTuyen.PhongVan.NgayPhongVan.ToString() != "01/01/0001 12:00:00 SA" ? viTriTuyenDung.ThiSinhTrungTuyen.PhongVan.NgayPhongVan.ToString() : ""

                        );
                }


                
            }
            
        }
        private string loadTenBangMa(string ma)
        {
            List<DTO.ViTriTuyenDung> vttd = (List<DTO.ViTriTuyenDung>)db.ViTriTuyenDung.find();
            List<DTO.ThiSinhUngTuyen> tsut = vttd.Select(row => row.ThiSinhUngTuyen[0]).ToList();
            DTO.ThiSinhUngTuyen tsutt = tsut.Where(row => row.MaThiSinh == ma).FirstOrDefault();
            return tsutt.HoTen;
        }

        private string loadTenNV(string ma)
        {
            List<DTO.NhanVienPhongVan> nv = (List<DTO.NhanVienPhongVan>)db.NhanVienPhongVan.find();
            DTO.NhanVienPhongVan nv1 = nv.Where(row => row._id.ToString() == ma).FirstOrDefault();
            if(nv1!=null)
            {
                  return nv1.HoTen;
            }    
            return "";
        }
      
        private void PhongVan_GUI_Load(object sender, EventArgs e)
        {
            

            define_Column_Table();
            load_data();
            loadCbNV();
  

        }

        private void table_employee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = table_employee.CurrentRow.Cells[1].Value.ToString();
            txt_name.Text = loadTenBangMa(txt_id.Text);
            cbb_nv.Text = table_employee.CurrentRow.Cells[2].Value.ToString();
            //cbb_nv.Text = table_employee.CurrentRow.Cells[2].Value.ToString();
            if(table_employee.CurrentRow.Cells[3].Value.ToString() == "01/01/0001 12:00:00 SA")
            {
                date.Value = DateTime.Now;
            }
            else {
                date.Text = table_employee.CurrentRow.Cells[3].Value.ToString();

            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_id.Text == "" || cbb_nv.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thí sinh và nhân viên phỏng vấn");
            }
            else
            {
                DTO.PhongVan phongVan = new DTO.PhongVan();
                phongVan.NgayPhongVan = date.Value;
                phongVan.NhanVienPhongVan = ObjectId.Parse(cbb_nv.SelectedValue.ToString());
                DTO.ThiSinhTrungTuyen thiSinhTrungTuyen = new DTO.ThiSinhTrungTuyen();
                thiSinhTrungTuyen.MaThiSinh = txt_id.Text;
                thiSinhTrungTuyen.PhongVan = phongVan;
                DTO.Custom vttd = new DTO.Custom();
                vttd.ThiSinhTrungTuyen = thiSinhTrungTuyen;
                if (db.ThiSinhTrungTuyen.updateOne(vttd))
                {
                    MessageBox.Show("Cập nhật thành công");
                    table_employee.Rows.Clear();
                    load_data();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }
            
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(txt_id.Text == "")
            {
                MessageBox.Show("Vui lòng chọn thí sinh phỏng vấn");

            }
            else
            {
                DTO.PhongVan phongVan = new DTO.PhongVan();
                phongVan.NgayPhongVan = DateTime.Parse("01/01/0001 12:00:00 SA");
                phongVan.NhanVienPhongVan = ObjectId.Parse("000000000000000000000000");
                DTO.ThiSinhTrungTuyen thiSinhTrungTuyen = new DTO.ThiSinhTrungTuyen();
                thiSinhTrungTuyen.MaThiSinh = txt_id.Text;
                thiSinhTrungTuyen.PhongVan = phongVan;
                DTO.Custom vttd = new DTO.Custom();
                vttd.ThiSinhTrungTuyen = thiSinhTrungTuyen;
                if (db.ThiSinhTrungTuyen.updateOne(vttd))
                {
                    MessageBox.Show("Xóa thành công");
                    table_employee.Rows.Clear();
                    load_data();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }
    }
}
