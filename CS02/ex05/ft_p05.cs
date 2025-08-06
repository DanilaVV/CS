using System;

class Program
{

	static int[,]	ft_create(int n1, int n2)
	{
		int[,]	ms;
		Random	r;

		ms = new int[n1, n2];
		r = new Random();
		for (int i = 0; i < ms.GetLength(0); i++)
			for (int j = 0; j < ms.GetLength(1); j++)
				ms[i, j] = r.Next(1, 100);
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

	static int	ft_max(int[,] ms, out int imax, out int jmax)
	{
		int	max;

		max = ms[0, 0];
		imax = 0;
		jmax = 0;
		for (int i = 0; i < ms.GetLength(0); i++)
			for (int j = 0; j < ms.GetLength(1); j++)
				if (ms[i, j] > max)
				{
					max = ms[i, j];
					imax = i;
					jmax = j;
				}
		return (max);
	}

	static void	Main()
	{
		int	i;
		int	j;
		int[,]	ms;

		try
		{
			ms = ft_create(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()));
			ft_show(ms);
			Console.WriteLine("Max: " + ft_max(ms, out i, out j) + "\nimin: " + i + "\njmin: " + j);
		}
		catch
		{
			Console.WriteLine("Error!");
		}
	}
}
