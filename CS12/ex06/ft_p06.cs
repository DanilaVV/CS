using System;

class MyClass
{
	int[]	ms;

	public MyClass(int n)
	{
		ms = new int[n];
		for (int i = 0; i < n; i++)
			ms[i] = i + 1;
	}

	public int	this[int i]
	{
		set
		{
			ms[i] = value;
		}
	}
}

class Program
{
	static int	ft_met(MyClass m)
	{
		int	i;

		i = 0;
		while (true)
		{
			try
			{
				m[i] = 0;
				i++;
			}
			catch
			{
				break ;
			}
		}
		return (i);
	}

	static void	Main()
	{
		MyClass	m;

		m = new MyClass(Int32.Parse(Console.ReadLine()));
		Console.WriteLine("Size of Array is " + ft_met(m));
	}
}
