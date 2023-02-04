using System;

class trying1
{
    static void Main1(string[] args)
    {
        for(int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (i == j)
                    break;
                Console.WriteLine(i + " " + j);
            }
            
        }    
    }

    static void Main(string[] args)
    {
        int options;
        do
        {
            Console.Write("enter 1st num: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("enter 2nd num: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("enter your option: ");
            options = int.Parse(Console.ReadLine());    
            if(options==1)
                Console.WriteLine(a+b);
            else if(options==2)
                Console.WriteLine(a*b);


        }
        while (true);   
      

    


    }
}