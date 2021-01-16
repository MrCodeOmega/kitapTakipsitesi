using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebUI.Models
{
    public class KitapAraModel
    {  
        [Required(ErrorMessage ="Lütfen Kitap ismini girin!")]
        public string KitapAdi { get; set; }
        public int Puan { get; set; }
        public string Yorum { get; set; }
        public string YorumAdi { get; set; }
        public string KategoriAdi { get; set; }
        public string Resim { get; set; }
        public string Yazar { get; set; }
        [Required(ErrorMessage = "Lütfen Kitap ismini girin!")]
        public List<Kitap> Kitap { get; set; }
        public List<Yorumlar> Yorumlar { get; set; }
    }
}
