using System;

namespace CSharp_Kodluyoruz_Odevler
{
    class Sessiz_Harf
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cümle girin.");
            string metin = Console.ReadLine();
            string[] text = metin.Split(' ');
            Metotlar metotlar = new Metotlar();
            metotlar.sessizHarf(text);

        }
    }

    public class Metotlar
    {
        public void sessizHarf(string[] text)
        {
            foreach (var item in text)
            {
                bool sonuc = false;

                for (int i = 1; i < item.Length; i++)
                {
                    if (sesliHarf(item[i]) == sesliHarf(item[i - 1]))
                        sonuc = true;
                }
                Console.Write(sonuc + " ");
            }
        }


        bool sesliHarf(char c)
        {
            return !"aeıioöuü".ToCharArray().Contains(c);
        }
    }
}
