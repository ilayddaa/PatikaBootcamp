
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

public class Program
{
    public static void Main()
    {
        Console.Clear();
        Ogretmen ogretmen = new Ogretmen("Eda", "Yılmaz", "5000");
        ogretmen.Bilgi();
        Console.WriteLine("-------------------------------------------------");
        Ogrenci ogrenci = new Ogrenci("Ayşe", "Yılmaz", 1234);
        ogrenci.Bilgi();
        Console.ReadKey();
    }
}

public class BaseKisi
{
    public string Ad { get; set; }
    public string Soyad { get; set; }

    public BaseKisi(string ad, string soyad) // BaseKisi class'ının constructor'ı
    {
        Ad = ad; // Ad property'sine ad değerini atadık
        Soyad = soyad;
    }
    public void Bilgi() // Kişinin bilgilerini consola yazan method
    {
        Console.WriteLine($"Ad: {Ad} Soyad: {Soyad}");
    }

}
public class Ogrenci : BaseKisi
{
    public Ogrenci(string _ad, string _soyad, int _okulno) : base(_ad, _soyad) // BaseKisi class'ından ad ve soyad parametrelerini alarak nesne oluşturduk.
    {
        OkulNumarasi = _okulno;
    }

    public int OkulNumarasi { get; set; }

    public void Bilgi()
    {
        base.Bilgi();
        Console.WriteLine($"Okul Numarası: {OkulNumarasi}");
    }
}
public class Ogretmen : BaseKisi
{
    public Ogretmen(string _ad, string _soyad, string _maas) : base(_ad, _soyad)
    {
        Maas = _maas;
    }
    public string Maas { get; set; }

    public void Bilgi()
    {
        base.Bilgi();
        Console.WriteLine($"Maaş: {Maas}");
    }
}
