Console.Clear();
int i = 0;
while (i < 10)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    i++;
}
// while döngüsü ile 10 tane yazı yazdırılmıştır.
//-------------------------1.

int a = 1;
while (a <= 20)
{
    Console.WriteLine(a);
    a++;
}
// while döngüsü ile 1den 20ye kadar olan sayılar yazdırılmıştır.
//-------------------------2.

int b = 0;
while (b <= 20)
{
    if (b % 2 == 0)
    {
        Console.WriteLine(b);
    }
    b++;
}
// b++ yı if dışına yazma sebebi uygulamanın sönsüz döngüye girmemesini sağlamak.
//----------------------------3.
int toplam = 0;
int c = 50;
while (c <= 150)
{
    toplam = toplam + c;
    c++;

}
Console.WriteLine(toplam);
// console.writeline(toplam)'ın dışarı yazılma sebebi içeride kendisini döngüye sokmamasıdır.
//-------------------------4.

int toplamCift = 0;
int toplamTek = 0;
int d = 1;
while (d <= 120)
{
    if (d % 2 == 0)
    {
        toplamCift = d + toplamCift;
    }
    else
    {
        toplamTek = d + toplamTek;
    }
    d++;
}
Console.WriteLine("Çift sayıların toplamı: " + toplamCift);
Console.WriteLine("Tek sayıların toplamı: " + toplamTek);
// ------------------------5.

Console.ReadKey();
