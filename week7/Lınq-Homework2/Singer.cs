using System;

namespace Lınq_Homework2;

public class Singer
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Type { get; set; }
    public int RealiseDate { get; set; }
    public int Sales { get; set; }
    public Singer(string name, string surname, string type, int realiseDate, int sales)
    {
        Name = name;
        Surname = surname;
        Type = type;
        RealiseDate = realiseDate;
        Sales = sales;
    }
    public override string ToString()
    {
        return $"Name: {Name}, Surname: {Surname}, Type: {Type}, Realise Date: {RealiseDate}, Sales: {Sales}";
    }

}
