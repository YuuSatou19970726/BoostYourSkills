using System;

namespace question_14
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            calculator.CalculationComplete += calculator.Add;
            calculator.CalculationComplete += calculator.Subtract;
            calculator.CalculationComplete += calculator.Multiply;
            calculator.CalculationComplete += calculator.Divide;

            Console.WriteLine("Input x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Input y: ");
            int y = int.Parse(Console.ReadLine());

            calculator.InputValue(x, y);
        }
    }
}