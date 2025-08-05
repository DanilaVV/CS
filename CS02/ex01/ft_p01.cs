using System;

class Program
{
	static int	ft_recsum(int n)
	{
		if (n <= 1)
			return (1);
		return (n * n + ft_recsum(n - 1));
	}

	static int	ft_norecsum(int n)
	{
		int	res;

		if (n <= 1)
			return (1);
		res = 0;
		while (n >= 1)
		{
			res += n * n;
			n--;
		}
		return (res);
	}
	
	static void	Main()
	{
		int	n;
		int	res;

		try
		{
			while (true)
			{
				n = Convert.ToInt32(Console.ReadLine());
				res = ft_recsum(n);
				Console.WriteLine("f{0} = {1}", n, res);
				res = ft_norecsum(n);
				Console.WriteLine("f{0} = {1}", n, res);
				Console.WriteLine("Checking: {0}", n * (n + 1) * (2 * n + 1) / 6);
			}
		}
		catch
		{
			Console.WriteLine("Error!");
		}
	}
}
