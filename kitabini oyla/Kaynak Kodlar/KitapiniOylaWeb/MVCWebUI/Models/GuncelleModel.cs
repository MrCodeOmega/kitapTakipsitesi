using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebUI.Models
{
    public class GuncelleModel
    {
        public int Id { get; set; }
        public int Puan { get; set; }

        [Required(ErrorMessage = "Kitap İsmi Giriniz.!")]
        public string KitapAdi { get; set; }
        [Required(ErrorMessage = "Kitap Yazarı Giriniz.!")]
        public string Yazar { get; set; }
        [Required(ErrorMessage = "Kategori Giriniz.!")]
        public string Kategori { get; set; }

        public string Resim { get; set; }
        public int YorumId { get; set; }
        public int KategoriId { get; set; }


    }
}
