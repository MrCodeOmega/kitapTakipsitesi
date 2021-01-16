using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebUI.Models
{
    public class PuanlamaModel
    {
        public int Puan { get; set; }
        public int Id { get; set; }
        [Required]
        public string  Yorum { get; set; }
        public int YorumId { get; set; }
        [Required]
        public string YorumAdi { get; set; }
        public string  KitapAdi { get; set; }
    }
}
