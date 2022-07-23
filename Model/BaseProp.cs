using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev.Model
{
    internal abstract class BaseProp
    {
        public string AdSoyad { get; set; }
        public int Yas { get; set; }
        public decimal Maas { get; set; }
        public decimal Boyu { get; set; }
        public string Gorev { get; set; }
        public DateTime SozlesmeBitis { get; set; }
        public string Mevki { get; set; }
        public int FormaNo { get; set; }
    }
}
