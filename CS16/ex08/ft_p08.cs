using System;
using System.Collections;

class Program
{
	static int[]	ft_createArray(int n)
	{
		int[]	ms;
		Random	rnd;

		rnd = new Random();
		ms = new int[n];
		for (int i = 0; i < n; i++)
			ms[i] = rnd.Next(1, 100);
		return (ms);
	}
	static Stack	ft_createStack(int[] ms)
	{
		double	res;
		Stack st;

		res = 0;
		st = new Stack();
		foreach (var n in ms)
			res += n;
		res /= ms.Length;
		foreach (var n in ms)
			if (n >= res)
				st.Push(n);
		Console.WriteLine("Average: " + res);
		return (st);
	}
	static void	ft_showArray(int[] ms)
	{
		foreach (var n in ms)
			Console.Write(n + " ");
		Console.WriteLine();
	}
	static void	ft_showStack(Stack ms)
	{
		foreach (var n in ms)
			Console.Write(n + " ");
		Console.WriteLine();
	}
	static void	Main()
	{
		var ms = ft_createArray(Int32.Parse(Console.ReadLine()));
		ft_showArray(ms);
		ft_showStack(ft_createStack(ms));
	}
}
