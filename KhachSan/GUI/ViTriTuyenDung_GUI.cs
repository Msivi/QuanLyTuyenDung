
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
using KhachSan;
using KhachSan.DAO;
using MongoDB.Bson;
using System.Globalization;

namespace KhachSan.GUI
{
    public partial class ViTriTuyenDung_GUI : Form
    {
        private List<DTO.NhanVienPhongVan> nhanVienPhongVans;
        private ObjectId _id;
        public ViTriTuyenDung_GUI()
        {
            InitializeComponent();
            this.nhanVienPhongVans = (List<DTO.NhanVienPhongVan>)db.NhanVienPhongVan.find();
            cbb_TrangThai.Items.AddRange(new String[] { "Open", "Close" });
            cbb_TrangThai.SelectedIndex = 0;
            cbb_TrangThaiFilter.Items.AddRange(new String[] { "Open", "Close" });
            cbb_TrangThaiFilter.SelectedIndex = 0;
            if (this.nhanVienPhongVans.Count > 0)
            {
                foreach (DTO.NhanVienPhongVan nv in this.nhanVienPhongVans)
                {
                    cbb_NVPV.Items.Add(nv.HoTen + " - " + nv.ViTriLamViec + " - " + nv._id);
                }
                cbb_NVPV.SelectedIndex = 0;
            }
            define_Column_Table_NVPV();
            define_Column_Table_TuyenDung();
            load_data_TuyenDung();
        }

        private void define_Column_Table_NVPV()
        {
            Table_NVPV.ColumnCount = 3;
            Table_NVPV.Columns[0].HeaderText = "Tên nhân viên";
            Table_NVPV.Columns[1].HeaderText = "Vị trí làm việc";
            Table_NVPV.Columns[2].HeaderText = "Mã nhân viên";
        }

        private void define_Column_Table_TuyenDung()
        {
            Table_ViTriTuyenDung.ColumnCount = 12;
            Table_ViTriTuyenDung.Columns[0].HeaderText = "Mã tuyển dụng";
            Table_ViTriTuyenDung.Columns[1].HeaderText = "Tên vị trí";
            Table_ViTriTuyenDung.Columns[2].HeaderText = "SL cần tuyển";
            Table_ViTriTuyenDung.Columns[3].HeaderText = "Ngày đề xuất";
            Table_ViTriTuyenDung.Columns[4].HeaderText = "Ngày kết thúc";
            Table_ViTriTuyenDung.Columns[5].HeaderText = "Trang thái";
            Table_ViTriTuyenDung.Columns[6].HeaderText = "Mức lương đề xuất";
            Table_ViTriTuyenDung.Columns[7].HeaderText = "Kinh nghiệm yêu cầu";
            Table_ViTriTuyenDung.Columns[8].HeaderText = "Số NV tham gia";
            Table_ViTriTuyenDung.Columns[9].HeaderText = "Số TS ứng tuyển";
            Table_ViTriTuyenDung.Columns[10].HeaderText = "Số TS trúng tuyển";
            Table_ViTriTuyenDung.Columns[11].HeaderText = "Số TS đạt yêu cầu";
        }


        private void resetAll()
        {
            this._id = new ObjectId();
            cbb_TrangThai.SelectedIndex = 0;
            cbb_TrangThaiFilter.SelectedIndex = 0;
            cbb_NVPV.SelectedIndex = 0;
            picker_NgayKetThuc.Value = DateTime.Now;
            TextBoxs().ForEach(item => item.Text = "");
            Table_ViTriTuyenDung.Rows.Clear();
            load_data_TuyenDung();
            Table_NVPV.Rows.Clear();
        }
        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            resetAll();
        }

