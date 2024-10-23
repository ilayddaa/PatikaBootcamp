Console.Clear();
bool gecerli = false; // girişin doğruluğunu kontrol etmek için bir değişken tanımladık
while (!gecerli)
{
    try // hata verirse catch ile yakalıyoruz
    {
        Console.Write("Lütfen sayı giriniz: ");
        int sayi = Convert.ToInt32(Console.ReadLine()); // kullanıcıdan sayı girişi alıyoruz
        gecerli = true; // doğru giriş yapıldıysa döngüden çık
        Console.WriteLine("Girdiğiniz sayının karesi: " + sayi * sayi); // girilen sayının karesini yazdırıyoruz
    }
    catch // hata verirse catch ile yakalıyoruz
    {
        Console.WriteLine("Hatalı bir giriş yaptınız, lütfen tekrar deneyiniz.");
    }
}
Console.ReadKey();