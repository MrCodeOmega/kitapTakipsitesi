using Core.DataAccess.Concrete.EntityFramework;
using Core.Entites.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IKitapService
    {
        List<Kitap> GetAll();
        List<Kitap> GetByKategori(int kategoriId);
        List<Kitap> GetById(int Id);
        List<Kitap> GetByPuan(int Puan);
        List<Yorumlar> GetYorums(int yorumId);
        List<Yorumlar> GetAll2();
        Kitap GetById3(int Id);
        List<Kitap> GetByName(string kitapAdi);
        Kitap GetByName2(string kitapAdi);
        void Add(Kitap kitap);
        void Delete(Kitap kitap);
        void Update(Kitap kitap);
    }
}
