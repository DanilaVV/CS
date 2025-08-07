using System;

class MyClass
{
	int	n1;
	int	n2;

	public MyClass()
	{
		n1 = 100;
		n2 = -100;
	}

	public MyClass(int n)
	{
		n1 = n;
		n2 = n;
	}

	public MyClass(int n1, int n2)
	{
		this.n1 = n1;
		this.n2 = n2;
	}

	public void	ft_show()
	{
		Console.WriteLine("N1: " + n1 + "\nN2: " + n2);
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
		m = new MyClass(14, -2);
		m.ft_show();
	}
}
