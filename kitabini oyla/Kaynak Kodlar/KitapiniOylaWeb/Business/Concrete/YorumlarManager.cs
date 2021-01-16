using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class YorumlarManager : IYorumlarService
    {
        private IYorumlarDal _yorumlarDal;
        public YorumlarManager(IYorumlarDal yorumlarDal)
        {
            _yorumlarDal = yorumlarDal;
        }

        public List<Yorumlar> GetAll()
        {
            return _yorumlarDal.GetList();
        }

        public List<Yorumlar> GetByKitap(int kitapId)
        {
            return _yorumlarDal.GetList(filter: p => p.Id == kitapId);
        }
        public List<Yorumlar> GetById(int Id)
        {
            return _yorumlarDal.GetList(filter: p => p.Id == Id);
        }

        public Yorumlar GetById2(int Id)
        {
            return _yorumlarDal.Get(filter: p => p.Id == Id);
        }

        public void Add(Yorumlar yorum)
        {
            _yorumlarDal.Add(yorum);
        }

        public void Delete(Yorumlar yorum)
        {
            _yorumlarDal.Delete(yorum);
        }

        public void Update(Yorumlar yorum)
        {
            _yorumlarDal.Update(yorum);
        }
    }
}

