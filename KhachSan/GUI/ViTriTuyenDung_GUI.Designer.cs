
namespace KhachSan.GUI
{
    partial class ViTriTuyenDung_GUI
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
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.Table_ViTriTuyenDung = new System.Windows.Forms.DataGridView();
            this.cbb_TrangThaiFilter = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Search = new System.Windows.Forms.TextBox();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.btn_ThemTuyen = new System.Windows.Forms.Button();
            this.btn_XoaTuyen = new System.Windows.Forms.Button();
            this.btn_CapNhatTuyen = new System.Windows.Forms.Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbb_TrangThai = new System.Windows.Forms.ComboBox();
            this.btn_ThemNVPV = new System.Windows.Forms.Button();
            this.btn_LoaiBoNVPV = new System.Windows.Forms.Button();
            this.cbb_NVPV = new System.Windows.Forms.ComboBox();
            this.picker_NgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.Table_NVPV = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_LuongDeXuat = new System.Windows.Forms.TextBox();
            this.txt_TenViTri = new System.Windows.Forms.TextBox();
            this.txt_SoLuongCanTuyen = new System.Windows.Forms.TextBox();
            this.txt_KinhNghiemYC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table_ViTriTuyenDung)).BeginInit();
            this.guna2GroupBox2.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table_NVPV)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.Controls.Add(this.Table_ViTriTuyenDung);
            this.guna2GroupBox3.Controls.Add(this.cbb_TrangThaiFilter);
            this.guna2GroupBox3.Controls.Add(this.label9);
            this.guna2GroupBox3.Controls.Add(this.label8);
            this.guna2GroupBox3.Controls.Add(this.txt_Search);
            this.guna2GroupBox3.CustomBorderColor = System.Drawing.Color.LightBlue;
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox3.Location = new System.Drawing.Point(8, 419);
            this.guna2GroupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(1318, 529);
            this.guna2GroupBox3.TabIndex = 5;
            this.guna2GroupBox3.Text = "Bảng vị trí tuyển dụng";
            // 
            // Table_ViTriTuyenDung
            // 
            this.Table_ViTriTuyenDung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Table_ViTriTuyenDung.ColumnHeadersHeight = 29;
            this.Table_ViTriTuyenDung.Location = new System.Drawing.Point(0, 54);
            this.Table_ViTriTuyenDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Table_ViTriTuyenDung.Name = "Table_ViTriTuyenDung";
            this.Table_ViTriTuyenDung.RowHeadersWidth = 51;
            this.Table_ViTriTuyenDung.RowTemplate.Height = 24;
            this.Table_ViTriTuyenDung.Size = new System.Drawing.Size(1318, 475);
            this.Table_ViTriTuyenDung.TabIndex = 50;
            this.Table_ViTriTuyenDung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Table_ViTriTuyenDung_CellClick);
            // 
            // cbb_TrangThaiFilter
            // 
            this.cbb_TrangThaiFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_TrangThaiFilter.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_TrangThaiFilter.FormattingEnabled = true;
            this.cbb_TrangThaiFilter.Location = new System.Drawing.Point(459, 8);
            this.cbb_TrangThaiFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbb_TrangThaiFilter.Name = "cbb_TrangThaiFilter";
            this.cbb_TrangThaiFilter.Size = new System.Drawing.Size(186, 36);
            this.cbb_TrangThaiFilter.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(313, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 25);
            this.label9.TabIndex = 41;
            this.label9.Text = "Trạng thái:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(698, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 30);
            this.label8.TabIndex = 40;
            this.label8.Text = "Tìm kiếm:";
            // 
            // txt_Search
            // 
            this.txt_Search.Location = new System.Drawing.Point(822, 9);
            this.txt_Search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Search.Name = "txt_Search";
            this.txt_Search.Size = new System.Drawing.Size(473, 35);
            this.txt_Search.TabIndex = 2;
            this.txt_Search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Search_KeyUp);
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.btn_LamMoi);
            this.guna2GroupBox2.Controls.Add(this.btn_ThemTuyen);
            this.guna2GroupBox2.Controls.Add(this.btn_XoaTuyen);
            this.guna2GroupBox2.Controls.Add(this.btn_CapNhatTuyen);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.Color.LightBlue;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(1143, 15);
            this.guna2GroupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(180, 396);
            this.guna2GroupBox2.TabIndex = 4;
            this.guna2GroupBox2.Text = "Tác vụ";
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_LamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LamMoi.Location = new System.Drawing.Point(20, 270);
            this.btn_LamMoi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(141, 50);
            this.btn_LamMoi.TabIndex = 30;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.UseVisualStyleBackColor = false;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // btn_ThemTuyen
            // 
            this.btn_ThemTuyen.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_ThemTuyen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThemTuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemTuyen.Location = new System.Drawing.Point(20, 85);
            this.btn_ThemTuyen.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_ThemTuyen.Name = "btn_ThemTuyen";
            this.btn_ThemTuyen.Size = new System.Drawing.Size(141, 50);
            this.btn_ThemTuyen.TabIndex = 25;
            this.btn_ThemTuyen.Text = "Thêm";
            this.btn_ThemTuyen.UseVisualStyleBackColor = false;
            this.btn_ThemTuyen.Click += new System.EventHandler(this.btn_ThemTuyen_Click);
            // 
            // btn_XoaTuyen
            // 
            this.btn_XoaTuyen.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_XoaTuyen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_XoaTuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaTuyen.Location = new System.Drawing.Point(20, 148);
            this.btn_XoaTuyen.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_XoaTuyen.Name = "btn_XoaTuyen";
            this.btn_XoaTuyen.Size = new System.Drawing.Size(141, 50);
            this.btn_XoaTuyen.TabIndex = 27;
            this.btn_XoaTuyen.Text = "Xoá";
            this.btn_XoaTuyen.UseVisualStyleBackColor = false;
            this.btn_XoaTuyen.Click += new System.EventHandler(this.btn_XoaTuyen_Click);
            // 
            // btn_CapNhatTuyen
            // 
            this.btn_CapNhatTuyen.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_CapNhatTuyen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CapNhatTuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhatTuyen.Location = new System.Drawing.Point(20, 208);
            this.btn_CapNhatTuyen.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_CapNhatTuyen.Name = "btn_CapNhatTuyen";
            this.btn_CapNhatTuyen.Size = new System.Drawing.Size(141, 50);
            this.btn_CapNhatTuyen.TabIndex = 28;
            this.btn_CapNhatTuyen.Text = "Cập nhật";
            this.btn_CapNhatTuyen.UseVisualStyleBackColor = false;
            this.btn_CapNhatTuyen.Click += new System.EventHandler(this.btn_CapNhatTuyen_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.cbb_TrangThai);
            this.guna2GroupBox1.Controls.Add(this.btn_ThemNVPV);
            this.guna2GroupBox1.Controls.Add(this.btn_LoaiBoNVPV);
            this.guna2GroupBox1.Controls.Add(this.cbb_NVPV);
            this.guna2GroupBox1.Controls.Add(this.picker_NgayKetThuc);
            this.guna2GroupBox1.Controls.Add(this.Table_NVPV);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.txt_LuongDeXuat);
            this.guna2GroupBox1.Controls.Add(this.txt_TenViTri);
            this.guna2GroupBox1.Controls.Add(this.txt_SoLuongCanTuyen);
            this.guna2GroupBox1.Controls.Add(this.txt_KinhNghiemYC);
            this.guna2GroupBox1.Controls.Add(this.label7);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.LightBlue;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(8, 15);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(1128, 396);
            this.guna2GroupBox1.TabIndex = 3;
            this.guna2GroupBox1.Text = "Thông tin vị trí tuyển dụng";
            // 
            // cbb_TrangThai
            // 
            this.cbb_TrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_TrangThai.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_TrangThai.FormattingEnabled = true;
            this.cbb_TrangThai.Location = new System.Drawing.Point(232, 231);
            this.cbb_TrangThai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbb_TrangThai.Name = "cbb_TrangThai";
            this.cbb_TrangThai.Size = new System.Drawing.Size(329, 36);
            this.cbb_TrangThai.TabIndex = 48;
            // 
            // btn_ThemNVPV
            // 
            this.btn_ThemNVPV.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_ThemNVPV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ThemNVPV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemNVPV.Location = new System.Drawing.Point(822, 61);
            this.btn_ThemNVPV.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_ThemNVPV.Name = "btn_ThemNVPV";
            this.btn_ThemNVPV.Size = new System.Drawing.Size(141, 42);
            this.btn_ThemNVPV.TabIndex = 47;
            this.btn_ThemNVPV.Text = "Chọn";
            this.btn_ThemNVPV.UseVisualStyleBackColor = false;
            this.btn_ThemNVPV.Click += new System.EventHandler(this.btn_ThemNVPV_Click);
            // 
            // btn_LoaiBoNVPV
            // 
            this.btn_LoaiBoNVPV.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_LoaiBoNVPV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LoaiBoNVPV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoaiBoNVPV.Location = new System.Drawing.Point(974, 61);
            this.btn_LoaiBoNVPV.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_LoaiBoNVPV.Name = "btn_LoaiBoNVPV";
            this.btn_LoaiBoNVPV.Size = new System.Drawing.Size(141, 42);
            this.btn_LoaiBoNVPV.TabIndex = 46;
            this.btn_LoaiBoNVPV.Text = "Loại bỏ";
            this.btn_LoaiBoNVPV.UseVisualStyleBackColor = false;
            this.btn_LoaiBoNVPV.Click += new System.EventHandler(this.btn_LoaiBoNVPV_Click);
            // 
            // cbb_NVPV
            // 
            this.cbb_NVPV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_NVPV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_NVPV.FormattingEnabled = true;
            this.cbb_NVPV.Location = new System.Drawing.Point(593, 111);
            this.cbb_NVPV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbb_NVPV.Name = "cbb_NVPV";
            this.cbb_NVPV.Size = new System.Drawing.Size(522, 36);
            this.cbb_NVPV.TabIndex = 45;
            // 
            // picker_NgayKetThuc
            // 
            this.picker_NgayKetThuc.CustomFormat = "dd/MM/yyyy";
            this.picker_NgayKetThuc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picker_NgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.picker_NgayKetThuc.Location = new System.Drawing.Point(232, 172);
            this.picker_NgayKetThuc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picker_NgayKetThuc.Name = "picker_NgayKetThuc";
            this.picker_NgayKetThuc.Size = new System.Drawing.Size(329, 39);
            this.picker_NgayKetThuc.TabIndex = 44;
            this.picker_NgayKetThuc.Value = new System.DateTime(2023, 10, 10, 0, 0, 0, 0);
            // 
            // Table_NVPV
            // 
            this.Table_NVPV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Table_NVPV.ColumnHeadersHeight = 29;
            this.Table_NVPV.Location = new System.Drawing.Point(593, 164);
            this.Table_NVPV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Table_NVPV.Name = "Table_NVPV";
            this.Table_NVPV.RowHeadersWidth = 51;
            this.Table_NVPV.RowTemplate.Height = 24;
            this.Table_NVPV.Size = new System.Drawing.Size(522, 209);
            this.Table_NVPV.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(588, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 30);
            this.label4.TabIndex = 39;
            this.label4.Text = "Tham gia phỏng vấn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(11, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 25);
            this.label6.TabIndex = 33;
            this.label6.Text = "Ngày kết thúc:";
            // 
            // txt_LuongDeXuat
            // 
            this.txt_LuongDeXuat.BackColor = System.Drawing.SystemColors.Window;
            this.txt_LuongDeXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LuongDeXuat.Location = new System.Drawing.Point(232, 284);
            this.txt_LuongDeXuat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_LuongDeXuat.Name = "txt_LuongDeXuat";
            this.txt_LuongDeXuat.Size = new System.Drawing.Size(329, 35);
            this.txt_LuongDeXuat.TabIndex = 23;
            // 
            // txt_TenViTri
            // 
            this.txt_TenViTri.BackColor = System.Drawing.SystemColors.Window;
            this.txt_TenViTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenViTri.Location = new System.Drawing.Point(232, 66);
            this.txt_TenViTri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TenViTri.Name = "txt_TenViTri";
            this.txt_TenViTri.Size = new System.Drawing.Size(329, 35);
            this.txt_TenViTri.TabIndex = 18;
            // 
            // txt_SoLuongCanTuyen
            // 
            this.txt_SoLuongCanTuyen.BackColor = System.Drawing.SystemColors.Window;
            this.txt_SoLuongCanTuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SoLuongCanTuyen.Location = new System.Drawing.Point(232, 119);
            this.txt_SoLuongCanTuyen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SoLuongCanTuyen.Name = "txt_SoLuongCanTuyen";
            this.txt_SoLuongCanTuyen.Size = new System.Drawing.Size(329, 35);
            this.txt_SoLuongCanTuyen.TabIndex = 19;
            // 
            // txt_KinhNghiemYC
            // 
            this.txt_KinhNghiemYC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_KinhNghiemYC.Location = new System.Drawing.Point(232, 335);
            this.txt_KinhNghiemYC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_KinhNghiemYC.Name = "txt_KinhNghiemYC";
            this.txt_KinhNghiemYC.Size = new System.Drawing.Size(329, 35);
            this.txt_KinhNghiemYC.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(11, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 25);
            this.label7.TabIndex = 32;
            this.label7.Text = "Mức lương đề xuất:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(11, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 31;
            this.label5.Text = "Trạng thái:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(11, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tên vị trí:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Số lượng cần tuyển:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(11, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Kinh nghiệm y cầu:";
            // 
            // ViTriTuyenDung_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 962);
            this.Controls.Add(this.guna2GroupBox3);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ViTriTuyenDung_GUI";
            this.Text = "ROOM_GUI";
            this.guna2GroupBox3.ResumeLayout(false);
            this.guna2GroupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table_ViTriTuyenDung)).EndInit();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Table_NVPV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.TextBox txt_KinhNghiemYC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_TenViTri;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_SoLuongCanTuyen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_LamMoi;
        private System.Windows.Forms.Button btn_CapNhatTuyen;
        private System.Windows.Forms.Button btn_XoaTuyen;
        private System.Windows.Forms.Button btn_ThemTuyen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker picker_NgayKetThuc;
        private System.Windows.Forms.DataGridView Table_NVPV;
        private System.Windows.Forms.Button btn_ThemNVPV;
        private System.Windows.Forms.Button btn_LoaiBoNVPV;
        private System.Windows.Forms.ComboBox cbb_NVPV;
        private System.Windows.Forms.ComboBox cbb_TrangThai;
        private System.Windows.Forms.TextBox txt_LuongDeXuat;
        private System.Windows.Forms.ComboBox cbb_TrangThaiFilter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Search;
        private System.Windows.Forms.DataGridView Table_ViTriTuyenDung;
    }
}