Console.Clear();
//konsolu temizler.

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim.");
}
//for ile yazılan kod bloğu süslü parantez olmadan sadece bir satır yazılmıştır.
//else bloğu süslü parantez olmadan sadece bir satır yazılmıştır.
//for döngüsü bize 10 tane yazı yazdırmıştır.

//-------------------------1.

for (int i = 1; i <= 20; i++)
{
    Console.WriteLine(i);
}
// for döngüsü ile 1den 20ye kadar olan sayıları yazdırmıştır.

//-------------------------2.

for (int i = 0; i <= 20; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
// for döngüsü ile 0dan 20ye kadar olan çift sayıları yazdırmıştır.3.

//-------------------------3.
int toplam = 0;
for (int i = 50; i <= 150; i++)
{
    toplam = toplam + i;
}
Console.WriteLine(toplam);
// ----------------------4.

int toplamTek = 0;
int toplamCift = 0;
for (int i = 1; i <= 120; i++)
{
    if (i % 2 == 0)
    {
        toplamCift = i + toplamCift;
    }
    else
    {
        toplamTek = i + toplamTek;
    }
}
Console.WriteLine("çift sayıların toplamı: " + toplamCift);
Console.WriteLine("tek sayıların toplamı: " + toplamTek);
// tek ve çift sayıların toplamını ayrı ayrı bulduk.
//-------------------------5.

Console.ReadKey();
//ekranını kapatmak için kullanıcıdan bir tuş bekler.
















