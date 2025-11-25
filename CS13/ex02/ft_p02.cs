using System;
using System.Threading;

class Program
{
	static void	Main()
	{
		Thread	t1;
		Thread	t2;
		char[]	ms;

		ms = new char[Int32.Parse(Console.ReadLine())];
		t1 = new Thread(() => {
				for (int i = 0; i < ms.Length; i += 2)
				{
					ms[i] = (char)('A' + i);
					Thread.Sleep(2000);
					Console.SetCursorPosition(5 * i, Console.CursorTop);
					Console.Write(ms[i]);
				}
				});
		t2 = new Thread(() => {
				for (int i = 1; i < ms.Length; i += 2)
				{
					ms[i] = (char)('a' + i);
					Thread.Sleep(2000);
					Console.SetCursorPosition(5 * i, Console.CursorTop);
					Console.Write(ms[i]);
				}
				});
		t1.Start();
		Thread.Sleep(1000);
		t2.Start();
		if (t1.IsAlive)
			t1.Join();
		if (t2.IsAlive)
			t2.Join();
		Console.WriteLine();
	}
}
