using System;

namespace Example4;

public class Student
{
public string Name { get; set; }
public int Id { get; set; }
}

public class Grade
{
public int StudentId { get; set; }
public string Course { get; set; }
public int Score { get; set; }
}
