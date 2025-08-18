using System;

class MyClass
{
	int[]	ms;

	public MyClass(int n)
	{
		ms = new int[n];
		for (int i = 0; i < n; i++)
			ms[i] = i + 1;
	}

	public int	property
	{
		get
		{
			int	n;

			n = 0;
			foreach (var l in ms)
				n += l;
			return (n);
		}
	}

	public override string	ToString()
	{
		string	st;

		st = "";
		foreach (var n in ms)
			st += (n + " ");
		return ("MyClass: " + st);
	}
}

class Program
{
	static void	Main()
	{
		MyClass	m;

		m = new MyClass(11);
		Console.WriteLine(m);
		Console.WriteLine(m.property);
	}
}
