using System;

class cls1
{
    static void Main(string[] args)
    {
        int a,b,c;
        a = 10;
        b = 20;
        c = a;
        a = b;
        b = c;
        Console.WriteLine($"a={a} ,b={b}");

        Console.Write("enter first num: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("enter second num: ");
        b = int.Parse(Console.ReadLine());

        a = a + b;

        b = a - b;

        a = a - b;

        Console.WriteLine($"a={a},b={b}");

        



    }
}
