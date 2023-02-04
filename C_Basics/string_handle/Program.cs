using System;

class str_check
{
    static void Main(string[] args)
    {
        //Console.Write("Enter A Num1: ");
        //string s = Console.ReadLine();
        ////int n = int.Parse(s);
        ////Console.Write("Enter A Num2: ");
        ////string s1 = Console.ReadLine();
        ////int n1 = int.Parse(s1);
        ////int sum = n + n1;
        ////Console.WriteLine("sum of : '='" + sum);
        ////int n;
        ////bool n1 = int.TryParse(s, out n);
        ////char c = (char)n;
        ////Console.WriteLine(c);

        //char c = char.Parse(s);
        //int n = c;
        //Console.WriteLine(n);


        //int n1 = 10;
        //int n2 = 20;
        //Console.WriteLine($"the sum of {n1} and {n2} is = {n1 + n2} ");
        //string s = "";
        //Console.WriteLine(n1.GetType());

        //Console.WriteLine(string.IsNullOrEmpty(s));

        //string s = "";

        //System.Text.StringBuilder sb = new System.Text.StringBuilder();

        //for(int i =0; i<100; i++)
        //{
        //    sb.Append('A');
        //    Console.WriteLine($"{sb.Capacity}and{sb.Length}");
        //}
        //s = sb.ToString();
        //Console.WriteLine(s);


        dayofweeks day = dayofweeks.sat;
        int n = 7;
        day  = (dayofweeks)n;
        
        Console.WriteLine(day);

    }
    enum dayofweeks : int
    {
        sun , mon ,tues, wednes, thurs, fri, sat
    }
}