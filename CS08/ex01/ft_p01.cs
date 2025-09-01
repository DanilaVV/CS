using System;

abstract class Base
{
	protected string	st;

	public Base(string s)
	{
		st = s;
	}

	public abstract uint	prop
	{
		get ;
	}

	public abstract int	this[int i]
	{
		get ;
	}

	public abstract void	ft_met1(string s);

	public abstract void	ft_met2();
}

class MyClass: Base
{
	public MyClass(string s): base(s)
	{}

	public override uint	prop
	{
		get
		{
			return ((uint)st.Length);
		}
	}

	public override int	this[int i]
	{
		get
		{
			return ((int)st[i]);
		}
	}

	public override void	ft_met1(string s)
	{
		st = s;
	}

	public override void	ft_met2()
	{
		Console.WriteLine(st);
	}
}

class Program
{
	static void	Main()
	{
		MyClass m = new MyClass("The novel 1984");
		m.ft_met2();
		m.ft_met1("Amazing");
		Console.WriteLine(m[0]);
	}
}
