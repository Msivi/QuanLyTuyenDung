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
    class ViTriTuyenDung : db
    {
        private const String Collections_name = "ViTriTuyenDung";


        public IMongoCollection<BsonDocument> Collection(Boolean Bson)
        {
            MongoClient mongo = new MongoClient(ConnectionString);
            IMongoDatabase d = mongo.GetDatabase(Database);
            IMongoCollection<BsonDocument> c = d.GetCollection<BsonDocument>(Collections_name);
            return c;
        }

        public IMongoCollection<DTO.ViTriTuyenDung> Collection()
        {
            MongoClient mongo = new MongoClient(ConnectionString);
            IMongoDatabase d = mongo.GetDatabase(Database);
            IMongoCollection<DTO.ViTriTuyenDung> c = d.GetCollection<DTO.ViTriTuyenDung>(Collections_name);
            return c;
        }
        public Object find()
        {
            List<DTO.ViTriTuyenDung> result = Collection().Find(new BsonDocument()).ToList();
            return result;
        }

        public Object findOne(ObjectId _id)
        {
            return Collection().Find(
                Builders<DTO.ViTriTuyenDung>.Filter.Eq("_id", _id)
            ).FirstOrDefault();
        }


      

        public Boolean insertOne(DTO.ViTriTuyenDung vttd, List<ObjectId> nvpvs_id)
        {
            try
            {
                BsonArray nvpvs = new BsonArray();
                foreach (ObjectId o in nvpvs_id) {
                    nvpvs.Add((BsonDocument)db.NhanVienPhongVan.findOne(o, true));
                }

                Collection(true).InsertOne(new BsonDocument()
                {
                    { "TenViTri",  vttd.TenViTri},
                    { "SoLuongCanTuyen", vttd.SoLuongCanTuyen},
                    { "NgayDeXuat", DateTime.Now},
                    { "TrangThai", vttd.TrangThai},
                    { "MucLuongDeXuat", vttd.MucLuongDeXuat},
                    { "KinhNghiemYeuCau", vttd.KinhNghiemYeuCau},
                    { "NgayKetThuc", vttd.NgayKetThuc },
                    { "ThamGiaPhongVan", nvpvs},
                    { "ThiSinhUngTuyen", new BsonArray()},
                    { "ThiSinhTrungTuyen", new BsonArray()},
                    { "ThiSinhDatYeuCau", new BsonArray()}
                });
                return true;
            }
            catch(Exception e){ return false;}
        }

        public Boolean deleteOne(ObjectId _id)
        {
            try
            {
                Collection().DeleteOne(
                    Builders<DTO.ViTriTuyenDung>.Filter.Eq("_id", _id)
                ) ;
                return true;
            }
            catch(Exception e) { return false; }
        }

        public Boolean updateOne(DTO.ViTriTuyenDung vttd, List<ObjectId> nvpvs_id)
        {
            try
            {
                BsonArray nvpvs = new BsonArray();
                foreach (ObjectId o in nvpvs_id)
                {
                    nvpvs.Add((BsonDocument)db.NhanVienPhongVan.findOne(o, true));
                }

                Collection(true).UpdateOne(
                    Builders<BsonDocument>.Filter.Eq("_id", vttd._id),
                    Builders<BsonDocument>.Update
                    .Set("TenViTri",  vttd.TenViTri)
                    .Set("SoLuongCanTuyen", vttd.SoLuongCanTuyen)
                    .Set("TrangThai", vttd.TrangThai)
                    .Set("MucLuongDeXuat", vttd.MucLuongDeXuat)
                    .Set("KinhNghiemYeuCau", vttd.KinhNghiemYeuCau)
                    .Set("NgayKetThuc", vttd.NgayKetThuc)
                    .Set("ThamGiaPhongVan", nvpvs)
                );
                return true;
            }
            catch(Exception e) { return false; }
        }
    }
}
