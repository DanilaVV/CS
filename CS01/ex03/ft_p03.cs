using System;

class Program
{
	static char[]	ft_create(int n)
	{
		char[] ms;

		if (n > 10)
			n = 10;
		ms = new char[n];
		for (int i = 0, j = 0; i < n; j++)
		{
			switch((char)('A' + j))
			{
				case 'A':
				case 'E':
				case 'I':
				case 'O':
				case 'U':
				case 'Y': continue;
			}
			ms[i++] = (char)('A' + j);
		}
		return (ms);
	}

	static void	ft_show(char[] ms)
	{
		for (int i = 0; i < ms.Length; i++)
			Console.Write(ms[i] + " ");
		Console.WriteLine();
		for (int i = ms.Length - 1; i >= 0; i--)
			Console.Write(ms[i] + " ");
		Console.WriteLine();
	}

	static void	Main()
	{
		try
		{
			ft_show(ft_create(Int32.Parse(Console.ReadLine())));
		}
		catch
		{
			Console.WriteLine("Error");
		}
	}
}
