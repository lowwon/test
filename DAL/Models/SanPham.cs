﻿using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class SanPham
    {
        public SanPham()
        {
            Cthds = new HashSet<Cthd>();
        }

        public string MaSp { get; set; } = null!;
        public string? TenSp { get; set; }
        public string? Donvitinh { get; set; }
        public double? Dongia { get; set; }
        public int? MaLoaiSp { get; set; }
        public string? HinhSp { get; set; }

        public virtual LoaiSp? MaLoaiSpNavigation { get; set; }
        public virtual ICollection<Cthd> Cthds { get; set; }
    }
}
