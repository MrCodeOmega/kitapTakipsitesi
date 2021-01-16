using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using MVCWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebUI.Controllers
{
    public class KategoriController : Controller
    {
        private IKategoriService _kategoriService;

        public KategoriController(IKategoriService kategoriService)
        {
            _kategoriService = kategoriService;
        }
        public IActionResult Index()
        {
            var model = new KategoriListViewModel
            {
                Kategoriler = _kategoriService.GetAll()

            };
            return View(model);

        }


    }
}
