using System;

public class Student
{
    private int _id;
    private string _Name;
    private int _passmarks;

    public void setId(int id)
    {
        if (id <= 0)
        {
            throw new Exception("id must have positive value");

        }
        _id = id;
    }
    public int getId()
    {
        return _id;
    }
}

public class program
{
    public static void Main()
    {
        Student student = new Student();
        student.setId(89);
        Console.WriteLine("id = {0}",student.getId());
    }
}



