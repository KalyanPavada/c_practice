using System.Collections;


namespace CollectionsDemo
{
    internal class sortlist
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();
           sl.Add(1, "The");
            sl.Add(2, "quick");
            sl.Add(3, "brown");
            sl.Add(4, "fox");
            sl.Add(14, "s4");
            sl.Add(15, "s5");
            sl.Add(16, "s6");
            sl.Remove(12);
            string v1 = sl[14].ToString();
            Console.WriteLine(v1);
            foreach (DictionaryEntry de in sl)
            {
                int key = (int)de.Key;
                string value = de.Value.ToString();

                Console.WriteLine($"{key} and {value}");

            }

        }
    }
}
