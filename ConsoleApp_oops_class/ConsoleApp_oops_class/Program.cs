using System;

//for (int i = 1; i < 10; i++)
//{
//    for(int j = 1; j<=i; j++)
//        Console.Write("*");
//    Console.WriteLine("");
//}

class program
{
    string _firstName;
    string lastName;

    public program(string first,string last)
    {
        _firstName = first;
        lastName = last;
       
    }

    public void PrintName()
    {
        Console.WriteLine("full Name : {0} {1}",_firstName,lastName);
    }
}

class obj
{
   public static void Main(string[] args)
    {
        program ob = new program("hi", "hello");
        ob.PrintName();
    }
}