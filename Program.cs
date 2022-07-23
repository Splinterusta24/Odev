using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Xml;

namespace Odev
{
    internal class Program
    {

        static void Main(string[] args)
        {
        devam:
            try
            {

                Console.WriteLine("Spor Otomasyonuna hoşgeldiniz");
                Console.WriteLine("Hangi Alanda İşlem Yapacaksınız?");
                Console.WriteLine("Futbol(F),Basketbol(B),Voleybol(V)");
                string secim = Console.ReadLine();

                switch (secim.ToUpper())
                {
                    case "F":
                        Console.WriteLine("Oyuncu İşlemleri (O) , Personel İşlemleri(P) ");
                        string secim2 = Console.ReadLine().ToUpper();
                        if (secim2 == "O") 
                        {
                            Console.WriteLine("Futbol Takımı Oyuncu İşlemleri");
                            Console.WriteLine("Ekle(E),Sil(S),Getir(G),MaaşÖde(M),Prim(P),Günceller(U)");
                            string secimA = Console.ReadLine();
                            FutbolTakimi.Oyuncular oyuncular = new FutbolTakimi.Oyuncular(secimA);
                        }
                        else if (secim2 == "P")
                        {
                            Console.WriteLine("Futbol Takımı Personel İşlemleri");
                            Console.WriteLine("Ekle(E),Sil(S),Getir(G),MaaşÖde(M),Günceller(U)");
                            string secimB = Console.ReadLine();
                            FutbolTakimi.Personeller personeller = new FutbolTakimi.Personeller(secimB);
                        }
                        break;
                    case "B":
                        Console.WriteLine("Oyuncu İşlemleri 'O' , Personel İşlemleri(P) ");
                        string secim3 = Console.ReadLine();

                        if (secim3 == "O")
                        {
                            Console.WriteLine("Basketbol Takımı Oyuncu İşlemleri");
                        }
                        else if (secim3 == "P")
                        {
                            Console.WriteLine("Basketbol Takımı Personel İşlemleri");
                        }
                        break;
                    case "V":
                        Console.WriteLine("Oyuncu İşlemleri 'O' , Personel İşlemleri(P) ");
                        string secim4 = Console.ReadLine();
                        if (secim4 == "O")
                        {
                            Console.WriteLine("Voleybol Takımı Oyuncu İşlemleri");
                        }
                        else if (secim4 =="P")
                        {
                            Console.WriteLine("Voleybol Takımı Personel İşlemleri");

                        }
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("HATA!!");
                Console.WriteLine("Sebepleri:");
                string date = DateTime.Now.ToString();
                Console.WriteLine(date + "\n");
                Console.WriteLine(e.Message + "\n");
                Console.WriteLine(e.StackTrace + "\n");
                Console.WriteLine(e.HelpLink + "\n");
                Console.WriteLine("Program baştan başlıyor...");
                goto devam;
            }



        }
    }
}
