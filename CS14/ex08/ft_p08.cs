using System;

class MyClass<X>
{
	X[]	ms;

	public MyClass(X[] ms)
	{
		this.ms = ms;
	}
	public static MyClass<X>	operator+(MyClass<X> m1, MyClass<X> m2)
	{
		X[]	ms;
		int	i;
		int	j;

		ms = new X[m1.ms.Length + m2.ms.Length];
		i = 0;
		j = 0;
		for (; i < m1.ms.Length; i++)
			ms[i] = m1.ms[i];
		for (; j < m2.ms.Length; i++, j++)
			ms[i] = m2.ms[j];
		return (new MyClass<X>(ms));
	}
	public override string	ToString()
	{
		string	res;

		res = "";
		foreach (var n in ms)
			res += (n + " ");
		return (res);
	}
}

class Program
{
	static void	Main()
	{
		MyClass<string>	m1;
		MyClass<string>	m2;

		m1 = new MyClass<string>(new string[]{"One", "Two"});
		m2 = new MyClass<string>(new string[]{"blue", "red", "yellow"});
		Console.WriteLine(m1);
		Console.WriteLine(m2);
		Console.WriteLine((m1 + m2));
	}
}
