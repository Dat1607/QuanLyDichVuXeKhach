using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BDPhanQuyen
    {
        QLDVXeKhachDataContext db = new QLDVXeKhachDataContext();
        public List<MANHINH> LoadManHinh()
        {
            var mhs = from mh in db.MANHINHs select mh;
            return mhs.ToList();
        }

        public List<TaiKhoan> LoadTK()
        {
            var tks = from tk in db.TaiKhoans select tk;
            return tks.ToList();
        }
        public List<QUYEN> LoadQ()
        {
            var qs = from q in db.QUYENs select q;
            return qs.ToList();
        }
        public List<NHOMQUYEN> LoadNQ()
        {
            var nqs = from nq in db.NHOMQUYENs select nq;
            return nqs.ToList();
        }
        public List<PQ> LoadPQ(string maquyen)
        {
            var pqs = (from pq in db.PHANQUYENs
                       join q in db.QUYENs on pq.MaQuyen equals q.MaQuyen
                       join mh in db.MANHINHs on pq.MaManHinh equals mh.MaManHinh
                       where q.MaQuyen == maquyen
                       select new PQ { MaManHinh = pq.MaManHinh, TenManHinh = mh.TenManHinh, MaQuyen = pq.MaQuyen, TenQuyen = q.TenQuyen, CoQuyen = pq.CoQuyen }).ToList();
            return pqs;
        }
        public void themQ(string maquyen, string tenquyen)
        {
            db.QUYENs.InsertOnSubmit(new QUYEN { MaQuyen = maquyen, TenQuyen = tenquyen });
            db.SubmitChanges();
        }
        public void xoaQ(string maquyen)
        {
            QUYEN qs = db.QUYENs.Where(t => t.MaQuyen == maquyen).FirstOrDefault();
            db.QUYENs.DeleteOnSubmit(qs);
            db.SubmitChanges();
        }
        public bool KiemTraQuyen(string tenq)
        {
            var q = db.QUYENs.FirstOrDefault(t => t.TenQuyen == tenq);
            return q == null;
        }
        public void themNQ(string manhomquyen, string tentk, string maq)
        {
            db.NHOMQUYENs.InsertOnSubmit(new NHOMQUYEN { MaNhomQuyen = manhomquyen, TenDangNhap = tentk, MaQuyen = maq });
            db.SubmitChanges();
        }
        public void xoaNQ(string manhomquyen)
        {
            NHOMQUYEN nqs = db.NHOMQUYENs.Where(t => t.MaNhomQuyen == manhomquyen).FirstOrDefault();
            db.NHOMQUYENs.DeleteOnSubmit(nqs);
            db.SubmitChanges();
        }
        public void suaNQ(string manhomquyen, string tentk, string maq)
        {
            NHOMQUYEN nqs = db.NHOMQUYENs.Where(t => t.MaNhomQuyen == manhomquyen).FirstOrDefault();
            nqs.TenDangNhap = tentk; nqs.MaQuyen = maq;
            db.SubmitChanges();
        }
        public bool KiemTraXetQuyen(string tendk)
        {
            var nq = db.NHOMQUYENs.FirstOrDefault(t => t.TenDangNhap == tendk);
            return nq == null;
        }
        public void themPQ(string mamh, string maq, bool coq)
        {
            db.PHANQUYENs.InsertOnSubmit(new PHANQUYEN { MaManHinh = mamh, MaQuyen = maq, CoQuyen = coq });
            db.SubmitChanges();
        }
        public void xoaPQ(string mamh, string maq)
        {
            PHANQUYEN pqs = db.PHANQUYENs.Where(t => t.MaManHinh == mamh && t.MaQuyen == maq).FirstOrDefault();
            db.PHANQUYENs.DeleteOnSubmit(pqs);
            db.SubmitChanges();
        }
        public void suaPQ(string mamh, string maq, bool coq)
        {
            PHANQUYEN pqs = db.PHANQUYENs.Where(t => t.MaManHinh == mamh && t.MaQuyen == maq).FirstOrDefault();
            if (pqs != null)
            {
                pqs.CoQuyen = coq;
                db.SubmitChanges();
            }
        }
        public string LayTenMHByMaMH(string mamh)
        {
            MANHINH mh = db.MANHINHs.FirstOrDefault(s => s.MaManHinh == mamh);
            return mh != null ? mh.TenManHinh : null;
        }
        public bool KiemTraPhanQuyen(string mamh, string maq)
        {
            var pq = db.PHANQUYENs.FirstOrDefault(t => t.MaManHinh == mamh && t.MaQuyen == maq);
            return pq == null;
        }
        public string LayMaQ(string tendn)
        {
            var user = from u in db.NHOMQUYENs
                       join x in db.TaiKhoans on u.TenDangNhap equals x.TenDangNhap
                       join y in db.QUYENs on u.MaQuyen equals y.MaQuyen
                       where u.TenDangNhap == tendn
                       select y.MaQuyen;

            return user.FirstOrDefault();
        }
        public void themMH(string mamh, string tenmh)
        {
            db.MANHINHs.InsertOnSubmit(new MANHINH { MaManHinh = mamh, TenManHinh = tenmh });
            db.SubmitChanges();
        }
        public void xoaMH(string mamh)
        {
            MANHINH mhs = db.MANHINHs.Where(t => t.MaManHinh == mamh).FirstOrDefault();
            db.MANHINHs.DeleteOnSubmit(mhs);
            db.SubmitChanges();
        }
        public void suaMH(string mamh, string tenmh)
        {
            MANHINH mhs = db.MANHINHs.Where(t => t.MaManHinh == mamh).FirstOrDefault();
            mhs.TenManHinh = tenmh; 
            db.SubmitChanges();
        }
        public bool KiemTraTenManHinh(string tenmh)
        {
            var mh = db.MANHINHs.FirstOrDefault(t => t.TenManHinh == tenmh);
            return mh == null;
        }
        public bool CheckPermission(string userId, string screenCode)
        {
            var permission = (from p in db.PHANQUYENs
                              join s in db.MANHINHs on p.MaManHinh equals s.MaManHinh
                              where p.MaQuyen == userId && s.MaManHinh == screenCode
                              select p).FirstOrDefault();

            return permission != null && (bool)permission.CoQuyen;
        }
    }
}
