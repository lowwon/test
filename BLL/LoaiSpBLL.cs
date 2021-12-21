using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class LoaiSpBLL
    {
        private LoaiSpDAL dal;
        public LoaiSpBLL()
        {
            dal = new LoaiSpDAL();
        }
        public IList<LoaiSpDTO> GetAll()
        {
            return dal.GetAll();    
        }
    }
}
