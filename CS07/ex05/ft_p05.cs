using System;

class Base
{
	public string	st;

	public virtual MyClass	ft_create()
	{
		return (new MyClass());
	}
}

class MyClass: Base
{
	public char	ch;

	public override MyClass	ft_create()
	{
		MyClass	m;
		
		m = new MyClass();
		m.ch = ch;
		return (m);
	}
}

class Program
{
	static void	Main()
	{
		MyClass m = new MyClass();
		m.ch = 'E';
		MyClass m2 = m.ft_create();
		Console.WriteLine(m.ch + "\t" + m2.ch);
		m.ch = 'Z';
		Console.WriteLine(m.ch + "\t" + m2.ch);
	}
}
