using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Kodluyoruz_Ödevler
{
    class FibonacciOrtalama
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kaç adet sayı isteniyorsa giriniz");
            int adet = int.Parse(Console.ReadLine());
            Metotlar metotlar = new Metotlar();
            metotlar.hesapla(adet);
            Console.ReadKey();
        }

        public class Metotlar
        {
            int a = 0;
            int b = 1;
            int c;
            int toplam = 0;

            public void hesapla(int adet)
            {
                for (int i = 1; i <= adet; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;

                    toplam += c;

                    Console.WriteLine(c);
                }
                Console.WriteLine("Dizinin ortalaması :" + toplam / adet);
            }
        }
    }
}
