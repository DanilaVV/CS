using System;

class Program
{

	static void	ft_fill(int[,] ms, int i0, int n)
	{
		if (ms.GetLength(0) - i0 <= i0)
			return ;

		int	i;
		int	j;

		for (j = i0; j < ms.GetLength(1) - i0 - 1; j++)
			ms[i0, j] = n++;
		for (i = i0; i < ms.GetLength(0) - i0 - 1; i++)
			ms[i, j] = n++;
		if (i == i0 || j == i0)
		{
			ms[i, j] = n;
			return ;
		}
		for (; j > i0; j--)
			ms[i, j] = n++;
		for (; i > i0; i--)
			ms[i, j] = n++;
		ft_fill(ms, i0 + 1, n);
	}

	static int[,]	ft_create(int n1, int n2)
	{
		int[,]	ms;

		ms = new int[n1, n2];
		ft_fill(ms, 0, 0);
		return (ms);
	}

	static void	ft_show(int[,] ms)
	{
		for (int i = 0; i < ms.GetLength(0); i++)
		{
			for (int j = 0; j < ms.GetLength(1); j++)
				Console.Write("{0,-4}", ms[i, j]);
			Console.WriteLine();
		}
	}

	static void	Main()
	{
		try
		{
			ft_show(ft_create(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine())));
		}
		catch
		{
			Console.WriteLine("Error!");
		}
	}
}
