using System;

class MyClass
{
	int	nm;
	public char	ch;

	public MyClass(int n, char c)
	{
		nm = n;
		ch = c;
	}

	public static bool	operator true(MyClass m)
	{
		if (m.nm - m.ch <= 10)
			return (true);
		return (false);
	}

	public static bool	operator false(MyClass m)
	{
		if (m)
			return (false);
		return (true);
	}

	public override string	ToString()
	{
		return ("" + ch);
	}
}

class Program
{
	static void	Main()
	{
		MyClass	m;

		m = new MyClass('A', 'A');

		while (m)
		{
			Console.Write(m);
			m.ch--;
		}
		Console.WriteLine();
	}
}
