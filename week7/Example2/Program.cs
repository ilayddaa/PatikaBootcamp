Console.Clear();
Console.WriteLine("-----------------------------------------------------");
List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; //listeyi oluşturduk
var evenNumbers = from number in numbers //listeyi döngüye aldık
                  where number % 2 == 0 //şartı belirledik
                  select number; //şartı sağlayanları seçtik
foreach (var number in evenNumbers) //şartı sağlayanları yazdırdık
{
    Console.WriteLine(number);
} 
Console.WriteLine("-----------------------------------------------------");
var evenNumbers2 = numbers.Where(n => n % 2 == 0); //yukarıdaki işlemi tek satırda yapar
foreach (var number in evenNumbers2)
{
    Console.WriteLine(number);
}
Console.WriteLine("-----------------------------------------------------");