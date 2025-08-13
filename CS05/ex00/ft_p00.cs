using System;

class MyClass
{
	char	ch;

	public MyClass(char c)
	{
		ch = c;
	}

	public static MyClass	operator++(MyClass m)
	{
		m.ch++;
		return (m);
	}

	public static MyClass	operator--(MyClass m)
	{
		m.ch--;
		return (m);
	}

	public static MyClass	operator+(MyClass m, int n)
	{
		return (new MyClass((char)(m.ch + n)));
	}

	public static MyClass	operator+(int n, MyClass m)
	{
		return (m + n);
	}

	public static int	operator-(MyClass m1, MyClass m2)
	{
		return (m1.ch - m2.ch);
	}

	public override string	ToString()
	{
		return ("MyClass: " + ch);
	}
}

class Program
{
	static void	Main()
	{
		MyClass	m1, m2;

		m1 = new MyClass('E');
		Console.WriteLine(m1);
		m1++;
		Console.WriteLine(m1);
		m2 = 20 + m1;
		Console.WriteLine(m2);
		Console.WriteLine(m1 - m2);
	}
}
