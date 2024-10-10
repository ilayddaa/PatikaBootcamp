void SarkiSozu() // void tipinde bir fonksiyon oluşturduk. void tipinde fonksiyonlar geriye değer döndürmez.
{
    Console.WriteLine("İnsan hak ettiğini bulur günün birinde");
}
SarkiSozu(); // Fonksiyonu çağırdık.
//---------------------------------------------------------1.

int RastgeleSayi()
{
    Random rnd = new Random(); // Random sınıfından bir nesne oluşturduk.
    int sayi = rnd.Next(1, 100); // 1 ile 100 arasında rastgele bir sayı oluşturduk.

    return sayi / 2; // Oluşturduğumuz sayıyı 2'ye böldük ve sonucu geri döndürdük.
}

int sayi = RastgeleSayi(); // Fonksiyonu çağırdık ve dönen değeri number değişkenine atadık.
Console.WriteLine($"Rastgele sayının yarısı: {sayi}"); // number değişkenini ekrana yazdırdık.
// Console.WriteLine(RastgeleSayi()); Fonksiyonu çağırdık ve dönen değeri ekrana yazdırdık.
//---------------------------------------------------------2.

int Carpim(int number1, int number2) // int tipinde iki parametre alan bir fonksiyon oluşturduk.
{
    return number1 * number2;
}
int sonuc = Carpim(10, 6); // Fonksiyonu çağırdık ve dönen değeri sonuc değişkenine atadık.
Console.WriteLine($"10 ile 6'nın çarpımı: {sonuc}"); // sonuc değişkenini ekrana yazdırdık. // $ işareti ile string interpolation yaparak değişkenleri yazdırdık.
//---------------------------------------------------------3.

void Hello(string name, string surname) // void tipinde iki parametre alan bir fonksiyon oluşturduk.
{
    Console.WriteLine($"Merhaba {name} {surname}"); // string interpolation ile parametreleri ekrana yazdırdık.
}
Hello("Eylül", "Uncertain"); // Fonksiyonu çağırdık ve parametreleri gönderdik.
//---------------------------------------------------------4.
