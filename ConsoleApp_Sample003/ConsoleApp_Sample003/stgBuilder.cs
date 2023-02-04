using System;

using System.Text;


namespace ConsoleApp_Sample003
{
    class stgBuilder
    {
        public static void str()
        {
            string s = "";
            for(int i = 0; i < 100; i++)
            {
                s += 'A';
            }
            Console.WriteLine(s);
        }

        public static void strBUD()
        {
            StringBuilder sb = new StringBuilder(); 
            for (int i = 0; i < 100; i++)
            {
                sb.Append('a');
                Console.WriteLine($"{"this is capacity :" + sb.Capacity} {sb.Length}");

            }
            
            Console.WriteLine(sb);
        }

        static void Main(string[] args)
        {
            str();
            strBUD();
        }
    }
}
