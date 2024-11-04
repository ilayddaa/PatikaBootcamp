using System;

namespace Lınq_Homework3;

public class Series
{
public string Name { get; set; }
public int ReleaseYear { get; set; }
public string Type { get; set; }
public int StartYear { get; set; }
public string Director { get; set; }
public string Platform { get; set; }
public Series(string name, int releaseYear, string type, int startYear, string director, string platform)
{
    Name = name;
    ReleaseYear = releaseYear;
    Type = type;
    StartYear = startYear;
    Director = director;
    Platform = platform;
}
    public override string ToString()
    {
        return $"Name: {Name}, Release Year: {ReleaseYear}, Type: {Type}, Start Year: {StartYear}, Director: {Director}, Platform: {Platform}";
    }
    
}

