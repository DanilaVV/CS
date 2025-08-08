using System;

class MyClass
{
	int	nm;

	public void	ft_set()
	{
		nm = 0;
	}

	public void	ft_set(int n)
	{
		if (n > 100)
			nm = 100;
		else
			nm = n;
	}

	public void	ft_show()
	{
		Console.WriteLine("Integer: " + nm);
	}

	public	MyClass()
	{
		ft_set();
	}

	public	MyClass(int n)
	{
		ft_set(n);
	}
}

class Program
{
	static void	Main()
	{
		MyClass	m;

		m = new MyClass();
		m.ft_show();
		m = new MyClass(12);
		m.ft_show();
		m.ft_set(111);
		m.ft_show();
	}
}
