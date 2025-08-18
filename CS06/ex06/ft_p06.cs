using System;

class MyClass
{
	uint	nm;

	public MyClass(uint n)
	{
		nm = n;
	}

	public int	this[int i]
	{
		get
		{	int[]	ms;
			string	st;
			uint	n;

			ms = new int[32];
			st = "";
			n = nm;
			while (n > 0)
			{
				st = n % 2 + st;
				n /= 2;
			}
			for (int j = 0; j < st.Length; j++)
				ms[j] = Int32.Parse(st[j] + "");
			if (i > 32)
				i = 32;
			if (i < 0)
				i = 0;
			return (ms[i]);
		}
	}

	public override string	ToString()
	{
		string	st;

		st = "";
		for (int i = 0; i < 32; i++)
			st += (this[i] + "");
		return ("MyClass: " + nm + "\t"+ st);
	}
}

class Program
{
	static void	Main()
	{
		MyClass	m;

		m = new MyClass(11);
		Console.WriteLine(m);
	}
}
