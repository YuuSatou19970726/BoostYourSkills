using System;
namespace question_20
{
	public class Account
	{
		public string name { get; set; }
		public int balance { get; set; }

        Validate validate = new Validate();

        public Account()
		{
		}

		public Account(string name, int balance)
		{
			this.name = name;
			this.balance = balance;
            validate.Print += validate.checkVaild;
        }

		public void Deposit()
		{
            while (true)
			{
				try
				{
                    Console.Write("Input deposit: ");
                    int val = int.Parse(Console.ReadLine());
					if(val < 100)
					{
						validate.check("Invalid amount for deposit. Please enter other value!");
					} else
					{
						balance += val;
						break;
					}
                }
				catch (Exception)
				{
                    validate.check("Invalid amount for deposit. Please enter other value!");
                }
			}
            Console.WriteLine();
		}

        public void Withdraw()
        {
            while (true)
            {
                try
                {
                    Console.Write("Input withdraw: ");
                    int val = int.Parse(Console.ReadLine());
                    if (val < 100 || val > balance)
                    {
                        validate.check("Invalid amount for withdraw. Please enter other value!");
                    }
                    else
                    {
                        balance -= val;
                        break;
                    }
                }
                catch (Exception)
                {
                    validate.check("Invalid amount for withdraw. Please enter other value!");
                }
            }
            Console.WriteLine();
        }

        public void Display()
        {
            Console.WriteLine("Account name: " + name);
            Console.WriteLine("Account balance: " + balance);
            Console.WriteLine();
        }
    }
}

