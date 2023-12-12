using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using KhachSan;

namespace KhachSan.DAO
{
    class TaiKhoanUngDung : db
    {

        private const String Collections_name = "TaiKhoanUngDung";

        private IMongoCollection<DTO.TaiKhoanUngDung> Collection()
        {
            MongoClient mongo = new MongoClient(ConnectionString);
            IMongoDatabase d = mongo.GetDatabase(Database);
            IMongoCollection<DTO.TaiKhoanUngDung> c = d.GetCollection<DTO.TaiKhoanUngDung>(Collections_name);
            return c;
        }
        public Object findOne(String TenTaiKhoan)
        {
            var filter = Builders<DTO.TaiKhoanUngDung>.Filter.Eq("TenTaiKhoan", TenTaiKhoan);
            DTO.TaiKhoanUngDung result = Collection().Find(filter).FirstOrDefault();
            return result;
        }

        public Object findOne(String TenTaiKhoan, String MatKhau)
        {
            var filter = Builders<DTO.TaiKhoanUngDung>.Filter.And(
                Builders<DTO.TaiKhoanUngDung>.Filter.Eq("TenTaiKhoan", TenTaiKhoan),
                Builders<DTO.TaiKhoanUngDung>.Filter.Eq("MatKhau", MatKhau)
            );
            DTO.TaiKhoanUngDung result = Collection().Find(filter).FirstOrDefault();
            return result;
        }

        public Object find()
        {
            List<DTO.TaiKhoanUngDung> result = Collection().Find(new BsonDocument()).ToList();
            return result;
        }
    }
}
