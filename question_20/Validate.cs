using System;
namespace question_20
{
	internal class Validate
	{
		public event MyValid Print;

		public void checkVaild(string s)
		{
			Console.WriteLine(s);
        }

		public void check(string s)
		{
			Print?.Invoke(s);
		}
	}
}

