using System;

namespace DependencyInjection;

public class ClassRoom
{
    public ITeacher Teacher { get; set; }
    public ITeacher Teacher2 { get; set; }
    public ITeacher Teacher3 { get; set; }
    public ITeacher Teacher4 { get; set; }

    public void GetTeacherInfo()
    {
        Console.WriteLine(Teacher.GetInfo());
        Console.WriteLine(Teacher2.GetInfo());
        Console.WriteLine(Teacher3.GetInfo());
        Console.WriteLine(Teacher4.GetInfo());
    }
    public ClassRoom(ITeacher teacher, ITeacher teacher2, ITeacher teacher3, ITeacher teacher4)
    {
        Teacher = teacher;
        Teacher2 = teacher2;
        Teacher3 = teacher3;
        Teacher4 = teacher4;
    }
}
