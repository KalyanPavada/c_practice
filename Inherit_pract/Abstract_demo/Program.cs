using System;

abstract class Figure
{
    public int Dimension;
    public Figure()  // perimeter less constructor
    {

    }
    public Figure(int dimension)  // perimeterized constructor
    {
        Dimension = dimension;
    }

    public abstract double Area();
    public abstract double Perimeter();

}
class Circle : Figure
{
    public Circle() { } // perimeter less constructor
    public Circle(int radius) : base(radius)   // perimeterized constructor
    {

    }

    public override double Area()
    {
        return Math.PI * Dimension * Dimension;
    }
    public override double Perimeter()
    {
        return 2 * Math.PI * Dimension;
    }
}

class Squre : Figure
{
    public Squre() { } // perimeter less constructor
    public Squre(int radius) : base(radius)   // perimeterized constructor
    {

    }
    public override double Area()
    {
        return Dimension * Dimension;
    }
    public override double Perimeter()
    {
        return 4 * Dimension;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Figure fig;


        if (args[0] == "r")
        {
            fig = new Circle(15);

        }
        else
        {
            fig = new Squre(10);

        }
        //fig.Dimension = 10;
        Console.WriteLine(fig.Area());
        Console.WriteLine(fig.Perimeter());

    }
}
//using System;

//class Point : Object
//{
//    public int x, y;

//    public override string ToString()
//    {
//        return x+" "+y;
//    }
//}

//class Pr1
//{
//    static void Main(string[] args)
//    {
//        Point point = new Point() { x= 10, y=20};
//        Console.WriteLine(point);

//    }
//}