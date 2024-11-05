using Example4;

List <Student> students = new List<Student>
{
    new Student { Name = "Alice", Id = 1 },
    new Student { Name = "Bob", Id = 2 },
    new Student { Name = "Charlie", Id = 3 }
};  

List<Grade> grades = new List<Grade>
{
    new Grade { StudentId = 1, Course = "Math", Score = 90 },
    new Grade { StudentId = 1, Course = "Science", Score = 85 },
    new Grade { StudentId = 2, Course = "Math", Score = 95 },
    new Grade { StudentId = 2, Course = "Science", Score = 80 },
    new Grade { StudentId = 3, Course = "Math", Score = 100 },
    new Grade { StudentId = 3, Course = "Science", Score = 75 }
};
var studentGrades = students.Join(grades,
student => student.Id,
grade => grade.StudentId, 
(student, grade) => new { 
student.Name, 
grade.Course, 
grade.Score }
);

foreach ( var student in studentGrades)
{
    Console.WriteLine($"{student.Name} got {student.Score} in {student.Course}");
}


Console.WriteLine("--------------------------");

var studentGrades1= from student in students
join grade in grades on student.Id equals grade.StudentId // equals: join methodunu kullanırken kullanılan eşitlik operatörü
select new { 
student.Name,
grade.Course, 
grade.Score };

foreach ( var student in studentGrades1)
{
    Console.WriteLine($"{student.Name} got {student.Score} in {student.Course}");
}

Console.WriteLine("--------------------------");

var studentsWithGrades = students.GroupJoin(grades,
student=> student.Id,
grade => grade.StudentId,
(student,studentGrades)=> new
{
    StudentName = student.Name,
    Grades = studentGrades
});

foreach (var student in studentsWithGrades)
{
    Console.WriteLine($"{student.StudentName}");
    Console.WriteLine("Grades:");
    foreach (var grade in student.Grades)
    {
        Console.WriteLine($"\t{grade.Course} : {grade.Score}");
    }
}
Console.WriteLine("--------------------------");

var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var groupedAndSummed = numbers.GroupBy(n => n % 2 == 0 ? "Çift" : "Tek")
.Select(group => new
{
    Key = group.Key, //çift mi tek mi olduğunu belirler
    Sum = group.Sum() //grup içindeki sayıları toplar
});

foreach (var group in groupedAndSummed)
{
    Console.WriteLine($"{group.Key} : {group.Sum}");
}
Console.WriteLine("--------------------------");

var studenAverageGrades = students.Select(student=> new{
    StudentName = student.Name,
    AverageGrade = grades.Where(grade=> grade.StudentId == student.Id).Average(grade=> grade.Score)
});
foreach (var student in studenAverageGrades)
{
    Console.WriteLine($"{student.StudentName} : {student.AverageGrade}");
}
Console.WriteLine("--------------------------");

var pagedStudents = students.OrderBy(student=> student.Name)
.Skip(1) //ilk elemanı atlar
.Take(1); //ilk elemanı alır

Console.WriteLine("-------");

students.Any(student=> student.Name == "A"); // var mı yok mu kontrol eder
students.All(student=> student.Name == "A"); // hepsi var mı kontrol eder

