using System;
using System.Collections.Generic;

namespace question_8
{
	internal class StudentList
    {
		List<Student> studentList = new List<Student>();
		
		public StudentList()
		{
		}

        public void inputStudent()
        {
            Student student = new Student();
            Console.WriteLine("Enter student ID: ");
            student.studentId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter student name: ");
            student.studentName = Console.ReadLine();
            Console.WriteLine("Enter student address: ");
            student.address = Console.ReadLine();
            Console.WriteLine("Enter student email: ");
            student.email = Console.ReadLine();

            studentList.Add(student);
            Console.WriteLine();
        }

        public void ShowAll()
		{
			for(int i = 0; i < studentList.Count; i++)
			{
				Console.WriteLine(studentList[i].ToString());
            }
            Console.WriteLine();
        }

		public void deleteStudent(int id)
		{
            
            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].studentId == id)
                {
                    studentList.Remove(studentList[i]);
                }
            }
            Console.WriteLine();
        }

        public void search(string name)
        {

            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].studentName.Contains(name))
                {
                    Console.WriteLine(studentList[i].ToString());
                }
            }
            Console.WriteLine();
        }
    }
}

