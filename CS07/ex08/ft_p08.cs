using System;

class Base
{
	protected int[]	ms;

	public Base(int n)
	{
		ms = new int[n];
	}

	public int	this[uint i]
	{
		get
		{
			return (ms[i % prop]);
		}
		set
		{
			ms[i % prop] = value;
		}
	}

	public int	prop
	{
		get
		{
			return (ms.Length);
		}
	}
}

class MyClass: Base
{
	protected char[]	mms;

	public MyClass(int n1, int n2): base(n1)
	{
		mms = new char[n2];
	}

	public char	this[char i]
	{
		get
		{
			return (mms[i % mms.Length]);
		}
		set
		{
			mms[i % mms.Length] = value;
		}
	}

	new public int[]	prop
	{
		get
		{
			int[]	ams;

			ams = new int[2];
			ams[0] = base.prop;
			ams[1] = mms.Length;
			return (ams);
		}
	}
}

class Program
{
	static void	Main()
	{
		MyClass	m;

		m = new MyClass(10, 12);
		Console.WriteLine(m.prop[0] + "\t" + m.prop[1]);
	}
}
