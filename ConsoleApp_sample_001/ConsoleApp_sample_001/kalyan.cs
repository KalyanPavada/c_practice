//see https://aka.ms/new-console-template for more information
using System;

using static practice;

class program001
{
    static void Main1()
    {
        string str = "1729";
        int i1 = 0;
        bool issucess = int.TryParse(str, out i1);
        if (issucess)
        {
            Console.WriteLine(i1);
        }
        else
        {
            Console.WriteLine("please provide valid data");
        }
    }
    static void Main2()
    {
        Console.Write("please enter firstname : ");
        string fname = Console.ReadLine();
        Console.Write("please enter lastname : ");
        string lname = Console.ReadLine();
        //Console.WriteLine("my name is " + name);
        Console.WriteLine("hello {0} {1}", fname, lname);  // using place holders 
    }

    static void Main(string[] args)
    {

        float f = 89;
        int i = (int)f;
        Console.WriteLine("mini value of int = {0}", int.MinValue);
        Console.WriteLine("max value of int = {0}", int.MaxValue);
        Main1();
        Main2();
        Console.WriteLine(i);

        string name = "\"kalyan\"";  // using escape sequences


        string name1 = "c:\\kalyan\\c#\\practice\\hard";   // if we want back slashes in the output ,
                                                          //this called escape squence


        Console.WriteLine("one\ntwo");  // new line purpose

        string name2 = @"c:\\kalyan\\c#\\practice\\hard";  // this is called verbatim literal 

        Console.WriteLine(name);
        Console.WriteLine(name1);
        Method2();


    }


}

