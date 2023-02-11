
using System;
using System.ComponentModel;


public class Program
{


    public delegate void add(int a, int b);

    public delegate void sub(int a, int b);

    public static void sum(int x, int y)
    {
        Console.WriteLine($"sum of {x + y}");
    }
    public static void substrack(int m, int n)
    {
        Console.WriteLine($"{m - n}");
    }
    static void Main(string[] args)
    {
        add a = new add(sum);
        a(21, 90);

        sub s = new sub(substrack);

        s(50, 30);
    }
}