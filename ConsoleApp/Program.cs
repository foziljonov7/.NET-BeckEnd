//IDictionary<int, Person> persons = new Dictionary<int, Person>();

//persons.Add(1, new Person(1, "Abdulvosid Foziljonov", "+998945666964", 19));
//persons.Add(2, new Person(2, "Muhammadkarim Xolmatov", "+998909000990", 23));

//foreach(var person in persons)
//    Console.WriteLine(person.Value);



//public class Person
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public string PhoneNumber { get; set; }
//    public int Age { get; set; }

//    public Person(
//        int id,
//        string name,
//        string phone,
//        int age)
//    {
//        Id = id;
//        Name = name;
//        PhoneNumber = phone;
//        Age = age;
//    }

//    public override string ToString()
//    {
//        return $"Id: {Id}, Name: {Name}, Phone number: {PhoneNumber}, Age: {Age}";
//    }
//}




//Task

//Task<int> task1 = Task.Run(() =>
//{
//    int n = 0;
//    for (int i = 0; i <= 5; i++)
//    {
//        n += i;
//        System.Threading.Thread.Sleep(1000); //Sleep() - to'xtatib turish uchun
//        Console.WriteLine($"Task 1: {i}");
//    }

//    return n;
//});

//Task<int> task2 = Task.Run(() =>
//{
//    int n = 0;
//    for(int i = 0; i <= 10; i++)
//    {
//        n += i;
//        System.Threading.Thread.Sleep(1000);
//        Console.WriteLine($"Task 2: {i}");
//    }

//    return n;
//});

//// WhenAll - 2 la Task ni birdaniga birdaniga ishlatib natijani qaytaradi
////ContinueWith - keyingi taskni chaqiradi
//Task.WhenAll(task1, task2).ContinueWith((tasks) =>   
//{
//    Console.WriteLine("Tugadi!");
//});


//Thread


//Thread thread = new Thread(DoWork);
//thread.Start();

//Task task = Task.Run(() => DoWork());

//Console.WriteLine("Thread kutilmoqda...");
//thread.Join();

//Console.WriteLine("Task kutilmoqda...");
//task.Wait();


//static void DoWork()
//{
//    for(int i = 0; i < 10; i++)
//    {
//        Console.WriteLine("{0}" + i);
//        Thread.Sleep(500);
//    }
//}

string text1 = "Salom";

IDictionary<int, string> dt = new Dictionary<int, string>();

Console.WriteLine("Malumotlar dictionary yozilmoqda...");
for (int i = 0; i < 5; i++)
{
    if(i == 3)
        text1 = "Hi";

    dt.Add(i, text1);
}

Console.WriteLine("Malumotlar qidirilmoqda...");
Task task = Task.Run(async () =>
{
    var res = await GetDtKeysAsync("Hi", dt);
    foreach(var k in res)
        Console.WriteLine(k);
});

task.Wait();
Console.WriteLine("Topilgan barcha malumotlar!");
static async Task<IDictionary<int, string>> GetDtKeysAsync(string T1, IDictionary<int, string> dt)
{
    await Task.Delay(100);

    IDictionary<int, string> dt2 = new Dictionary<int, string>();
    foreach (var key in dt)
        if (key.Value == T1)
            dt2.Add(key.Key, key.Value);

    return dt2;
}



//public delegate Task<int> MyDelegate(int n);

//public class Program
//{
//    public static async Task Main()
//    {
//        Task task = Task.Run(async () =>
//        {
//            MyDelegate myDelegate;  
//            MyMath math = new MyMath();

//            myDelegate = math.MathAsync;
//            Console.WriteLine(await myDelegate(5));

//            myDelegate = math.Math2Async;
//            Console.WriteLine(await myDelegate(3));
//        });

//        task.Wait();
//    }
//}

//public class MyMath
//{
//    public async Task<int> MathAsync(int n)
//        => await Task.FromResult(n * n);

//    public async Task<int> Math2Async(int n)
//        => await Task.FromResult((n * n) * 2);
//}









