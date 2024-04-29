using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BDXe
    {
        QLDVXeKhachDataContext qldvxk = new QLDVXeKhachDataContext();
        public List<Xe> LoadX()
        {
            var xs = from x in qldvxk.Xes select x;
            return xs.ToList();
        }
        public void ThemX(string max, string tentx, string bsx, int soghe, string tinhtrangxe)
        {
            qldvxk.Xes.InsertOnSubmit(new Xe { MaXe = max, Tentx = tentx, BienSX = bsx, SoGhe = soghe, TinhTrangXe = tinhtrangxe });
            qldvxk.SubmitChanges();
        }
        public void XoaX(string max)
        {
            Xe xes = qldvxk.Xes.Where(t => t.MaXe == max).FirstOrDefault();
            qldvxk.Xes.DeleteOnSubmit(xes);
            qldvxk.SubmitChanges();
        }
        public void SuaX(string max,string tentx, string biensx, int soghe,string tinhtrang)
        {
            Xe xes = qldvxk.Xes.Where(t => t.MaXe == max).FirstOrDefault();
            xes.Tentx = tentx;xes.BienSX = biensx;xes.SoGhe = soghe; xes.TinhTrangXe = tinhtrang;
            qldvxk.SubmitChanges();
        }
        public bool KiemTraTrungBienSX(string biensx)
        {
            var x = qldvxk.Xes.FirstOrDefault(t => t.BienSX == biensx);
            return x == null;
        }
        public void CapNhatX(string max, string tinhtrang)
        {
            Xe xes = qldvxk.Xes.Where(t => t.MaXe == max).FirstOrDefault();
            xes.TinhTrangXe = tinhtrang;
            qldvxk.SubmitChanges();
        }
        public List<Xe> TimKiemXe(string timkiem)
        {
            var xs = from x in qldvxk.Xes
                     where x.MaXe.Contains(timkiem) ||
                     x.BienSX.Contains(timkiem)
                     select x;
            return xs.ToList();
        }
    }
}
