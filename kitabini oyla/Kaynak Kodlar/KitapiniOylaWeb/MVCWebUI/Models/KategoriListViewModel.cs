using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebUI.Models
{
    public class KategoriListViewModel
    {

        public List<Kategori> Kategoriler { get; set; }
        public int currentKategori { get; set; }
    }
}
