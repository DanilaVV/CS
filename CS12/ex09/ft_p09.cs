using System;

class MyClass
{
	byte[]	ms;

	public MyClass(int n)
	{
		ms = new byte[n];
	}
	public int	this[int i]
	{
		get
		{
			return (ms[i % ms.Length]);
		}
		set
		{
			try
			{
				checked
				{
					ms[i % ms.Length] = (byte)value;
				}
			}
			catch
			{
				ms[i % ms.Length] = 255;
			}
		}
	}

	public override string	ToString()
	{
		string	st;

		st = "";
		foreach (var n in ms)
			st += (n + " ");
		return (st);
	}
}

class Program
{
	static void	Main()
	{
		MyClass	m;

		m = new MyClass(5);
		for (int i = 0; i < 5; i++)
			m[i] = 253 + i;
		Console.WriteLine(m);
	}
}
