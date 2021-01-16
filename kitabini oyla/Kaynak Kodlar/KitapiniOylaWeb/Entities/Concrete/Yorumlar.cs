using Core.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Yorumlar:IEntity
    {
        public int Id { get; set; }
        public int YorumId { get; set; }
        public string KitapAdi { get; set; }
        public string Yorum { get; set; }
        public string YorumAdi { get; set; }
    }
}
