using System;
namespace question_19
{
	internal class Worker : Employee
	{
        public string Name { get; set; }
        public double Salary { get; set; }
        public int Workday { get; set; }
        public double BASIC = 50;

        public Worker()
		{
		}

        public double calculateSalary()
        {
            return this.Workday * BASIC / 22;
        }

        public string display()
        {
            return "Name: " + this.Name + " | workday: " + this.Workday + " | Salary: " + this.Salary;
        }

        public void input()
        {
            string name;
            int workday;
            while (true)
            {
                Console.WriteLine("Input name: ");
                name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(name)){
                    this.Name = name;
                    break;
                }
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("Input workday: ");
                    workday = int.Parse(Console.ReadLine());
                    if(workday >= 0 && workday <= 31)
                    {
                        this.Workday = workday;
                        break;
                    }
                } catch (Exception)
                {

                }
            }

            this.Salary = calculateSalary();


        }
    }
}

