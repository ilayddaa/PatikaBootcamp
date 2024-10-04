using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Merhaba Yarışmaya Hoş Geldiniz!");
        Console.WriteLine("Kendinizi Tanıtın Lütfen! İsminiz Nedir?");
        string isim = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("Hoşgeldin " + isim + "!");
        Console.WriteLine("Yarışmamız 3 soru içermektedir. Her soru karşılığı 50 kuruş kazanacaksınız. Hazır mısınız?");
        Console.WriteLine("Evet/Hayır");
        string hazir = Console.ReadLine()?.ToLower() ?? string.Empty;
        if (hazir == "evet")

        {
            Console.WriteLine("O zaman başlayalım!");

        }
        else if (hazir == "hayır")
        {
            Console.WriteLine("Yarışmaya hazır değilseniz BAŞLAMAYIZ!. İyi Günler!");

        }

        else
        {
            Console.WriteLine("Lütfen sadece Evet ya da Hayır yazınız!");
            return;
        }

        Console.WriteLine("Sorular başlıyor!");
        Console.WriteLine("1. Soru: Hangisi yemeğe katılabilir?");
        Console.WriteLine("A) Amonyak B) Klor C) Tuz Ruhu D) Tuz");
        string cevap1 = Console.ReadLine()?.ToLower() ?? string.Empty;
        if (cevap1 == "d")
        {
            Console.WriteLine("Tebrikler! 50 kuruş kazandınız!");
        }
        else if (cevap1 == "a" || cevap1 == "b" || cevap1 == "c")
        {
            Console.WriteLine("Üzgünüm, yanlış cevap verdiniz. Kaybettiniz.");
            Console.WriteLine("Yarışma sona erdi. Birdaha beklemeyiz. İyi günler'");
            return;
        }
        else
        {
            Console.WriteLine("Lütfen sadece A, B , C ya da D yazınız!");
            return;
        }
        Console.WriteLine("Hangisi bir yiyecek değildir?");
        Console.WriteLine("A) Kablo B) Elma C) Lahmacun D) İskender");
        string cevap2 = Console.ReadLine()?.ToLower() ?? string.Empty;
        if (cevap2 == "a")
        {
            Console.WriteLine("Tebrikler! 50 kuruş daha kazanarak 1TL elde ettiniz!");
        }
        else if (cevap2 == "d" || cevap2 == "b" || cevap2 == "c")

        {
            Console.WriteLine("Üzgünüm, yanlış cevap verdiniz. Kaybettiniz.");
            Console.WriteLine("Yarışma sona erdi. 1TL kazandınız. İyi Günlerde Harcayın!");
            return;
        }
        else
        {
            Console.WriteLine("Lütfen sadece A, B, C ya da D yazınız!");
            return;
        }
        Console.WriteLine("Evet, son soruya geçelim!");
        Console.WriteLine("Hangisi teknolojik bir alet değildir?");
        Console.WriteLine("A) Bilgisayar B) Telefon C) Tablet D) Odun");

        string cevap3 = Console.ReadLine()?.ToLower() ?? string.Empty;
        if (cevap3 == "d")
        {
            Console.WriteLine("Tebrikler! Bir 50 kuruş daha kazandınız. Toplamda 1.50TL kazandınız!");
            Console.WriteLine("Yarışma sona erdi. Umarım keyifli vakit geçirmişsinizdir. İyi Günler!");
        }

        else if (cevap1 == "a" || cevap1 == "b" || cevap1 == "c")

        {
            Console.WriteLine("Üzgünüm, yanlış cevap verdiniz. Kaybettiniz.");
            Console.WriteLine("Yarışma bitti. Kaybettiniz. Belki de çoktan kaybetmiştiniz. İyi Günler!");
            return;
        }
        else
        {
            Console.WriteLine("Lütfen sadece A, B, C ya da d yazınız!");
            return;
        }
    }
}