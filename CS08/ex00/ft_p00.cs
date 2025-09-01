using System;

abstract class Base
{
	protected int[]	ms;

	public Base(uint n)
	{
		ms = new int[n];
	}

	public uint	prop
	{
		get
		{
			return ((uint)ms.Length);
		}
	}

	public abstract void	ft_show();
	public abstract int	this[uint i]
	{
		get ;
		set ;
	}
}

class MyClass: Base
{
	public MyClass(uint n): base(n)
	{
		
	}

	public override void	ft_show()
	{
		for (int i = 0; i < prop; i++)
			Console.Write(ms[i] + " ");
		Console.WriteLine("\n");
	}

	public override int	this[uint i]
	{
		get
		{
			if (i >= prop)
				i = prop - 1;
			return (ms[i]);
		}
		set
		{
			if (i >= prop)
				i = prop - 1;
			ms[i] = value;
		}
	}
}

class Program
{
	static void	Main()
	{
		MyClass m = new MyClass(12);
		m[15] = 100;
		m[7] = -4;
		m[1] = 21;
		m.ft_show();
	}
}
