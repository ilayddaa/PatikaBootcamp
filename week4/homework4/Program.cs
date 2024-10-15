public class Araba
{
    private string _marka; // field
    private string _model;
    private string _renk;
    private int _kapiSayisi;

    public string Marka // property
    {
        get { return _marka; }
        set { _marka = value; }
    }
    public string Model
    {
        get { return _model; }
        set { _model = value; }
    }
    public string Renk
    {
        get { return _renk; }
        set { _renk = value; }
    }
    public int KapiSayisi
    {
        get { return _kapiSayisi; }
        set
        {
            if (value == 2 || value == 4)
            {
                _kapiSayisi = value;
            }
            else
            {
                Console.WriteLine("Araba kapı sayısı 2 veya 4 olabilir.");
                _kapiSayisi = -1;
            }
        }
    }
    public Araba(string marka, string model, string renk, int kapiSayisi) // constructor parametreleri
    {
        Marka = marka;
        Model = model;
        Renk = renk;
        KapiSayisi = kapiSayisi;
    }
    public void Bilgi() // Araba bilgilerini consola yazan method
    {
        Console.WriteLine($"Araba Markası: {Marka} \nAraba Modeli: {Model} \nAraba Rengi: {Renk} \nKapı Sayısı: {KapiSayisi}");
    }
}
public class Program
{
    public static void Main() // Main method
    {
        Console.Clear();
        Araba araba1 = new Araba("Mercedes", "C200", "Kırmızı", 4);
        araba1.Bilgi();
        Console.WriteLine("-------------------------------------------------");
        Araba araba2 = new Araba("BMW", "X6", "Siyah", 2);
        araba2.Bilgi();
        Console.WriteLine("-------------------------------------------------");
        Araba araba3 = new Araba("Audi", "A3", "Beyaz", 3); // 3 kapılı araba olamayacağı için -1 dönecek
        araba3.Bilgi();
        Console.ReadKey();
    }
}
