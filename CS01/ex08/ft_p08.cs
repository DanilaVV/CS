using System;

class Program
{

	static int[,]	ft_create(int n1, int n2)
	{
		int[,]	ms;
		Random	rnd;

		ms = new int[n1, n2];
		rnd = new Random();
		for (int i = 0; i < n1; i++)
			for (int j = 0; j < n2; j++)
				ms[i, j] = rnd.Next(10, 100);
		return (ms);
	}

	static void	ft_show(int[,] ms)
	{
		for (int i = 0; i < ms.GetLength(0); i++)
		{
			for (int j = 0; j < ms.GetLength(1); j++)
				Console.Write(ms[i, j] + " ");
			Console.WriteLine();
		}
		Console.WriteLine();
	}

	static int[,]	ft_delete(int[,] ms)
	{
		int[,]	mms;
		Random	rnd;
		int	id;
		int	jd;

		rnd = new Random();
		id = rnd.Next(0, ms.GetLength(0));
		Console.WriteLine("Deleted line: " + id);
		jd = rnd.Next(0, ms.GetLength(1));
		Console.WriteLine("Deleted colomn: " + jd);
		mms = new int[ms.GetLength(0) - 1, ms.GetLength(1) - 1];
		for (int i = 0, k = 0; i < ms.GetLength(0); i++)
		{
			if (i == id)
				continue ;
			for (int j = 0, l = 0; j < ms.GetLength(1); j++)
			{
				if (j == jd)
					continue ;
				mms[k, l] = ms[i, j];
				l++;
			}
			k++;
		}
		return (mms);
	}

	static void	Main()
	{
		int	n1;
		int	n2;

		try
		{
			n1 = Int32.Parse(Console.ReadLine());
			n2 = Int32.Parse(Console.ReadLine());
			var	ms1 = ft_create(n1, n2);
			ft_show(ms1);
			var	ms2 = ft_delete(ms1);
			ft_show(ms2);
		}
		catch
		{
			Console.WriteLine("Error!");
		}
	}
}
