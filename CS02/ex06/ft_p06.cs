using System;

class Program
{

	static void	ft_show(char[] ms)
	{
		foreach (char n in ms)
			Console.Write(n + " ");
		Console.WriteLine("\n");
	}

	static void	ft_rev(char[] ms)
	{
		char	c;

		for (int i = 0, j = ms.Length - 1; i < ms.Length / 2; i++, j--)
		{
			c = ms[i];
			ms[i] = ms[j];
			ms[j] = c;
		}
	}

	static void	Main()
	{
		char[]	ms;

		ms = new char[]{'A', 'B', 'C', 'D', 'E', 'F'};
		ft_show(ms);
		ft_rev(ms);
		ft_show(ms);
	}
}
