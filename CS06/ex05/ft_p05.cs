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

	public int	this[int i]
	{
		get
		{
			return (ms[i % ms.Length]);
		}
		set
		{
			ms[i % ms.Length] = value;
		}
	}

	public override string	ToString()
	{
		string	st;

		st = "";
		for (int i = 0; i < ms.Length; i++)
			st += (this[i] + " ");
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
		m[70] = 0;
		Console.WriteLine(m);
	}
}
