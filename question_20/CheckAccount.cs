using System;

namespace question_20
{
    internal class CheckAccount
    {
        static void Main(string[] args)
        {
            Account account = new Account("kuuhaku", 150);
            int option = 0;
            while (true)
            {
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Show");
                Console.WriteLine("4. Quit");
                Console.WriteLine();
                Console.Write("Input your option: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        account.Deposit();
                        break;
                    case 2:
                        account.Withdraw();
                        break;
                    case 3:
                        account.Display();
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