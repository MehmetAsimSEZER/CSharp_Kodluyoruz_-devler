using System;

namespace CSharp_Kodluyoruz_Ödevler
{
    class Ucgen_Ciz
    {
        static void Main(string[] args)
        {
            Console.Write("Üçgenin yüksekliğini giriniz.");
            int yukseklik = int.Parse(Console.ReadLine());
            Metotlar metotlar = new Metotlar();
            metotlar.ucgenCiz(yukseklik);
            Console.ReadKey();
        }
    }

    public class Metotlar
    {
        public void ucgenCiz(int yukseklik)
        {
            for (int i = 1; i <= yukseklik; i++)
            {
                for (int j = 0; j < yukseklik-i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < 2*i-1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
