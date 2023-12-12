using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using KhachSan;
using MongoDB.Bson.Serialization;

namespace KhachSan.DAO
{
    class ThiSinhUngTuyen : db
    {

        public Object findOne(String MaThiSinh, ObjectId id_tuyendung)
        {
            BsonDocument match1 = new BsonDocument
            {
                {
                    "$match", new BsonDocument
                    {
                        {"_id", id_tuyendung }
                    }
                }
            };

            BsonDocument unwind = new BsonDocument
            {
                {
                    "$unwind", "$ThiSinhUngTuyen"
                }
            };

            BsonDocument match2 = new BsonDocument
            {
                {
                    "$match", new BsonDocument
                    {
                        {"ThiSinhUngTuyen.MaThiSinh", MaThiSinh }
                    }
                }
            };

            BsonDocument project = new BsonDocument
            {
                {
                    "$project", new BsonDocument
                    {
                        {"_id", 0 },
                        {"MaThiSinh", "$ThiSinhUngTuyen.MaThiSinh" },
                        {"HoTen", "$ThiSinhUngTuyen.HoTen" },
                        {"Phai", "$ThiSinhUngTuyen.Phai" },
                        {"NgaySinh", "$ThiSinhUngTuyen.NgaySinh" },
                        {"Email", "$ThiSinhUngTuyen.Email" },
                        {"NgayUngTuyen", "$ThiSinhUngTuyen.NgayUngTuyen" },
                        {"TrangThai", "$ThiSinhUngTuyen.TrangThai" },
                        {"KinhNghiem", "$ThiSinhUngTuyen.KinhNghiem" },
                        {"KyNang", "$ThiSinhUngTuyen.KyNang" },
                        {"LinkCV", "$ThiSinhUngTuyen.LinkCV" }
                    }
                }
            };

            PipelineDefinition<DTO.ViTriTuyenDung, BsonDocument> pipeline = new BsonDocument[] {match1, unwind, match2, project};
            BsonDocument ts_bson = db.ViTriTuyenDung.Collection().Aggregate(pipeline).FirstOrDefault();
            if (ts_bson == null) return ts_bson;
            return BsonSerializer.Deserialize<DTO.ThiSinhUngTuyen>(ts_bson);
        }

        public Boolean DuyetUngTuyen(String MaThiSinh, ObjectId id_tuyendung)
        {
            try
            {
                var filter = Builders<BsonDocument>.Filter.And(
                     Builders<BsonDocument>.Filter.Eq("_id", id_tuyendung),
                     Builders<BsonDocument>.Filter.Eq("ThiSinhUngTuyen.MaThiSinh", MaThiSinh)
                 );

                var update = Builders<BsonDocument>.Update.Set("ThiSinhUngTuyen.$.TrangThai", "Trúng tuyển");

                db.ViTriTuyenDung.Collection(true).UpdateOne(filter, update);
                DTO.ThiSinhUngTuyen ts = (DTO.ThiSinhUngTuyen)findOne(MaThiSinh, id_tuyendung);

                filter = Builders<BsonDocument>.Filter.Eq("_id", id_tuyendung);
                var push = Builders<BsonDocument>.Update.Push("ThiSinhTrungTuyen", new BsonDocument
                {
                    { "MaThiSinh", ts.MaThiSinh},
                    { "NgayTrungTuyen", DateTime.UtcNow}
                });

                db.ViTriTuyenDung.Collection(true).UpdateOne(filter, push);
                return true;
            }
            catch(Exception e) { return false; }
        }
       
    }
}
