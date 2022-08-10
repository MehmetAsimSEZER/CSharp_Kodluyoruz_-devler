using System;

namespace CSharp_Kodluyoruz_Ödevler
{
    class Alan_Hesapla
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Cisimler cisimler = new Cisimler();

                Console.WriteLine("İslem yapmak istediğiniz geometrik şekli seçin");
                Console.WriteLine("**********************************************");
                Console.WriteLine("Dikdört için 1 ");
                Console.WriteLine("Kare için 2 ");
                Console.WriteLine("Üçgen için 3");
                Console.WriteLine("Daire için 4");

                int cisimSecimi = int.Parse(Console.ReadLine());
                switch (cisimSecimi)
                {
                    case 1:
                        cisimler.Dikdortgen();
                        Console.ReadKey();
                        break;
                    case 2:
                        cisimler.Kare();
                        Console.ReadKey();
                        break;
                    case 3:
                        cisimler.Ucgen();
                        Console.ReadKey();
                        break;
                    case 4:
                        cisimler.Daire();
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Şekil seçimi hatalı ");
                        Console.WriteLine("Tekrar seçim yapmak için bir tuşa basın ");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }

    public class Cisimler
    {
        public void Dikdortgen()
        {
            Console.WriteLine("Alan Hesabı için 1");
            Console.WriteLine("Çevre Hesabı için 2");
            Console.WriteLine("Hacim Hesabı için 3");

            int secim = int.Parse(Console.ReadLine());
            int kenar1;
            int kenar2;
            int h;

            if (secim == 1)
            {
                Console.WriteLine("Dikdörtgenin 1. kenar uzunluğunu girin ");
                kenar1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Dikdörtgenin 2. Kenar uzunluğunu girin ");
                kenar2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Dikdörtgenin Alanı : " + (kenar1 * kenar2));
            }
            else if (secim == 2)
            {
                Console.WriteLine("Dikdörtgenin 1. kenar uzunluğunu girin ");
                kenar1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Dikdörtgenin 2. Kenar uzunluğunu girin ");
                kenar2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Dikdörtgenin Çevresi :" + (kenar1 + kenar2) * 2);
            }
            else if (secim == 3)
            {
                Console.WriteLine("Dikdörtgenin 1. kenar uzunluğunu girin ");
                kenar1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Dikdörtgenin 2. Kenar uzunluğunu girin ");
                kenar2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Dikdörtgenin yüksekliğini girin ");
                h = int.Parse(Console.ReadLine());

                Console.WriteLine("Dikdörtgenini Hacmi : " + (kenar1 * kenar2 * h));
            }
            else
            {
                Console.WriteLine("Seçim Gerçekleştirilemedi");
            }
        }

        public void Kare()
        {
            Console.WriteLine("Alan Hesabı için 1");
            Console.WriteLine("Çevre Hesabı için 2");
            Console.WriteLine("Hacim Hesabı için 3");

            int secim = int.Parse(Console.ReadLine());
            int kenar;

            if (secim == 1)
            {
                Console.WriteLine("Kenar uzunluğunu girin : ");
                kenar = int.Parse(Console.ReadLine());

                Console.WriteLine("Karenin alanı : " + (kenar * kenar));
            }
            else if (secim == 2)
            {
                Console.WriteLine("Kenar uzunluğunu girin : ");
                kenar = int.Parse(Console.ReadLine());

                Console.WriteLine("Karenin Çevresi : " + (kenar * 4));
            }
            else if (secim == 3)
            {
                Console.WriteLine("Kenar uzunluğunu girin : ");
                kenar = int.Parse(Console.ReadLine());

                Console.WriteLine("Küpün hacmi : " + (kenar * kenar * kenar));
            }
            else
            {
                Console.WriteLine("Seçim işlemi Gerçekleştirilemedi");
            }
        }

        public void Ucgen()
        {
            Console.WriteLine("Alan Hesabı için 1");
            Console.WriteLine("Çevre Hesabı için 2");
            Console.WriteLine("Hacim Hesabı için 3");

            int secim = int.Parse(Console.ReadLine());
            int kenar1;
            int kenar2;
            int kenar3;
            int h;

            if (secim == 1)
            {
                Console.WriteLine("Üçgenin taban uzunluğu : ");
                kenar1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Üçgenin Yüksekliği : ");
                h = int.Parse(Console.ReadLine());

                Console.WriteLine("Üçgenin alanı : " + (kenar1 * h) / 2);
            }
            else if (secim == 2)
            {
                Console.WriteLine("Üçgenin 1.kenar uzunluğu : ");
                kenar1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Üçgenin 2.kenar uzunluğu : ");
                kenar2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Üçgenin 3.kenar uzunluğu : ");
                kenar3 = int.Parse(Console.ReadLine());

                Console.WriteLine("Üçgenin Çevresi : " + (kenar1 + kenar2 + kenar3));

            }
            else if (secim == 3)
            {
                Console.WriteLine("Üçgenin taban uzunluğu : ");
                kenar1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Üçgenin Yüksekliği : ");
                kenar2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Prizmanın yüksekliği ");
                h = int.Parse(Console.ReadLine());

                Console.WriteLine("Üçgenler prizmasının hacmi : " + ((kenar1 * kenar2) / 2) * h);
            }
            else
            {
                Console.WriteLine("Seçim işlemi Gerçekleştirilmedi");
            }
        }

        public void Daire()
        {
            Console.WriteLine("Alan Hesabı için 1");
            Console.WriteLine("Çevre Hesabı için 2");
            Console.WriteLine("Hacim Hesabı için 3");

            int secim = int.Parse(Console.ReadLine());
            int yaricap;

            if (secim == 1)
            {
                Console.WriteLine("Dairenin Yarı Çapını Girin : ");
                yaricap = int.Parse(Console.ReadLine());

                Console.WriteLine("Dairenin Alanı : " + (yaricap * yaricap * 3.14));
            }
            else if (secim == 2)
            {
                Console.WriteLine("Dairenin Yarı Çapını Girin : ");
                yaricap = int.Parse(Console.ReadLine());

                Console.WriteLine("Dairenin Çevresi : " + (2 * 3.14 * yaricap));
            }
            else if (secim == 3)
            {
                Console.WriteLine("Dairenin Yarı Çapını Girin : ");
                yaricap = int.Parse(Console.ReadLine());

                Console.WriteLine("Kürenin Hacmi : " + ((yaricap * yaricap * yaricap) * ( 3.14 * 4 / 3)));
            }
            else
            {
                Console.WriteLine("Seçim İşlemi Gerçekleştirilmedi ");
            }
        }
    }
}