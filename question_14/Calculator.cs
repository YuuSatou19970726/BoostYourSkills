using System;
namespace question_14
{
	public class Calculator
	{
        public event CalculationHandler CalculationComplete;

        public Calculator()
		{
		}

        public void InputValue(int x, int y)
        {
            if(CalculationComplete != null)
            {
                CalculationComplete(x, y);
            }
        }

        public void Add(int x, int y)
        {
            Console.WriteLine(x + " + " + y + " = " + (x + y));
        }

        public void Subtract(int x, int y)
        {
            Console.WriteLine(x + " - " + y + " = " + (x - y));
        }

        public void Multiply(int x, int y)
        {
            Console.WriteLine(x + " * " + y + " = " + (x * y));
        }

        public void Divide(int x, int y)
        {
            Console.WriteLine(x + " / " + y + " = " + (x / y));
        }
    }
}

