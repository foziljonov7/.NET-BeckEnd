using Lesson15;

//Book book = new Book();
//Console.WriteLine($"Id: {book.Id} Name: {book.Name}  " +
//    $"Author: {book.Author} Price: {book.Price}" +
//    $"  {book.Time}");

//Console.Write("Id : ");
//int id = int.Parse(Console.ReadLine());
//Console.Write("Course name : ");
//string name = Console.ReadLine();
//Console.Write("Cuorse teacher : ");
//string teacher = Console.ReadLine();

//Course course = new Course(id, name, teacher);
//Console.WriteLine($"{course.Id}  {course.Name}  {course.Teacher}");

Console.Write("Student Id sini kiriting: ");
int id = int.Parse(Console.ReadLine());
Console.Write("Student to'liq ismini kiriting: ");
string fullname = Console.ReadLine();
Console.Write("Student manzilini kiriting: ");
string location = Console.ReadLine();

Student student = new Student(id, fullname, location);
student.GetStudent();
Console.Write("Student idsi orqali qidirish: ");
int studentId = int.Parse(Console.ReadLine());
student.GetStudentById(studentId);