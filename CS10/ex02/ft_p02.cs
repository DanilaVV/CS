using System;

struct MyStruct
{
	char[]	ms;

	public MyStruct(string st)
	{
		ms = st.ToCharArray();
	}

	public MyStruct(char c, int n)
	{
		ms = new char[n];

		for (int i = 0; i < n; i++)
			this[i] = c;
	}

	public void	ft_reverse()
	{
		char	c;

		for (int i = 0, j = ms.Length - 1; i < ms.Length / 2; i++, j--)
		{
			c = ms[i];
			ms[i] = ms[j];
			ms[j] = c;
		}
	}

	public char	this[int i]
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
		foreach (var c in ms)
			st += c;
		return (st);
	}
}

class Program
{
	static void	Main()
	{
		MyStruct	m;

		m = new MyStruct("Television");
		Console.WriteLine(m);
		m.ft_reverse();
		Console.WriteLine(m);
		m = new MyStruct('E', 11);
		Console.WriteLine(m);
	}
}
