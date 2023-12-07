//Modifikatorlar
//private, public, protected
//Metodlar


//var s = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//Console.WriteLine(AddNumber(s[0], s[1]));

//void Text(string a)
//{
//    Console.WriteLine(a + " xush kelibsiz!");
//}

//string t1 = Console.ReadLine(); //Abdulvosid
//Text(t1);

//int a = int.Parse(Console.ReadLine());
//if (a % 2 == 0)
//    Ortirish(a);
//else
//    Kamayish(a);

//void Ortirish(int a)
//{
//    for(int i = a; i <= 100; i++)
//        Console.WriteLine(i);
//}

//void Kamayish(int a)
//{
//    for(int i = a; i >= 0; i--)
//        Console.WriteLine(i);
//}

//1-misol: 1 ta int typeda kvadrat degan metod hosil qiling
//metod int a son qabul qilsin va osha sonning kvadratini qaytarsin
for (int i = 0; i < 5; i++)
{
    int a = int.Parse(Console.ReadLine());
    string c = Console.ReadLine();
    int b = int.Parse(Console.ReadLine());
    if (c == "+")
        Qoshish(a, b);
    else if (c == "-")
        Ayrish(a, b);
    else if (c == "*")
        Kopaytirish(a, b);
    else if (c == "/")
        Bolish(a, b);
    else
        Console.WriteLine("Ayhollar qanaqa!");
}


void Qoshish(int a, int b)
{
    Console.WriteLine(a + b);
}
void Ayrish(int a, int b)
{
    Console.WriteLine(a - b);
}
void Kopaytirish(int a, int b)
{
    Console.WriteLine(a * b);
}
void Bolish(int a, int b)
{
    Console.WriteLine(a / b);
}