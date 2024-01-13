using Shifoxona.Models;
using Shifoxona.Services;

while(true)
{
    Console.WriteLine("1) Mijozni ro'yxatdan o'tkazish");
    Console.WriteLine("2) Mijozlar rp'yxatini ko'rish");
    Console.WriteLine("3) Mijozlar ro'yxatidan malumot qidirish");
    Console.WriteLine("4) Mijozlar ro'yxatidan keraksiz malumotni o'chirib yuborish");
    Console.WriteLine("5) Yangi xona qo'shish");
    Console.WriteLine("6) Xonalar ro'yxatini ko'rish");
    Console.WriteLine("7) Xonalar ro'yxatidan malumot qidirish");
    Console.WriteLine("8) Bosh xona qidirish");
    Console.WriteLine("9) Yangi xodim qo'shish");
    Console.WriteLine("10) Barcha xodimlarning malumotlarini ko'rish");
    Console.WriteLine("11) Xodim malumotlarni qidirish");
    Console.WriteLine("12) Xodimni ro'yxatdan chiqarib yuborish");
    Console.WriteLine("13) Xodimlarni lavozim bo'yicha ajratish");

    int i = Convert.ToInt32(Console.ReadLine());
    switch(i)
    {
        case 1: CreatePerson(); break;
        case 2: GetPersons(); break;
        case 3: GetPerson(); break;
        case 4: DeletePerson(); break;
        case 5: CreateRoom(); break;
        case 6: GetRooms(); break;
        case 7: GetRoom(); break;
        case 8: RoomIsActive(); break;
        case 9: CreateEmployee(); break;
        case 10: GetEmployees(); break;
        case 11: GetEmployee(); break;
        case 12: DeleteEmployee(); break;
        case 13: GeTCareer(); break;
        default: Console.WriteLine("Ahvollar joyidami!"); break;
    }
}


//Person
void GetPersons()
{
    Console.WriteLine("-------------------------------------");
    PersonService service = new PersonService();
    var persons = service.GetPersons();
    foreach(var p in persons)
        Console.WriteLine(p.ToString());
    Console.WriteLine("--------------------------------------");
}

void CreatePerson()
{
    Random rand = new Random();
    Console.WriteLine("-----------------------------------");
    Console.Write("To'liq ismini kiriting: ");
    string fullname = Console.ReadLine();
    Console.Write("Tell raqamni kiriting: ");
    string phone = Console.ReadLine();
    Console.Write("Yoshini kiriting: ");
    int age = int.Parse(Console.ReadLine());
    Console.Write("Xona raqamini kiriting: ");
    int room = Convert.ToInt32(Console.ReadLine());
    Console.Write("Manzilni kiriting: ");
    string location = Console.ReadLine();
    Console.Write("Kasalligini kiriting: ");
    string disease = Console.ReadLine();

    var newPerson = new Person
    {
        Id = rand.Next(10, 1000),
        Fullname = fullname,
        PhoneNumber = phone,
        Age = age,
        RoomId = room,
        Location = location,
        Disease = disease
    };
    PersonService service = new PersonService();
    service.CreatePerson(newPerson);
    Console.WriteLine("-------------------------------------");
}

void GetPerson()
{
    Console.WriteLine("--------------------------------");
    Console.Write("Id sini kiriting: ");
    int personId = Convert.ToInt32(Console.ReadLine());
    PersonService service = new PersonService();
    service.GetPerson(personId);
    Console.WriteLine("---------------------------------");
}

void DeletePerson()
{
    Console.WriteLine("---------------------------------");
    Console.Write("Id sini kiriting: ");
    int personId = Convert.ToInt32(Console.ReadLine());
    PersonService service = new PersonService();
    service.DeletePerson(personId);
    Console.WriteLine("---------------------------------");
}

//Room
void GetRooms()
{
    Console.WriteLine("----------------------------------");
    RoomService service = new RoomService();
    var room = service.GetRooms();
    foreach(var r in room)
        Console.WriteLine(r.ToString());
    Console.WriteLine("----------------------------------");
}

void CreateRoom()
{
    Console.WriteLine("----------------------------------");
    Console.Write("Id: ");
    int roomId = Convert.ToInt32(Console.ReadLine());
    Console.Write("Bo'limi: ");
    string department = Console.ReadLine();
    Console.Write("Active: ");
    string roomIsActive = Console.ReadLine();
    Console.Write("Mijoz Id sini kiriting: ");
    int personId = Convert.ToInt32(Console.ReadLine());

    var newRoom = new Room
    {
        RoomId = roomId,
        Department = department,
        IsActive = bool.Parse(roomIsActive),
        PersonId = personId
    };
    RoomService service = new RoomService();
    service.CreateRoom(newRoom);
    Console.WriteLine("---------------------------------");
}

void GetRoom()
{
    Console.WriteLine("-------------------------------------");
    Console.Write("Xona Id sini kiriting: ");
    int roomId = Convert.ToInt32(Console.ReadLine());
    RoomService service = new RoomService();
    service.GetRoom(roomId);
    Console.WriteLine("------------------------------------");
}
void RoomIsActive()
{
    Console.WriteLine("------------------------------------");
    Console.Write("Xona Id sini kiriting: ");
    int roomId = Convert.ToInt32(Console.ReadLine());
    RoomService service = new RoomService();
    service.GetIsActive(roomId);
    Console.WriteLine("------------------------------------");
}
//Employee

void GetEmployees()
{
    Console.WriteLine("--------------------------------------");
    EmployeeService service = new EmployeeService();
    var employee = service.GetEmployees();
    foreach(var e in employee)
        Console.WriteLine(e.ToString());
    Console.WriteLine("----------------------------------------");
}

void CreateEmployee()
{
    Random rand = new Random();
    Console.WriteLine("-------------------------------------");
    Console.Write("To'liq ism: ");
    string fullname = Console.ReadLine();
    Console.Write("Career: ");
    string career = Console.ReadLine();
    Console.Write("Tell raqami: ");
    string phone = Console.ReadLine();
    Console.Write("yoshni kiriting: ");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.Write("Manzilni kiriting: ");
    string location = Console.ReadLine();

    var newEmployee = new Employee
    {
        Id = rand.Next(100, 500),
        Fullname = fullname,
        Career = career,
        PhoneNumber = phone,
        Age = age,
        Location = location
    };

    EmployeeService service = new EmployeeService();
    service.CreateEmployee(newEmployee);
    Console.WriteLine("--------------------------------------");
}

void GetEmployee()
{
    Console.WriteLine("--------------------------------------");
    Console.Write("Id sini kiriting: ");
    int emploeeId = Convert.ToInt32(Console.ReadLine());
    EmployeeService service = new EmployeeService();
    service.GetEmployee(emploeeId);
    Console.WriteLine("--------------------------------------");
}
void GeTCareer()
{
    Console.WriteLine("--------------------------------------");
    Console.Write("Career ni kiriting: ");
    string career = Console.ReadLine();
    EmployeeService service = new EmployeeService();
    service.GetCareer(career);
    Console.WriteLine("--------------------------------------");
}

void DeleteEmployee()
{
    Console.WriteLine("--------------------------------------");
    Console.Write("Id sini kiriting: ");
    int employeeId = Convert.ToInt32(Console.ReadLine());
    EmployeeService service = new EmployeeService();
    service.DeleteEmployee(employeeId);
    Console.WriteLine("--------------------------------------");
}