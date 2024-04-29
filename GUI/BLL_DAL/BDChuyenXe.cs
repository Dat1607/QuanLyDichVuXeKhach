using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BDChuyenXe
    {
        QLDVXeKhachDataContext qldvxk = new QLDVXeKhachDataContext();
        public BDChuyenXe() { }

        public List<DiaDiemTP> LoadTP()
        {
            var tps = qldvxk.GetTable<DiaDiem>()
                 .Select(tp => new DiaDiemTP  { TP = tp.ThanhPho })
                 .ToList();
            return tps;
        }
        public List<ChuyenXe> LoadCX()
        {
            var cxs = from cx in qldvxk.ChuyenXes select cx; return cxs.ToList();
        }
        public void ThemCX(string macx, string diemdi, string diemden, DateTime ngaydi, DateTime ngayden, decimal giave, string manv)
        {
            qldvxk.ChuyenXes.InsertOnSubmit(new ChuyenXe { MaCX = macx, DiemDi = diemdi, DiemDen = diemden, NgayDi = ngaydi, NgayDenDuKien = ngayden, GiaVe = giave, MaNV = manv });
            qldvxk.SubmitChanges();
        }

        public void XoaCX(string macx)
        {
            ChuyenXe cx = qldvxk.ChuyenXes.Where(t => t .MaCX == macx).FirstOrDefault();
            qldvxk.ChuyenXes.DeleteOnSubmit(cx);
            qldvxk.SubmitChanges();
        }
        public void SuaCX(string macx, string diemdi, string diemden, DateTime ngaydi, DateTime ngayden, Decimal giave)
        {
            ChuyenXe cx = qldvxk.ChuyenXes.Where(t => t.MaCX == macx).FirstOrDefault();
            cx.DiemDi = diemdi;cx.DiemDen = diemden;cx.NgayDi = ngaydi;cx.NgayDenDuKien = ngayden;cx.GiaVe = giave;
            qldvxk.SubmitChanges();
        }

        public bool KiemTraTrungChuyen(string diemdi, string diemden, DateTime ngaydi)
        {
            var cx = qldvxk.ChuyenXes.FirstOrDefault(t => t.DiemDi == diemdi && t.DiemDen == diemden && t.NgayDi == ngaydi);
            return cx == null;
        }
        public string LayMaNV(string cccd)
        {
            var dk = qldvxk.NhanViens.FirstOrDefault(t => t.CCCD == cccd);
            if (dk != null)
            {
                return dk.MaNV.ToString();
            }
            return "Không tìm thấy";
        }
    }
}
