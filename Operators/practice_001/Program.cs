
//using System;

//class practice_001
//{
//    static void Main(string[] args)
//    {
//        //string str;
//        //Console.WriteLine("enter num: ");
//        //str = Console.ReadLine();

//        //int n;
//        //if(int.TryParse(str, out n))
//        //{
//        //    Console.WriteLine((char)n);
//        //}
//        //else
//        //{
//        //    Console.WriteLine("invalid");
//        //}

//        int n1 = 10;
//        int n2 = 20;
//        int n3 = 37;
//        int res = Add(b:n1,a:n2,d:n3);
//        Console.WriteLine(res);
//        string name = Add("kalyan", "pavada");
//        Console.WriteLine(name);

//        int[] mar = { 1, 2, 3, 4, 5, 6 };
//        int[] mar2;
//        mar2 = new int[] { 1, 2, 3, 34, 5 };
//        int mar1 = Add(mar);
//        Console.WriteLine(mar1);
//        mar1 = Add(mar2);

//        Console.WriteLine(mar1);
//        Console.WriteLine(Add(1,2,3,4,56,7,8,9));


//    }
//    public static int Add(int a, int b, int c=0,int d=0)
//    {
//        return a + b-c+d;
//    }
//    public static string Add(string s1, string s2 = null)
//    {
//        return s1 + " " + s2;
//    }
//    public static int Add(params int[] ar)
//    {
//        int sum = 0;
//        foreach ( int n in ar)
//        {
//            sum += n;
//        }
//        return sum;
//    }             
//}



using System;

class preri
{
    static void Main(string[] args)
    {
        Console.WriteLine((int)weekdays.wedn);
        Console.WriteLine(weekdays.sat);

        perimeter p = new perimeter();
        p.peri(6, perimeter.shape.circle); 
        p.peri(6, perimeter.shape.squre);  
            

    }
    enum weekdays
    {
        sun, mon, tue, wedn, thur, fri, sat
    }

}

public class perimeter
{
    public enum shape
    {
        circle, squre
    }

    public void peri(int val, shape s1)
    {
        if (s1 == 0)
        {
            Console.WriteLine($"circumference of circle is : {val*3.14*2}");
        }
        else
        {
            Console.WriteLine($"perimeter squre: {4*val}");
        }
    }


}