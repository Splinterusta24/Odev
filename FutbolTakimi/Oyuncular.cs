using Odev.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev.FutbolTakimi
{
    internal class Oyuncular : BaseProp,IMetodlar1,IMetodlar2
    {
        public Oyuncular(string x)
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
            Console.WriteLine("Yaşı?");
            Yas = int.Parse(Console.ReadLine());
            Console.WriteLine("Mevki?");
            Mevki = Console.ReadLine();
            Console.WriteLine("Maaş?");
            Maas = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Sözleşme bitiş tarihi?(GG.AA.YY)");
            SozlesmeBitis.TarihDuzenle();
            SozlesmeBitis = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Forma Numarası");
            FormaNo = int.Parse(Console.ReadLine());
            Console.WriteLine("Oyuncu Eklendi"+"\n" + AdSoyad + "\n" + "yaşı:{0}",Yas + "\n"+ Mevki +"\n" + SozlesmeBitis + "\n" + FormaNo);
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

        public void Prim()
        {
            throw new NotImplementedException();
        }

        public void Sil()
        {
            throw new NotImplementedException();
        }
    }
}
