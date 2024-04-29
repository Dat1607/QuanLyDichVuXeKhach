using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BLL_DAL
{
    public class BDNhanVien
    {
        QLDVXeKhachDataContext qldvxk = new QLDVXeKhachDataContext();
        public BDNhanVien() { }
        public List<NhanVien> LoadNhanVien()
        {
            var nvs = from nv in qldvxk.NhanViens select nv;
            return nvs.ToList();
        }
        public void ThemNV(string manv, string tennv, string email, string cccd, string chucvu)
        {
            qldvxk.NhanViens.InsertOnSubmit(new NhanVien { MaNV = manv, TenNV = tennv, Email = email, CCCD = cccd, ChucVu = chucvu });
            qldvxk.SubmitChanges();
        }
        public void XoaNV(string manv)
        {
            NhanVien nv = qldvxk.NhanViens.Where(t => t.MaNV == manv).FirstOrDefault();
            qldvxk.NhanViens.DeleteOnSubmit(nv);
            qldvxk.SubmitChanges();
        }
        public void SuaNV(string manv, string tennv, string email, string cccd)
        {
            NhanVien nv = qldvxk.NhanViens.Where(t => t.MaNV == manv).FirstOrDefault();
            nv.TenNV = tennv; nv.Email = email; nv.CCCD = cccd;
            qldvxk.SubmitChanges();
        }
        public bool KiemTraTrungMaNV(string manv)
        {
            var nv = qldvxk.NhanViens.FirstOrDefault(t => t.MaNV == manv);
            return nv == null;
        }
        public bool KiemTraTrungEmail(string email)
        {
            var nv = qldvxk.NhanViens.FirstOrDefault(t => t.Email == email);
            return nv == null;
        }
        public bool KiemTraTrungCCCD(string cccd)
        {
            var nv = qldvxk.NhanViens.FirstOrDefault(t => t.CCCD == cccd);
            return nv == null;
        }
        public bool KiemTraCCCD(string cccd)
        {
                return qldvxk.NhanViens.Any(t => t.CCCD == cccd);
        }
        public List<NhanVien> TimKiemNV(string timkiem)
        {
            var nhanviens = from nv in qldvxk.NhanViens
                            where nv.MaNV.ToString().Contains(timkiem) ||
                             nv.TenNV.Contains(timkiem) ||
                             nv.CCCD.Contains(timkiem)
                            select nv;
            return nhanviens.ToList();
        }
        public string LayTenNVByMaNV(string manv)
        {
            NhanVien kh = qldvxk.NhanViens.FirstOrDefault(s => s.MaNV == manv);
            return kh != null ? kh.TenNV : null;
        }
    }
}
