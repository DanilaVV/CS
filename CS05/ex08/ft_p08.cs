using System;

class MyClass
{
	int	nm;

	public MyClass(int n)
	{
		nm = n;
	}

	public static int	operator+(MyClass m, int n)
	{
		return (m.nm + n);
	}

	public static int	operator-(MyClass m, int n)
	{
		return (m.nm - n);
	}

	public static int	operator*(MyClass m, int n)
	{
		return (m.nm * n);
	}

	public static implicit operator MyClass(int n)
	{
		return (new MyClass(n));
	}

	public override string	ToString()
	{
		return ("MyClass: " + nm);
	}
}

class Program
{
	static void	Main()
	{
		MyClass	m;

		m = new MyClass(7);
		Console.WriteLine(m);
		m += 3;
		Console.WriteLine(m);
		m -= 5;
		Console.WriteLine(m);
		m *= 11;
		Console.WriteLine(m);
	}
}
