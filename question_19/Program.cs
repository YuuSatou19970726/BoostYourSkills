using System;
using System.Collections.Concurrent;

namespace question_19
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Test test = new Test();
            int option = 0;
            while (true)
            {
                Console.WriteLine("1. Add Worker");
                Console.WriteLine("2. Find Over Time");
                Console.WriteLine("3. Display All");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Input your option: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        test.Add();
                        break;
                    case 2:
                        test.OverTime();
                        break;
                    case 3:
                        test.DisplayAll();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    Default:
                        Console.WriteLine("Invalid option!");

                }
            }
        }
    }
}