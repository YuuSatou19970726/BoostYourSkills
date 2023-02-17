using System;
using System.Collections;

namespace question_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //demo ArrayList
            ArrayList list = new ArrayList();
            list.Add("abc");
            list.Add(2023);
            list.Add("Hello World!");

            Console.WriteLine("Array List: ");
            foreach(object i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //demo Hashtable
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "abc");
            hashtable.Add(3, 2023);
            hashtable.Add(2, "Hello World!");

            Console.WriteLine("Hashtable: ");
            foreach (DictionaryEntry i in hashtable)
            {
                Console.WriteLine(i.Key + " : " + i.Value);
            }
            Console.WriteLine();

            //demo SortedList
            SortedList sorted = new SortedList();
            sorted.Add(1, "abc");
            sorted.Add(3, 2023);
            sorted.Add(2, "Hello World!");

            Console.WriteLine("SortedList: ");
            foreach (DictionaryEntry i in sorted)
            {
                Console.WriteLine(i.Key + " : " + i.Value);
            }
            Console.WriteLine();
            Console.WriteLine(sorted[1]);
        }
    }
}