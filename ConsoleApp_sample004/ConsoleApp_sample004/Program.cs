using System;

class arrayProgram
{
    static void array()
    {
        int[] evennumbers = new int[3];
        evennumbers[0] = 0;
        evennumbers[1] = 2;
        evennumbers[2] = 4;
        Console.WriteLine(evennumbers[2]);
    }
    static void Main1()
    {
        Console.Write("Enter your Number : ");
        int userno = int.Parse(Console.ReadLine());
        if (userno==1)
        {
            Console.WriteLine("numer is "+userno);
        }
        else if (userno == 2)
        {
            Console.WriteLine("Number is "+userno);
        }
        else
        {
            Console.WriteLine("number is out of raange");
        }
        array();
    }

     //static void Main(string[] args)
     //{
     //    Console.Write("Enter your Number : ");
     //    int userno = int.Parse(Console.ReadLine());
     //    switch (userno)
     //    {
           /*  case 10:
                 Console.WriteLine("your number is{0}",userno);
                 break;
             case 20:
                 Console.WriteLine("your number is{0}",userno);
                 break ;

             default:
                 Console.WriteLine("number is out of range");
                 break;  */

          /*  case 10:
            case 20:
            case 30:
                Console.WriteLine("your number is: {0}",userno);
                break;
            default:
                Console.WriteLine("out of range");
                break;  */


     //    } 

     //}

    static void Main(string[] args)
    {
        
    }

}