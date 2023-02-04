using System;

class Circle
{
    int _radius;
    public static float _PI; // we can invoke the static variable/methods by using class name;

    static Circle()  /* static constructor called only once, but instance constructor 
                      invoked dependance on how many objects we create*/
    {
        Circle._PI = 3.14f;
        Console.WriteLine("this static constructor");
    }
    public Circle(int radius)
    {
        _radius = radius;
        Console.WriteLine("this is instance constructor");
    }
    public float Calculate_Radius()
    {
        return Circle._PI * _radius * _radius;
    }
}

class AreaOfCircle
{
    public static void Main(string[] args)
    {
        Circle C1 = new Circle(6);
        float Area = C1.Calculate_Radius();
        Console.WriteLine("Area of the Circle: {0}", Area);

        Circle C2 = new Circle(8);
        float Area1 = C2.Calculate_Radius();
        Console.WriteLine("Area of Circle: {0}", Area1);

    }
}
