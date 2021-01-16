using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IYorumlarService
    {
        List<Yorumlar> GetAll();
        List<Yorumlar> GetByKitap(int kitapId);
        List<Yorumlar> GetById(int Id);
        Yorumlar GetById2(int Id);
        void Add(Yorumlar yorum);
        void Delete(Yorumlar yorum);
        void Update(Yorumlar yorum);
    }
}
