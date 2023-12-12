using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;
using KhachSan.DTO;
namespace KhachSan.DAO
{
    class db
    {
        protected String ConnectionString = "mongodb://localhost:27017";
        protected String Database = "TuyenDung";

        public static NhanVienPhongVan NhanVienPhongVan = new NhanVienPhongVan();
        public static TaiKhoanUngDung TaiKhoanUngDung = new TaiKhoanUngDung();
        public static ViTriTuyenDung ViTriTuyenDung = new ViTriTuyenDung();
        public static ThiSinhUngTuyen ThiSinhUngTuyen = new ThiSinhUngTuyen();
        public static ThiSinhTrungTuyen ThiSinhTrungTuyen = new ThiSinhTrungTuyen();
        public static ThiSinhDatYeuCau ThiSinhDatYeuCau = new ThiSinhDatYeuCau();
    }
}
