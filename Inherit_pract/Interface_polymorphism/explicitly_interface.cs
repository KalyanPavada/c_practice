using System;

interface IA1
{
    void foo1();
    void foo2();
}
interface IA2
{
    void foo2();
    void foo3();
}

class CA : IA1, IA2
{
    public void foo1()
    {
        Console.WriteLine("IA1");
    }
     void IA2.foo2()
    {
        Console.WriteLine("not public IA2");
    }   void IA1.foo2()
    {
        Console.WriteLine("not public IA1");
    }

    public void foo3()
    {
        Console.WriteLine("IA3");
    }
}

class Programm
{
    static void Main(string[] args)
    {
        CA a; 
        IA1 a1; 
        IA2 a2;

        a = new CA();
        a2 = new CA();
        a.foo1();
        a2.foo2();
        a.foo3();

        //a =(CA)a1;
        a1 = a;
        //a2 = a;
    }
}