using System;

class MyClass
{
	int	n1;
	int	n2;

	public MyClass(int n1, int n2)
	{
		this.n1 = n1;
		this.n2 = n2;
	}

	public static bool	operator>(MyClass m1, MyClass m2)
	{
		if (m1.n1 * m1.n1 + m1.n2 * m1.n2 > m2.n1 * m2.n1 + m2.n2 * m2.n2)
			return (true);
		return (false);
	}

	public static bool	operator<(MyClass m1, MyClass m2)
	{
		if (m1.n1 * m1.n1 + m1.n2 * m1.n2 < m2.n1 * m2.n1 + m2.n2 * m2.n2)
			return (true);
		return (false);
	}
	
	public override string	ToString()
	{
		return ("MyClass: " + n1 + "\t" + n2);
	}
}

class Program
{
	static void	Main()
	{
		MyClass	m1, m2;

		m1 = new MyClass(3, 5);
		m2 = new MyClass(2, 6);
		Console.WriteLine(m1);
		Console.WriteLine(m2);
		Console.WriteLine(m1 > m2);
		Console.WriteLine(m1 < m2);
	}
}
