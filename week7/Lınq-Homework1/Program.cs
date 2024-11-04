Console.Clear();
List<int> numbers = new List<int>() { -7, -3, -8, 3, 2, 4, 5, 7, 9, 1, 8, 6, 10, 13, 16, 19, 56, 58 };

Console.WriteLine("Numbers içindeki çift sayıları ekrana yazdıran programı yazınız:");
var evenNumbers = numbers.Where(n => n % 2 == 0);
foreach (var number in evenNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("Numbers içindeki tek sayıları ekrana yazdıran programı yazınız:");
var oddNumbers = numbers.Where(n => n % 2 != 0);
foreach (var number in oddNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("Numbers içindeki negatif sayıları ekrana yazdıran programı yazınız:");
var negativeNumbers = numbers.Where(n => n < 0);
foreach (var number in negativeNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("Numbers içindeki pozitif sayıları ekrana yazdıran programı yazınız:");
var positiveNumbers = numbers.Where(n => n > 0);
foreach (var number in positiveNumbers)
{
    Console.WriteLine(number);
}


Console.WriteLine("15'ten büyük 22'den küçük sayıları ekrana yazdıran programı yazınız:");
var betweenNumbers = numbers.Where(n => n > 15 && n < 22);
foreach (var number in betweenNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("Listedeki her bie sayının karesini alarak ekrana yazdıran programı yazınız:");
var squareNumbers = numbers.Select(n => n * n);
foreach (var number in squareNumbers)
{
    Console.WriteLine(number);
}

