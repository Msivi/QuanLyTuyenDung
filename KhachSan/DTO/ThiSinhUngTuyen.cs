using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace KhachSan.DTO
{
    class ThiSinhUngTuyen
    {
        public String MaThiSinh { get; set; }
        public String HoTen { get; set; }
        public String Phai { get; set; }
        public DateTime NgaySinh { get; set; }
        public String Email { get; set; }
        public DateTime NgayUngTuyen { get; set; }
        //public ObjectId ViTriUngTuyen { get; set; }
        public String TrangThai { get; set; }
        public List<KinhNghiem> KinhNghiem { get; set; }
        public List<String> KyNang { get; set; }
        public String LinkCV { get; set; }
        //public List<PhongVan> PhongVans { get; set; }

        public override String ToString()
        {
            return "test{" +
                    "MaThiSinh='" + MaThiSinh + '\'' +
                    ", HoTen='" + HoTen + '\'' +
                    ", Phai='" + Phai + '\'' +
                    ", NgaySinh=" + NgaySinh +
                    ", Email='" + Email + '\'' +
                    ", NgayUngTuyen=" + NgayUngTuyen +
                    ", TrangThai='" + TrangThai + '\'' +
                    ", KinhNghiems=" + KinhNghiem +
                    ", KyNang=" + KyNang +
                    ", Source_CV='" + LinkCV + '\'' +
                    '}';
        }

        
    }
}
