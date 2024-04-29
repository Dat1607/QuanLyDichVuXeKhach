using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BDVe
    {
        QLDVXeKhachDataContext qldvxk = new QLDVXeKhachDataContext();
        public List<VeXe> LoadVX()
        {
            var vxs = from vx in qldvxk.VeXes select vx;
            return vxs.ToList();
        }
        public void ThemVX(string mavx, string magh, DateTime ngayDat, string max)
        {
                VeXe newVe = new VeXe
                {
                    MaVX = mavx,
                    MaGheNgoi = magh,
                    NgayDatVe = ngayDat,
                    MaXe = max,
                };

                qldvxk.VeXes.InsertOnSubmit(newVe);
            qldvxk.SubmitChanges();
        }
        public bool TicketCodeExists(string maVe)
        {
                bool ticketExists = qldvxk.VeXes.Any(t => t.MaVX == maVe);
                return ticketExists;
        }
        public List<VeXe> TimKiemVe(string timkiem)
        {
            var vxs = from vx in qldvxk.VeXes
                      where vx.MaXe.Contains(timkiem) ||
                      vx.MaVX.Contains(timkiem)
                      select vx;
            return vxs.ToList();
        }
        public List<VeX> TraCuuVe(string tenkh, string sdt)
        {
            var vs = from ve in qldvxk.VeXes
                      join kh in qldvxk.KhachHangs on ve.MaVX equals kh.MaVX 
                      join xe in qldvxk.Xes on ve.MaXe equals xe.MaXe
                      where kh.TenKH == tenkh && kh.Sdt == sdt
                      select new VeX
                      {
                          MaVX = ve.MaVX,
                          MaGheNgoi = ve.MaGheNgoi,
                          NgayDat = ve.NgayDatVe,
                          MaXe = ve.MaXe,
                          BienSX = xe.BienSX,
                          MaKH = kh.MaKH,
                          TenKH = kh.TenKH
                      };
            return vs.ToList();
        }
    }
}
