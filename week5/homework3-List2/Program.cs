Console.Clear();

List<string> kahve = new List<string>();
for (int i = 1; i <= 5; i++) //1'den başlayıp 5'e kadar gider
{
    Console.Write($"Lütfen {i}. kahve çeşidini giriniz: ");
    string kahveCesitleri = Console.ReadLine();
    kahve.Add(kahveCesitleri);
}
int counter = 1; //counter'ı 1 olarak tanımlar
foreach (string kahveCesitleri in kahve) //kahve listesindeki elemanları yazdırır
{
    Console.WriteLine($"{counter}. {kahveCesitleri}"); //counter'ı ve kahveCesitleri'ni yazdırır
    counter++; //counter'ı 1 arttırır
}
Console.ReadKey();