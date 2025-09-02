using System;

interface intf1
{
	string	prop
	{
		get ;
	}
}

interface intf2
{
	string	prop
	{
		get ;
	}
}

class MyClass: intf1, intf2
{
	public string	prop
	{
		get
		{
			return ("MyClass");
		}
	}

	string	intf1.prop
	{
		get
		{
			return ("Interface1");
		}
	}

	string	intf2.prop
	{
		get
		{
			return ("Interface2");
		}
	}
}

class Program
{
	static void	Main()
	{
		MyClass m = new MyClass();
		intf1 if1 = m;
		intf2 if2 = m;
		Console.WriteLine(m.prop + "\n" + if1.prop + "\n" + if2.prop);
	}
}
