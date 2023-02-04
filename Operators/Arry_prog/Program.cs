using System;

class Progr_arry
{
    static void Main(string[] args)
    {
        Console.Write("enter the length of num: ");

        int n = int.Parse(Console.ReadLine());
        int[]ar = new int[n];
        int sum = 0;
        for(int i = 0; i < ar.Length; i++)
        {
            Console.Write("enter the " + (i+1) + " number:"  );
            ar[i] = int.Parse(Console.ReadLine());
            sum = sum + ar[i];

        }
        Console.WriteLine($"avg of {1.0*sum/n}");

        for (int i = ar.Length-1; i >= 0; i--)
        {
            Console.WriteLine(ar[i]);
        }
    }
}