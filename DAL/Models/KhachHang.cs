using System;
using System.Collections.Generic;

namespace DAL.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public string MaKh { get; set; } = null!;
        public string? TenKh { get; set; }
        public string? DiaChi { get; set; }
        public string? DienThoai { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
