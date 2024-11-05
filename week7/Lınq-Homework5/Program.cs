using Lınq_Homework5;

Console.Clear();

List<Student> students = new List<Student>() // öğrenci listesi
{
    new Student(1, "Ali", 1),
    new Student(2, "Ayşe", 2),
    new Student(3, "Mehmet", 1),
    new Student(4, "Fatma", 3),
    new Student(5, "Ahmet", 2),
};

List<Class> classes = new List<Class>() // sınıf listesi
{
    new Class(1, "Matematik"),
    new Class(2, "Türkçe"),
    new Class(3, "Kimya"),
};

var classGroup = classes.GroupJoin(students,
c => c.Id,
student => student.ClassId, // sınıf id'ye göre öğrenci id'si ile eşleştirme
(c, student) => new // sınıf adı ve sınıfa kayıtlı öğrencileri gruplama
{
    ClassName = c.Name,
    Students = student.Select(s => s.Name) // sınıfa kayıtlı öğrencileri seçme
});

foreach (var group in classGroup) // sınıf adı ve sınıfa kayıtlı öğrencileri ekrana yazdırma
{
    Console.WriteLine($"{group.ClassName} sınıfına kayıtlı öğrenciler:");
    foreach (var student in group.Students) // sınıfa kayıtlı öğrencileri ekrana yazdırma
    {
        Console.WriteLine(student);
    }
    Console.WriteLine("*******************");
}

Console.ReadKey();