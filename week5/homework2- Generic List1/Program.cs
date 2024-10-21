Console.Clear();

List<string> davetliler = new List<string>();
davetliler.Add("Sagopa KAJMER");
davetliler.Add("Ceza");
davetliler.Add("Ezhel");
davetliler.Add("Şehinşah");
davetliler.Add("Fuat Ergin");
davetliler.Add("Tarkan");
davetliler.Add("Funda Arar");

Console.WriteLine("Davetliler: ");
for (int i = 0; i < davetliler.Count; i++) // 0'dan başlayıp davetliler.Count'a kadar gider
{
    Console.WriteLine($"{i + 1}. {davetliler[i]}");
}
Console.ReadKey();
