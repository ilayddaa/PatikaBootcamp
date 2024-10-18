using System.ComponentModel;
using System.Runtime.CompilerServices;

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
    public İnsanKaynakları(string ad, string surname, string departman) : base(ad, surname, departman)
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
    public Mudur(string ad, string surname, string departman) : base(ad, surname, departman)
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
    public Yazılımcı(string ad, string surname, string departman) : base(ad, surname, departman)
    {
    }
    public override void BilgileriGoster()
    {
        Console.WriteLine("Yazılımcının adı: " + Ad);
        Console.WriteLine("Yazılımcının Soyadı: " + Surname);
        Console.WriteLine("Yazılımcının Departmanı: " + Departman);
    }
    public class Hizmetçi: Calısan
{
    public Hizmetçi(string ad, string surname, string departman) : base(ad, surname, departman)
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
        İnsanKaynakları insanKaynakları = new İnsanKaynakları("İlayda", "Taş", "İnsan Kaynakları");
        insanKaynakları.BilgileriGoster();
        Console.WriteLine("************");
        Yazılımcı yazılımcı = new Yazılımcı("Lyd", "Taş", "Yazılımcı");
        yazılımcı.BilgileriGoster();
        Console.WriteLine("************");
        Hizmetçi hizmetçi = new Hizmetçi("Burak", "Özkan", "Hizmetçi");
        hizmetçi.BilgileriGoster();
        Console.WriteLine("************");
        Mudur mudur = new Mudur("İlyada", "Taş", "Müdür");
        mudur.BilgileriGoster();
        
    }
}
}