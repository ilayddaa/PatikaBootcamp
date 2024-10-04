Console.WriteLine("Lyda Manavına Hoş Geldiniz!");

Console.WriteLine("Elma = 100TL ");
Console.WriteLine("Karpuz = 200TL");
Console.WriteLine("Muz = 500TL");
Console.WriteLine("Portakal = 300TL");
Console.WriteLine("Diğer bütün meyveler = 2TL");


Console.Write("Hangi Meyveyi Satın Almak İstersiniz?");
Console.Write("(Elma/Karpuz/Muz/Portakal/Diğer): ");

string meyve = Console.ReadLine().ToLower(); // ToLower: Buyuk harf kucuk harfe dikkat eder.


int fiyat = 0;
switch (meyve)
{
    case "elma":
        fiyat = 100;
        break;
    case "karpuz":
        fiyat = 200;
        break;
    case "muz":
        fiyat = 500;
        break;
    case "portakal":
        fiyat = 300;
        break;

    default:
        fiyat = 2;
        break;


}

Console.WriteLine("Seçtiğiniz meyvenin fiyatı " + fiyat + " TL'dir.");

Console.ReadKey(); //bilgilendirme içermeyen yazı kapanır.
