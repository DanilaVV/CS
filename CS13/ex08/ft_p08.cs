using System;
using System.Threading;

class Program
{
	static int	ft_fact(int n)
	{
		if (n == 1)
			return (n);
		return (n * ft_fact(n - 1));
	}
	static int	ft_pow(int x, int n)
	{
		if (n == 1)
			return (x);
		return (x * ft_pow(x, n - 1));
	}
	static void	Main()
	{
		double	res;
		int	i;
		Thread	t;

		res = 0;
		i = 1;
		t = new Thread(() => {
				while (true)
				{
					res += (double)ft_pow(2, i) * (i + 1) / ft_fact(i);
					i++;
					Thread.Sleep(100);
				}
				});
		t.IsBackground = true;
		t.Start();
		Thread.Sleep(1000);
		Console.WriteLine(res);
	}
}
