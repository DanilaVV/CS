using System;

class Base
{
	public int	nm;

	public void	ft_set(int n)
	{
		nm = n;
	}

	public Base(int n)
	{
		ft_set(n);
	}
}

class MyClass: Base
{
	public char	ch;

	public void	ft_set(int n, char c)
	{
		ch = c;
	}

	public MyClass(int n, char c): base(n)
	{
		ft_set(n, c);
	}
}

class MyClassLess: MyClass
{
	public string	st;

	public void	ft_set(int n, char c, string s)
	{
		st = s;
	}

	public MyClassLess(int n, char c, string s): base(n, c)
	{
		ft_set(n, c, s);
	}

	public override string	ToString()
	{
		return ("Int: " + nm + "\nChar: " + ch + "\nString: " + st);
	}
}

class Program
{
	public static void Main()
	{
		MyClassLess	m;

		m = new MyClassLess(12, 'D', "1999");
		Console.WriteLine(m);
	}
}
