using System;
using System.Collections.Generic;

namespace question_21
{
	internal class BookManage : IEnumerable
    {
		List<Book> bookList = new List<Book>();

		public BookManage()
		{
		}

		public void createBook(Book book)
		{
			bookList.Add(book);
			Console.WriteLine();
		}

		public void findByIsSale()
		{
			int flag = -1;
			foreach(Book book in bookList)
			{
				if (book.isSale)
				{
					book.bookInfo();
					flag++;

                }
			}

			if(flag == -1)
			{
                enumerable();
            }

            Console.WriteLine();
        }

        public void findAll()
        {
            int flag = -1;
            foreach (Book book in bookList)
            {
                book.bookInfo();
                flag++;
            }

            if (flag == -1)
            {
				enumerable();
            }

            Console.WriteLine();
        }

        public void enumerable()
        {
            Console.WriteLine("Book list is empty");
        }
    }
}

