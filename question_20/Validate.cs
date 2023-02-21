using System;
namespace question_20
{
	internal class Validate
	{
		public event MyValid Print;

		public void checkVaild(string s)
		{
			Console.WriteLine(s);
            Print?.Invoke(s);
        }
	}
}

