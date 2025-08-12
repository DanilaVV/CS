using System;

class MyClass
{
	int[]	ms;

	public MyClass(int n)
	{
		Random	r;

		ms = new int[n];
		r = new Random();
		for (int i = 0; i < n; i++)
			ms[i] = r.Next(100);
	}

	public override string	ToString()
	{
		string	res;
		double	nm;

		res = "Massiv: ";
		nm = 0;
		foreach (var n in ms)
		{
			nm += n;
			res += (n + " ");
		}
		res += ("\nCount is " + ms.Length+ "\nMiddle is " + (double)nm / ms.Length);
		return (res);
	}
}

class Program
{
	static void	Main()
	{
		MyClass	m;

		m = new MyClass(11);
		Console.WriteLine(m);
	}
}
