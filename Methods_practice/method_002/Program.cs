using System;

class Program
{
    static void Main(string[] args)
    {
        //int add = Program.Add(10, 8, 70);
        //Console.WriteLine(Program.Add(10, 8));

        //Console.WriteLine(Program.Add(s1: "hello", s2: " puli", s3: " hi"));

        //Console.WriteLine("three numbers sum: {0}", add);
        //Console.WriteLine(add2);

        Console.WriteLine(Add_arry(12,23,45,67));






    }

    public static int Add(int a, int b, int c = 0)
    {
        return a + b + c;
    }
    public static string Add(string s1, string s2, string s3 = null)
    {
        return s1 + s2 + s3;
    }

    public static int Add_arry(params int[] ary)
    {
        int sum = 0;
        foreach (int n in ary)
        {
            sum = sum + n;
            //return sum; 

        }
        return sum ;

    }
}
