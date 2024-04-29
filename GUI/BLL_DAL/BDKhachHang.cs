using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BDKhachHang
    {
        QLDVXeKhachDataContext qldvxk = new QLDVXeKhachDataContext();
        public List<KhachHang> LoadKH()
        {
            var khs = from kh in qldvxk.KhachHangs select kh;
            return khs.ToList();
        }
        public void ThemKH(string makh, string tenkh, string sdt, string mavx, DateTime ngaythanhtoan, string ttthanhtoan)
        {
            KhachHang newKhachHang = new KhachHang
            {
                MaKH = makh,
                TenKH = tenkh,
                Sdt = sdt,
                MaVX = mavx,
                NgayThanhToan = ngaythanhtoan,
                TinhTrangThanhToan = ttthanhtoan
            };
            qldvxk.KhachHangs.InsertOnSubmit(new KhachHang { MaKH = makh, TenKH = tenkh, Sdt = sdt, MaVX = mavx, NgayThanhToan = ngaythanhtoan, TinhTrangThanhToan = ttthanhtoan });
            qldvxk.SubmitChanges();
        }
    }
}
