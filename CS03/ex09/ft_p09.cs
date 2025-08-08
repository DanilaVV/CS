using System;

class MyClass
{
	public static int	ft_fact(int n)
	{
		if (n == 0)
			return (1);
		if (n == 1)
			return (n);
		return (n * ft_fact(n - 1));
	}

	public static double	ft_pow(double x, int y)
	{
		if (y == 0)
			return (1);
		return (x * ft_pow(x, y - 1));
	}

	public static double	ft_cos(double x, int n)
	{
		double	res;

		res = 0;
		for (int i = 0; i < n; i++)
			res += (ft_pow(-1, i) * ft_pow(x, 2 * i) / ft_fact(2 * i));
		return (res);
	}

	public static double	ft_sh(double x, int n)
	{
		double	res;

		res = 0;
		for (int i = 0; i < n; i++)
			res += (ft_pow(x, 2 * i + 1) / ft_fact(2 * i + 1));
		return (res);
	}

	public static double	ft_ch(double x, int n)
	{
		double	res;

		res = 0;
		for (int i = 0; i < n; i++)
			res += (ft_pow(x, 2 * i) / ft_fact(2 * i));
		return (res);
	}
}

class Program
{
	static void	Main()
	{
		double	pi;
		int	n;

		pi = 3.14 / 4;
		n = 10;
		Console.WriteLine(Math.Cos(pi) + "\t" + MyClass.ft_cos(pi, n));
		Console.WriteLine(Math.Cosh(pi) + "\t" + MyClass.ft_ch(pi, n));
		Console.WriteLine(Math.Sinh(pi) + "\t" + MyClass.ft_sh(pi, n));
	}
}
