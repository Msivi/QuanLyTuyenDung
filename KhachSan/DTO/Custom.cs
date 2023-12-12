using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhachSan.DTO
{
    class Custom
    {
        public ObjectId _id { get; set; }

        public String TenViTri { get; set; }
       
        public ThiSinhTrungTuyen ThiSinhTrungTuyen { get; set; }

        public override String ToString()
        {
            return "test{" +
                    ", TenViTri='" + TenViTri + '\'' +
                    ", ThiSinhTrungTuyen=" + ThiSinhTrungTuyen +
                    '}';
        }
    }
}
