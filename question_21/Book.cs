using System;
namespace question_21
{
	internal class Book : Library
	{
        public string title { get; set; }
        public double price { get; set; }
        public bool isSale { get; set; }

		public Book()
		{
		}

        public override void bookInfo()
        {
            Console.WriteLine("Title: " + title + " | Price: " + price + " | Sale: " + isSale);
        }
    }
}

