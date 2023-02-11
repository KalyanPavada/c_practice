using System;

public delegate void SampleDelegate();
class SampleProgram
{
    static void Main(string[] args)
    {
        //SampleDelegate del = new SampleDelegate(SampleMethode1);
        //del();
        //SampleDelegate del1, del2, del3,del4;

        //del1 = new SampleDelegate(SampleMethode1);
        //del2 = new SampleDelegate(SampleMethode2);
        //del3 = new SampleDelegate(SampleMethode3);

        //del4 = del1+del2 -del2 + del3;
        //del4();

        SampleDelegate del = new SampleDelegate(SampleMethode1);
        del += SampleMethode2;
        del += SampleMethode3;
        del();
    }
    public static void SampleMethode1()
    {
        Console.WriteLine("Its invoked Methode1");
    }
    public static void SampleMethode2()
    {
        Console.WriteLine("Its invoked Methode2");
    }
    public static void SampleMethode3()
    {
        Console.WriteLine("Its invoked Methode3");
    }
}