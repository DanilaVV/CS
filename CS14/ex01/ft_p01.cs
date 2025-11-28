using System;

class MyClass
{
	static void	ft_met<X>(X[] ms)
	{
		X	n;

		n = ms[0];
		for (int i = 0; i < ms.Length - 1; i++)
		{
			ms[i] = ms[i + 1];
		}
		ms[ms.Length - 1] = n;
	}
	static void	ft_show<X>(X[] ms)
	{
		foreach (var n in ms)
			Console.Write(n + " ");
		Console.WriteLine();
	}
	static void	Main()
	{
		char[]	ms;

		ms = new char[]{'A', 'B', 'C', 'D'};
		ft_show(ms);
		for(int i = 0; i < 5; i++)
		{
			ft_met(ms);
			ft_show(ms);
		}
	}
}
