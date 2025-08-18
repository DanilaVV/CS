using System;

class MyClass
{
	static int	nm;

	public MyClass()
	{
		nm = 1;
	}

	public int	property
	{
		get
		{
			nm += 2;
			return (nm - 2);
		}
		set
		{
			nm = value * 2 - 1;
		}
	}
	public override string	ToString()
	{
		return ("MyClass: " + nm);
	}
}

class Program
{
	static void	Main()
	{
		MyClass	m;

		m = new MyClass();
		m.property = 3;
		Console.WriteLine(m.property);
		Console.WriteLine(m.property);
	}
}
