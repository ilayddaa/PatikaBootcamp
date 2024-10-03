using System;
using System.ComponentModel.Design;
namespace week
{
    internal class Program
    {
        static void Main(string[]args)
        {
            Console.Write("Lütfen bir sayı giriniz: ");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 10)
            {
                Console.WriteLine("Sayı 10'dan büyüktür.");
            }
            
            else if (number < 10)
                Console.WriteLine("Sayı 10'dan küçüktür.");
            
            else
            {
                Console.WriteLine("Sayı 10'a eşittir.");
            }
            if (number % 2 == 0)
            {
                Console.WriteLine("Çift sayıdır.");
            }

            else
            {
                Console.WriteLine("Tek sayıdır.");

            }
            }

            }
                   
            }

