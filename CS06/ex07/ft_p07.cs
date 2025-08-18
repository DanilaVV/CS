using System;

class MyClass
{
	uint	nm;

	public MyClass(uint n)
	{
		nm = n;
	}

	public	uint this[int j]
	{
		set
		{
			uint[]	ms;
			uint	n;
			
			ms = new uint[32];
			n = nm;
			if (j < 1)
				j = 1;
			if (j > 9)
				j = 9;
			for (int i = 0; i < 9; i++)
			{
				ms[i] = n % 10;
				n /= 10;
				if (j - 1 == i)
					ms[i] = value % 10;
			}
			n = 0;
			for (int i = 0; i < 9; i++)
				n += (ms[i] * (uint)Math.Pow(10, i));
			nm = n;
		}
	}
	public override string	ToString()
	{
		return ("MyClass: " + nm);
	}
}

class Program
{
	static void	Main()
	{
		MyClass	m;

		m = new MyClass(UInt32.Parse(Console.ReadLine()));
		Console.WriteLine(m);
		m[30] = 41;
		Console.WriteLine(m);
	}
}
