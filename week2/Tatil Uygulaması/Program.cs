while (true) // Sonsuz döngü oluşturur.
{
    Console.Clear();    // Konsol ekranını temizler.
    Console.WriteLine("Tatil Uygulamsına Hoş Geldiniz!");
    Console.WriteLine("1-New York ");
    Console.WriteLine("2-Londra ");
    Console.WriteLine("3-Paris ");
    Console.Write("Lütfen Gitmek İstediğiniz Yerin Adını Yazınız:");
    string secimYer = (Console.ReadLine() ?? string.Empty).ToLower();
    int fiyatTatil = 0;
    while (fiyatTatil == 0)
    {
        switch (secimYer) // Girilen değere göre işlem yapar.
        {
            case "new york":
            case "1":
                fiyatTatil = 5000;
                Console.WriteLine($"New York'a gitmek için {fiyatTatil}TL ödemeniz gerekmektedir.");
                break;

            case "londra":
            case "2":
                fiyatTatil = 3000;
                Console.WriteLine($"Londra'ya gitmek için {fiyatTatil}TL ödemeniz gerekmektedir.");
                break;

            case "paris":
            case "3":
                fiyatTatil = 3500;
                Console.WriteLine($"Paris'e gitmek için {fiyatTatil}TL ödemeniz gerekmektedir.");
                break;

            default: // Yukarıdaki durumların dışında bir durumda çalışır.
                Console.WriteLine("Hatalı seçim yaptınız.");
                Console.Write("Lütfen Gitmek İstediğiniz Yerin Adını Yazınız:");
                secimYer = (Console.ReadLine() ?? string.Empty).ToLower();
                break; // Döngüyü kırmaz ve tekrar döngü başına döner.
        }
    }
    int kisi = 0;
    Console.Write("Kaç kişiyle gitmek istersiniz: ");
    int.TryParse(Console.ReadLine(), out kisi);

    while (kisi <= 0)
    {
        Console.WriteLine("Hatalı giriş yaptınız. Lütfen tekrar deneyiniz.");
        Console.Write("Kaç kişiyle gitmek istersiniz: ");
        int.TryParse(Console.ReadLine(), out kisi);
    }

    Console.WriteLine("Lütfen ne şekilde gitmek istediğinizi seçiniz.");
    Console.WriteLine("1-Uçak");
    Console.WriteLine("2-Tren");
    Console.Write("Lütfen seçiminizin adını yazınız: ");
    string secimUlasim = (Console.ReadLine() ?? string.Empty).ToLower();
    int fiyatUlasim = 0;
    while (fiyatUlasim <= 0)
    {
        switch (secimUlasim)
        {
            case "uçak":
            case "1":
                fiyatUlasim = 1000;
                break;

            case "tren":
            case "2":
                fiyatUlasim = 500;
                break;

            default:
                Console.WriteLine("Hatalı seçim yaptınız.Tekrar deneyiniz");
                Console.Write("Lütfen seçiminizin adını yazınız: ");
                secimUlasim = (Console.ReadLine() ?? string.Empty).ToLower();
                break;
        }
    }

    Console.WriteLine("--------<3--------");
    Console.WriteLine("Merhaba Değerli Müşterimiz, toplam fiyat bilgisi aşağıdadır.");
    Console.WriteLine($"Toplam ödemeniz gereken tutar: {(fiyatTatil + fiyatUlasim) * kisi}TL'dir.");
    Console.WriteLine("---------<3---------");
    Console.WriteLine("Keyifli bir tatil gerçimenizi dileriz.Tatil sırasında her şey fiyata dahildir.");
    Console.WriteLine("Gidilen her yerde konaklama ve yemekler ücretsizdir.");
    Console.WriteLine("Ödemeniz gerekene ek olarak ulaşım ücreti de dahildir.");
    Console.WriteLine("---------<3---------");


    Console.WriteLine("Yeni bir tatil planlamak ister misiniz? (E/H)");
    string devam = (Console.ReadLine() ?? string.Empty).ToLower();
    if (devam != "e")
    {
        Console.Write("Programdan çıkmak için bir tuşa basınız.");
        Console.ReadKey(); // Kullanıcı bir tuşa basana kadar programın kapanmaması için kullanılır.
        break; // Programı sonlandırır.
    }
}



