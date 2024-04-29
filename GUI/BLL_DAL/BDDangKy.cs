using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace BLL_DAL
{
    public class BDDangKy
    {
        QLDVXeKhachDataContext qldvxk = new QLDVXeKhachDataContext();
        public BDDangKy() { }
        public List<TaiKhoan> LoadTK()
        {
            var tks = from tk in qldvxk.TaiKhoans select tk;
            return tks.ToList();
        }

        public void DangKy(string tendk, string mk)
        {
            qldvxk.TaiKhoans.InsertOnSubmit(new TaiKhoan { TenDangNhap = tendk, MatKhau = mk});
            qldvxk.SubmitChanges();
        }
        public bool KiemTraTrungTenDK(string tendk)
        {
            var dk = qldvxk.TaiKhoans.FirstOrDefault(t => t.TenDangNhap == tendk);
            return dk == null;
        }
    }
}
