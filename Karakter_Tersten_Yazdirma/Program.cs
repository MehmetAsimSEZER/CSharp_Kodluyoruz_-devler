using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Kodluyoruz_Ödevler
{
    class Karakter_Tersten_Yazdirma
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen metin girişi yapınız: ");
            string text = Console.ReadLine();
            string[] Text = text.Split(' ');
            ReverseWrite(Text);
        }

        public static void ReverseWrite(string[] Text)
        {

            foreach (string item in Text)
            {
                for (int i = item.Length - 1; i >= 0; i--)
                {
                    Console.Write(item[i]);
                }
                Console.Write(" ");
            }

        }
    }
}