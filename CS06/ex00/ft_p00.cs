using System;

class MyClass
{
	char	c;

	public char	property
	{
		get
		{
			return (c);
		}
		set
		{
			if (value < 'A')
				c = 'A';
			else if (value > 'Z')
				c = 'Z';
			else
				c = value;
		}
	}

	public override string	ToString()
	{
		return ("MyClass: " + c);
	}
}

class Program
{
	static void	Main()
	{
		MyClass	m;

		m = new MyClass();
		m.property = 'p';
		Console.WriteLine(m);
		m.property = 'U';
		Console.WriteLine(m);
	}
}
