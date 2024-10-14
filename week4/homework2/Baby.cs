using System;

namespace homework2;

public class Baby
{
    private string _name;
    private string _surname;
    private DateTime _birthdate;

    public Baby() // default constructor , no parameters
    {
        Cry(); // Cry method is called
    }
    public Baby(string name, string surname) // constructor with parameters
    {
        _name = name;
        _surname = surname;
        _birthdate = DateTime.Now;
        Cry(); // Cry method is called
    }
    public string Name // Name property
    {
        get { return _name; }
        set { _name = value; }
    }
    public string Surname // Surname property
    {
        get { return _surname; }
        set { _surname = value; }
    }
    public DateTime Birthdate // Birthdate property
    {
        get { return _birthdate; }
        set
        {
            if (value <= DateTime.Now) // if the value is less than or equal to the current date
            {
                _birthdate = value;
            }
        }
    }
    public void Cry() // Cry method is defined
    {
        Console.WriteLine("Ingaaaaaaaaaaaaaa!");
    }

}

