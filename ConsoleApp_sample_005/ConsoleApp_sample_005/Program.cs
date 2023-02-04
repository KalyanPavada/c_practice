//using System;

//class conditionals
//{
//    static void Main(string[] args)
//    {
//        start:
//            Console.Write("Enter your Number: ");
//            int userNo = int.Parse(Console.ReadLine());
//        int num = 0;
//        while (num <= userNo)
//        {
//            Console.Write(num + " ");
//            num = num + 2;
//        }
//        decide:
//            Console.Write("do you want to continue Yes / No: ");
//            string UserChoice = Console.ReadLine().ToUpper();
//        if (UserChoice=="YES")
//        {
//            goto start;
//        }
//        else if (UserChoice!="YES" && UserChoice!="NO")
//        {
//            Console.WriteLine("Please Enter Valid Choice");
//            goto decide;
//        }
//    }
//}
