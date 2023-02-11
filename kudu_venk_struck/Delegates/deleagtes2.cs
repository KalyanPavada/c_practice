using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;


public delegate bool IsPromote(Employee Iseligible);
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int salary { get; set; }


    public static void compareemp(List<Employee> emplist,IsPromote IstrueOrNot)
    {
        foreach (Employee Eligiblestud in emplist)
        {
            if (IstrueOrNot(Eligiblestud))
            {
                Console.WriteLine($"promoted = {Eligiblestud.Name}");
            }
        }
    }
}
public class Program1
{
    static void Main(string[] args)
    {

        List<Employee> empl = new List<Employee>();
        empl.Add(new Employee() { Id = 1,Name = "abc1",salary = 6});
        empl.Add(new Employee() { Id = 2, Name = "abc2", salary = 5 });
        empl.Add(new Employee() { Id = 3, Name = "abc3", salary = 3 });
        
        //IsPromote IsEmp = new IsPromote(Promote);
         Employee.compareemp(empl,Isemp=> Isemp.salary >= 5);  // lamda function


        // static bool Promote(Employee emp1)
        //{
        //    if (emp1.salary >= 5)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        
    }
}

