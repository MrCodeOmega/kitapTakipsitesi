using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using MVCWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace MVCWebUI.ViewComponents
{
    public class KategoriListViewComponent:ViewComponent
    { 
        
        private IKategoriService _kategoriService;
        public KategoriListViewComponent(IKategoriService kategoriService)
        {
            _kategoriService = kategoriService;
        }
        public ViewViewComponentResult Invoke()
        {
            var model = new KategoriListViewModel
            {
                Kategoriler = _kategoriService.GetAll(),
                currentKategori =Convert.ToInt32(HttpContext.Request.Query["kategori"]) 
            };
            return View(model);
        }
    }
}
