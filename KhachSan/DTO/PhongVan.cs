using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhachSan.DTO
{
    class PhongVan
    {
        public ObjectId NhanVienPhongVan { get; set; } //id Nhân viên phỏng vấn
        public DateTime NgayPhongVan { get; set; }
        public String NhanXet { get; set; }
        //public ViTriTuyenDung ViTriTuyenDung { get; set; }
        //public NhanVienPhongVan NhanVienPhongVan_Ob { get; set; }
        //public ThiSinhTrungTuyen ThiSinhTrungTuyen { get; set; }

    }
}
