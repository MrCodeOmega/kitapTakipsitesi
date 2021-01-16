using Core.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Kitap:IEntity
    {
        public int Id { get; set; }
        public string KitapAdi { get; set; }
        public int KategoriId { get; set; }
        public string KategoriAdi { get; set; }
        public string Yazar { get; set; }
        public string Resim { get; set; }
        public int Puan { get; set; }
        public int YorumId { get; set; }
        public string KitapAciklama { get; set; }


    }
}
