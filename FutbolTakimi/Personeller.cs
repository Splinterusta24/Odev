using Odev.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev.FutbolTakimi
{
    internal class Personeller : BaseProp, IMetodlar1
    {
 
        public Personeller(string x)
        {
            switch (x.ToUpper())
            {
                case "E":
                    Ekle();
                    break;
            }
        }

        public void Ekle()
        {
            Console.WriteLine("Adı Soyadı");
            AdSoyad = Console.ReadLine();
            Console.WriteLine("Görev?");
            Gorev = Console.ReadLine();
            Console.WriteLine("Yaşı?");
            Yas = int.Parse(Console.ReadLine());
            Console.WriteLine("Maaş?");
            Maas = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Oyuncu Eklendi" + "\n" + AdSoyad + "\n" + "yaşı:{0}", Yas + "\n" + Gorev + "\n" + Maas);
        }

        public void Getir()
        {
            throw new NotImplementedException();
        }

        public void Guncelle()
        {
            throw new NotImplementedException();
        }

        public void MaasOde()
        {
            throw new NotImplementedException();
        }

        public void Sil()
        {
            throw new NotImplementedException();
        }
    }
}
