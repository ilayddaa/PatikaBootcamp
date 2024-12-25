using System;

namespace DependencyInjection;

public class SoftwareTeacher : ITeacher
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FavouriteLanguage { get; set; }

    public string GetInfo()
    {
        return $"{FirstName} {LastName} {FavouriteLanguage}";
    }
}
