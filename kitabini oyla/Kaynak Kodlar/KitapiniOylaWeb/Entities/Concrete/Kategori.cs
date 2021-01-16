using Core.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Kategori:IEntity
    {
        public int KategoriId { get; set; }
        public string KategoriAdi { get; set; }
        public string Aciklama { get; set; }
    }
}
