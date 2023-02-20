using System;
namespace question_19
{
	internal class Test
	{
        List<Worker> workerList = new List<Worker>();

        public Test()
		{
		}

		public void Add()
		{
			Worker worker = new Worker();
			worker.input();
			workerList.Add(worker);
            Console.WriteLine();
        }

        public void OverTime()
        {
            for (int i = 0; i < workerList.Count; i++)
            {
                if (workerList[i].Workday >= 22)
                {
                    Console.WriteLine(workerList[i].display());
                }
            }
            Console.WriteLine();
        }

        public void DisplayAll()
        {
            for (int i = 0; i < workerList.Count; i++)
            {
                Console.WriteLine(workerList[i].display());
            }
            Console.WriteLine();
        }
    }
}

