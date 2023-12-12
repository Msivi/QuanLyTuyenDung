using KhachSan.DTO;
using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KhachSan.DAO
{
    class ThiSinhTrungTuyen : db
    {
        private IMongoCollection<DTO.Custom> Collection()
        {
            MongoClient mongo = new MongoClient(ConnectionString);
            IMongoDatabase d = mongo.GetDatabase(Database);
            IMongoCollection<DTO.Custom> c = d.GetCollection<DTO.Custom>("ViTriTuyenDung");
            return c;
        }

        public Object find()
        {

            /* db.ViTriTuyenDung.aggregate([ { $project: { _id: 0, TenViTri: 1, ThiSinhTrungTuyen: 1 } }, { $unwind: “$ThiSinhTrungTuyen” } ])*/
            var result = Collection().Aggregate()
                .Project<DTO.Custom>(Builders<DTO.Custom>.Projection
                                   .Include("TenViTri")
                                                      .Include("ThiSinhTrungTuyen")
                                                                         .Exclude("_id")
                                                                                        )
                .Unwind("ThiSinhTrungTuyen")
                .ToList();
            var list = new List<Custom>();

            foreach (var doc in result) { list.Add(BsonSerializer.Deserialize<Custom>(doc)); }
            return list;
        }

        public Object find(ObjectId _id_tuyendung)
        {
            DTO.ViTriTuyenDung vttd = (DTO.ViTriTuyenDung)db.ViTriTuyenDung.findOne(_id_tuyendung);

            List<Custom> tstt = new List<Custom>();
            vttd.ThiSinhTrungTuyen.ForEach(
                item => {
                    item.ThiSinhUngTuyen = (DTO.ThiSinhUngTuyen)db.ThiSinhUngTuyen.findOne(item.MaThiSinh, _id_tuyendung);
                    tstt.Add(new DTO.Custom()
                    {
                        TenViTri = vttd.TenViTri,
                        ThiSinhTrungTuyen = item
                    });
                }
            );
            return tstt;
        }

        public bool updateOne(DTO.Custom vttd)
        {
            try
            {
                Collection().UpdateOne(
                                   Builders<DTO.Custom>.Filter.Eq("ThiSinhTrungTuyen.MaThiSinh", vttd.ThiSinhTrungTuyen.MaThiSinh),
                                                  Builders<DTO.Custom>.Update.Set("ThiSinhTrungTuyen.$.PhongVan", vttd.ThiSinhTrungTuyen.PhongVan)
                                                                                                                                                                                   );
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool unset_PhongVan(String MaThiSinh, ObjectId _id_vt)
        {
            try
            {
                var filter = Builders<BsonDocument>.Filter;
                var update = Builders<BsonDocument>.Update;

                db.ViTriTuyenDung.Collection(true).UpdateOne(
                        filter.And(
                            filter.Eq("_id", _id_vt),
                            filter.Eq("ThiSinhTrungTuyen.MaThiSinh", MaThiSinh)
                        ),
                        update.Unset("ThiSinhTrungTuyen.$.PhongVan")
                    );
                db.ViTriTuyenDung.Collection(true).UpdateOne(
                        filter.Eq("_id", _id_vt),
                        update.Pull("ThiSinhDatYeuCau", new BsonDocument {
                            { "MaThiSinh", MaThiSinh}
                        })
                    );


                var col_vt = db.ViTriTuyenDung.Collection();

                int soLuongCanTuyen = col_vt.Find(
                        Builders<DTO.ViTriTuyenDung>.Filter.Eq("_id", _id_vt)
                    ).FirstOrDefault().SoLuongCanTuyen;

                col_vt.UpdateOne(
                        Builders<DTO.ViTriTuyenDung>.Filter.Eq("_id", _id_vt),
                        Builders<DTO.ViTriTuyenDung>.Update.Set("SoLuongCanTuyen", soLuongCanTuyen + 1)
                    );

                col_vt.UpdateOne(
                       Builders<DTO.ViTriTuyenDung>.Filter.And(
                        Builders<DTO.ViTriTuyenDung>.Filter.Eq("_id", _id_vt),
                        Builders<DTO.ViTriTuyenDung>.Filter.Eq("ThiSinhUngTuyen.MaThiSinh", MaThiSinh)
                       ),
                       Builders<DTO.ViTriTuyenDung>.Update.Set("ThiSinhUngTuyen.$.TrangThai", "Trúng Tuyển")
                   );

                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }


        public bool updateOneUnset(DTO.Custom vttd)
        {
            try
            {
                Collection().UpdateOne(
                                 Builders<DTO.Custom>.Filter.Eq("ThiSinhTrungTuyen.MaThiSinh", vttd.ThiSinhTrungTuyen.MaThiSinh),
                                             Builders<DTO.Custom>.Update.Unset("ThiSinhTrungTuyen.$.PhongVan")
                                                                                                                                                                                                                                                                                         );
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public Object findOne(String _id_thiSinh, ObjectId _id_tuyenDung)
        {
           
            DTO.ViTriTuyenDung viTri = (DTO.ViTriTuyenDung)db.ViTriTuyenDung.findOne(_id_tuyenDung);
            if (viTri == null) return viTri;

            DTO.ThiSinhTrungTuyen thiSinh = viTri.ThiSinhTrungTuyen.Where(
                item => item.MaThiSinh.Equals(_id_thiSinh)
                ).FirstOrDefault();
            return thiSinh;
        }

        
    }
}
