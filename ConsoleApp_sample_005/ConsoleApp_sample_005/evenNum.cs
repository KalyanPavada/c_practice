using System;


namespace ConsoleApp_sample_005
{
    internal class evenNum
    {
        static void Main()
        {
            Console.Write("Enter your num: ");
            int n = int.Parse(Console.ReadLine());
            
            for(int start=0; start<=n; start++)
            {
                
                Console.WriteLine(n+"*"+start+" = " +n*start);
                
             
            }  
            
        
        }
       
    }
}
