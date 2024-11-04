using Lınq_Homework2;

Console.Clear();
List<Singer> singers = new List<Singer>(){
new Singer("Sagopa","Kajmer","Rap",1998,90000000),
new Singer("Ajda", "Pekkan", "Pop", 1968, 20000000),
new Singer("Sezen", "Aksu", "Türk Halk Müziği/Pop", 1971, 10000000),
new Singer("Funda","Arar","Pop",1999,3000000),
new Singer("Sertab","Erener","Pop",1994,5000000),
new Singer("Sıla","Gençoğlu","Pop",2009,3000000),
new Singer("Serdar","Ortaç","Pop",1992,10000000),
new Singer("Tarkan","Tevek","Pop",1994,40000000),
new Singer("Hande","Yener","Pop",1999,7000000),
new Singer("Hadise","Açıkgöz","Pop",2005,5000000),
new Singer("Gülben","Ergen","Pop/Türk Halk Müziği",1997,6000000),
new Singer("Neşet","Ertaş","Türk Halk Müziği/Türk Sanat Müziği",1960,2000000),
};

Console.WriteLine("1-İsmi 'S' harfi ile başlayan şarkıcılar:");
var startWithS = singers.Where(s => s.Name.StartsWith("S"));
foreach (var singer in startWithS)
{
    Console.WriteLine(singer);
}
Console.WriteLine("---------------------------------");

Console.WriteLine("2-Albüm satışı 10 milyonun üzerinde olan şarkıcılar:");
var high10M = singers.Where(s => s.Sales > 10000000);
foreach (var singer in high10M)
{
    Console.WriteLine(singer);
}
Console.WriteLine("---------------------------------");

Console.WriteLine("3-2000 yılı öncesi çıkış yapmış ve pop müzik yapan şarkıcılar:");
var popBefore2000 = singers.Where(s => s.Type.Contains("Pop") && s.RealiseDate < 2000).GroupBy(s => s.RealiseDate); //Contains metodu ile pop müzik türüne sahip olan şarkıcıları seçtik.
foreach (var group in popBefore2000)
{
    Console.WriteLine($"Çıkış Yılı: {group.Key}");
    foreach (var singer in group) //Çıkış yılına göre grupladık.
    {
        Console.WriteLine(singer);
    }
    Console.WriteLine("---------------------------------");
}
// iki kere foreach yapmasının nedeni çıkış yılına göre gruplamak istememizdir. ikinci foreachte grupladığımız şarkıcıları yazdırdık.
Console.WriteLine("---------------------------------");

Console.WriteLine("En çok albüm satan şarkıcı:");
var highSales = singers.OrderByDescending(s=> s.Sales).First();
Console.WriteLine(highSales + " ⭐⭐⭐");
Console.WriteLine("---------------------------------");

Console.WriteLine("En yeni çıkış yapan şarkıcı ve en eski çıkış yapan şarkıcı:");
var Ordered = singers.OrderByDescending(s=> s.RealiseDate);
Console.WriteLine("En yeni çıkış yapan şarkıcı: " + Ordered.First());
Console.WriteLine("En eski çıkış yapan şarkıcı: " + Ordered.Last());

