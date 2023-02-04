using System;

class Method_Call
{
    public static void Main(string[] args)
    {
        Method_Call.EvenNumbers();

        Method_Call ob = new Method_Call();
        Console.WriteLine("sum = {0}", ob.Add(30, 40));
        int sum = ob.Add(30, 90);
        Console.WriteLine($"thi sum is: {sum}");
    }
    
    public int Add(int a,int b)
    {
        return a + b;   
    }
    public static void EvenNumbers()
    {
        int start = 0;
        while(start <= 10)
        {
            Console.WriteLine("EvenNumber is: " + start );
            start = start + 2;
        }
            
    
    }
}
