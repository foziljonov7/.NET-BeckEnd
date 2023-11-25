// Switch-case Tanlash operatori


int i = 0;
do
{
    if(i < 1)
    {
        Console.WriteLine("Welcome to ...!");
        Console.WriteLine("Hozirda menyuda ushbu Fast foodlar mavjud");
        Console.WriteLine("1: Gamburger");
        Console.WriteLine("2: Chizburger");
        Console.WriteLine("3: Lavash");
    }
    Console.Write("Taom tanlang : ");
    string s = Console.ReadLine();
    switch (s)
    {
        case "Gamburger":
            Console.WriteLine("Gamburger narxi 25000"); break;
        case "Chizburger":
            Console.WriteLine("Chizburger narxi 25000"); break;
        case "Lavash":
            Console.WriteLine("Lavash narxi 25000"); break;
        default:
            Console.WriteLine("Halvol joyidami!"); break;
    }
    i++;
} while (i < 100);