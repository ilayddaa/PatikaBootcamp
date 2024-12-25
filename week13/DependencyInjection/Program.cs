// See https://aka.ms/new-console-template for more information
using DependencyInjection;

Console.WriteLine("Öğretmenlerimiz!");
SoftwareTeacher teacher4 = new SoftwareTeacher { FirstName = "Yiğit", LastName = "HACIEFENDİOĞLU", FavouriteLanguage = "C#" };
Teacher teacher3 = new Teacher { FirstName = "Yiğit", LastName = "HACIEFENDİOĞLU" };
Teacher teacher1 = new Teacher { FirstName = "İlayda", LastName = "TAŞ" };
Teacher teacher2 = new Teacher { FirstName = "Burak", LastName = "ÖZKAN" };
MathTeacher mathTeacher = new MathTeacher { FirstName = "Elif", LastName = "ESER", Department = "Matematik" };


ClassRoom patika = new ClassRoom(teacher1, teacher2, teacher3, teacher4);
patika.GetTeacherInfo();