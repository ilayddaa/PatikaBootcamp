using System.ComponentModel;

Console.Clear(); // clear console temizler.
Console.WriteLine(@"Merhaba
Nasılsın ?
İyiyim
Sen nasılsın ?");
//----------------------------------------------------------------1.
int sayi = 155;
string metin = "komşumdan nefret ediyorum";
Console.WriteLine($"Sayı: {sayi}, Metin: {metin}");
//----------------------------------------------------------------2.
Random rnd = new Random();
int sayi1 = rnd.Next(1, 100);
Console.WriteLine($"Üretilen sayı: {sayi1}"); // $ işareti ile string içinde değişken kullanımı.
//----------------------------------------------------------------3.
Random rnd1 = new Random();
int sayi2 = rnd1.Next(1, 100);
Console.WriteLine("Üretilen sayının üçe bölümünden kalan: " + (sayi2 % 3)); // üçe bölümünden kalanı bulma.
//----------------------------------------------------------------4.
Console.Write("Lütfen yaşınızı giriniz");
int yas = Convert.ToInt32(Console.ReadLine());
if (yas >= 18)
{
    Console.WriteLine("Yetişkinsiniz.");
}
else
{
    Console.WriteLine("Çocuksunuz.");
}
//----------------------------------------------------------------5.
for (int i = 1; i <= 10; i++) // 1 den 10 a kadar olan döngüyü oluşturur.
{
    Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
}
//----------------------------------------------------------------6.
Console.Write("Lütfen bir isim giriniz: ");
string isim1 = Console.ReadLine();
Console.Write("Lütfen bir isim daha giriniz: ");
string isim2 = Console.ReadLine();
string bos = isim1;
isim1 = isim2;
isim2 = bos;
Console.WriteLine($"İlk isim : {isim1}, İkinci isim: {isim2}");
//----------------------------------------------------------------7.

void BenDegerDondurmem() // void metotlar değer döndürmez.
{
    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
}
BenDegerDondurmem(); // void metot çağrısı.
//----------------------------------------------------------------8.

int Topla(int sayi, int sayi1) // int tipinde iki parametre alan ve toplama işlemi yapan metot.
{
    return sayi + sayi1; // return ile metottan döndürülen değer.
}
int toplam = Topla(3, 6); // metot çağrısı.
Console.WriteLine($"Toplam: {toplam}");
//----------------------------------------------------------------9.
string Secenek(bool a)
{
    if (a == true)
    {
        return "Evet";
    }
    else
    {
        return "Hayır";
    }
}
//string sonuc = Secenek(false);
//Console.WriteLine(Secenek(true)); // metot çağrısı.
Console.Write("Lütfen bir seçim yapınız (true/false): ");
bool secim = Convert.ToBoolean(Console.ReadLine()); // boolean tipinde kullanıcıdan veri alır.
Console.WriteLine(Secenek(secim));
//----------------------------------------------------------------10.
Console.Write("Lütfen 1. yaşı giriniz: ");
int yas1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Lütfen 2. yaşı giriniz: ");
int yas2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Lütfen 3. yaşı giriniz: ");
int yas3 = Convert.ToInt32(Console.ReadLine());
int enBuyuk = Math.Max(yas1, yas2); // Math.Max ile en büyük sayıyı bulma.
enBuyuk = Math.Max(enBuyuk, yas3);
Console.WriteLine($"En büyük yaş: {enBuyuk}");
//----------------------------------------------------------------11.
int maxSayi = int.MinValue; // int tipinde en küçük değer.
while (true)
{
    Console.Write("Lütfen bir sayı giriniz ve çıkmak için Q yazınız: ");
    string girilen = Console.ReadLine();
    if (girilen == "Q" || girilen == "q")
    {
        break;
    }
    int sayi3 = Convert.ToInt32(girilen);
    if (maxSayi < sayi3)
    {
        maxSayi = sayi3;
    }
}
Console.WriteLine($"En büyük sayı: {maxSayi}");
//----------------------------------------------------------------12.
Console.Write("Lütfen bir isim giriniz: ");
string isim3 = Console.ReadLine();
Console.Write("Lütfen bir isim daha giriniz: ");
string isim4 = Console.ReadLine();
(isim3, isim4) = (isim4, isim3); // tuple ile değişken değerlerini değiştirme.
Console.WriteLine($"İlk isim : {isim3}, İkinci isim: {isim4}");
//----------------------------------------------------------------13.
bool CiftMi(int sayi) // int tipinde parametre alan ve çift mi tek mi olduğunu kontrol eden metot.
{
    return (sayi % 2 == 0);
}
Console.Write("Lütfen bir sayı giriniz: ");
int sayi4 = Convert.ToInt32(Console.ReadLine());
if (CiftMi(sayi4))
{
    Console.WriteLine("Çift sayıdır.");
}
else
{
    Console.WriteLine("Tek sayıdır.");
}
//----------------------------------------------------------------14.
int Mesafe(int hiz, int zaman) // int tipinde iki parametre alan ve hızla zamanı çarparak mesafeyi bulan metot.
{
    return hiz * zaman; // hızla zamanı çarparak mesafeyi bulma.
}
Console.Write("Lütfen hızınızı giriniz km/s: ");
int hiz = Convert.ToInt32(Console.ReadLine());
Console.Write("Lütfen zaman giriniz: ");
int zaman = Convert.ToInt32(Console.ReadLine());
int yol = Mesafe(hiz, zaman);
Console.WriteLine($"Gidilen yol: {yol} km");
//----------------------------------------------------------------15.
double Alan(int yaricap)
{
    return Math.PI * yaricap * yaricap; // Math.PI ile pi sayısını kullanma.
}
Console.Write("Lütfen yarıçapı giriniz: ");
int yaricap = Convert.ToInt32(Console.ReadLine()); // kullanıcıdan yarıçap alır.
double alan = Alan(yaricap); // metot çağrısı.
Console.WriteLine($"Dairenin alanı: {alan}"); // alanı ekrana yazdırma.
//----------------------------------------------------------------16.
string metin2 = "Zaman bir GeRi SayIm";
Console.WriteLine(metin2.ToLower()); // ToLower ile metni küçük harfe çevirir.)
Console.WriteLine(metin2.ToUpper()); // ToUpper ile metni büyük harfe çevirir.
//----------------------------------------------------------------17.

string metin3 = "           Selamlar                  ";
Console.WriteLine(metin3.Trim()); // Trim ile metnin başındaki ve sonundaki boşlukları siler.
//----------------------------------------------------------------18.


Console.ReadKey(); // Kullanıcı bir tuşa basana kadar programın kapanmamasını sağlar.