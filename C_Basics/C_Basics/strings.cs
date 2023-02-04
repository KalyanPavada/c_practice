using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Basics
{
    internal class strings
    {
        static void Main(string[] args)
        {
            string s1 = "100";
            int n;
            bool n1 = int.TryParse(s1, out n);
            Console.WriteLine(n1 +" "+ n);
           
            string s = n.ToString();
            Console.WriteLine(s.GetType());
            if(typeof(string) == s.GetType()) ;
            {
                Console.WriteLine(s);
            }

        }
    }
}
