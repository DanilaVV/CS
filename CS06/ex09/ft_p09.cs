using System;

class MyClass
{
	string[]	ms;

	public MyClass(string[] st)
	{
		ms = st;
	}

	public string	this[int i]
	{
		get
		{
			if (i < 0)
				i = 0;
			if (i > ms.Length - 1)
				i = ms.Length - 1;
			return (ms[i]);
		}
		set
		{
			if (i < 0)
				i = 0;
			if (i > ms.Length - 1)
				i = ms.Length - 1;
			ms[i] = value;
		}
	}
	public char	this[int i, int j]
	{
		get
		{
			return (ms[i % ms.GetLength(0)][j % ms[i % ms.GetLength(0)].Length]);
		}
	}
}

class Program
{
	static void	Main(string[] argv)
	{
		MyClass	m;

		m = new MyClass(argv);
		Console.WriteLine(m[100] + "\t" + m[2, 3]);
	}
}
