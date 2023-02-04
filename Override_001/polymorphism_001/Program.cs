using System;

public class Base
{
    public void print()
    {
        Console.WriteLine("this is base");
    }
}
public class child : Base
{
    public new void print()
    {
        Console.WriteLine("this is child");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Base Cd = new child();
        Cd.print();
    }
}