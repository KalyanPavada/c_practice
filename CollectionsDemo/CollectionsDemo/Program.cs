using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        ArrayList Al = new ArrayList();
        Al.Add("s1");
        Al.Add("s2");
        Al.Add("s3");
        Al.Add("s4");
        Al.Insert(2, "A1");
        Al.AddRange(new string[] { "a1", "a2" });
        Al.Remove("s4");
        Al.RemoveAt(0);
        Al.Sort();
        foreach (string s in Al)
        {
            Console.WriteLine(s);
        }

        string[] ar = (string[])Al.ToArray(typeof(string));
        Console.WriteLine(Al.Capacity + " " + Al.Count);
    }
}

class HashTable
{
    static void Main(string[] args)
    {
        Hashtable ht = new Hashtable();

        ht.Add(11, "s1");
        ht.Add(12, "s2");
        ht.Add(13, "s3");
        ht.Add(14, "s4");
        ht.Add(15, "s5");
        ht.Add(16, "s6");
        ht.Remove(12);
        string v1 = ht[13].ToString();
        Console.WriteLine(v1);
        foreach (DictionaryEntry de in ht)
        {
            int key = (int)de.Key;
            string value = de.Value.ToString();

            Console.WriteLine($"{ key} and { value}");

        }

    }
}