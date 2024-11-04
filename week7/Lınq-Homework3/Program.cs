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
Console.WriteLine("Patikaflix'e Hoş Geldiniz!");
while (true)
{
    Console.Write("Dizi eklemek istiyor musunuz? (E/H): ");
    
answer:
    string answer = Console.ReadLine();

    if (answer == "H" || answer == "h")
    {
        break;
    }
    else if (answer == "E" || answer == "e")
    {
        Console.Write("Lütfen eklemek istediğiniz dizinin ismini giriniz: ");
        string seriesName = Console.ReadLine();

        Console.Write("Yapım yılını giriniz: ");
        int releaseYear = Convert.ToInt32(Console.ReadLine());

        Console.Write("Türünü giriniz: ");
        string type = Console.ReadLine();

        Console.Write("Dizinin yayınlanma yılını giriniz: ");
        int startYear = Convert.ToInt32(Console.ReadLine());

        Console.Write("Yönetmenini giriniz: ");
        string director = Console.ReadLine();

        Console.Write("Platformunu giriniz: ");
        string platform = Console.ReadLine();
        Console.Clear();

        Console.WriteLine("Dizi eklendi.");

    }
    else
    {
        Console.WriteLine("Hatalı giriş yaptınız.");
        goto answer;
    }
    

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

