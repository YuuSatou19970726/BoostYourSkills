using System;
using System.Net;
using System.Reflection;
using System.Xml.Linq;

namespace question_8
{
    internal class EmployeeTest
    {
        static void Main(string[] args)
        {
            int option = 0;
            StudentList studentList = new StudentList();
            while (true)
            {
                Console.WriteLine("1. Create a new student");
                Console.WriteLine("2. Show all");
                Console.WriteLine("3. Search");
                Console.WriteLine("4. Delete by id");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Input your option: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        studentList.inputStudent();
                        break;
                    case 2:
                        studentList.ShowAll();
                        break;
                    case 3:
                        Console.WriteLine("Enter student name to search: ");
                        string name = Console.ReadLine();
                        studentList.search(name);
                        break;
                    case 4:
                        Console.WriteLine("Enter student ID to delete: ");
                        int id = int.Parse(Console.ReadLine());
                        studentList.deleteStudent(id);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    Default:
                        Console.WriteLine("Invalid option!");

                }
            }
        }
    }
}

