using System;
using System.Threading;

class Program
{
	static void	Main()
	{
		Thread	t1;
		Thread	t2;
		int[]	ms;

		ms = new int[Int32.Parse(Console.ReadLine())];
		t1 = new Thread(() => {
				for (int i = 0; i < ms.Length / 2; i++)
				{
					ms[i] = (int)Math.Pow(2, i + 1);
					Thread.Sleep(1500);
					Console.SetCursorPosition(5 * i, Console.CursorTop);
					Console.Write(ms[i]);
				}
				});
		t2 = new Thread(() => {
				for (int i = ms.Length - 1, j = 1; i >= ms.Length / 2; i--, j++)
				{
					ms[i] = (int)Math.Pow(3, j);
					Thread.Sleep(1500);
					Console.SetCursorPosition(5 * i, Console.CursorTop);
					Console.Write(ms[i]);
				}
				});
		t1.Start();
		Thread.Sleep(750);
		t2.Start();
		if (t1.IsAlive)
			t1.Join();
		if (t2.IsAlive)
			t2.Join();
		Console.WriteLine();
	}
}
