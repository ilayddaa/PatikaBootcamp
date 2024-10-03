
using System;
namespace week
{
internal class Program
{
static void Main(string[]args)
{


Console.WriteLine("Lütfen Aşağıdaki Bilgileri Giriniz");
Console.Write("TC Kimlik Numaranızı Girin:");
string a = Console.ReadLine();
Console.Write("Adı:");
string b = Console.ReadLine();
Console.Write("Soyadı:");
string c= Console.ReadLine();
Console.Write("Telefon Numarası:");
string d= Console.ReadLine();
Console.Write("Yaş:");
string e= Console.ReadLine();
Console.Write("İlk Aldığı Ürünün Fiyatı:");
int f=Convert.ToInt32(Console.ReadLine());
Console.Write("İkinci Aldığı Ürünün Fiyatı:");
int g= Convert.ToInt32(Console.ReadLine());
int h = ((f + g)* 10)/100;

Console.WriteLine(" --------------------------------------------");

Console.WriteLine(a + " " + "TC Kimlik Numarali "+ b+" " + c + " İsimli kisi icin kayit olusturulmustur.");
Console.WriteLine(d + " " + "Telefon numarasina bildirim mesaji gonderilmistir.");
Console.WriteLine(  (f + g) + " " + "Toplam harcama karsiligi kazanilan %10 patika puan miktari " + h +" TL'dir" );

}
}
}

