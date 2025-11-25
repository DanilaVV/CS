using System;
using System.Threading;

class Program
{
	static void	ft_fill1(int[] ms, int top)
	{
		for (int i = 0; i < ms.Length; i++)
		{
			ms[i] = i + 1;
			Console.SetCursorPosition(5 * i, top + 1);
			Console.Write(ms[i]);
			Thread.Sleep(1500);
		}
	}
	static void	ft_fill2(char[] ms, int top)
	{
		for (int i = 0; i < ms.Length; i++)
		{
			ms[i] = (char)('A' + i);
			Console.SetCursorPosition(5 * i, top + 2);
			Console.Write(ms[i]);
			Thread.Sleep(1500);
		}
	}
	static void	Main()
	{
		int[]	ms1;
		char[]	ms2;
		int	top;
		Thread	t1;
		Thread	t2;

		Console.Write("Write size of intArray: ");
		ms1 = new int[Int32.Parse(Console.ReadLine())];
		Console.Write("Write size of charArray: ");
		ms2 = new char[Int32.Parse(Console.ReadLine())];
		top = Console.CursorTop;
		t1 = new Thread(() => ft_fill1(ms1, top));
		t2 = new Thread(() => ft_fill2(ms2, top));
		t1.Start();
		Thread.Sleep(750);
		t2.Start();
		if (t1.IsAlive)
			t1.Join();
		if (t2.IsAlive)
			t2.Join();
		Console.SetCursorPosition(0, top + 3);
	}
}
