using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV2
{
	class Program
	{
		static void Main(string[] args)
		{
			/* Student Manager challenge from the C# training,
			Now using 2 collections ("Lists"):
			List 1: Whole classroom students.
			List 2: New students to be added in List 1. 
			Defining a Student C# Class with all the required information for managing a student classroom
			i.e. Names, grades, birthday, address and phone number, etc.
			Finally, output the list.
			*/

			var students = new List<Student>();

			bool AddStudent = true;

			while (AddStudent)
			{
				var newStudent = new Student();

				Console.WriteLine("Student Name: ");
				newStudent.Name = Console.ReadLine();

				Console.WriteLine("Student Grade: ");
				newStudent.Grade = int.Parse(Console.ReadLine());

				Console.WriteLine("Student Birthday: ");
				newStudent.Birthday = Console.ReadLine();

				Console.WriteLine("Student Address: ");
				newStudent.Address = Console.ReadLine();

				Console.WriteLine("Student Phone: ");
				newStudent.Phone=int.Parse(Console.ReadLine());

				students.Add(newStudent);

				Console.WriteLine("Add another student? y/n");
				if (Console.ReadLine() != "y")
					AddStudent = false;
			}

			/* Student manager ouput */

			Console.WriteLine("Student Manager");

			foreach (var student in students)
			{
				Console.WriteLine("Student: {0}, Grade: {1}, Birthday: {2}, Address: {3}", student.Name, student.Grade, student.Birthday, student.Address);
			}
		}

		class Student
		{

			public string Name;
			public int Grade;
			public string Birthday;
			public string Address;
			private int phone;
			public int Phone
			{
				set { phone = value; Console.WriteLine(phone); }
			}

			public void SetPhone(int number)
			{
				phone = number;
			}	 
		}
	}
}
