using System;

class MyClass
{
	int	max;
	int	min;

	public void	ft_set(int n)
	{
		if (n < min)
			min = n;
		if (n > max)
			max = n;
	}

	public void	ft_set(int n1, int n2)
	{
		ft_set(n1);
		ft_set(n2);
	}
	
	public void	ft_show()
	{
		Console.WriteLine("Min: " + min + "\nMax: " + max);
	}

	public	MyClass(int n)
	{
		ft_set(n);
	}

	public	MyClass(int n1, int n2)
	{
		ft_set(n1, n2);
	}
}

class Program
{
	static void	Main()
	{
		MyClass	m;

		m = new MyClass(-1);
		m.ft_show();
		m.ft_set(12, 14);
		m.ft_show();
	}
}
