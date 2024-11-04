using System;

namespace Example3;

public class Person
{
    public int Id { get; set; }

    public override string ToString()
    {
        return Id.ToString();
    }
}