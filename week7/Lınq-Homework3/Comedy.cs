using System;
using System.Diagnostics.Contracts;

namespace Lınq_Homework3;

public class Comedy
{
public string Name { get; set; }
public string Type { get; set; }
public string Director { get; set; }
public Comedy(string name, string type, string director)
{
    Name = name;
    Type = type;
    Director = director;
}
    public override string ToString()
    {
        return $"Name: {Name}, Type: {Type}, Director: {Director}";
    }
}
