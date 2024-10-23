public class Araba
{ //Üretim Tarihi, Seri Numarası, Marka, Model, Renk, Kapı Sayısı
    public string Marka { get; set; }
    public string Model { get; set; }
    public string Renk { get; set; }
    public int KapıSayısı { get; set; }
    public DateTime ÜretimTarihi { get; set; }
    public string SeriNumarası { get; set; }
    public Araba(string marka, string model, string renk, int kapıSayısı, string seriNumarası)
    {
        Marka = marka;
        Model = model;
        Renk = renk;
        KapıSayısı = kapıSayısı;
        ÜretimTarihi = DateTime.Now;
        SeriNumarası = seriNumarası;
    }
    public void Bilgi()
    {
        Console.WriteLine($"Araba Markası: {Marka} \nAraba Modeli: {Model} \nAraba Rengi: {Renk} \nKapı Sayısı: {KapıSayısı} \nÜretim Tarihi: {ÜretimTarihi} \nSeri Numarası: {SeriNumarası}");

    }

}
public class Program
{
    public static void Main()
    {
        Console.Clear();
        List<Araba> arabalar = new List<Araba>();
        while (true)
        {
            Console.Write("Araba Markasını Giriniz: ");
            string marka = Console.ReadLine();
            Console.Write("Araba Modelini Giriniz: ");
            string model = Console.ReadLine();
            Console.Write("Araba Rengini Giriniz: ");
            string renk = Console.ReadLine();

        dene:
            int kapıSayısı; // Kapı sayısını tutacak değişken.
            try
            {
                Console.Write("Araba Kapı Sayısını Giriniz: ");
                kapıSayısı = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Lütfen kapı sayısını sayı olarak giriniz.");
                goto dene; // Hata oluştuğunda dene etiketine git.
            }

            Console.Write("Araba Seri Numarasını Giriniz: ");
            string seriNumarası = Console.ReadLine();

            Araba araba = new Araba(marka, model, renk, kapıSayısı, seriNumarası); // Araba nesnesi oluşturuluyor.
            arabalar.Add(araba); // List arabalar'a araba nesnesi ekleniyor.

            Console.Write("Başka araba eklemek ister misiniz?(E/H): ");
            string cevap = Console.ReadLine();
            if (cevap.ToLower() == "h" || cevap.ToLower() == "hayır")
            {
                break;
            }
        }
        Console.WriteLine("Eklenen Arabalar: ");
        foreach (var araba in arabalar)
        {
            araba.Bilgi();
            Console.WriteLine("-------------------------------------------------");

        }
        Console.ReadKey();
    }
}
