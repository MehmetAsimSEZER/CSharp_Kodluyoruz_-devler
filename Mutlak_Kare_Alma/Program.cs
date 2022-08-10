using System;

namespace CSharp_Kodluyoruz_Ödevler
{
    class Mutlak_Kare_Alma
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N tane 2'li sayı girin");
            string metin = Console.ReadLine();
            string[] sayilar = metin.Split(" ");
            Metotlar metotlar = new Metotlar();
            metotlar.hesapla(sayilar);
        }
    }

    public class Metotlar
    {
        public void hesapla(string[] sayilar)
        {
            int kucukToplam = 0;
            int buyukToplam = 0;
            int[] kucukler = new int[20];
            int[] buyukler = new int[20];

            for (int i = 0; i < sayilar.Length; i++)
            {
                if (int.Parse(sayilar[i]) < 67)
                {
                    kucukler[i] = 67 - int.Parse(sayilar[i]);
                }
                else if(int.Parse(sayilar[i]) >= 67)
                {
                    int mutlak = int.Parse(sayilar[i]) - 67;
                    buyukler[i] = mutlak * mutlak;
                }
            }

            foreach (var sayi in kucukler)
            {
                kucukToplam += sayi;
            }
            foreach (var sayi in buyukler)
            {
                buyukToplam += sayi;
            }

            Console.WriteLine(kucukToplam);
            Console.WriteLine(buyukToplam);
            Console.ReadKey();
        }
    }
}