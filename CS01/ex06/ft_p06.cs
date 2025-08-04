using System;

class Program
{

	static char[]	ft_create(int n)
	{
		char[]	ms;
		
		ms = new char[n];
		for (int i = 0; i < n; i++)
			ms[i] = (char)('A' + i);
		return (ms);
	}

	static void	ft_show(char[] ms)
	{
		for (int i = 0; i < ms.Length; i++)
			Console.Write(ms[i] + " ");
		Console.WriteLine();
	}

	static void	ft_reverse(char[] ms)
	{
		char	c;

		for (int i = 0, k = ms.Length - 1; i < ms.Length / 2; i++, k--)
		{
			c = ms[i];
			ms[i] = ms[k];
			ms[k] = c;
		}
	}

	static void	Main()
	{
		char[]	ms;

		try
		{
			ms = ft_create(Convert.ToInt32(Console.ReadLine()));
			ft_show(ms);
			ft_reverse(ms);
			ft_show(ms);
		}
		catch
		{
			Console.WriteLine("Error!");
		}
	}
}
