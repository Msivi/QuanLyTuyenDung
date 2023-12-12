
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
            define_Column_Table();
            List<DTO.ViTriTuyenDung> vttds = (List<DTO.ViTriTuyenDung>)db.ViTriTuyenDung.find();
            if(vttds.Count > 0)
            {
                vttds.ForEach(item => cbb_ViTriTuyenDung.Items.Add(item.TenViTri + " - " + item._id));
                cbb_ViTriTuyenDung.SelectedIndex = 0;
            }
            txt_nhanxet.Enabled = false;
            txt_luong.Enabled = false;
            date_ngayvaolam.Enabled = false;
            btn_dau.Enabled = false;

            load_data_dyc();
        }

        private void define_Column_Table()
        {
            table_employee.ColumnCount = 6;
            table_employee.Columns[0].HeaderText = "Tên vị trí";
            table_employee.Columns[1].HeaderText = "Mã thí sinh";
            table_employee.Columns[2].HeaderText = "Tên thí sinh";
            table_employee.Columns[3].HeaderText = "Ngày trúng tuyển";
            table_employee.Columns[4].HeaderText = "Người phỏng vấn";
            table_employee.Columns[5].HeaderText = "Ngày phỏng vấn";
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
            define_Column_Table();
            table_employee.Rows.Clear();
            if (cbb_ViTriTuyenDung.Items.Count < 1) return;
            ObjectId _id_tuyendung = ObjectId.Parse(cbb_ViTriTuyenDung.Text.Split('-')[1].Trim());
            List<DTO.Custom> viTriTuyenDungs = (List<Custom>)db.ThiSinhTrungTuyen.find(_id_tuyendung);
            foreach(DTO.Custom viTriTuyenDung in viTriTuyenDungs)               
            {
                if (viTriTuyenDung.ThiSinhTrungTuyen.PhongVan == null)
                {
                    table_employee.Rows.Add(viTriTuyenDung.TenViTri,
                    viTriTuyenDung.ThiSinhTrungTuyen.MaThiSinh,
                    viTriTuyenDung.ThiSinhTrungTuyen.ThiSinhUngTuyen.HoTen,
                    viTriTuyenDung.ThiSinhTrungTuyen.NgayTrungTuyen);

                }
                else
                {
                    table_employee.Rows.Add(viTriTuyenDung.TenViTri,
                        viTriTuyenDung.ThiSinhTrungTuyen.MaThiSinh,
                        viTriTuyenDung.ThiSinhTrungTuyen.ThiSinhUngTuyen.HoTen,
                        viTriTuyenDung.ThiSinhTrungTuyen.NgayTrungTuyen,
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
            

            load_data();
            //loadCbNV();

            load_cbb_nvpv();
        }



        private void define_Column_Table_dyc()
        {
            table_DatYeuCau.ColumnCount = 7;
            table_DatYeuCau.Columns[0].HeaderText = "Mã thí sinh";
            table_DatYeuCau.Columns[1].HeaderText = "Tên thí sinh";
            table_DatYeuCau.Columns[2].HeaderText = "Ngày sinh";
            table_DatYeuCau.Columns[3].HeaderText = "phái";
            table_DatYeuCau.Columns[4].HeaderText = "Ngày vào làm";
            table_DatYeuCau.Columns[5].HeaderText = "Mức lương chấp thuận";
            table_DatYeuCau.Columns[6].HeaderText = "Kết quả phỏng vấn";
        }

        private void load_data_dyc() {
            define_Column_Table_dyc();
            table_DatYeuCau.Rows.Clear();
            if (cbb_ViTriTuyenDung.Items.Count < 1) return;

            Dictionary<String, Object> json_dic = 
                (Dictionary<String, Object>)db.ThiSinhDatYeuCau.find_inject_to_tab(
                    ObjectId.Parse(cbb_ViTriTuyenDung.Text.Split('-')[1].Trim()));

            if (json_dic == null) return;

            List<DTO.ThiSinhDatYeuCau> thongtin_dyc = (List<DTO.ThiSinhDatYeuCau>)json_dic["ThongTinDatYeuCau"];
            List<DTO.ThiSinhUngTuyen> thongtin_ut = (List<DTO.ThiSinhUngTuyen>)json_dic["ThongTinUngTuyen"];
            List<DTO.ThiSinhTrungTuyen> thongtin_tt = (List<DTO.ThiSinhTrungTuyen>)json_dic["ThongTinTrungTuyen"];

            int len = thongtin_dyc.Count;
            for(int i = 0; i < len; i++)
            {
                DTO.ThiSinhDatYeuCau dyc = thongtin_dyc[i];
                DTO.ThiSinhUngTuyen ut = thongtin_ut[i];
                DTO.ThiSinhTrungTuyen tt = thongtin_tt[i];

                table_DatYeuCau.Rows.Add(new String[]
                {
                    dyc.MaThiSinh,
                    ut.HoTen,
                    ut.NgaySinh.ToString("dd/MM/yyyy"),
                    ut.Phai,
                    dyc.NgayVaoLam.ToString("dd/MM/yyyy"),
                    dyc.MucLuongChapThuan,
                    tt.PhongVan == null ? "null" : tt.PhongVan.NhanXet
                });
            }
        }

        private void table_employee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (table_employee.CurrentCell.RowIndex == table_employee.Rows.Count - 1) return;
            //txt_id.Text = table_employee.CurrentRow.Cells[1].Value.ToString();
            //txt_name.Text = loadTenBangMa(txt_id.Text);
            //cbb_nv.Text = table_employee.CurrentRow.Cells[2].Value.ToString();
            ////cbb_nv.Text = table_employee.CurrentRow.Cells[2].Value.ToString();
            //if(table_employee.CurrentRow.Cells[3].Value.ToString() == "01/01/0001 12:00:00 SA")
            //{
            //    date.Value = DateTime.Now;
            //}
            //else {
            //    date.Text = table_employee.CurrentRow.Cells[3].Value.ToString();

            //}

            txt_luong.Text = "";
            txt_nhanxet.Text = "";
            date_ngayvaolam.Value = DateTime.Now;
            ObjectId _id_tuyendung = ObjectId.Parse(cbb_ViTriTuyenDung.Text.Split('-')[1].Trim());
            String MaThiSinh = table_employee.Rows[table_employee.CurrentCell.RowIndex].Cells[1].Value.ToString();
            DTO.ThiSinhTrungTuyen tstt = (DTO.ThiSinhTrungTuyen)db.ThiSinhTrungTuyen.findOne(MaThiSinh, _id_tuyendung);
            tstt.ThiSinhUngTuyen = (DTO.ThiSinhUngTuyen)db.ThiSinhUngTuyen.findOne(MaThiSinh, _id_tuyendung);
            txt_id.Text = tstt.MaThiSinh;
            txt_name.Text = tstt.ThiSinhUngTuyen.HoTen;
            if(tstt.PhongVan != null)
            {
                btn_dau.Enabled = true;
                btn_add.Enabled = false;
                date.Enabled = false;
                date.Value = tstt.PhongVan.NgayPhongVan;
                int len = cbb_nv.Items.Count;
                for(int i = 0; i < len; i++)
                {
                    if (cbb_nv.Items[i].ToString().Contains(tstt.PhongVan.NhanVienPhongVan.ToString()))
                    {
                        cbb_nv.SelectedIndex = i;
                        break;
                    }
                }

                cbb_nv.Enabled = false;
                if (tstt.PhongVan.NhanXet.Equals(""))
                {
                    txt_nhanxet.Enabled = true;
                }
                else
                {
                    txt_nhanxet.Enabled = false;
                    txt_nhanxet.Text = tstt.PhongVan.NhanXet;
                }

                DTO.ThiSinhDatYeuCau tsdyc = (DTO.ThiSinhDatYeuCau)db.ThiSinhDatYeuCau.findOne(MaThiSinh, _id_tuyendung);

                if (tsdyc != null && !tsdyc.MucLuongChapThuan.Equals(""))
                {
                    btn_dau.Enabled = false;
                    txt_luong.Enabled = false;
                    date_ngayvaolam.Enabled = false;
                    txt_luong.Text = tsdyc.MucLuongChapThuan;
                    date_ngayvaolam.Value = tsdyc.NgayVaoLam;
                }
                else
                {
                    txt_luong.Enabled = true;
                    date_ngayvaolam.Enabled = true;
                }
            }
            else
            {
                btn_add.Enabled = true;
                cbb_nv.Enabled = true;
                date.Enabled = true;
                btn_dau.Enabled = false;
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
                if (cbb_nv.Enabled.Equals(false)) return;

                DTO.PhongVan phongVan = new DTO.PhongVan();
                phongVan.NgayPhongVan = date.Value;
                phongVan.NhanVienPhongVan = ObjectId.Parse(cbb_nv.Text.Split('-')[1].Trim());
                phongVan.NhanXet = "";
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
                ObjectId _id_vt = ObjectId.Parse(cbb_ViTriTuyenDung.Text.Split('-')[1].Trim());
                String MaThiSinh = txt_id.Text;
                if (db.ThiSinhTrungTuyen.unset_PhongVan(MaThiSinh, _id_vt))
                {
                    MessageBox.Show("Xóa thành công");
                    table_employee.Rows.Clear();
                    load_data();
                    load_data_dyc();
                    txt_luong.Text = "";
                    txt_nhanxet.Text = "";
                    date_ngayvaolam.Value = DateTime.Now;
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
            }
        }
        
        private void load_cbb_nvpv()
        {
            if (cbb_ViTriTuyenDung.Items.Count < 1) return;

            ObjectId _id_tuyendung = ObjectId.Parse(cbb_ViTriTuyenDung.Text.Split('-')[1].Trim());

            List<DTO.NhanVienPhongVan> nvpvs = (List<DTO.NhanVienPhongVan>)db.NhanVienPhongVan.find(_id_tuyendung);

            cbb_nv.Items.Clear();
            nvpvs.ForEach(item => cbb_nv.Items.Add(item.HoTen + " - " + item._id));
            cbb_nv.SelectedIndex = 0;
        }

        private void cbb_ViTriTuyenDung_SelectedIndexChanged(object sender, EventArgs e)
        {
            load_data();
            load_cbb_nvpv();
            load_data_dyc();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_luong.Text.Equals("") || txt_nhanxet.Text.Equals(""))
            {
                MessageBox.Show("Nhận xét, Lương ????", "Thông báo");
                return;
            }
            
            MessageBox.Show(
                db.ThiSinhDatYeuCau.pass_interview(
                    new DTO.ThiSinhDatYeuCau()
                    {
                        MaThiSinh = txt_id.Text.ToString(),
                        MucLuongChapThuan = txt_luong.Text.ToString(),
                        NgayVaoLam = date_ngayvaolam.Value
                    },
                    txt_nhanxet.Text.ToString(),
                    ObjectId.Parse(cbb_ViTriTuyenDung.Text.Split('-')[1].Trim())), 
                "Thông báo");
            txt_luong.Text = "";
            txt_nhanxet.Text = "";
            date_ngayvaolam.Value = DateTime.Now;
            load_data_dyc();
        }
    }
}
