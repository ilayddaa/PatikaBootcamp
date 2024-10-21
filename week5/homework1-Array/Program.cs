Console.Clear();
int[] numbers = new int[10];
for (int i = 0; i < numbers.Length; i++) // 0'dan başlayıp 10'a kadar gider
{
    numbers[i] = i + 1;
}

Console.WriteLine("Numbers array'in içindeki elemanları: "); //numbers array'in içindeki elemanları yazdırır
foreach (int number in numbers)
{
    Console.WriteLine(number);
}
Console.Write("Lütfen 11. elemanı ekleyiniz: "); //11. elemanı ekleyiniz yazdırır
int onbir = int.Parse(Console.ReadLine()); //11. elemanı alır

int[] newNumbers = new int[11]; //newNumbers array'ini oluşturur
for (int i = 0; i < numbers.Length; i++) //numbers array'inin elemanlarını newNumbers array'ine atar
{
    newNumbers[i] = numbers[i]; //numbers array'inin elemanlarını newNumbers array'ine atar
}
newNumbers[10] = onbir; //newNumbers array'inin 10. elemanına onbir'i atar
Console.WriteLine("Güncellenmiş Numbers array'in içindeki elemanları: "); //güncellenmiş numbers array'in içindeki elemanları yazdırır
foreach (int number in newNumbers) //newNumbers array'inin elemanlarını yazdırır
{
    Console.WriteLine(number);
}

// Console.WriteLine("************");

Array.Sort(newNumbers);
Array.Reverse(newNumbers);
Console.WriteLine("Güncellenmiş Numbers array'in içindeki elemanları tersten sıralanmış hali: ");
foreach (int number in newNumbers)
{
    Console.WriteLine(number);
}

Console.ReadKey();

