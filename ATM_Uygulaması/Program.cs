using System;

namespace CSharp_Kodluyoruz_Odevler
{
    class ATM_Uygulaması
    {
        static void Main(string[] args)
        {
            Console.WriteLine("UserName giriniz.");
            string UserName = Console.ReadLine();
            Console.WriteLine("Password giriniz.");
            string Password = Console.ReadLine();
            Metotlar metotlar = new Metotlar();
            metotlar.GirisYap(UserName, Password);
            Console.WriteLine("Çekmek istediğiniz tutarı giriniz.");
            int tutar = int.Parse(Console.ReadLine());
            metotlar.ParaCek(tutar);
        }
    }

    public class Metotlar
    {
        string userName = "Asım Sezer";
        string password = "123456789";

        bool SignIn(string UserName, string Password)
        {
            if (UserName == "" || Password == "")
            {
                return false;
                Console.WriteLine("Eksik bilgi girdiniz.");
            }
            else
            {
                return true;
                Console.WriteLine("Bilgiler Doğrulandı.Hoşgeldiniz.");
            }
        }

        public void GirisYap(string userName, string password)
        {
            bool account = SignIn(userName, password);
            {
                if (account == true)
                {
                    Console.WriteLine("Giriş yapıldı.");
                }
                else
                {
                    Console.WriteLine("lütfen bilgilerinizi kontrol ediniz", "hatalı bilgi girdiniz.");
                }
            }
        }

        public void ParaCek(int amount)
        {
            int balance = 5000;
            if (balance >= amount)
            {
                Console.WriteLine($"kalan bakiye:{balance - amount}");
                Console.WriteLine("işlem başarı ile gerçekleştirildi.", "bakiyeniz yeterli");
            }
            else
            {
                Console.WriteLine("işlem başarısız", "bakiyeniz yetersiz");
            }
        }
    }
}