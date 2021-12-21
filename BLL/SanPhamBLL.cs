using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class SanPhamBLL
    {
        private SanPhamDAL dal;

        public SanPhamBLL()
        {
            dal = new SanPhamDAL();
        }

        public IList<SanPhamDTO> GetAll()
        {
            return dal.GetAll();
        }
    }
}