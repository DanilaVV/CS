using System;

class Program
{
	static int	ft_recdfact(int n)
	{
		if (n <= 0)
			return (1);
		if (n <= 2)
			return (n);
		return (n * ft_recdfact(n - 2));
	}

	static int	ft_norecdfact(int n)
	{
		int	res;

		if (n <= 0)
			return (1);
		if (n <= 2)
			return (n);
		res = 1;
		while (n >= 1)
		{
			res*=n;
			n-=2;
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
				res = ft_recdfact(n);
				Console.WriteLine("{0}!! = {1}", n, res);
				res = ft_norecdfact(n);
				Console.WriteLine("{0}!! = {1}", n, res);
			}
		}
		catch
		{
			Console.WriteLine("Error!");
		}
	}
}
