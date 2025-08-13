using System;

class MyClass
{
	int[]	ms;

	public MyClass(int n)
	{
		ms = new int[n];
	}

	public static string	operator~(MyClass m)
	{
		string	res;

		res = "";
		foreach (var n in m.ms)
			res += (n + " ");
		return (res);
	}

	public static MyClass	operator++(MyClass m)
	{
		MyClass	mn;

		mn = new MyClass(m.ms.Length + 1);
		for (int i = 0; i < m.ms.Length; i++)
			mn.ms[i] = m.ms[i];
		m = mn;
		return (m);
	}

	public static MyClass	operator--(MyClass m)
	{
		MyClass mn;

		mn = new MyClass(m.ms.Length - 1);
		for (int i = 0; i < mn.ms.Length; i++)
			mn.ms[i] = m.ms[i];
		m = mn;
		return (m);
	}

	public static MyClass	operator+(MyClass m, int n)
	{
		MyClass	mn;

		mn = new MyClass(m.ms.Length + 1);
		for (int i = 0; i < m.ms.Length; i++)
			mn.ms[i] = m.ms[i];
		mn.ms[m.ms.Length] = n;
		return (mn);
	}

	public static MyClass	operator+(int n, MyClass m)
	{
		MyClass	mn;

		mn = new MyClass(m.ms.Length + 1);
		mn.ms[0] = n;
		for (int i = 1, j = 0; i < mn.ms.Length; i++, j++)
			mn.ms[i] = m.ms[j];
		return (mn);
	}

	public static MyClass	operator+(MyClass m1, MyClass m2)
	{
		MyClass	m;

		m = new MyClass(m1.ms.Length);
			for (int i = 0; i < m1.ms.Length; i++)
				m.ms[i] = m1.ms[i];
		foreach (var n in m2.ms)
			m = m + n;
		return (m);
	}
	
	public override string	ToString()
	{
		return ("MyClass: " + ~this);
	}
}

class Program
{
	static void	Main()
	{
		MyClass	m;

		m = new MyClass(1);
		Console.WriteLine(m);
		m++;
		Console.WriteLine(m);
		m--;
		Console.WriteLine(m);
		m = 12 + m;
		m = m + -10;
		Console.WriteLine(m);
		Console.WriteLine(m + new MyClass (10));
	}
}
