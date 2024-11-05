using System;

namespace Lınq_Homework5;

public class Student
{
public int Id { get; set; }
public string Name { get; set; }
public int ClassId { get; set; }
public Student(int id, string name, int classId)
{
    Id = id;
    Name = name;
    ClassId = classId;
}
}

