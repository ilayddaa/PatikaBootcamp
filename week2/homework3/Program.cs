int sayac = 0;
Console.Write("Lütfen bir sayı giriniz: ");
int limit = Convert.ToInt32(Console.ReadLine());

do
{
    Console.WriteLine("Ben bir Patika'lıyım!");
    sayac++;

} while (sayac < limit); // limit değerine kadar döngü çalışır.

//-----------------------------
int sayac1 = 0;
Console.WriteLine("Lütfen bir sayı giriniz: ");
int limit1 = Convert.ToInt32(Console.ReadLine());
while (sayac1 < limit1)
{
    Console.WriteLine("'Ben bir Patika'lıyım'");
    sayac1++;
}
// while döngüsü ile yapılan işlem do-while döngüsü ile yapılan işlem aynıdır fakat do-while döngüsünde döngü en az bir kere çalışır .
// çünkü do-while döngüsünde koşul en sonda kontrol edilir. while döngüsünde ise koşul en başta kontrol edilir.


