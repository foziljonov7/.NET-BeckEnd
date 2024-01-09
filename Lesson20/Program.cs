//double[] arr = { 3, 3.01, 7.47, 9.42, 3.14, 5 };

//Console.WriteLine(Max(3, 3.13));
//Console.WriteLine(Max2(3.14, 5.74, 4.11));
//Console.WriteLine(Max3(arr));


//static double Max(double d1, double d2)
//{
//    return (d1 > d2) ? d1 : d2;
//}

//static double Max2(double d1, double d2, double d3)
//{
//    if (d1 > d2 && d1 > d3)
//        return d1;
//    else if (d2 > d1 && d2 > d3)
//        return d2;
//    else if (d3 > d1 && d3 > d2)
//        return d3;
//    else
//        return -1;
//}

//static double Max3(double[] arr)
//{
//    if(arr != null)
//    {
//        double max = arr[0]; //3
//        for(int i = 1; i < arr.Length; i++)
//        {
//            if (arr[i] > max) max = arr[i];  
//        }
//        return max; //9.42
//    }
//    return -1;
//}


int a = Convert.ToInt32(Console.ReadLine());
string a1 = Console.ReadLine();

if (a == a1.Length)
    Console.WriteLine(a1);
else
    Console.WriteLine($"text uzunligi {a1.Length} = {a} teng emass");