using System.Data.Common;
using Example3;

List<int> numbers = new List<int>() { -2, -1, 0, 5, 2, 3, 6 };

var positiveNumbers = numbers.Where(n => n > 0).ToList();

foreach (var number in positiveNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("-----------------------------------------------------");
var squaredNumbers = numbers.Select(num => num * num);
foreach (var number in squaredNumbers)
{
    Console.WriteLine(number);
}
Console.WriteLine("-----------------------------------------------------");
var personList = numbers.Select(num => new Person { Id = num });
foreach (var person in personList)
{
    Console.WriteLine(person.Id);
}
Console.WriteLine("-----------------------------------------------------");

IEnumerable<int> sortedNumbers = numbers.OrderBy(num => num); //Ie numaraların sıralanmış hali
foreach (var number in sortedNumbers)
{
    Console.WriteLine(number);
}
Console.WriteLine("-----------------------------------------------------");

IEnumerable<int> reversedNumbers = numbers.OrderByDescending(num => num); //Ie numaraların tersten sıralanmış hali
foreach (var number in reversedNumbers)
{
    Console.WriteLine(number);
}
Console.WriteLine("-----------------------------------------------------");

