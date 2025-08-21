using System;

class Base
{
	protected string	st;

	public Base(string s)
	{
		st = s;
	}

	public virtual void	ft_show()
	{
		Console.WriteLine("Base: " + st);
	}
}

class MyClass1: Base
{
	protected int	nm;

	public MyClass1(string s, int n): base(s)
	{
		nm = n;
	}

	public override void	ft_show()
	{
		Console.WriteLine("MyClass1: " + st + "\t" + nm);
	}
}

class MyClass2: Base
{
	protected char	ch;

	public MyClass2(string s, char c): base(s)
	{
		ch = c;
	}

	public override void	ft_show()
	{
		Console.WriteLine("MyClass2: " + st + "\t" + ch);
	}
}

class Program
{
	public static void Main()
	{
		MyClass1	m1;
		MyClass2	m2;
		Base	m;

		m1 = new MyClass1("Hello", 12);
		m2 = new MyClass2("See you", 'E');
		m1.ft_show();
		m2.ft_show();
		m = m1;
		m.ft_show();
		m = m2;
		m.ft_show();
	}
}
