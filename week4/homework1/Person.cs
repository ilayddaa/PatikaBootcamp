using System;

namespace homework1;

public class Person // Person classı oluşturuldu.
{
    private string name; // name, surname ve age değişkenleri oluşturuldu.
    private string surname;
    private int age;


    public string Name
    {
        get { return name; } // get ve set metodları oluşturuldu.
        set
        {
            if (value.Length >= 2) // Eğer girilen değer 2 karakterden büyükse name değişkenine atama yapılır.
            {
                name = value;
            }
        }
    }
    public string Surname // Surname değişkeni için get ve set metodları oluşturuldu.
    {
        get { return surname; }
        set
        {
            if (value.Length >= 2 && value.Length <= 20)
            {
                surname = value;
            }
        }
    }
    public int Age // Age değişkeni için get ve set metodları oluşturuldu.
    {
        get { return age; }
        set
        {
            if (value >= 0 && value <= 100) // Eğer girilen değer 4 ile 100 arasında ise age değişkenine atama yapılır.
            {
                age = value; // Girilen değer age değişkenine atandı.
            }
        }
    }
}