using System;
using System.Collections;

namespace hashtabless
{
    class hashtables
    {
        static void Main(string[] args)
        {
            // add to a hashtable
            Hashtable myhashtable = new Hashtable();
            myhashtable.Add("0", "zero");
            myhashtable.Add("1", "one");
            myhashtable.Add("2", "two");

            ICollection c = myhashtable.Keys;

            // return all values
            foreach (string str in c)
                Console.WriteLine(str + ": " + myhashtable[str]);

            //delete from a hash table - remove '2' value
            myhashtable.Remove("2");
            foreach (string str in c)
                Console.WriteLine(str + ": " + myhashtable[str]);

            // search hashtable for an entry
            Console.WriteLine(myhashtable.ContainsKey("2"));
            Console.WriteLine(myhashtable.ContainsValue("one"));
            Console.WriteLine();


        }
    }
    class Program
    {
        const int size = 5; //constant prime number size
        static void Main(string[] args)
        {
            Console.WriteLine("1. Add to hash table 2. Search hash table 3. Delete hash entry 4. Print hash table 5. Output load factor");
            Console.ReadLine();
        }
    }
}
