using System;

namespace BLL_DAL
{
    public class ChuyenVaXeS
    {
        public string MaChuyenXe { get; internal set; }
        public string DiemDi { get; internal set; }
        public string DiemDen { get; internal set; }
        public string MaXe { get; internal set; }
        public string BienSoXe { get; internal set; }
        public int? SoGheConLai { get; internal set; }
        public string TinhTrangGhe { get; internal set; }
        public TimeSpan? GioKhoiHanh { get; internal set; }
        public TimeSpan? GioKetThuc { get; internal set; }
    }
}