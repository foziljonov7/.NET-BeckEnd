
Console.WriteLine(Son.Metod(25));

public static class Son
{
    public static int Metod(int son)
    {
        if(son > 10 || son < 50)
        {
            int a = son / 5;
            return a;
        }
        else
        {
            int k = 0;
            for (int i = son; i > 0; i--)
            {
                k += i;
            }
            return k;
        }
    }
}





//Console.WriteLine(Matem.PI * 3);    

//public static class Matem
//{
//    public static double pi = 3.14;

//    public static double PI
//    {
//        get
//        {
//            return pi;
//        }
//    }
//}


