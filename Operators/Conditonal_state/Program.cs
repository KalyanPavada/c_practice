using System;

class check_while
{
    static void Main(string[] args)
    {
        //int n = 0;
        //while (n < 10)
        //{
        //    n++;
        //    Console.WriteLine($"hello {n}");
        // }

        //int n;
        //Console.Write("Table of: ");
        //n = int.Parse((Console.ReadLine()));
        //string s = "";
        //for (int i = 1; i <+ 10; i++)
        //{
        //    s =s+ n + "*" + i + "=" + n * i + "\n";

        //}
        //Console.WriteLine(s);


        int k = 0;
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j <= i; j++)
                Console.Write(k++ + "\t");
            Console.WriteLine();
        }



    }
}