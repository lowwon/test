﻿using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class HoaDon
    {
        public HoaDon()
        {
            Cthds = new HashSet<Cthd>();
        }

        public string MaHd { get; set; } = null!;
        public string? MaKh { get; set; }
        public int? MaNv { get; set; }
        public DateTime NgayLapHd { get; set; }
        public DateTime NgayGiaoHang { get; set; }

        public virtual KhachHang? MaKhNavigation { get; set; }
        public virtual Nhanvien? MaNvNavigation { get; set; }
        public virtual ICollection<Cthd> Cthds { get; set; }
    }
}
