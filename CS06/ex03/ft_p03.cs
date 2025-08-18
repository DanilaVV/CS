using System;

class MyClass
{
	uint	nm;
	string	st;

	public MyClass(uint n)
	{
		nm = n;
		st = "";
		while (n != 0)
		{
			st = n % 8 + st;
			n /= 8;
		}
	}

	public uint	property1
	{
		set
		{
			uint	n;
			
			n = value;
			nm = value;
			st = "";
			while (n != 0)
			{
				st = n % 8 + st;
				n /= 8;
			}
		}
	}

	public string	property2
	{
		get
		{
			return (st);
		}
	}

	public override string	ToString()
	{
		return ("MyClass: " + nm + "\t" + st);
	}
}

class Program
{
	static void	Main()
	{
		MyClass	m;

		m = new MyClass(8);
		Console.WriteLine(m);
		m.property1 = 19;
		Console.WriteLine(m.property2);
	}
}
