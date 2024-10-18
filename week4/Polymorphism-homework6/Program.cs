public class BaseGeometrikSekil
{
    public double Genislik { get; set; }
    public double Yukseklik { get; set; }
    public BaseGeometrikSekil(double genislik, double yukseklik) // Constructor. Genişlik ve yükseklik değerlerini alır. 
    {
        Genislik = genislik;
        Yukseklik = yukseklik;
    }
    public virtual double AlanHesapla()
    {
        return Genislik * Yukseklik;
    }
}
public class Kare : BaseGeometrikSekil
{
    public Kare(double genislik, double yukseklik) : base(genislik, yukseklik) // BASE ile yukarıya gönderiyoruz
    {
    }

    public override double AlanHesapla ()
    {
        return Genislik * Genislik;
    }
}
public class Dikdortgen : BaseGeometrikSekil
{
    public Dikdortgen(double genislik, double yukseklik) : base(genislik, yukseklik) // BASE ile yukarıya gönderiyoruz
    {
    }
}
public class Ucgen : BaseGeometrikSekil
{
    public Ucgen(double genislik, double yukseklik) : base(genislik, yukseklik)
    {
    }

    public override double AlanHesapla() //override: üsttekini geçersiz kılıp altta kendine özgü bir şey yapmak
    {
       return (Genislik *  Yukseklik)/ 2;
    }
}

public class Program{
    public static void Main()
    {
        Console.Clear();
        Kare kare = new Kare(5,5);
        Dikdortgen dikdortgen = new Dikdortgen(5,10);
        Ucgen ucgen = new Ucgen(5,10);

        Console.WriteLine("Karenin alanı: " + kare.AlanHesapla());
        Console.WriteLine("Dikdörtgenin alanı: " + dikdortgen.AlanHesapla());
        Console.WriteLine("Üçgenin alanı: " + ucgen.AlanHesapla());
        Console.ReadKey();
    }
}

