using Shifoxona;


while (true)
{
    Console.WriteLine("Shixonamizga xush kelibsiz!");
    Console.WriteLine("1. Ro'yxatdan o'tish");
    Console.WriteLine("2. Ro'yxatni ko'rish");
    Console.WriteLine("3. Ro'yxatdan malumot o'chirish");
    Console.WriteLine("4. Ro'yxatdan Id bo'yicha malumot qidirish");
    Console.WriteLine("0. Dasturdan chiqish");

    int m = int.Parse(Console.ReadLine());

    if (m == 0)
        break;

    switch(m)
    {
        case 1:
            CreatePerson(); break;
        case 2:
            GetPersons(); break;
        case 3: 
            DeletePerson(); break;
        case 4:
            GetPerson(); break;
        default:
            Console.WriteLine(""); break;
    }
}

void GetPerson()
{
    Console.WriteLine("------------------------");
    Console.Write("Qidirmoqchi bo'lgan mijoz Id si kiritilsin: ");
    int id = int.Parse(Console.ReadLine());
    PersonService p = new PersonService();
    p.GetPerson(id);

    Console.WriteLine("-------------------------");
}

void GetPersons()
{
    Console.WriteLine("----------------------");
    Console.WriteLine("Umumiy malumotlar");
    PersonService p = new PersonService();
    List<Person> result = p.GetPersons();

    foreach(var i in result)
    {
        Console.WriteLine($"{i.Id} {i.Fullname} {i.PhoneNumber} {i.Location} {i.Age} {i.Disease}");
        Console.WriteLine("------------------------");
    }

    Console.WriteLine("----------------------");
}
void DeletePerson()
{
    Console.WriteLine("----------------------");
    Console.Write("O'chirmoqchi bo'lgan malumot Id si: ");
    int id = int.Parse(Console.ReadLine());
    PersonService p = new PersonService();
    p.DeletePerson(id);
    Console.WriteLine("----------------------");
}
void CreatePerson()
{
    Console.WriteLine("----------------------");
    Console.WriteLine("Registratsiya malumotlarni kiriting");
    var p = Console.ReadLine().Split(", ").ToArray();

    var newPerson = new Person()
    {
        Id = int.Parse(p[0]),
        Fullname = p[1],
        PhoneNumber = p[2],
        Age = int.Parse(p[3]),
        Location = p[4],
        Disease = p[5]
    };

    PersonService person = new PersonService();
    person.CreatePerson(newPerson);
    Console.WriteLine("-----------------------");
}