using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class BDDatGhe
    {
        QLDVXeKhachDataContext db = new QLDVXeKhachDataContext();
        public void ThemGhe(string[] cacMaGhe, string maXe)
        {
            foreach (var maGhe in cacMaGhe)
            {
                GheNgoi newGhe = new GheNgoi
                {
                    MaGhe = maGhe,
                    MaXe = maXe,
                };

                db.GheNgois.InsertOnSubmit(newGhe);
            }

            db.SubmitChanges();
        }
    }
}
