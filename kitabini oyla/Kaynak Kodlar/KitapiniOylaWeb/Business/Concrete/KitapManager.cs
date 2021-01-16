using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class KitapManager : IKitapService
    {
        private IKitapDal _kitapDal;
        private IYorumlarDal _yorumlarDal;
        public KitapManager(IKitapDal kitapDal,IYorumlarDal yorumlarDal)
        {
            _yorumlarDal = yorumlarDal;
            _kitapDal = kitapDal;
        }

        public List<Kitap> GetAll()
        {
            return _kitapDal.GetList();
        }

        public List<Kitap> GetByKategori(int kategoriId)
        {
            return _kitapDal.GetList(filter:p => p.KategoriId==kategoriId);
        }
        public List<Kitap> GetById(int Id)
        {
            return _kitapDal.GetList(filter: p => p.Id == Id);
        }

        public List<Yorumlar> GetYorums(int yorumId)
        {
            return _yorumlarDal.GetList(filter: p => p.YorumId == yorumId);
        }
        public List<Yorumlar> GetAll2()
        {
            return _yorumlarDal.GetList();
        }

        public void Add(Kitap kitap)
        {
            _kitapDal.Add(kitap);
        }

        public void Delete(Kitap kitap)
        {
            _kitapDal.Delete(kitap);
        }

        public void Update(Kitap kitap)
        {
            _kitapDal.Update(kitap);
        }

        public Kitap GetById3(int Id)
        {
            return _kitapDal.Get(filter: p => p.Id == Id);
        }

        public List<Kitap> GetByName(string kitapAdi)
        {
            return _kitapDal.GetList(filter: p => p.KitapAdi == kitapAdi);
        }

        public Kitap GetByName2(string kitapAdi)
        {
            return _kitapDal.Get(filter: p => p.KitapAdi == kitapAdi);
        }

        public List<Kitap> GetByPuan(int Puan)
        {
            return _kitapDal.GetList(filter: p => p.Puan == Puan);
        }
    }
}
