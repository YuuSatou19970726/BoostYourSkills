using System;

namespace question_21
{
    internal class Enrollment_number
    {
        static void Main(string[] args)
        {
            BookManage bookManage = new BookManage();
            int option = 0;
            while (true)
            {
                Console.WriteLine("1. Create New");
                Console.WriteLine("2. Find By isSale");
                Console.WriteLine("3. Find All");
                Console.WriteLine("4. Exit");
                Console.WriteLine();
                Console.Write("Input your option: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Book book = new Book();
                        while (true)
                        {
                            try
                            {
                                Console.Write("Input book type: ");
                                string valTitle = Console.ReadLine();
                                if (!string.IsNullOrWhiteSpace(valTitle))
                                {
                                    book.title = valTitle;
                                    break;
                                } else
                                {
                                    Console.WriteLine("Title can not empty!");
                                }
                            } catch (Exception)
                            {
                                Console.WriteLine("Title can not empty!");
                            }
                        }

                        while (true)
                        {
                            try
                            {
                                Console.Write("Book sale(Y/n): ");
                                string valIsSale = Console.ReadLine();
                                if (!string.IsNullOrWhiteSpace(valIsSale) && valIsSale.ToLower() == "y" || valIsSale.ToLower() == "n")
                                {
                                    if(valIsSale.ToLower() == "y")
                                    {
                                        book.isSale = true;
                                    } else
                                    {
                                        book.isSale = false;
                                    }
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Re-enter please!");
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Re-enter please!");
                            }
                        }

                        while (true)
                        {
                            try
                            {
                                Console.Write("Input book price: ");
                                double valPrice = double.Parse(Console.ReadLine());
                                if (valPrice > 0)
                                {
                                    book.price = valPrice;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Re-enter please!");
                                }
                            } catch (Exception)
                            {
                                Console.WriteLine("Re-enter please!");
                            }
                        }

                        bookManage.createBook(book);
                        break;
                    case 2:
                        bookManage.findByIsSale();
                        break;
                    case 3:
                        bookManage.findAll();
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