        private void btn_ThemNVPV_Click(object sender, EventArgs e)
        {
            String[] NV = cbb_NVPV.Text.Split('-');
            String _id_NV = NV[NV.Length - 1].Trim();
            int tab_row_count = Table_NVPV.Rows.Count;
            int i = 0;
            for (; i < tab_row_count - 1; i++)
            {
                if (Table_NVPV.Rows[i].Cells[NV.Length - 1].Value.Equals(_id_NV))
                {
                    MessageBox.Show("Nhân viên phỏng vấn đã được thêm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            for(i = 0; i < 3; i++) NV[i] = NV[i].Trim();
            Table_NVPV.Rows.Add(NV);
        }

        private void btn_LoaiBoNVPV_Click(object sender, EventArgs e)
        {
            if (Table_NVPV.Rows.Count == 1) return;
            if (Table_NVPV.CurrentCell.RowIndex == Table_NVPV.Rows.Count - 1) return;
            Table_NVPV.Rows.Remove(Table_NVPV.Rows[Table_NVPV.CurrentCell.RowIndex]);
        }

        private List<TextBox> TextBoxs()
        {
            return new List<TextBox>()
            {
                txt_KinhNghiemYC,
                txt_LuongDeXuat,
                txt_SoLuongCanTuyen,
                txt_TenViTri
            };
        }

        private Boolean Is_Empty_txt()
        {
            List<TextBox> txts = TextBoxs();
            foreach (TextBox t in txts) if (t.Text.Equals("")) return true;
            return false;
        }
        private void btn_ThemTuyen_Click(object sender, EventArgs e)
        {
            if (Is_Empty_txt())
            {
                MessageBox.Show("Không được bỏ trống trường nào !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int TGPV_count = Table_NVPV.Rows.Count;
            List<ObjectId> TGPV = new List<ObjectId>();
            for(int i = 0; i < TGPV_count - 1; i++)
            {
                TGPV.Add(ObjectId.Parse(
                    Table_NVPV.Rows[i].Cells[Table_NVPV.ColumnCount - 1].Value.ToString().Trim()
                ));
            }

            Boolean result = db.ViTriTuyenDung.insertOne(new DTO.ViTriTuyenDung()
            {
                TenViTri = txt_TenViTri.Text,
                SoLuongCanTuyen = int.Parse(txt_SoLuongCanTuyen.Text),
                TrangThai = cbb_TrangThai.Text,
                MucLuongDeXuat = txt_LuongDeXuat.Text,
                KinhNghiemYeuCau = txt_KinhNghiemYC.Text,
                NgayKetThuc = picker_NgayKetThuc.Value
            }, TGPV);

            if (!result)
            {
                MessageBox.Show("Thêm mới thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Thêm mới thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            resetAll();
        }

        private void btn_XoaTuyen_Click(object sender, EventArgs e)
        {
            if (!Table_ViTriTuyenDung.CurrentCell.Selected 
                || Table_ViTriTuyenDung.CurrentCell.RowIndex 
                == Table_ViTriTuyenDung.Rows.Count - 1) return;

            DataGridViewRow row = Table_ViTriTuyenDung.Rows[Table_ViTriTuyenDung.CurrentCell.RowIndex];
            String TenViTri = row.Cells[1].Value.ToString();
            String _id = row.Cells[0].Value.ToString();

            DialogResult ch = MessageBox.Show("Chắc chắn muốn xóa đăng tuyển " + TenViTri + "\nID: " + _id, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (ch == DialogResult.OK)
            {
                if (!db.ViTriTuyenDung.deleteOne(ObjectId.Parse(_id))){
                    MessageBox.Show("Xóa thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                MessageBox.Show("Xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Table_ViTriTuyenDung.Rows.Clear();
                load_data_TuyenDung();
            }
        }

        private void load_data_TuyenDung()
        {
            List<DTO.ViTriTuyenDung> vttd = (List<DTO.ViTriTuyenDung>)db.ViTriTuyenDung.find();
            foreach(DTO.ViTriTuyenDung vt in vttd)
            {
                Table_ViTriTuyenDung.Rows.Add(new String[]
                {
                    vt._id.ToString(),
                    vt.TenViTri,
                    vt.SoLuongCanTuyen.ToString(),
                    vt.NgayDeXuat.ToString("dd/MM/yyyy"),
                    vt.NgayKetThuc.ToString("dd/MM/yyyy"),
                    vt.TrangThai,
                    vt.MucLuongDeXuat,
                    vt.KinhNghiemYeuCau,
                    vt.ThamGiaPhongVan != null ? vt.ThamGiaPhongVan.Count.ToString() : "0",
                    vt.ThiSinhUngTuyen != null ? vt.ThiSinhUngTuyen.Count.ToString() : "0",
                    vt.ThiSinhTrungTuyen != null ? vt.ThiSinhTrungTuyen.Count.ToString() : "0",
                    vt.ThiSinhDatYeuCau != null ? vt.ThiSinhDatYeuCau.Count.ToString() : "0"
                });
            }
        }

        private void Table_ViTriTuyenDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Table_ViTriTuyenDung.CurrentCell.RowIndex == Table_ViTriTuyenDung.Rows.Count - 1) return;
            Table_NVPV.Rows.Clear();
            int row_index = Table_ViTriTuyenDung.CurrentCell.RowIndex;
            DataGridViewRow row = Table_ViTriTuyenDung.Rows[row_index];
            this._id = ObjectId.Parse(row.Cells[0].Value.ToString());
            txt_TenViTri.Text = row.Cells[1].Value.ToString();
            txt_SoLuongCanTuyen.Text = row.Cells[2].Value.ToString();
            picker_NgayKetThuc.Value = DateTime.ParseExact(row.Cells[4].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);;
            cbb_TrangThai.SelectedItem = row.Cells[5].Value.ToString();
            txt_LuongDeXuat.Text = row.Cells[6].Value.ToString();
            txt_KinhNghiemYC.Text = row.Cells[7].Value.ToString();

            DTO.ViTriTuyenDung vttd = (DTO.ViTriTuyenDung)db.ViTriTuyenDung.findOne(this._id);
            vttd.ThamGiaPhongVan.ForEach(item =>
            {
                Table_NVPV.Rows.Add(new String[] {
                    item.HoTen, item.ViTriLamViec, item._id.ToString()
                });
            });
        }

        private void btn_CapNhatTuyen_Click(object sender, EventArgs e)
        {
            if (Is_Empty_txt())
            {
                MessageBox.Show("Không được bỏ trống trường nào !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int TGPV_count = Table_NVPV.Rows.Count;
            List<ObjectId> TGPV = new List<ObjectId>();
            for (int i = 0; i < TGPV_count - 1; i++)
            {
                TGPV.Add(ObjectId.Parse(
                    Table_NVPV.Rows[i].Cells[Table_NVPV.ColumnCount - 1].Value.ToString().Trim()
                ));
            }

            Boolean result = db.ViTriTuyenDung.updateOne(new DTO.ViTriTuyenDung()
            {
                _id = this._id,
                TenViTri = txt_TenViTri.Text,
                SoLuongCanTuyen = int.Parse(txt_SoLuongCanTuyen.Text),
                TrangThai = cbb_TrangThai.Text,
                MucLuongDeXuat = txt_LuongDeXuat.Text,
                KinhNghiemYeuCau = txt_KinhNghiemYC.Text,
                NgayKetThuc = picker_NgayKetThuc.Value
            }, TGPV);

            if (!result)
            {
                MessageBox.Show("Cập nhật thất bại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            MessageBox.Show("Cập nhật thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            resetAll();
        }

        private void txt_Search_KeyUp(object sender, KeyEventArgs e)
        {
            List<DTO.ViTriTuyenDung> vtsssss = (List<DTO.ViTriTuyenDung>)DAO.db.ViTriTuyenDung.find();
            String t = txt_Search.Text;
            vtsssss = vtsssss.Where(item => item.TenViTri.ToUpper().Contains(t.ToUpper())).ToList();
            if (t == String.Empty || vtsssss == null || vtsssss != null && vtsssss.Count == 0)
            {
                load_data_TuyenDung();

                return;

            }


            Table_ViTriTuyenDung.Rows.Clear();
           
            foreach(DTO.ViTriTuyenDung vt in vtsssss)
            {
                Table_ViTriTuyenDung.Rows.Add(new String[]
               {
                    vt._id.ToString(),
                    vt.TenViTri,
                    vt.SoLuongCanTuyen.ToString(),
                    vt.NgayDeXuat.ToString("dd/MM/yyyy"),
                    vt.NgayKetThuc.ToString("dd/MM/yyyy"),
                    vt.TrangThai,
                    vt.MucLuongDeXuat,
                    vt.KinhNghiemYeuCau,
                    vt.ThamGiaPhongVan != null ? vt.ThamGiaPhongVan.Count.ToString() : "0",
                    vt.ThiSinhUngTuyen != null ? vt.ThiSinhUngTuyen.Count.ToString() : "0",
                    vt.ThiSinhTrungTuyen != null ? vt.ThiSinhTrungTuyen.Count.ToString() : "0",
                    vt.ThiSinhDatYeuCau != null ? vt.ThiSinhDatYeuCau.Count.ToString() : "0"
               });
            }
        }
    }
}
