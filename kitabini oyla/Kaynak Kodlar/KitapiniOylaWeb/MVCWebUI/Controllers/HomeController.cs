using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using MVCWebUI.Models;

namespace MVCWebUI.Controllers
{
    public class HomeController : Controller
    {
        private IKitapService _kitapService;
        

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger,IKitapService kitapService)
        {
            _kitapService = kitapService;
            _logger = logger;
        }

        public IActionResult Index(int kategori)
        {
            
            var model = new KitapListViewModel
            {
                Kitap = kategori > 0 ? _kitapService.GetByKategori(kategori) : _kitapService.GetAll()

            };
            return View();
        }
        
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Hakkimizda()
        {
            return View();
        }

        public IActionResult KitapAraa()
        {
            return View();
        }





        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult KitapAra(string kitapAdi)
        {
           
            var model = new KitapAraModel
            {
                Kitap = _kitapService.GetByName(kitapAdi)
            };

            return View(model);

        }


        


        public IActionResult NotFound(int code)
        {

            ViewBag.Code = code;
            return View();

        }

        
        public void SetSession(string key,string value)
        {

            HttpContext.Session.SetString(key, value);

        }

        public string GetSession(string key)
        {

            return HttpContext.Session.GetString(key);

        }




    }
}
