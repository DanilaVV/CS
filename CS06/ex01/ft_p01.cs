using System;

class MyClass
{
	int[]	ms;
	int	ch;

	public MyClass(int n)
	{
		ms = new int[n];
		for (int i = 0; i < n; i++)
			ms[i] = i + 1;
		ch = 0;
	}

	public int	property
	{
		get
		{
			int	n;

			n = ch;
			ch++;
			ch %= ms.Length;
			return (ms[n]);
		}
		set
		{
			ms[ch] = value;
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
		for (int i = 0; i < 6; i++)
			Console.WriteLine(m.property);
		m.property = -10;
		Console.WriteLine(m);
	}
}
