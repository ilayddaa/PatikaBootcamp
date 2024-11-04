Console.Clear();
/*Func<int, int, int> divide = (x, y) =>
{
    if (y == 0)
    {
        throw new DivideByZeroException("Bölen sıfır olmaz."); // throw hata fırlatır
    }
    return x / y;
};
Console.WriteLine(divide(10, 2)); */
Console.WriteLine("-----------------------------------------------------");

/*var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
pn(numbers, n => n % 2 == 0);
static void pn(List<int> numbers, Func<int, bool> filter)
{
    foreach (var number in numbers)
    {
        if (filter(number))
        {
            Console.WriteLine(number);
        }
    }
}*/
Console.WriteLine("-----------------------------------------------------");
/*Add add = (x, y) => x + y;
Console.WriteLine(add(5, 3));
public delegate int Add(int x, int y);

Add add = (x, y) => x + y; 
Console.WriteLine(add(5, 3));

Func<int, int, int> add2 = (x, y) => x * y; //delegate olmadan tanımlama.
Console.WriteLine(add2(5, 3));
public delegate int Add(int x, int y); // delegate tanımlama: istediğin yerde kullanabilirsin.*/
Console.WriteLine("-----------------------------------------------------");
/*Action<string> write = message => Console.WriteLine(message);
write("Hello World!");*/
Console.WriteLine("-----------------------------------------------------");