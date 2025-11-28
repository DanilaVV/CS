using System;

class MyClass
{
	string	st;
	public MyClass(string s)
	{
		st = s;
	}
	public override string	ToString()
	{
		return (st);
	}
}

class Program
{
	static void	ft_met<X>(ref X n1, ref X n2)
	{
		X	n;

		n = n1;
		n1 = n2;
		n2 = n;
	}
	static void	Main()
	{
		MyClass	m1;
		MyClass	m2;

		m1 = new MyClass("One");
		m2 = new MyClass("Two");
		Console.WriteLine(m1 + "\t" + m2);
		ft_met(ref m1, ref m2);
		Console.WriteLine(m1 + "\t" + m2);
	}
}