//Delegate

//MyDelegate myDelegate;
//MyClass obj = new MyClass();

//myDelegate = obj.Method1;
//Console.WriteLine(myDelegate("1 - Delegate chaqirildi!"));

//myDelegate = obj.Method2;
//Console.WriteLine(myDelegate("2 - Delegate chaqirildi!"));



//public delegate string MyDelegate(string message);

//public class MyClass
//{
//    public string Method1(string message)
//    {
//        return $"Method1 output: {message}";
//    }

//    public string Method2(string message)
//    {
//        return $"Method2 output: {message}";
//    }
//}



//Math math;
//MyClass my = new MyClass();

//math = my.Kvadrat;
//Console.WriteLine(math(5));

//math = my.kub;
//Console.WriteLine(math(5));

//public delegate int Math(int x);

//public class MyClass
//{
//    public int Kvadrat(int x)
//        => x * x;

//    public int kub(int x)
//        => x * x * x;
//}


//ResDelegate res;
//MyClass my = new MyClass();

//res = my.method1;
//res(false, "Kvadrat hisoblandi", 5);

//res = my.method2;
//res(false, "n - sonni 2 kamaytirildi", 190);


//public delegate void ResDelegate(bool flag, string message, int x);

//public class MyClass
//{
//    public void method1(bool flag, string message, int n)
//    {
//        if(flag)
//            Console.WriteLine($"output 1: {flag} {message} {n * n}");
//        else
//            Console.WriteLine($"output 1: {flag}");
//    }

//    public void method2(bool flag, string message, int n)
//    {
//        if(flag && n > 100)
//            Console.WriteLine($"output 2: {flag} {message} {n / 2}");
//        else
//            Console.WriteLine($"output 2: {flag}");
//    }
//}



//Publisher pub = new Publisher();
//Subscriber sub = new Subscriber();

//sub.Subscribe(pub);

//pub.RaiseEvent("Event yuzaga keldi");



//public class Publisher
//{
//    public event EventHandler MyEvent;

//    public void RaiseEvent(string message)
//        => MyEvent?.Invoke(this, new MyEventArgs(message));
//}

//public class MyEventArgs : EventArgs
//{
//    public string Message { get; set; }

//    public MyEventArgs(string message)
//        => Message = message;
//}

//public class Subscriber
//{
//    public void Subscribe(Publisher pub)
//        => pub.MyEvent += HandleEvent;

//    public void HandleEvent(object sender, EventArgs e)
//        => Console.WriteLine($"Voqea yuzaga keldi: {((MyEventArgs)e).Message}");
//}


//IDictionary<int, string> dictionary = new Dictionary<int, string>();
//ICollection<int> keys = dictionary.Keys;
//ICollection<string> values = dictionary.Values;

//string name;
//int i = 0;

//while (i < 5)
//{
//    i++;
//    Console.Write("Fishni kiriting: ");
//    name = Console.ReadLine();
//    dictionary.Add(i, name);


//    if(i == 2)
//    {
//        foreach(int key in keys)
//            Console.WriteLine($"Id: {key}, Fish: {dictionary[key]}");

//        break;
//    }
//}
//Console.WriteLine("Sikl yakunlandi!");


//ICollection<int> keys = dictionary.Keys;
//ICollection<string> values = dictionary.Values;

//dictionary.Add(1, "Bir");
//dictionary.Add(2, "Ikki");

//Console.WriteLine("Indeks orqali murojat: ");
//foreach(var key in keys)
//    Console.WriteLine($"Key: {key}, Value: {dictionary[key]}");

//Console.WriteLine("\nO'zgaruvchilar toplam kabi saqlash");
//int[] keyArray = new int[dictionary.Count];
//string[] valueArray = new string[dictionary.Count];

//keys.CopyTo(keyArray, 0);
//values.CopyTo(valueArray, 0);

//for(int i = 0; i < keyArray.Length; i++)
//    Console.WriteLine($"Key: {keyArray[i]}, Value: {valueArray[i]}");
