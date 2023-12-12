using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace KhachSan.DTO
{
    class ThiSinhTrungTuyen
    {
        public String MaThiSinh { get; set; } //  id Thí sinh ứng tuyển
        public DateTime NgayTrungTuyen { get; set; }
        public PhongVan PhongVan { get; set; }
        public ThiSinhUngTuyen ThiSinhUngTuyen { get; set; }
        public ViTriTuyenDung ViTriTuyenDung { get; set; }
    }
}
