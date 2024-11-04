using System.Formats.Asn1;
using Lınq_Homework3;

Console.Clear();
List<Series> series = new List<Series>(){
    new Series("Avrupa Yakası", 2004, "Komedi", 2004, "Yüksel Aktuğ", "Kanal D"),
    new Series("Yalan Dünya", 2012, "Komedi", 2012, "Gülseren Buda Başkaya", "Fox TV"),
new Series("Jet Sosyete", 2018, "Komedi", 2018, "Gülseren Buda Başkaya", "TV8"),
new Series("Dadı", 2006, "Komedi", 2006, "Yusuf Pirhasan", "Kanal D"),
new Series("Belalı Baldız", 2007, "Komedi", 2007, "Yüksel Aksu", "Kanal D"),
new Series("Arka Sokaklar", 2004, "Polisiye,Dram", 2004, "Orhan Oğuz", "Kanal D"),
new Series("Aşk-ı Memnu", 2008, "Dram,Romantik", 2008, "Hilal Saral", "Kanal D"),
new Series("Muhteşem Yüzyıl", 2011, "Tarih,Dram", 2011, "Mercan Çilingiroğlu", "Star TV"),
new Series("Yaprak Dökümü", 2006, "Dram", 2006, "Serdar Akar", "Kanal D"),
};

while (true)
{
    Console.WriteLine("Dizinin ismini giriniz: ");
    string seriesName = Console.ReadLine();
    Console.WriteLine("---------------------------------");
    Console.WriteLine("Yapım yılını giriniz: ");
    int releaseYear = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("---------------------------------");
    Console.WriteLine("Türünü giriniz: ");
    string type = Console.ReadLine();
    Console.WriteLine("---------------------------------");
    Console.WriteLine("Dizinin yayınlanma yılını giriniz: ");
    int startYear = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("---------------------------------");
    Console.WriteLine("Yönetmenini giriniz: ");
    string director = Console.ReadLine();
    Console.WriteLine("---------------------------------");
    Console.WriteLine("Platformunu giriniz: ");
    string platform = Console.ReadLine();
    Console.WriteLine("---------------------------------");
    Console.WriteLine("Dizi eklendi.");
    Console.WriteLine("Başka bir dizi eklemek ister misiniz? (E/H)");
    answer:
    string answer = Console.ReadLine();

    if (answer == "H" || answer == "h")
    {
        break;
    }
    else if (answer == "E" || answer == "e")
    {
        continue;
    }
    else
    {
        Console.WriteLine("Hatalı giriş yaptınız.");
        goto answer;
    }
    Console.Clear();
}

Console.WriteLine("Komedi türündeki diziler:");
List<Comedy> comedies = series.Where(s=> s.Type.Contains("Komedi")).Select(s=> new Comedy(s.Name, s.Type, s.Director)).ToList(); //Komedi türündeki dizileri seçtik ve yeni bir Comedy listesi oluşturduk.
foreach (var comedy in comedies)
{
    Console.WriteLine(comedy);
}
Console.WriteLine("---------------------------------");

Console.WriteLine("Tüm Diziler: ");
series.OrderBy(s=> s.Name).OrderBy(s=> s.Director).ToList().ForEach(s=> Console.WriteLine(s)); //Dizileri isme ve yönetmene göre sıraladık ve yazdırdık.

