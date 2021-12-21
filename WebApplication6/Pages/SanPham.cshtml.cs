using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using DTO;
namespace WebApplication6.Pages
{
    public class SanPhamModel : PageModel
    {
        private SanPhamBLL bus;
        private LoaiSpBLL bus1;
        public List<SanPhamDTO> lst;
        public List<LoaiSpDTO> lst1;
        public string msp { get; private set; }
        public string tsp { get; private set; }
        public string dvt { get; private set; }
        public string dg { get; private set; }
        public string lsp { get; private set; }
        public string sx { get; private set; }
        public SanPhamModel()
        {
            bus = new SanPhamBLL(); 
            bus1 = new LoaiSpBLL();
        }
        public void OnGet()
        {

            lst = bus.GetAll().ToList();
            lst1 = bus1.GetAll().ToList();
        }
        public void OnPost()
        {
            lst = bus.GetAll().ToList();
            lst1 = bus1.GetAll().ToList();
            msp = Request.Form["msp"];
            tsp = Request.Form["tsp"];
            dvt = Request.Form["dvt"];
            dg = Request.Form["dg"];
            lsp = Request.Form["lsp"];
            sx = Request.Form["sx"];
            var temp1 = new List<SanPhamDTO>();
            var temp2 = new List<SanPhamDTO>();
            var temp3 = new List<SanPhamDTO>();
            var temp4 = new List<SanPhamDTO>();
            var temp5 = new List<SanPhamDTO>();
            var temp6 = new List<SanPhamDTO>(); 
            if (msp != "")
            {
                temp1 = (from s in lst
                         where s.MaSp == msp
                         select s).ToList();
                lst = temp1;
            }            
            if (tsp != "")
            {
                temp2 = (from s in lst
                         where s.TenSp.Contains(tsp)
                         select s).ToList();
                lst = temp2;
            }
            if (dvt != "")
            {
                temp3 = (from s in lst
                         where s.Donvitinh == dvt
                         select s).ToList();
                lst = temp3;
            }
            if (dg != "")
            {
                //temp4 = (from s in lst
                //         where s.Dongia == Convert.ToDouble(dg)
                //         select s).ToList();;
                if (dg == "1000000")
                {
                    temp4 = (from s in lst
                             where s.Dongia <= Convert.ToInt64(dg)
                             select s).ToList();
                }
                else if (dg == "2000000")
                {
                    temp4 = (from s in lst
                             where s.Dongia > 1000000 && s.Dongia <= Convert.ToInt64(dg)
                             select s).ToList();
                }
                else if (dg == "3000000")
                {
                    temp4 = (from s in lst
                             where s.Dongia > 2000000 && s.Dongia <= Convert.ToInt64(dg)
                             select s).ToList();
                }
                else if (dg == "4000000")
                {
                    temp4 = (from s in lst
                             where s.Dongia > 3000000 && s.Dongia <= Convert.ToInt64(dg)
                             select s).ToList();
                }
                else
                {
                    temp4 = (from s in lst
                             where s.Dongia > Convert.ToInt64(dg)
                             select s).ToList();
                }
                lst = temp4;
            }
            if (lsp != "")
            {
                temp5 = (from s in lst
                         where s.MaLoaiSp == Convert.ToInt64(lsp)
                         select s).ToList();
                lst = temp5;
            }
            if(sx != "")
            {
                if(sx == "tangdan")
                {
                    temp6 = (from s in lst
                             orderby s.Dongia ascending
                             select s).ToList();
                }
                else
                {
                    temp6 = (from s in lst
                             orderby s.Dongia descending
                             select s).ToList();
                }
                lst = temp6;
            }
        }

    }
}
