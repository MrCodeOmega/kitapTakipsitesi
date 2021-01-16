using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MVCWebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebUI.Controllers
{
    
  
    public class AdminController : Controller
    {

        
        private IKitapService _kitapService;
        private IYorumlarService _yorumlarService;

        public AdminController(IKitapService kitapService, IYorumlarService yorumlarService)
        {
            _kitapService = kitapService;
            _yorumlarService = yorumlarService;
            
        }
     
        public IActionResult Index(int kategori)
        {
            var model = new KitapListViewModel
            {
                Kitap = kategori > 0 ? _kitapService.GetByKategori(kategori) : _kitapService.GetAll()

            };
            return View(model);



        }

        public IActionResult Guncelle(int Id)
        {

            var gelenKitap = _kitapService.GetById3(Id);
            GuncelleModel model = new GuncelleModel
            {
                KitapAdi = gelenKitap.KitapAdi,
                KategoriId = gelenKitap.KategoriId,
                Resim = gelenKitap.Resim,
                Puan = gelenKitap.Puan,
                Id = gelenKitap.Id,
                Yazar = gelenKitap.Yazar,
                YorumId = gelenKitap.YorumId


            };

            return View(model);
 
        }

        [HttpPost]
        public IActionResult Guncelle(GuncelleModel model)
        {
            if (!ModelState.IsValid)
            {

                return View();

            }

            var guncellenecekKitap = _kitapService.GetById3(model.Id);
            var guncellenecekYorum = _yorumlarService.GetById2(model.Id);


            TempData.Add("message", "Kitap Başarı ile Güncellendi.!");


            guncellenecekKitap.KitapAdi = model.KitapAdi;


            guncellenecekKitap.Puan = model.Puan;

            guncellenecekKitap.Yazar = model.Yazar;

            guncellenecekKitap.Resim = model.Resim;

            guncellenecekKitap.YorumId = model.YorumId;
            guncellenecekKitap.YorumId = model.YorumId;

            guncellenecekKitap.KategoriAdi = model.Kategori;

            guncellenecekKitap.KategoriId = model.KategoriId;


            _kitapService.Update(guncellenecekKitap);
            _yorumlarService.Update(guncellenecekYorum);


            return RedirectToAction("Guncelle", controllerName: "Admin");

        }


        public IActionResult Sil(int id)
        {

            _kitapService.Delete(new Kitap { Id = id });
            _yorumlarService.Delete(new Yorumlar { Id = id });

            TempData.Add("message", "Kitap Başarı ile Silindi.!");

            return RedirectToAction("Index");
        }


        public IActionResult Ekle()
        {
            return View(new EkleModel());
        }

        [HttpPost]
        public IActionResult Ekle(EkleModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();

            }

            TempData.Add("message", "Kitap Başarı ile Eklendi.!");

            Kitap kitap = new Kitap();
            Yorumlar yorum = new Yorumlar();



            kitap.KitapAdi = model.KitapAdi;


            kitap.Puan = model.Puan;

            kitap.Yazar = model.Yazar;

            kitap.Resim = model.Resim;
            kitap.KitapAciklama = model.KitapDetay;
            kitap.YorumId = model.YorumId;
            yorum.YorumId = model.YorumId;

            kitap.KategoriAdi = model.Kategori;

            kitap.KategoriId = model.KategoriId;


            _kitapService.Add(kitap);
            _yorumlarService.Add(yorum);


            return RedirectToAction("Ekle", controllerName: "Admin");
        }



        public IActionResult YorumSil(int Id)
        {

            var model =new YorumSilModel{

                Yorumlar = Id > 0 ? _kitapService.GetYorums(Id) : _kitapService.GetAll2()
            };

            return View(model);

        }

       public IActionResult YorumSil2(int id)
        {
            var gelenYorum = _yorumlarService.GetById2(id);
            YorumSilModel model = new YorumSilModel
            {
                Id=gelenYorum.Id,
                Yorum = gelenYorum.Yorum,
                YorumAdi = gelenYorum.YorumAdi,
               

            };

            return View(model);


        }

        public IActionResult SilYorum(YorumSilModel model)
        {

            
            _yorumlarService.Delete(new Yorumlar { Id = model.Id });

            TempData.Add("message", "Kitap Başarı ile Silindi.!");

            return RedirectToAction("Index" ,controllerName:"Admin");
        }


        public void SetSession(string key, string value)
        {

            HttpContext.Session.SetString(key, value);

        }

        public string GetSession(string key)
        {

            return HttpContext.Session.GetString(key);

        }



    }


}
