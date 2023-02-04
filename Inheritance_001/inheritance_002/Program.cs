using System;

public class Parent
{
    public string _name;
    //public int _maks;
    public Parent()
    {
        Console.WriteLine("this parent method");
    }

    public Parent(string msg)
    {
        _name = msg;
        Console.WriteLine("2nd constructor of parent:"+ msg);
    }
}



public class Child : Parent
{
    public Child()/*:base("WELCOME")*/
    {
        Console.WriteLine("this child class");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Child CC = new Child();
        CC._name
    }
}