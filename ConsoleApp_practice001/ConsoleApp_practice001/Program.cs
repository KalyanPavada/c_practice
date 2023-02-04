using System;

class table_form
{
    static void Main(string[] args)
    {
        Console.Write("Enter a Number: ");
        int n = int.Parse(Console.ReadLine());
        string s = "";
        for(int i = 1; i <= 12; i++)
        {
            s += n +"*"+ i + "=" + n * i +'\n';
         
        }
        Console.WriteLine(s);   
    }
}