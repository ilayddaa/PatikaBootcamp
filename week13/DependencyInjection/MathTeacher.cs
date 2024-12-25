using System;

namespace DependencyInjection;

public class MathTeacher : ITeacher
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Department { get; set; }


    public string GetInfo()
    {
        return $"{FirstName} {LastName} {Department}";
    }

}