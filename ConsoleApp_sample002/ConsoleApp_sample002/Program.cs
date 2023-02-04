//using System;

//class prime_find
//{
//    static void Main(string[] args)
//    {
//        bool isprime = true;
//        foreach (int n in Enumerable.Range(1, 100))
//        {
//            if (n > 1)
//            {
//                foreach (int i in Enumerable.Range(2, n))
//                {
//                    if (i != n && n % i == 0)
//                    {
//                        isprime = false;
//                        break;
//                    }

//                }
//                if (isprime)
//                {
//                    Console.WriteLine("its prime find " + n);

//                }
//                isprime = true;
//            }
//            Console.ReadLine();
//        }
//    }

//}





//class Program
//{
//    static void Main(string[] args)
//    {
//        bool isPrime = true;
//        Console.WriteLine("Prime Numbers : ");
//        for (int i = 2; i <= 100; i++)
//        {
//            for (int j = 2; j <= i; j++)
//            {

//                if (i != j && i % j == 0)
//                {
//                    isPrime = false;
//                    break;
//                }

//            }
//            if (isPrime)
//            {
//                Console.WriteLine(i);
//            }
//            isPrime = true;
//        }

//    }
//}
