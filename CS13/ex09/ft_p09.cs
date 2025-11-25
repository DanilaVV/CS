using System;
using System.Threading;

class Program
{
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

		res = 1;
		i = 2;
		t = new Thread(() => {
				while (true)
				{
					res *= (double)(ft_pow(i, 3) - 1) / (ft_pow(i, 3) + 1);
					i++;
					Thread.Sleep(10);
				}
				});
		t.IsBackground = true;
		t.Start();
		Thread.Sleep(1000);
		Console.WriteLine(res);
		Console.WriteLine((double)2 / 3);
	}
}
