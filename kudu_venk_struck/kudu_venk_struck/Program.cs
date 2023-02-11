//using System;

//public class Property
//{
//    public int Id { get; set; }
//    public string Name { get; set; }    
//}

//public class Program {
//    static void Main(string[] args)
//    {
//        Property p1 = new Property();

//        p1.Id = 10;
//        p1.Name = "kalyan";

//        Property p2;
//        p2 = p1;

//        p2.Name = "maro";

//        Console.WriteLine($"name = {p1.Name} && {p2.Name}");
//    }
//}


using System;

interface I1       // multiple interfaces
{
    void print();
}
interface I2 : I1
{
    void print();
}

public class intr_imple : I2
{
     public void print()
    {
        Console.WriteLine("this is I1 interface");
    }  
    void I2. print()
    {
        Console.WriteLine("this is I2 interface");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        intr_imple p = new intr_imple();

        p.print();
        ((I2)p).print();

        //((I1)p).print(); 
        //((I2)p).print();

        //I1 P1 = new intr_imple();

        //I2 P2 = new intr_imple();

        //P1.print();
        //P2.print();
    }
}