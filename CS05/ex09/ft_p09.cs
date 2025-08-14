using System;

class MyClass
{
	char	ch;

	public MyClass(char c)
	{
		ch = c;
	}

	public static string	operator+(MyClass m1, MyClass m2)
	{
		return ("" + m1.ch + m2.ch);
	}

	public static int	operator-(MyClass m1, MyClass m2)
	{
		return (m1.ch - m2.ch);
	}
	
	public static implicit operator MyClass(string st)
	{
		int	n;

		n = 0;
		foreach (var c in st)
			n += c;
		return (new MyClass((char)(n / st.Length)));
	}

	public static implicit operator MyClass(int n)
	{
		if (n < 0)
			n = -n;
		return (new MyClass((char)(n % 100)));
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
		MyClass	m;

		m = new MyClass('A');
		Console.WriteLine(m);
		Console.WriteLine((m + 'Z'));
		Console.WriteLine((m - 'Z'));
		m += 'Z';
		Console.WriteLine(m);
		m -= 20;
		Console.WriteLine(m);
	}
}
