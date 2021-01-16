using Entities.Concrete;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebUI.Models
{
    public class KitapListViewModel
    {
        public int Puan { get; set; }
        public string KitapAdi { get; set; }
        public string Yorum { get; set; }
        public string YorumAdi { get; set; }
        public int YorumId { get; set; }
        public string KategoriAdi { get; set; }
        public string Resim { get; set; }
        public string Yazar { get; set; }
        public string KitapAciklama { get; set; }
        public List<Kitap> Kitap { get; set; }
        public List<Yorumlar> Yorumlar { get; set; }

    }
}
