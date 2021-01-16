using Business.Abstract;
using Business.Concrete;
using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using MVCWebUI.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MVCWebUI.Controllers
{
    public class KitapController:Controller
    {

        
        private IKitapService _kitapService;
        private IYorumlarService _yorumlarService;

        public KitapController(IKitapService kitapService, IYorumlarService yorumlarService)
        {
            _kitapService = kitapService;
            _yorumlarService = yorumlarService;
        }
        public IActionResult Index(int kategori)
        {
           
            var model = new KitapListViewModel
            {
                Kitap =kategori>0? _kitapService.GetByKategori(kategori):_kitapService.GetAll()

            };
            return View(model);

        }
        public IActionResult KitapDetay(int Id)
        {
        
            var model = new KitapListViewModel
            {
                Yorumlar =Id>0? _kitapService.GetYorums(Id):_kitapService.GetAll2(),
                Kitap = _kitapService.GetById(Id)
            };

            return View(model);

        }

       
        public IActionResult Puanla(int id)
        {
            var puanlanacak = _kitapService.GetById3(id);
            var yorumlar = _yorumlarService.GetById2(id);
            PuanlamaModel model = new PuanlamaModel
            {
                Puan = puanlanacak.Puan,
                YorumId = puanlanacak.YorumId,
                Id = puanlanacak.Id,
                KitapAdi = yorumlar.KitapAdi
                
                
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Puanla(PuanlamaModel model)
        {
            Yorumlar yorum = new Yorumlar();
            if (!ModelState.IsValid)
            {
                return View();

            }
            TempData.Add("message", "Puanınız Başarıyla Verilmiştir Efendim.!");
            var puan= _kitapService.GetById3(model.Id);
                puan.Puan = puan.Puan+1;
                yorum.YorumId = puan.YorumId;
                yorum.Yorum = model.Yorum;
                yorum.YorumAdi = model.YorumAdi;
            yorum.KitapAdi = model.KitapAdi;

            _yorumlarService.Add(yorum);
            _kitapService.Update(puan);

            return RedirectToAction("Index", controllerName: "Kitap");
        }


        public IActionResult Index2(int puan)
        {

            var model = new KitapListViewModel
            {
                Kitap = puan > 0 ? _kitapService.GetByPuan(puan) : _kitapService.GetAll().OrderByDescending(item => item.Puan).ToList()
            };
            return View(model);

        }




    }
}
