using homework1;
Console.Clear();

Person student = new Person(); // Person classından student ve teacher nesneleri oluşturuldu.
student.Name = "ilayda";
student.Surname = "tas";
student.Age = 20;

Person teacher = new Person();
teacher.Name = "Yiğit";
teacher.Surname = "Hacıefendioglu";
teacher.Age = 30;

Console.WriteLine($"Student: {student.Name} {student.Surname}'s age {student.Age}."); // Student ve teacher nesnelerinin özellikleri yazdırıldı.
Console.WriteLine($"Teacher: {teacher.Name} {teacher.Surname}'s age {teacher.Age}.");

Console.ReadKey();