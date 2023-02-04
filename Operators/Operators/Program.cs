using System;

class operends
{
    static void Main(string[] args)
    {
        //int n1 = 130;
        //int n2 = 20;
        //int max;
        //max = (n1>n2)?n1:n2;   // ternary operators give single line condition
        //Console.WriteLine($"max num is {max}");

        int n;

        if (args.Length == 0)
            Console.WriteLine("please enter a number");
        else if (int.TryParse(args[0], out n))
        {
            if (n % 2 == 0)
            {
                Console.WriteLine($"number is even {n}");
            }
            else
            {
                Console.WriteLine($"number is odd {n}");
            }
        }
        else
        {
            Console.WriteLine("It's allowed only numbers");
        }

    }
}