using System;

class MyClass<X>
{
	X	nm;

	public X	property
	{
		get
		{
			return (nm);
		}
		set
		{
			nm = value;
		}
	}
}

class Program
{
	static void	Main()
	{
		MyClass<string>	m;

		m = new MyClass<string>();
		m.property = "One more time";
		Console.WriteLine(m.property);
	}
}
