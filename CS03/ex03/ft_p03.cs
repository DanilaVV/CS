using System;

class MyClass
{
	char	ch;
	int	nm;

	public MyClass(int n, char c)
	{
		ch = c;
		nm = n;
	}

	public MyClass(double n)
	{
		ch = (char)((int)n);
		nm = (int)((n - (int)n) * 100);
	}

	public void	ft_show()
	{
		Console.WriteLine("Char: " + ch + "\nInteger: " + nm);
	}
}

class Program
{
	static void	Main()
	{
		MyClass	m;

		m = new MyClass('A', 'A');
		m.ft_show();
		m = new MyClass(65.1267);
		m.ft_show();
	}
}
