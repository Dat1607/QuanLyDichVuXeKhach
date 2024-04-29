using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BDDatVe
    {
        QLDVXeKhachDataContext qldvxk = new QLDVXeKhachDataContext();
        public BDDatVe() { }
        public List<DiaDiemTP> LoadTP()
        {
            var tps = qldvxk.GetTable<DiaDiem>()
                 .Select(tp => new DiaDiemTP { TP = tp.ThanhPho })
                 .ToList();
            return tps;
        }
        public List<ChuyenXeSS> TimKiemCX(string diemdi, string diemden, DateTime ngaydi)
        {
            var cxs = (from cx in qldvxk.ChuyenXes where (cx.DiemDi == diemdi && cx.DiemDen == diemden && cx.NgayDi == ngaydi ) select new ChuyenXeSS{macx = cx.MaCX, diemdi = cx.DiemDi,diemden = cx.DiemDen, ngaydi = cx.NgayDi, giave = cx.GiaVe}).ToList();
            return cxs;
        }
        public List<XeS> LayXeTheoMaCX(string macx)
        {
            var cvxss = (from cvx in qldvxk.ChuyenVaXes
                         join cx in qldvxk.ChuyenXes on cvx.MaCX equals cx.MaCX
                         join x in qldvxk.Xes on cvx.MaXe equals x.MaXe
                         where cvx.MaCX == macx
                         select new XeS { max = cvx.MaXe, tentx = x.Tentx, biensx = x.BienSX, soghe = x.SoGhe, SoGheConLai = cvx.SoGheConTrong, tinhtrang = cvx.TinhTrangGheNgoi, gioKH = cvx.GioKhoiHanh, gioKT = cvx.GioKetThucDuKien,maCX = cvx.MaCX }).ToList();

            return cvxss;
        }
        public TT LayTTTheoMaChuyenXe(string maChuyenXe)
        {
            var cxs = from cx in qldvxk.ChuyenXes
                        join x in qldvxk.ChuyenVaXes on cx.MaCX equals x.MaCX
                        join ddDi in qldvxk.DiaDiems on cx.DiemDi  equals ddDi.ThanhPho
                        join ddDen in qldvxk.DiaDiems on cx.DiemDen equals ddDen.ThanhPho
                        where x.MaCX == maChuyenXe
                        select new TT { DiemDi = cx.DiemDi,DiemDen = cx.DiemDen, BenXeDi = ddDi.BenXe, BenXeDen = ddDen.BenXe,NgayDi = cx.NgayDi,NgayDen = cx.NgayDenDuKien, GiaVe =cx.GiaVe };

            return cxs.FirstOrDefault();
        }

        public TTX LayTTTheoXe(string maXe)
        {
            var xs = from x in qldvxk.Xes
                     join cvx in qldvxk.ChuyenVaXes on x.MaXe equals cvx.MaXe
                     where cvx.MaXe == maXe 
                     select new TTX { BienSX = x.BienSX};
            return xs.FirstOrDefault();
        }
        public TTCVX LayTTTheoChVXe(string macx, string maxe)
        {
            var cxxs = from cvx in qldvxk.ChuyenVaXes
                     where cvx.MaCX == macx && cvx.MaXe == maxe
                     select new TTCVX { GioKH = cvx.GioKhoiHanh, GioKT = cvx.GioKetThucDuKien };
            return cxxs.FirstOrDefault();
        }

        public List<XeS> LayXeTheoTGian(string macx, TimeSpan startTime, TimeSpan endTime)
        {
            var cvxss = (from cvx in qldvxk.ChuyenVaXes
                         join cx in qldvxk.ChuyenXes on cvx.MaCX equals cx.MaCX
                       join x in qldvxk.Xes on cvx.MaXe equals x.MaXe
                      where cvx.MaCX == macx && cvx.GioKhoiHanh >= startTime && cvx.GioKhoiHanh <= endTime
                      select new XeS { max = x.MaXe, tentx = x.Tentx, biensx = x.BienSX, soghe = x.SoGhe,SoGheConLai = cvx.SoGheConTrong, tinhtrang = cvx.TinhTrangGheNgoi, gioKH = cvx.GioKhoiHanh, gioKT = cvx.GioKetThucDuKien, maCX = cvx.MaCX }).ToList();

            return cvxss;
        }
    }
}
