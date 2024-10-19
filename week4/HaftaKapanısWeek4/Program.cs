
using System.Data.Common;

public abstract class BaseMakine // abstract class: newlenemez. Kalıtım alınarak kullanılır.
{
    public DateTime UretimTarihi { get; set; }
    public string SeriNo { get; set; }
    public string Ad { get; set; }
    public string Aciklama { get; set; }
    public string İsletimSistemi { get; set; }
    public BaseMakine(string ad, string aciklama, string isletimSistemi, string seriNo) // Constructor. Genişlik ve yükseklik değerlerini alır.
    {
        Ad = ad;
        Aciklama = aciklama;
        İsletimSistemi = isletimSistemi;
        SeriNo = seriNo;
        UretimTarihi = DateTime.Now; // üretim tarihi otomatik olarak şu anki tarih ve saat olarak atanır.
    }
    public abstract void BilgileriGoster(); // abstract metot : kalıtım alan classlara bu metotun mutlaka tanımlanması zorunluluğu getirir.
    public abstract string UrunAdiGetir();

}
public class Bilgisayar : BaseMakine
{
    private int _usbGirisSayisi; // private field : sadece bu class içinde kullanılabilir. private yapma sebebi dışarıdan erişilmesini engellemek.


    public int UsbGirisSayisi
    {
        get
        {
            return _usbGirisSayisi;
        }
        set
        {
            if (value == 2 || value == 4)
            {
                _usbGirisSayisi = value;
            }
            else
            {
                Console.WriteLine("Bilgisayarın usb giriş sayısı 2 veya 4 olabilir.");
                _usbGirisSayisi = -1;
            }
        }
    }
    public bool Bluetooth { get; set; }
    public Bilgisayar(string ad, string aciklama, string isletimSistemi, string seriNo, int usbGirisSayisi, bool bluetooth) : base(ad, aciklama, isletimSistemi, seriNo) // BASE ile yukarıya gönderiyoruz
    {
        UsbGirisSayisi = usbGirisSayisi; //usbGirişSayısı sadece bilgisayar classına özgü bir özellik olduğu için burada tanımladık.
        Bluetooth = bluetooth; //Bluetooth sadece bilgisayar classına özgü bir özellik olduğu için burada tanımladık.
    }
    public override void BilgileriGoster()
    {
        Console.WriteLine("Bilgisayarın adı: " + Ad);
        Console.WriteLine("Bilgisayarın açıklaması: " + Aciklama);
        Console.WriteLine("Bilgisayarın işletim sistemi: " + İsletimSistemi);
        Console.WriteLine("Bilgisayarın seri numarası: " + SeriNo);
        Console.WriteLine("Bilgisayarın üretim tarihi: " + UretimTarihi);
        Console.WriteLine("Bilgisayarın usb giriş sayısı: " + UsbGirisSayisi);
        Console.WriteLine("Bilgisayarın bluetooth özelliği: " + Bluetooth);

    }

    public override string UrunAdiGetir() // override: üsttekini geçersiz kılıp altta kendine özgü bir şey yapmak
    {
        return ($"Bilgisayarın adı: {Ad}");
    }

}
public class Telefon : BaseMakine
{
    public bool TrLisans { get; set; }
    /*constractor olusturma*/
    public Telefon(string ad, string aciklama, string isletimSistemi, string seriNo, bool trLisans) : base(ad, aciklama, isletimSistemi, seriNo)
    {
        TrLisans = trLisans; //TrLisans sadece telefon classına özgü bir özellik olduğu için burada tanımladık.
    }

    public override void BilgileriGoster()
    {
        Console.WriteLine("Telefonun adı: " + Ad);
        Console.WriteLine("Telefonun açıklaması: " + Aciklama);
        Console.WriteLine("Telefonun işletim sistemi: " + İsletimSistemi);
        Console.WriteLine("Telefonun seri numarası: " + SeriNo);
        Console.WriteLine("Telefonun üretim tarihi: " + UretimTarihi);
        Console.WriteLine("Telefonun TR lisansı: " + TrLisans);
    }

    public override string UrunAdiGetir()
    {
        return ($"Telefonun adı: {Ad}");
    }
}

public class Program
{
    public static void Main() // void : geriye değer döndürmeyen metotlar için kullanılır.
    {
        Console.Clear();
        Console.WriteLine(@"Lütfen üretmek istediğiniz ürünü seçiniz: (1/2) 
1- Bilgisayar
2-Telefon");
        Console.Write("Seçiminiz: ");
        int secim = Convert.ToInt32(Console.ReadLine());
        if (secim == 1)
        {
            Console.Write("Bilgisayarın adını giriniz: ");
            string ad = Console.ReadLine();
            Console.Write("Bilgisayarın açıklamasını giriniz: ");
            string aciklama = Console.ReadLine();
            Console.Write("Bilgisayarın işletim sistemini giriniz: ");
            string isletimSistemi = Console.ReadLine();
            Console.Write("Bilgisayarın seri numarasını giriniz: ");
            string seriNo = Console.ReadLine();
            Console.Write("Bilgisayarın usb giriş sayısını giriniz: ");
            int usbGirisSayisi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bilgisayarın bluetooth özelliğini giriniz: (true/false) ");
            bool bluetooth = Convert.ToBoolean(Console.ReadLine());
            Bilgisayar bilgisayar = new Bilgisayar(ad, aciklama, isletimSistemi, seriNo, usbGirisSayisi, bluetooth);
            Console.WriteLine("-------------------");
            bilgisayar.BilgileriGoster(); // bilgisayar classına ait bilgileri gösterir.
        }
        else if (secim == 2)
        {
            Console.Write("Telefonun adını giriniz: ");
            string ad = Console.ReadLine();
            Console.Write("Telefonun açıklamasını giriniz: ");
            string aciklama = Console.ReadLine();
            Console.Write("Telefonun işletim sistemini giriniz: ");
            string isletimSistemi = Console.ReadLine();
            Console.Write("Telefonun seri numarasını giriniz: ");
            string seriNo = Console.ReadLine();
            Console.Write("Telefonun TR lisansını giriniz:(true/false) ");
            bool trLisans = Convert.ToBoolean(Console.ReadLine());
            Telefon telefon = new Telefon(ad, aciklama, isletimSistemi, seriNo, trLisans);
            Console.WriteLine("-------------------");
            telefon.BilgileriGoster(); // telefon classına ait bilgileri gösterir.
        }

        else
        {
            Console.WriteLine("Hatalı seçim yaptınız.");
        }
        Console.WriteLine("Başka bir ürün üretmek ister misiniz? (E/H)");
        string devam = Console.ReadLine();
        if (devam.ToUpper() == "E") //ToUpper: küçük harfleri büyük harfe çevirir.
        {
            Main(); // Main metodu içinde Main metodu çağrıldı. Bu işlem sonsuz döngü oluşturur.
        }
        else
        {
            Console.WriteLine(@"Program sonlandırıldı.
            Çıkmak için bir tuşa basınız.");
            Console.ReadKey();
        }
    }

}

