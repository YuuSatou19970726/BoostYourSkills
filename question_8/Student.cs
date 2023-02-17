using System;
namespace question_8
{
	internal class Student
	{
		public int studentId { get; set; }
        public string studentName { get; set; }
        public string address { get; set; }
        public string email { get; set; }

        public Student() { }

        public Student(int id, string name, string address, string email)
        {
            this.studentId = id;
            this.studentName = name;
            this.address = address;
            this.email = email;
        }

        public override string ToString()
        {
            return "Student ID: " + studentId + "\n" +
               "Student Name: " + studentName + "\n" +
               "Student Address: " + address + "\n" +
               "Student Email: " + email + "\n\n";
        }
    }
}

