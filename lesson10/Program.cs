//for(int i = 0; i<10; i++) // 0 1 2 3 4 5 6 7 8 9
//{
//    for(int n = 0; n < 10; n++) // 0 1 2 3 4 5 6 7 8 9
//    {
//        if(n >= i)
//        {
//            break;
//        }
//        Console.Write(n + " ");
//    }
//    Console.WriteLine(i + " ");
//}
// 0
// 0 1
// 0 1 2


//int i = 100;
//while(i > 0)
//{
//    if (i == 50)
//        break; 

//    Console.WriteLine(i);
//    i--;
//}
//Console.WriteLine("Tugadi!");


//int[] arr = { 123, 68712, 12331, 7186361, 12312 };
//for (int i = 0; i < 5; i++)
//{
//    if (arr[i] % 2 == 1) continue;
//    Console.WriteLine(arr[i]);
//}

//string t1 = "Assalomu aleykum";
//for(int i = 0; i < 3; i++)
//{
//    string t2 = Console.ReadLine();
//    if (t1 == t2) continue;
//    Console.WriteLine(t1);
//}

//int son = 20;
//key:
//if (son > 20)
//{
//    Console.WriteLine($"{son} > 20");
//}
//else if (son == 20)
//{
//    son++;
//    goto key;
//}
//else
//{
//    Console.WriteLine($"{son} < 20");
//}


//string img = Console.ReadLine();
//key:
//if(img.Length > 5)
//{
//    Console.WriteLine(img);
//}
//else
//{
//    img += ".jpg";
//    goto key;
//}

//array
//1-olchamli array

//int[] sonlar = new int[] { 121, 321, 98, 12, 41 }; //
//int[] sonlar2 = { 1312, 321, 42, 91, 12 };
//int[] sonlar3 = new int[10];


////2-olchamli array
//int[,] sonlar = new int[2, 4];
//for (int i = 0; i < 2; i++)
//{
//    for (int n = 0; n < 4; n++)
//    {
//        sonlar[i, n] = int.Parse(Console.ReadLine());
//    }
//}
//foreach (int k in sonlar)
//    Console.Write(k + " ");




//foreach (int i in sonlar)
//{
//    if (i < 5)
//    {
//        if (i < 20) continue;
//        {
//            Console.WriteLine(i);
//        }
//    }
//    else
//    {
//        break;
//    }
//}


//Console.WriteLine(sonlar[0, 2]);
//Console.WriteLine(sonlar[1, 1]);



