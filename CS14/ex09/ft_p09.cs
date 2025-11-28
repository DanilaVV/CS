using System;

class MyClass<X, Y> where X: IComparable where Y: IComparable
{
	public X[]	ms1;
	public Y[]	ms2;

	public MyClass(int n)
	{
		ms1 = new X[n];
		ms2 = new Y[n];
	}

	public X	this[Y j]
	{
		get
		{
			for (int i = 0; i < ms2.Length; i++)
				if (ms2[i].CompareTo(j) == 0)
					return (ms1[i]);
				return (ms1[0]);
		}
		set
		{
			for (int i = 0; i < ms2.Length; i++)
			if (ms2[i].CompareTo(j) == 0)
					ms1[i] = value;
		}
	}
	public override string	ToString()
	{
		return (ms1.Length + "");
	}
	public static MyClass<X, Y>	operator+(MyClass<X, Y> m, int j)
	{
		MyClass<X, Y>	ms;
		int	i;
		
		ms = new MyClass<X, Y>(m.ms1.Length + j);
		for (i = 0; i < m.ms1.Length; i++)
		{
			ms.ms1[i] = m.ms1[i];
			ms.ms2[i] = m.ms2[i];
		}
		for (int k = 0; k < j; i++, k++)
		{
			ms.ms1[i] = m.ms1[m.ms1.Length - 1];
			ms.ms2[i] = m.ms2[m.ms1.Length - 1];
		}
		return (ms);
	}
	public static MyClass<X, Y>	operator-(MyClass<X, Y> m, int j)
	{
		MyClass<X, Y>	ms;
		int	i;
		
		i = m.ms1.Length - j;
		if (i <= 0)
			return (null);
		ms = new MyClass<X, Y>(i);
		for (int k = 0; k < i; k++)
		{
			ms.ms1[k] = m.ms1[k];
			ms.ms2[k] = m.ms2[k];
		}
		return (ms);
	}
}

class Program
{
	static void	Main()
	{
		MyClass<int, char>	m;

		m = new MyClass<int, char>(12);
		for (int i = 0; i < 12; i++)
		{
			m.ms2[i] = (char)('A' + i);
			m.ms1[i] = m.ms2[i];
		}
		Console.WriteLine(m['E']);
		Console.WriteLine(m);
		m += 5;
		Console.WriteLine(m);
		m -= 3;
		Console.WriteLine(m);
		Console.WriteLine(m[m.ms2[m.ms2.Length - 1]]);
		Console.WriteLine(m[m.ms2[m.ms2.Length - 2]]);
	}
}
