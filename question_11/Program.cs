using System;

namespace question_11
{
    public delegate void Value(int x, int y);

    internal class Program
    {

        static void Add(int x, int y)
        {
            Console.WriteLine(x + " + " + y + " = " + (x + y));
        }

        static void Sub(int x, int y)
        {
            Console.WriteLine(x + " - " + y + " = " + (x - y));
        }

        static void Mul(int x, int y)
        {
            Console.WriteLine(x + " * " + y + " = " + (x * y));
        }

        static void Div(int x, int y)
        {
            Console.WriteLine(x + " / " + y + " = " + (x / y));
        }

        static void Main(string[] args)
        {
            Value value = new Value(Add);
            value += Sub;
            value += Mul;
            value += Div;

            value(4, 2);
        }
    }
}