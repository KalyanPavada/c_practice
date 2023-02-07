using System;
using System.Diagnostics.CodeAnalysis;

class arithamatic
{
    static void Main(string[] args)
    {
        //int n = 0;
        //for (int i = 1; i < 6; i++)
        //{
        //    Console.WriteLine(i);
        //    n+=i;
        //}
        //Console.WriteLine($"sum of numbers {n}");
        // int s1,s2,s3,s4;
        //Console.WriteLine("Enter subject marks: ");
        //s1 = int.Parse(Console.ReadLine());
        //s2 = int.Parse(Console.ReadLine());
        //s3 = int.Parse(Console.ReadLine());
        //s4 = int.Parse(Console.ReadLine());
        //int sum;
        //int total = 800;
        //sum = (s1+s2+s3+s4);
        //float per = (sum * 100) / total;
        //Console.WriteLine($"percentage is: {per}");

        //for (int i = 0; i < 5; i++)
        //{
        //    for (int j = 0; j <= i; j++)
        //    {
        //        Console.Write("*");
        //    }
        //    Console.WriteLine();
        //}

        Console.Write("enter a number: ");
        int n = int.Parse(Console.ReadLine());
        //for (int i = 0; i < n; i++)
        //{
        //    var res = (n == 0) ? "enter greater than one" : "good";
        //    Console.WriteLine(res); 
        //}  

        int a, b, c;
        a = 0; b = 1;
        if (n == 0)
        {
            Console.Write(n);
        }
        else
        {
            Console.Write(a + " " + b+" ");
            for (int i = 0; i < n; i++)
            {
               
                c = a + b;
                Console.Write(c+" ");
                a = b;
                b = c;
            }
        }

   

    }
}