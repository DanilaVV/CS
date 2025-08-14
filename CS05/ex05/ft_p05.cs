using System;

class MyClass
{
	int	nm;

	public MyClass(int n)
	{
		nm = n;
	}

	public static bool	operator true(MyClass m)
	{
		if (m.nm == 2 || m.nm == 3 || m.nm == 5 || m.nm == 7)
			return (true);
		return (false);
	}

	public static bool	operator false(MyClass m)
	{
		if (m.nm < 1 || m.nm > 10)
			return (true);
		return (false);
	}

	public static MyClass	operator&(MyClass m1, MyClass m2)
	{
		if (m1)
			return (m2);
		return (m1);
	}

	public static MyClass	operator|(MyClass m1, MyClass m2)
	{
		if (m1)
			return (m1);
		return (m2);
	}

	public override string	ToString()
	{
		return ("" + nm);
	}
}

class Program
{
	static void	Main()
	{
		MyClass	m1, m2;

		m1 = new MyClass(3);
		m2 = new MyClass(12);
		Console.WriteLine(m1 + "\t" + m2);
		Console.WriteLine((m1 && m2) + "\t" + (m1 || m2));
	}
}
