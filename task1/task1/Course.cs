using System;
namespace task1
{
	internal class Course
	{
		public Student[] Students = new Student[0];

		public int StudentsLimit;


		public void AddStudent(Student student)
		{
			if (Students.Length<StudentsLimit)
			{
				if(!CheckNo(student.No))
				{
                    Array.Resize(ref Students, Students.Length + 1);

                    Students[Students.Length - 1] = student;
                }
			}
		}

		public bool CheckNo(int number)
		{
			foreach (var student in Students)
			{
				if (student.No == number)
					return true;
			}
			return false;
		}

	}
}

