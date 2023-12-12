using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace KhachSan.DTO
{
    class TaiKhoanUngDung
    {
        public ObjectId _id { get; set; }
        public String TenTaiKhoan { get; set; }
        public String MatKhau { get; set; }
        public String QuyenHan { get; set; }
    }
}
