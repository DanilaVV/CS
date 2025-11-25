using System;
using System.Threading;

class Program
{
	static void	Main()
	{
		int[]	ms;
		Random	r;
		Thread	t1;
		Thread	t2;

		ms = null;
		t1 = new Thread(() => {
				int	min;
				
				min = ms[0];
				foreach (var n in ms)
					if (n < min)
						min = n;
				Console.WriteLine("Min: " + min);
				});
		t2 = new Thread(() => {
				int	max;
				
				max = ms[0];
				foreach (var n in ms)
					if (n > max)
						max = n;
				Console.WriteLine("Max: " + max);
				});
		r = new Random();
		Console.Write("Write size of array: ");
		ms = new int[Int32.Parse(Console.ReadLine())];
		for (int i = 0; i < ms.Length; i++)
		{
			ms[i] = r.Next(100);
			Console.Write(ms[i] + " ");
			Thread.Sleep(500);
		}
		Console.WriteLine();
		t1.Start();
		t2.Start();
	}
}
