using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL.Models;
namespace DAL
{
    public class LoaiSpDAL
    {
        private QLBHContext db;
        public LoaiSpDAL()
        {
            db = new QLBHContext(); 
        }
        public IList<LoaiSpDTO> GetAll()
        {
            List<LoaiSpDTO> list = new List<LoaiSpDTO>();
            try
            {
                var ls = db.LoaiSps.ToList();
                foreach (var s in ls)
                {
                    LoaiSpDTO a = new LoaiSpDTO();
                    a.MaLoaiSp = s.MaLoaiSp;
                    a.TenLoaiSp = s.TenLoaiSp;  
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
