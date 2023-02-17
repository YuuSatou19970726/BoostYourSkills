using System;

namespace question_10
{
    //khởi tạo delegate kiểu: method chỉ có một tham số kiểu int
    public delegate void MyDelegate(int number);

    internal class Program
    {
        //khởi tạo hàm cùng kiểu tham số int với delegate
        static void PrintNumber1(int number)
        {
            Console.WriteLine("The number 1 is " + number);
        }

        static void PrintNumber2(int number)
        {
            Console.WriteLine("The number 2 is " + number);
        }

        static void Main(string[] args)
        {
            //truyền PrintNumber1 cùng kiểu tham số với delegate 
            MyDelegate del = new MyDelegate(PrintNumber1);
            //delegate có thể nhận cùng lúc nhiều hàm cùng kiểu với nó 
            del += PrintNumber2;
            //del hiện tại ta sẽ có được cả 2 hàm được truyền là PrintNumber1, PrintNumber2

            //truyền tham số cho delegate, delegate sẽ gửi đến những hàm mà nó được truyền
            del(42);
            //del hiện tại đang truyền cho PrintNumber1(42), PrintNumber2(42)

        }
    }
}