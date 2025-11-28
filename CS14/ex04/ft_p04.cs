using System;

class MyClass<X>
{
	X	nm;
	public MyClass<X>	m;

	public MyClass(X n, MyClass<X> m)
	{
		nm = n;
		this.m = m;
	}
	public override string	ToString()
	{
		return (nm + "\n" +m);
	}
}

class Program
{
	static void	Main()
	{
		MyClass<int>	m1;
		MyClass<int>	m2;
		MyClass<int>	m3;

		m3 = new MyClass<int>(321, null);
		m2 = new MyClass<int>(21, m3);
		m1 = new MyClass<int>(1, m2);
		Console.WriteLine(m1);
	}
}
