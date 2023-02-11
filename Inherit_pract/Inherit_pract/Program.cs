using System;

class Parent
{
    public virtual void Foo()
    {
        Console.WriteLine("In Parent");
    }
}
class Child : Parent
{
    public override  void Foo()
    {
        Console.WriteLine("In Child");
    }
}
class GrandChild : Child
{
    public new virtual void Foo()
    {
        Console.WriteLine("In Grand Child");
    }
}

class BindingDemo
{
    static void Main(string[] args)
    {
        Parent p;
        Child c;
        GrandChild G;

        p = new GrandChild();
        p.Foo();
    }
}
