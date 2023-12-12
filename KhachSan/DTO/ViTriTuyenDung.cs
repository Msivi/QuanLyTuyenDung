using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace KhachSan.DTO
{
    class ViTriTuyenDung
    {
        [BsonId]
        public ObjectId _id { get; set; }
        public String TenViTri { get; set; }
        public int SoLuongCanTuyen { get; set; }
        public DateTime NgayDeXuat { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public String TrangThai { get; set; }
        public String MucLuongDeXuat { get; set; }
        public String KinhNghiemYeuCau { get; set; }
        public List<NhanVienPhongVan> ThamGiaPhongVan { get; set; }
        public List<ThiSinhUngTuyen> ThiSinhUngTuyen { get; set; }
        public List<ThiSinhTrungTuyen> ThiSinhTrungTuyen { get; set; }
        public List<ThiSinhDatYeuCau> ThiSinhDatYeuCau { get; set; }

        public override String ToString()
        {
            return "test{" +
                    "_id=" + _id +
                    ", TenViTri='" + TenViTri + '\'' +
                    ", SoLuongCanTuyen=" + SoLuongCanTuyen +
                    ", NgayDeXuat=" + NgayDeXuat +
                    ", NgayKetThuc=" + NgayKetThuc +
                    ", TrangThai='" + TrangThai + '\'' +
                    ", MucLuongDeXuat='" + MucLuongDeXuat + '\'' +
                    ", KinhNghiemYeuCau='" + KinhNghiemYeuCau + '\'' +
                    ", ThamGiaPhongVan=" + ThamGiaPhongVan +
                    ", ThiSinhUngTuyen=" + ThiSinhUngTuyen +
                    ", ThiSinhTrungTuyen=" + ThiSinhTrungTuyen +
                    ", ThiSinhDatYeuCau=" + ThiSinhDatYeuCau +
                    '}';
        }
    }
}
