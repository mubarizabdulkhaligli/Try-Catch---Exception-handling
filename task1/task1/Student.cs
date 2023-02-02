using System;
namespace task1
{
	internal class Student
	{
        public int No;
        public string FullName;
		public string GroupNo;
		public int Point;
		

		int totalCount;

		public Student()
		{
			totalCount++;
			No = totalCount;
		}


	}
}

