using System;

class Array_practice
{
    static void Main(string[] args)
    {
        Console.Write("Enter your num: ");
        int n = int.Parse(Console.ReadLine());
        int[] ary = new int[n];
        for(int i= 0; i<n;i++)  
        {
            Console.Write("Enter your num: ");
            ary[i] = int.Parse(Console.ReadLine());
        }
        int sum = 0;
        for(int i= 0; i<n;i++)
            sum +=ary[i];
        Console.WriteLine(sum);
    }
        
}
