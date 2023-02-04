using System;

//namespace MyApplication
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

//            for (int i = 0; i < numbers.GetLength(0); i++)
//            {
//                for (int j = 0; j < numbers.GetLength(1); j++)
//                {
//                    Console.WriteLine(numbers[i, j]);
//                }
//            }
//        }
//    }
//}



public class Employee
{
    public string FN = "hello";
    public string LN = "welcome";

    public virtual void PrintName()
    {
        Console.WriteLine("Base class: {0} {1}", FN, LN);
    }
}

public class Fulltime : Employee
{
    public override void PrintName()
    {
        Console.WriteLine("Full Time: {0} {1}", FN, LN);
    }
}

public class PartTime : Employee
{
    public override void PrintName()
    {
        Console.WriteLine("Part Time: {0} {1}", FN, LN);
    }
}

class Programm
{
    static void Main(string[] args)
    {

        Employee[] emp = new Employee[3];
        emp[0] = new Employee();    
        emp[1] = new Fulltime();
        emp[2] = new PartTime();
        foreach(Employee e in emp)
        {
            e.PrintName();
        }

        //Employee emp = new Employee();
      
        //Fulltime Ft = new Fulltime();

        //PartTime PT = new PartTime();

        //PT.PrintName();
        //Ft.PrintName();
        //emp.PrintName();

    }
}