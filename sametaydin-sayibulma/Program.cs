using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sametaydin_sayibulma
{

    class Program
    {
        static Random rastgele = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Seviye seçiniz \n1-Kolay: \n2-Orta: \n3-Zor:");
            byte seviye = byte.Parse(Console.ReadLine());
            int hak = 0;
            int enKucuk = 0, enBuyuk = 0;
            switch (seviye)
            {
                case 1:
                    hak = 10;
                    enKucuk = 1;
                    enBuyuk = 25;
                    break;
                case 2:
                    hak = 5;
                    enKucuk = 1;
                    enBuyuk = 50;
                    break;
                case 3:
                    hak = 3;
                    enKucuk = 1;
                    enBuyuk = 100;
                    break;
            }
            int tahmin, sayi = rastgele.Next(enBuyuk);
            while (true)
            {
                Console.WriteLine("\n\n" + hak-- + " hakkınız var.");
                if (hak < 0)
                {
                    Console.WriteLine("KAYBETTİNİZ! Tutulan sayı: " + sayi);
                    break;
                }

                Console.Write(enKucuk + " ile " + enBuyuk + " arası bir sayı giriniz: ");
                tahmin = Convert.ToInt32(Console.ReadLine());

                if (tahmin > sayi)
                {
                    if (tahmin < enBuyuk)
                    {
                        enBuyuk = tahmin;
                    }
                }
                else if (tahmin < sayi)
                {
                    if (tahmin > enKucuk)
                    {
                        enKucuk = tahmin;
                    }
                }
                else
                {
                    Console.WriteLine("Tebrikler doğru bildiniz!");
                    break;
                }

            }
            Console.ReadKey();

        }

    }
}

