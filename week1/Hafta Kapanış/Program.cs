// See https://aka.ms/new-console-template for more information

using System;
using System.Net.Sockets;
using System.Transactions;
namespace kapanıs
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Merhaba Dünya!"); // Birinci programımım. Merhaba Dünya yazdırrıyoruz.

            //--------------------------------------------------------------

            int a = 5; // a değişkenine 5 değerini atadık.
            int b = 8;
            int c = a + b; // c değişkenine a ve b değişkenlerinin toplamını atadık.
            Console.WriteLine(c); // c değişkenini ekrana yazdırdık.
                                  // İkinci programımız. İki sayının toplamını ekrana yazdırıyoruz.

            // --------------------------------------------------------------

            Console.Write("Lütfen yaşınızı giriniz: ");
            int yas = Convert.ToInt32(Console.ReadLine());

            if (yas < 18)
            {
                Console.WriteLine("Çocuksunuz.");
            }
            else
            {
                Console.WriteLine("Yetişkinsiniz.");
            }
            // Üçüncü programımız. Kullanıcıdan yaş bilgisi alıp, yaşa göre ekrana çıktı veriyoruz.

            // --------------------------------------------------------------

            Console.Write("Lütfen bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi % 2 == 0)
            {
                Console.WriteLine("Girdiğiniz sayı çifttir.");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı tektir.");
            }
            // Dördüncü programımız. Kullanıcıdan bir sayı alıp, sayının çift mi yoksa tek mi olduğunu ekrana yazdırıyoruz.

            // --------------------------------------------------------------

            Console.Write("Lütfen sıcaklık değerini giriniz: ");
            int sicaklik = Convert.ToInt32(Console.ReadLine());
            if (sicaklik < 0)
            {
                Console.WriteLine("Hava soğuk.");
            }
            else if (sicaklik >= 0 && sicaklik < 30)
            {
                Console.WriteLine("Hava normal.");
            }
            else if (sicaklik >= 30)
            {
                Console.WriteLine("Hava sıcak.");
            }
            // Beşinci programımız. Kullanıcıdan sıcaklık bilgisi alıp, sıcaklık durumuna göre ekrana çıktı veriyoruz.

            // --------------------------------------------------------------

            Console.WriteLine("Lütfen bir gün numarası giriniz: ");
            Console.WriteLine("1-7 arasında bir sayı giriniz!");
            int gun = Convert.ToInt32(Console.ReadLine());

            switch (gun)
            {
                case 1:
                    Console.WriteLine("Pazartesi.");
                    break;

                case 2:
                    Console.WriteLine("Salı.");
                    break;

                case 3:
                    Console.WriteLine("Çarşamba.");
                    break;

                case 4:
                    Console.WriteLine("Perşembe.");
                    break;

                case 5:
                    Console.WriteLine("Cuma.");
                    break;

                case 6:
                    Console.WriteLine("Cumartesi.");
                    break;

                case 7:
                    Console.WriteLine("Pazar.");
                    break;

                default:
                    Console.WriteLine("Geçersiz Gün.");
                    break;
            }
            // Altıncı programımız. Switch-case yapısı ile gün bilgisine göre ekrana çıktı veriyoruz.

            // --------------------------------------------------------------

            Console.Write("Lütfen puanınızı giriniz: ");
            int puan = Convert.ToInt32(Console.ReadLine());
            if (puan >= 0 && puan <= 60)
            {
                Console.WriteLine("Başarısız.");
            }
            else if (puan > 60 && puan <= 80)
            {
                Console.WriteLine("Orta.");
            }
            else if (puan > 80 && puan <= 100)
            {
                Console.WriteLine("Başarılı.");
            }
            // Yedinci programımız, Kullanıcıdan puaan bilgisi alıp, puan durumuna göre ekrana çıktı veriyoruz.

            // --------------------------------------------------------------

            Console.WriteLine("Ay No: ");
            Console.WriteLine("Lütfen 1-12 arasında bir sayı giriniz!");
            int ay = Convert.ToInt32(Console.ReadLine());
            int adet;


            switch (ay)
            {
                case 2:
                    adet = 28;
                    break;

                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    adet = 31;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    adet = 30;
                    break;

                default:
                    Console.WriteLine("Geçersiz ay no.");
                    Console.ReadKey();
                    return;
            }

            Console.WriteLine("Girilen ay  " + adet + " gün vardır.");
            // Sekizinci programımız. Switch-case yapısı ile ay bilgisine göre gün sayısını ekrana yazdırıyoruz.

            // --------------------------------------------------------------

            int sifre = 1903;
            Console.WriteLine("Lütfen şifrenizi giriniz: ");
            int girilenSifre = Convert.ToInt32(Console.ReadLine());
            if (sifre == girilenSifre)
            {
                Console.WriteLine("Şifre Başarılı.");
            }
            else
            {
                Console.WriteLine("Şifre Başarısız!");
            }
            // Dokuzuncu programımız, şifre kontrolü yaparak ekrana çıktı veriyoruz.

            // --------------------------------------------------------------


        }

    }

}



