using System;

namespace question_9
{
    //tạo 1 delegate nhận 1 tham số kiểu int, kiểu trả về: void
    public delegate void IntAction(int x);

    internal class Program
    {

        public class Counter
        {
            //khởi tạo event tương ứng với delegate
            public event IntAction Counted;


            public void Count(int n)
            {
                for(int i = 0; i < n; i++)
                {
                    Console.WriteLine(i);
                    //khởi chạy event IntAction có nhiệm vụ lặp lại Count 1 lần
                    Counted?.Invoke(i);
                }
            }
        }

        static void Main(string[] args)
        {
            Counter counter = new Counter();
            //
            counter.Counted += delegate (int x)
            {
                Console.WriteLine(x);
            };
            counter.Count(5);
        }
    }
}