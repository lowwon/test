using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL.Models;

namespace DAL
{
    public class SanPhamDAL
    {
        private QLBHContext db;
        public SanPhamDAL()
        {
            db = new QLBHContext();
        }
        public IList<SanPhamDTO> GetAll()
        {
            List<SanPhamDTO> list = new List<SanPhamDTO>();
            try
            {
                var ls = db.SanPhams.ToList();
                foreach (var s in ls)
                {
                    SanPhamDTO a = new SanPhamDTO();
                    a.MaSp = s.MaSp;
                    a.TenSp = s.TenSp;
                    a.Donvitinh = s.Donvitinh;
                    a.Dongia = s.Dongia;
                    a.MaLoaiSp = s.MaLoaiSp;
                    a.HinhSp = s.HinhSp;
                    list.Add(a);
                }
            }
            catch (Exception ex)
            {
                list = null;
            }
            return list;
        }
    }
}