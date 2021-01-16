using Core.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class KitapDetay:IDto
    {
        public int Id { get; set; }
        public string KitapAdi { get; set; }
        public string Yazar { get; set; }
        public string KategoriAdi { get; set; }
        public string Yorumlar { get; set; }
        public string YorumAdi { get; set; }
         public int Puan { get; set; }

    }
}
