using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCWebUI.Models
{
    public class YorumSilModel
    {
        public int Id { get; set; }
        public int YorumId { get; set; }
        public string Yorum { get; set; }
        public string YorumAdi { get; set; }
        public List<Yorumlar> Yorumlar { get; set; }
    }
}
