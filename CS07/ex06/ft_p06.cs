using System;

class Base
{
	public uint	nm;

	public Base(uint n)
	{
		nm = n;
	}

	public virtual uint	this[int i]
	{
		get
		{
			if (i < 1)
				i = 1;
			return ((nm / ((uint)Math.Pow(10, i - 1))) % 10);
		}
	}
}

class MyClass: Base
{
	public uint	nm2;
	
	public MyClass(uint n1, uint n2): base(n1)
	{
		nm2 = n2;
	}

	public uint	this[int i1, int i]
	{
		get
		{
			uint	n;

			if (i1 % 2 == 0)
				n = nm;
			else
				n = nm2;
			if (i < 1)
				i = 1;
			return ((n / ((uint)Math.Pow(10, i - 1))) % 10);

		}
	}

	public override uint	this[int i]
	{
		get
		{
			uint	n;

			n = nm + nm2;
			if (i < 1)
				i = 1;
			return ((n / ((uint)Math.Pow(10, i - 1))) % 10);

		}
	}
}

class Program
{
	static void	Main()
	{
		MyClass	m;

		m = new MyClass(1238, 17);
		Console.WriteLine(m.nm + "\t" + m.nm2);
		Console.WriteLine(m[0, 1] + "\t" + m[1, 1]);
		Console.WriteLine(m.nm + m.nm2);
		Console.WriteLine(m[1]+"\t"+m[2]+"\t"+m[3]);
	}
}
