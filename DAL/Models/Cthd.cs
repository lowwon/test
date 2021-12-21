using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class Cthd
    {
        public string MaHd { get; set; } = null!;
        public string MaSp { get; set; } = null!;
        public short? Soluong { get; set; }
        public float? DongiaBan { get; set; }
        public float? Giamgia { get; set; }

        public virtual HoaDon MaHdNavigation { get; set; } = null!;
        public virtual SanPham MaSpNavigation { get; set; } = null!;
    }
}
