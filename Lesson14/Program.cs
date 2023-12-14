//static int[] Range(int n, int m)
//{
//    int[] range = new int[m - n];
//    int k = 0;
//    for (int i = n; i < m; i++)
//        range[k++] = i;
//    return range;
//}

//var s = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//Console.WriteLine($"{s[0]} dan {s[1]} gacha bo'lgan yig'indi={Range(s[0], s[1] + 1).Sum()}");

//static void Sort(ref int[] massiv)
//{
//    int x;
//    for (int i = 0; i < massiv.Length - 1; i++)
//        for (int j = i + 1; j < massiv.Length; j++)
//        {
//            if (massiv[j] < massiv[i])
//            {
//                x = massiv[i];
//                massiv[i] = massiv[j];
//                massiv[j] = x;
//            }
//        }
//}

//int[] massiv = { 3, 5, 1, 4, 2 };
//Sort(ref massiv);
//foreach(int i in massiv)
//    Console.Write(i + " ");


//int[] sonlar = { 9, 3, 4, 7, 1, 5, 8, 6, 2 };
//Array.Sort(sonlar);
//foreach(int i in sonlar)
//    Console.Write(i + " ");

//int[] sonlar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
//if (Array.Exists(sonlar, x => x > 10))
//    Console.WriteLine("true");
//else
//    Console.WriteLine("false");

//if (Array.Exists(sonlar, x => x % 2 == 0))
//    Console.WriteLine(true);
//else
//    Console.WriteLine(false);

//string[] matn = { "salom", "hayr", "sog' bo'lin", "assalomu aleykum" };
//Console.WriteLine(Array.Exists(matn, x => x.StartsWith("s") && x.EndsWith("m")));


//string[] dTillar = { "Java", "Python", "Php", "C++", "Kotlin", "C#", "Flutter" };
//Array.Sort(dTillar);
//foreach(string i in dTillar)
//    Console.WriteLine(i);

//int[] sonlar = { 9, 1, 5, 3, 8, 4, 2, 7, 6 };
//Array.Sort(sonlar, 2, 5);
//foreach(int i in sonlar)
//    Console.Write(i + " ");

//Console.WriteLine(Array.IndexOf(sonlar, 7));
//Console.WriteLine(Array.IndexOf(sonlar, 8, 3));
//Console.WriteLine(Array.IndexOf(sonlar, 6, 5, 4));

//Console.WriteLine(Array.BinarySearch(sonlar, 8));
//Console.WriteLine(Array.BinarySearch(sonlar, 0, 8, 4));
