using System;

class MyClass<X>
{
	X[]	ms;

	public	MyClass(int n)
	{
		ms = new X[n];
	}

	public X	this[int i]
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
		return (st);
	}
}

class Program
{
	static void	Main()
	{
		MyClass<int>	m;
		int	size;

		Console.Write("Write size of array: ");
		size = Int32.Parse(Console.ReadLine());
		m = new MyClass<int>(size);
		for (int i = 0; i < size; i++)
			m[i] = Int32.Parse(Console.ReadLine());
		Console.WriteLine(m);
	}
}
