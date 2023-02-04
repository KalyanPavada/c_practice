using System;

public class Student
{
    public string F_Name;
    public string L_name;
    

    public void PrintFName()
    {
        Console.WriteLine("Base Class:{0} {1}",F_Name,L_name);
    } 

}

public class details : Student  //,marks not supported the multiple inheritance
{
    public string _Email;
    public int _Phone;

    public void PrintDetails()
    {
        Console.WriteLine("deriverd class: {0} {1}",_Email,_Phone);
    }
}

public class marks: details
{
    public int total_marks;
    public void SumOfMarks()
    {
        Console.WriteLine("child class- sum of the marks: {0}",total_marks);
    }


}
public class inheri_Programm
{
    static void Main(string[] args)
    {
        /*details Dt = new details();
        Dt._Email = "a1@gmail.com";
        Dt._Phone = 1234;
        Dt.F_Name = "abc";
        Dt.L_name = "xyz";
        Dt.PrintFName();
        Dt.PrintDetails();*/


        marks Mk = new marks();
        Mk._Email = "a1@gmail.com";
        Mk._Phone = 1234;
        Mk.F_Name = "abc";
        Mk.L_name = "xyz";
        Mk.total_marks = 599;
        Mk.SumOfMarks();
        Mk.PrintFName();
        Mk.PrintDetails();
    }
}