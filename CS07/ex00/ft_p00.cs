using System;

class Base
{
	protected string	st;

	public Base(string st)
	{
		this.st = st;
	}

	public override string	ToString()
	{
		return ("Base: "+ st);
	}
}

class MyClass: Base
{
	new protected string	st;

	public MyClass(string st): base(st)
	{
		this.st = st;
		base.st = "!" + st + "!";
	}
	public MyClass (string s1, string s2): base(s1)
	{
		st = s2;
	}
	public override string	ToString()
	{
		return ("MyClass: " + st + "\t" + base.st);
	}
}

class Program
{
	static void	Main()
	{
		MyClass	m;

		m = new MyClass("1993");
		Console.WriteLine(m);
		m = new MyClass("25", "14");
		Console.WriteLine(m);
	}
}
