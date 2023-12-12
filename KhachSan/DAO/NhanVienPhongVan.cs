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
    class NhanVienPhongVan : db
    {
        private const String Collections_name = "NhanVienPhongVan";
        private IMongoCollection<DTO.NhanVienPhongVan> Collection()
        {
            MongoClient mongo = new MongoClient(ConnectionString);
            IMongoDatabase d = mongo.GetDatabase(Database);
            IMongoCollection<DTO.NhanVienPhongVan> c = d.GetCollection<DTO.NhanVienPhongVan>(Collections_name);
            return c;
        }

        private IMongoCollection<BsonDocument> Collection(Boolean Bson)
        {
            MongoClient mongo = new MongoClient(ConnectionString);
            IMongoDatabase d = mongo.GetDatabase(Database);
            IMongoCollection<BsonDocument> c = d.GetCollection<BsonDocument>(Collections_name);
            return c;
        }

        public Object find()
        {
            List<DTO.NhanVienPhongVan> result = Collection().Find(new BsonDocument()).ToList();
            return result;
        }

        public Object find(ObjectId _id_tuyendung)
        {
            DTO.ViTriTuyenDung vttd = (DTO.ViTriTuyenDung)db.ViTriTuyenDung.findOne(_id_tuyendung);
            return vttd.ThamGiaPhongVan;
        }

        public Object findOne(ObjectId _id)
        {
            return Collection().Find(
                Builders<DTO.NhanVienPhongVan>.Filter.Eq("_id", _id)
            ).FirstOrDefault();
        }

        public Object findOne(ObjectId _id, Boolean Bson)
        {
            return Collection(true).Find(
                Builders<BsonDocument>.Filter.Eq("_id", _id)
            ).FirstOrDefault();
        }
    }
}
