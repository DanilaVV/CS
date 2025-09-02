using System;

abstract class Base
{
	protected int	nm1;
	protected int	nm2;

	public Base(int n1, int n2)
	{
		nm1 = n1;
		nm2 = n2;
	}
	public abstract int	this[int i]
	{
		get ;
		set ;
	}
}

interface intf
{
	int	ft_met(int n);
}

class MyClass: Base, intf
{
	public MyClass(int n1, int n2): base(n1, n2)
	{}

	public override int	this[int i]
	{
		get
		{
			if (i % 2 == 0)
				return (nm1);
			return (nm2);
		}
		set
		{
			if (i % 2 == 0)
				nm1 = value;
			else
				nm2 = value;
		}
	}

	public int	ft_met(int n)
	{
		return ((nm1 + nm2) * n);
	}
}

class Program
{
	static void	Main()
	{
		MyClass m = new MyClass(-2, 7);
		Console.WriteLine(m[2] + "\t" + m[11] + "\t" + m.ft_met(11));
	}
}
