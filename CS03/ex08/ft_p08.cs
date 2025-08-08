using System;

class MyClass
{
	public static int	ft_max(params int[] ms)
	{
		int	res;

		res = ms[0];
		foreach (int n in ms)
			if (res < n)
				res = n;
		return (res);
	}

	public	static int	ft_min(params int[] ms)
	{
		int	res;

		res = ms[0];
		foreach (int n in ms)
			if (res > n)
				res = n;
		return (res);
	}

	public static double	ft_middle(params int[] ms)
	{
		double	res;

		res = 0;
		foreach (int n in ms)
			res += n;
		return (res / ms.Length);
	}
}

class Program
{
	static void	Main()
	{
		int[]	ms;

		ms = new int[]{-2, 9, 13, 17, 0 , 3};
		Console.WriteLine(MyClass.ft_min(ms));
		Console.WriteLine(MyClass.ft_max(ms));
		Console.WriteLine(MyClass.ft_middle(ms));
	}
}
