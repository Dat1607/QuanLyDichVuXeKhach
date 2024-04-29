using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BDChuyenVaXe
    {
        QLDVXeKhachDataContext qldvxk = new QLDVXeKhachDataContext();
        public List<ChuyenVaXeS> LoadCVX()
        {
            var cvxs = from cvx in qldvxk.ChuyenVaXes
                       join cx in qldvxk.ChuyenXes on cvx.MaCX equals cx.MaCX
                       join x in qldvxk.Xes on cvx.MaXe equals x.MaXe
                       select new ChuyenVaXeS { MaChuyenXe = cvx.MaCX, DiemDi = cx.DiemDi, DiemDen = cx.DiemDen, MaXe = cvx.MaXe, BienSoXe = x.BienSX, SoGheConLai = cvx.SoGheConTrong, TinhTrangGhe = cvx.TinhTrangGheNgoi, GioKhoiHanh = cvx.GioKhoiHanh, GioKetThuc = cvx.GioKetThucDuKien };
            return cvxs.ToList();
        }
        public List<ChuyenXe> LoadCX()
        {
            var cxs = from cx in qldvxk.ChuyenXes select cx;
            return cxs.ToList();
        }
        public List<Xe> LoadX()
        {
            var xs = from x in qldvxk.Xes where x.TinhTrangXe == "Không có chuyến" select x;
            return xs.ToList();
        }
        public void ThemCVX(string macx, string max, int soghe, string tinhtrangghe, TimeSpan giokh, TimeSpan giokt)
        {
            qldvxk.ChuyenVaXes.InsertOnSubmit(new ChuyenVaXe { MaCX = macx, MaXe = max, SoGheConTrong = soghe, TinhTrangGheNgoi = tinhtrangghe, GioKhoiHanh = giokh, GioKetThucDuKien = giokt });
            qldvxk.SubmitChanges();
        }
        public void XoaCVX(string macx, string max)
        {
            ChuyenVaXe cvxs = qldvxk.ChuyenVaXes.Where(t => t.MaXe == max && t.MaCX == macx).FirstOrDefault();
            qldvxk.ChuyenVaXes.DeleteOnSubmit(cvxs);
            qldvxk.SubmitChanges();
        }
        public void SuaCVX(string macx, string max, TimeSpan giokh, TimeSpan giokt)
        {
            ChuyenVaXe cvxs = qldvxk.ChuyenVaXes.Where(t => t.MaXe == max && t.MaCX == macx).FirstOrDefault();
            cvxs.GioKhoiHanh = giokh; cvxs.GioKetThucDuKien = giokt;
            qldvxk.SubmitChanges();
        }
        public void CapNhatCVX(string macx, string max, int soghetrong, string tinhtrang)
        {
            ChuyenVaXe cvxs = qldvxk.ChuyenVaXes.Where(t => t.MaXe == max && t.MaCX == macx).FirstOrDefault();
            cvxs.SoGheConTrong = soghetrong; cvxs.TinhTrangGheNgoi = tinhtrang;
            qldvxk.SubmitChanges();
        }
        public string LayDiemDiByMaCX(string macx)
        {
            ChuyenXe cx = qldvxk.ChuyenXes.FirstOrDefault(s => s.MaCX == macx);
            return cx != null ? cx.DiemDi : null;
        }
        public string LayDiemDenByMaCX(string macx)
        {
            ChuyenXe cx = qldvxk.ChuyenXes.FirstOrDefault(s => s.MaCX == macx);
            return cx != null ? cx.DiemDen : null;
        }
        public string LayBienSXByMaX(string max)
        {
            Xe x = qldvxk.Xes.FirstOrDefault(s => s.MaXe == max);
            return x != null ? x.BienSX : null;
        }
        public string LaySoGheByMaX(string max)
        {
            Xe x = qldvxk.Xes.FirstOrDefault(s => s.MaXe == max);
            return x != null ? x.SoGhe.Value.ToString() : null;
        }
        public bool KiemTraTrungChuyenVaXe(string macx, string max)
        {
            var cvx = qldvxk.ChuyenVaXes.FirstOrDefault(t => t.MaCX == macx && t.MaXe == max);
            return cvx == null;
        }
        public List<ChuyenVaXeSS> TraCuuVe(string diemDauCuoi)
        {
            var cvxs = from cvx in qldvxk.ChuyenVaXes
                       join cx in qldvxk.ChuyenXes on cvx.MaCX equals cx.MaCX
                       join x in qldvxk.Xes on cvx.MaXe equals x.MaXe
                       where cx.DiemDen == diemDauCuoi
                       select new ChuyenVaXeSS
                       {
                           MaXe = x.MaXe,
                           BienSoXe = x.BienSX,
                           TinhTrangXe = x.TinhTrangXe
                       };
            return cvxs.ToList();
        }
    }
}
