using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhachSan.DTO
{
    class NhanVienPhongVan
    {
        [BsonId]
        public ObjectId _id { get; set; }
        public String HoTen { get; set; }
        public String ViTriLamViec { get; set; }
        public DateTime NgaySinh { get; set; }
        public String Phai { get; set; }
        public List<String> Email { get; set; }
        public String SoDienThoai { get; set; }
        public DiaChi DiaChi { get; set; }
        public List<PhongVan> PhongVans { get; set; }
        public List<ViTriTuyenDung> ThamGiaPhongVans { get; set; }
    }
}
