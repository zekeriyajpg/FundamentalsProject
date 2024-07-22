using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_FundamentalsProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int hedef = random.Next(1, 101);
            int can = 5;

            Console.WriteLine("lütfen 1 ile 100 arasında sayı giriniz");
            while (can > 0)
            {
                Console.Write("Tahmininiz : ");
                string cikis = Console.ReadLine();

                try
                {
                    int tahmin = Convert.ToInt32(cikis);
                    if (tahmin < 1 || tahmin > 100)
                    {
                        Console.WriteLine("lütfen 1 ile 100 arasında bir sayı girin");

                    }
                    else if (tahmin == hedef)
                    {
                        Console.WriteLine("doğru tahin ");
                        break;
                    }
                    else if (tahmin < hedef)
                    {
                        Console.WriteLine("daha yüksek bir sayı tahmin edin");

                    }
                    else
                    {
                        Console.WriteLine("daha büyük bir sayı tajmin edin");

                    }
                    can--;
                    Console.WriteLine($"kalan canınız {can}");

                }
                catch (FormatException)
                {
                    Console.WriteLine("Geçersiz giriş. Lütfen bir sayı girin.");
                }


            }

            if (can == 0)
            {
                Console.WriteLine($"üzgünüm kaybettiniz doğru sayı :{hedef}");
            }

            Console.WriteLine("-------------------------------------------------");

            try
            {
                Console.Write("lütfen 1. sayıyı giriniz : ");
                int say1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("lütfen 2. sayıyı giriniz : ");
                int say2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Yapmak istediğiniz işlemi seçin:");
                Console.WriteLine("Toplama için +");
                Console.WriteLine("Çıkarma için -");
                Console.WriteLine("Çarpma için *");
                Console.WriteLine("Bölme için /");
                char islem = Convert.ToChar(Console.ReadLine());

                double sonuc = 0;
                bool islemyap = true;

                switch (islem)
                {
                    case '+':
                        sonuc = say1 + say2;
                        Console.WriteLine($"Sonuç: {sonuc}");
                        break;
                    case '-':
                        sonuc = say1 - say2;
                        Console.WriteLine($"Sonuç: {sonuc}");
                        break;
                    case '*':
                        sonuc = say1 * say2;
                        Console.WriteLine($"Sonuç: {sonuc}");
                        break;
                    case '/':
                        if (say2 == 0)
                        {
                            Console.WriteLine("0 a bölünme hatası");
                        }
                        else
                        {
                            sonuc = (double)say1 / say2;
                        }
                        break;

                    default:
                        Console.WriteLine("geçersiz işlem seçimi");
                        islemyap = false;
                        break;


                }
                if (islemyap && islem != '/')
                {
                    Console.WriteLine($"sonuç : {sonuc}");

                }
            }
            catch (FormatException)
            {
                Console.WriteLine("geçersiz giriş geçerli sayı giriniz");
            }
            Console.WriteLine("----------------------------------------");
            try
            {
                // Kullanıcıdan üç ders notunu al
                Console.Write("Birinci ders notunu girin: ");
                int not1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("İkinci ders notunu girin: ");
                int not2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Üçüncü ders notunu girin: ");
                int not3 = Convert.ToInt32(Console.ReadLine());

                // Notların geçerliliğini kontrol et
                if ((not1 < 0 || not1 > 100) || (not2 < 0 || not2 > 100) || (not3 < 0 || not3 > 100))
                {
                    Console.WriteLine("Hata: Notlar 0 ile 100 arasında olmalıdır.");
                    return; // Programı sonlandır
                }

                // Notların ortalamasını hesapla
                double ortalama = (not1 + not2 + not3) / 3.0;
                Console.WriteLine($"Notların ortalaması: {ortalama:F2}");

                // Harf notunu belirle
                string harfNotu;

                if (ortalama >= 90)
                    harfNotu = "AA";
                else if (ortalama >= 85)
                    harfNotu = "BA";
                else if (ortalama >= 80)
                    harfNotu = "BB";
                else if (ortalama >= 75)
                    harfNotu = "CB";
                else if (ortalama >= 70)
                    harfNotu = "CC";
                else if (ortalama >= 65)
                    harfNotu = "DC";
                else if (ortalama >= 60)
                    harfNotu = "DD";
                else if (ortalama >= 55)
                    harfNotu = "FD";
                else
                    harfNotu = "FF";

                Console.WriteLine($"Harf notunuz: {harfNotu}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Geçersiz giriş. Lütfen geçerli bir sayı girin.");
            }
            Console.WriteLine("----------------------------------------");







        }
    }
}
