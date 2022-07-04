using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okulyonetim.App.Entities
{
   public class Ogrenci:OkulBase
    {
        public int Id { get; set; }
        public int Okulno { get; set; }
        public int? OgretmenId { get; set; }
        public int? ServisId { get; set; }
    }
}
