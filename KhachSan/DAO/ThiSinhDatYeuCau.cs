using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace KhachSan.DAO
{
    class ThiSinhDatYeuCau
    {
        public Object findOne(String MaThiSinh, ObjectId _id_tuyendung)
        {
            DTO.ViTriTuyenDung vttd = (DTO.ViTriTuyenDung)db.ViTriTuyenDung.findOne(_id_tuyendung);
            return vttd.ThiSinhDatYeuCau.Where(item => item.MaThiSinh.Equals(MaThiSinh)).FirstOrDefault();
        }

        public Object find_inject_to_tab(ObjectId _id_tuyendung)
        {
            List<DTO.ThiSinhDatYeuCau> tsdyc = ((DTO.ViTriTuyenDung)db.ViTriTuyenDung.findOne(_id_tuyendung)).ThiSinhDatYeuCau;

            if (tsdyc.Count < 1) return null;

            List<DTO.ThiSinhUngTuyen> thongTin_ungTuyen_tsdyc = new List<DTO.ThiSinhUngTuyen>();
            List<DTO.ThiSinhTrungTuyen> thongTin_trungTuyen_tsdyc = new List<DTO.ThiSinhTrungTuyen>();

            tsdyc.ForEach(item => {
                thongTin_ungTuyen_tsdyc.Add(
                    (DTO.ThiSinhUngTuyen)db.ThiSinhUngTuyen.findOne(item.MaThiSinh, _id_tuyendung));

                thongTin_trungTuyen_tsdyc.Add(
                    (DTO.ThiSinhTrungTuyen)db.ThiSinhTrungTuyen.findOne(item.MaThiSinh, _id_tuyendung));
                
            });

            return new Dictionary<String, Object>()
            {
                { "ThongTinDatYeuCau", tsdyc },
                { "ThongTinUngTuyen", thongTin_ungTuyen_tsdyc},
                { "ThongTinTrungTuyen", thongTin_trungTuyen_tsdyc}
            };
        }

        public String pass_interview(DTO.ThiSinhDatYeuCau ts, String nhanxet, ObjectId _id_tuyendung)
        {
            try
            {
                var filter = Builders<DTO.ViTriTuyenDung>.Filter;
                var update = Builders<DTO.ViTriTuyenDung>.Update;

                IMongoCollection<DTO.ViTriTuyenDung> col_vttd = db.ViTriTuyenDung.Collection();

                DTO.ViTriTuyenDung vttd = col_vttd.Find(
                    Builders<DTO.ViTriTuyenDung>.Filter.Eq("_id", _id_tuyendung)
                ).FirstOrDefault();

                if (vttd.ThiSinhDatYeuCau.Where(item => item.MaThiSinh.Equals(ts.MaThiSinh)).FirstOrDefault() != null)
                    return "Thí sinh này đã được nhận vào làm !!!";

                if (vttd.SoLuongCanTuyen == 0) return "Đã tuyển đủ số lượng !!!!";

                col_vttd.UpdateOne(
                    filter.Eq("_id", _id_tuyendung),
                    update.Push("ThiSinhDatYeuCau", ts)
                );

                col_vttd.UpdateOne(
                    filter.And(
                        filter.Eq("_id", _id_tuyendung),
                        filter.Eq("ThiSinhTrungTuyen.MaThiSinh", ts.MaThiSinh)

                    ),
                    update
                        .Set("ThiSinhTrungTuyen.$.PhongVan.NhanXet", nhanxet)
                        .Set("SoLuongCanTuyen", vttd.SoLuongCanTuyen - 1)
                );

                col_vttd.UpdateOne(
                    filter.And(
                        filter.Eq("_id", _id_tuyendung),
                        filter.Eq("ThiSinhUngTuyen.MaThiSinh", ts.MaThiSinh)
                    ),
                    update.Set("ThiSinhUngTuyen.$.TrangThai", "Đậu phỏng vấn")
                );

                return "Thành công !!!";
            }
            catch (Exception e) { return "Xảy ra lỗi !!!!"; }
        }
    }
}
