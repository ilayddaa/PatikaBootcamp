

public abstract class Calısan // calısan adında nesne üretilemez cünkü abstract
{
    public string Ad { get; set; }
    public string Surname { get; set; }
    public string Departman { get; set; }

    public Calısan(string ad, string surname, string departman)
    {
        Ad = ad;
        Surname = surname;
        Departman = departman;
    }
    public abstract void BilgileriGoster();
}
public class İnsanKaynakları : Calısan
{
    public İnsanKaynakları(string ad, string surname) : base(ad, surname, "İnsan Kaynakları") //base: üst sınıfın constructor'ını çalıştırır
    {
    }
    public override void BilgileriGoster() //override: üsttekini geçersiz kılıp altta kendine özgü bir şey yapmak
    {
        Console.WriteLine("İnsan Kaynaklarının adı: " + Ad);
        Console.WriteLine("İnsan Kaynaklarının Soyadı: " + Surname);
        Console.WriteLine("İnsan Kaynaklarının Departmanı: " + Departman);
    }

}
public class Mudur : Calısan
{
    public Mudur(string ad, string surname) : base(ad, surname, "Müdür")
    {
    }
    public override void BilgileriGoster()
    {
        Console.WriteLine("Müdürün adı: " + Ad);
        Console.WriteLine("Müdürün Soyadı: " + Surname);
        Console.WriteLine("Müdürün Departmanı: " + Departman);
    }
}
public class Yazılımcı : Calısan
{
    public Yazılımcı(string ad, string surname) : base(ad, surname, "Yazılımcı")
    {
    }
    public override void BilgileriGoster()
    {
        Console.WriteLine("Yazılımcının adı: " + Ad);
        Console.WriteLine("Yazılımcının Soyadı: " + Surname);
        Console.WriteLine("Yazılımcının Departmanı: " + Departman);
    }
    public class Hizmetçi : Calısan
    {
        public Hizmetçi(string ad, string surname) : base(ad, surname, "Hizmetçi")
        {
        }
        public override void BilgileriGoster()
        {
            Console.WriteLine("Hizmetçinin adı: " + Ad);
            Console.WriteLine("Hizmetçinin Soyadı: " + Surname);
            Console.WriteLine("Hizmetçinin Departmanı: " + Departman);
        }
    }
    public class Program
    {
        public static void Main()
        {
            Console.Clear();
            İnsanKaynakları insanKaynakları = new İnsanKaynakları("İlayda", "Taş");
            insanKaynakları.BilgileriGoster();
            Console.WriteLine("************");
            Yazılımcı yazılımcı = new Yazılımcı("Lyd", "Taş");
            yazılımcı.BilgileriGoster();
            Console.WriteLine("************");
            Hizmetçi hizmetçi = new Hizmetçi("Burak", "Özkan");
            hizmetçi.BilgileriGoster();
            Console.WriteLine("************");
            Mudur mudur = new Mudur("İlyada", "Taş");
            mudur.BilgileriGoster();

        }
    }
}