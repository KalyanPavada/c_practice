using System;

interface IFigure
{
    int Dimension { get; set; }
    double Area();
    double Perimeter();

}

class Circle : IFigure
{
    public Circle() { }
    public Circle(int radius)
    {
        Dimension = radius;
    }

    public int Dimension
    { get; set; }


    double IFigure.Area()  // if not use public than we use the Ifigure.
    {
        return Math.PI * Dimension * Dimension;
    }
    public double Perimeter()
    {
        return 2 * Math.PI * Dimension;
    }
}

class Squre : IFigure
{
    public Squre(int side)
    {
        Dimension = side;
    }

    public int Dimension { get; set; }  
    
     
    public double Area()
    {
        return Dimension * Dimension;
    }
    public double Perimeter()
    {
        return 4 * Dimension;
    }

}

class Impelement
{
    static void Main(string[] args)
    {
        IFigure fig;
        //if(args.Length == 0)
        //{
        //    Console.WriteLine("Please provide a clr arg");
        //}
        if (args[0] == "r")
        {
            fig = new Circle(10);

        }
        else
        {
            fig = new Squre(20);
        }

        Console.WriteLine(fig.Area());
        Console.WriteLine(fig.Perimeter());

    }
}