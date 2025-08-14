using System;

class MyClass
{
	int[]	ms;

	public MyClass(int n)
	{
		Random	r;

		r = new Random();
		ms = new int[n];
		for (int i = 0; i < n; i++)
			ms[i] = r.Next(100);
	}

	public static explicit operator int(MyClass m)
	{
		int	res;

		res = 0;
		foreach (var n in m.ms)
			res += n;
		return (res);
	}

	public static implicit operator string(MyClass m)
	{
		string	res;

		res = "";
		foreach (var n in m.ms)
			res += (n + " ");
		return (res);
	}

	public static explicit operator MyClass(int n)
	{
		MyClass	m;
		
		m = new MyClass(n);
		for (int i = 0; i < n; i++)
			m.ms[i] = 0;
		return (m);
	}

	public override string	ToString()
	{
		return (this);
	}
}

class Program
{
	static void	Main()
	{
		MyClass	m;

		m = new MyClass(7);
		Console.WriteLine(m + "\t" + (int)m);
		Console.WriteLine((MyClass)11);
	}
}
