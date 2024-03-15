

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
Console.WriteLine("Sikl yakunlandi!");


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
