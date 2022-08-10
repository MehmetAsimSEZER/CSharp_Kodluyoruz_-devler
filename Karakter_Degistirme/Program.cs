using System;

namespace CSharp_Kodluyoruz_Ödevler
{
    class Karakter_Degistirme
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir metin giriniz.");
            string metin = Console.ReadLine();
            string[] text = metin.Split(' ');
            Metotlar metotlar = new Metotlar();
            metotlar.karakterDegistirme(text);
        }
    }

    public class Metotlar
    {
        public void karakterDegistirme(string[] text)
        {
            foreach (var item in text)
            {
                char[] chars = item.ToCharArray();
                char temp = chars[0];
                chars[0] = chars[chars.Length - 1];
                chars[chars.Length - 1] = temp;

                string x = "";
                foreach (var chr in chars)
                {
                    x += chr.ToString();
                }
                Console.WriteLine(x + " ");
            }
        }
    }
}