using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharp_Kodluyoruz_Ödevler
{
    class Algoritma
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kelime ve sayi giriniz (Algoritma,2) vb.");
            string metin = Console.ReadLine();
            Metotlar metotlar = new Metotlar();
            metotlar.Istek(metin);
            Console.ReadKey();
        }
    }

    public class Metotlar
    {
        public void Istek(string metin)
        {
            int sayac = 0;
            string[] ilkAyrim = metin.Split(",");
            string kelime = ilkAyrim[0];
            int deger = int.Parse(ilkAyrim[1]);
            string[] kelimeDizisi = new string[50];

            foreach (var item in kelime.ToCharArray())
            {
                kelimeDizisi[sayac] = item.ToString();
                sayac++;
            }

            ArrayList kelimeArray = new ArrayList(kelimeDizisi);
            kelimeArray.RemoveAt(deger - 1);

            foreach (var item in kelimeArray)
            {
                Console.Write(item);
            }
        }
    }
}