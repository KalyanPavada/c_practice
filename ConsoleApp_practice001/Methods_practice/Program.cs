using System;

class program
{
    static void Main(string[] args)
    {
        program ob = new program();
        ob.EvenNum(30);
    }
    public void EvenNum(int a)
    {
       int start = 0;
        while(start <= a)
            Console.WriteLine(start);
            start=start+2;
    }
}