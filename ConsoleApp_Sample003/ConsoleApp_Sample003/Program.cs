using System;

class strig_uses
{
    static void Main1(string[] args)
    {
        //Console.Write("Enter a character : ");
        //string s = Console.ReadLine();
        //char c = char.Parse(s);
        //int n = c;
        //Console.WriteLine(n);
       
        Console.Write("Enter a number : ");
        string s = Console.ReadLine();
        int n = int.Parse(s);
        char c = (char) n;
        Console.WriteLine(c);
    }

    static void Main(string[] args)
    {
        //string s = "kalyan";
        ////s.Replace("a", "m");   /* S Replaced but not stored */

        //s = s.Replace("a", "m");  /* we got exact result */

        //Console.WriteLine(s);


        string s = "";

        for (int i = 0; i <3; i++)
        {
            s += 'a';
           
        }
        Console.WriteLine(s);
    }

}