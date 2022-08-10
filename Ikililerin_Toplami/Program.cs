using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharp_Kodluyoruz_Ödevler
{
    class Ikililerin_Toplami
    {
        static void Main(string[] args)
        {
            Console.WriteLine("N tane 2'li girin");
            string metin = Console.ReadLine();
            string[] sayilar = metin.Split(" ");
            Metotlar metotlar = new Metotlar();
            metotlar.topla(sayilar);
        }
    }

    public class Metotlar
    {
        public void topla(string[] sayilar)
        {
            int[] sonucListesi = new int[20];

            int kontrol = 1;
            int sayi1;
            int sayi2;

            while (kontrol == 1)
            {
                for (int i = 0; i < sayilar.Length; i += 2)
                {
                    sayi1 = int.Parse(sayilar[i]);
                    sayi2 = int.Parse(sayilar[i + 1]);

                    if (sayi1 != sayi2)
                    {
                        sonucListesi[i] = sayi1 + sayi2;
                    }
                    else
                    {
                        sonucListesi[i] = (sayi1 + sayi2) * (sayi1 + sayi2);
                    }
                }
                kontrol = 0;
            }

            foreach (var item in sonucListesi)
            {
                if (item != 0)
                {
                    Console.Write(item + " ");
                }
            }
            Console.ReadKey();
        }
    }
}