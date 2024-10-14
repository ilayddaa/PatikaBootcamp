using System;

namespace homework1;

public class Person
{
    private string name;
    private string surname;
    private int age;


    public string Name
    {
        get { return name; }
        set
        {
            if (value.Length >= 2)
            {
                name = value;
            }
        }
    }
    public string Surname
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
    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 4 && value <= 100)
            {
                age = value;
            }
        }
    }
}