using System;

interface inf
{
	int	ft_met();
}

class MyClass1: inf
{
	int	nm;

	public MyClass1(int n)
	{
		nm = n;
	}

	public int	ft_met()
	{
		int	res;

		res = 0;
		for (int i = 1; i <= nm; i++)
			res += (2 * i - 1);
		return (res); 
	}
}

class MyClass2: inf
{
	int	nm;

	public MyClass2(int n)
	{
		nm = n;
	}
	public int	ft_met()
	{
		int	res;

		res = 0;
		for (int i = 1; i <= nm; i++)
			res += (2 * i);
		return (res);
	}
}

class Program
{
	static void	Main()
	{
		MyClass1 m1 = new MyClass1(5);
		MyClass2 m2 = new MyClass2(5);
		inf it;
		it = m1;
		Console.WriteLine(it.ft_met());
		it = m2;
		Console.WriteLine(it.ft_met());
	}
}
