using System;

interface intf1
{
	int	prop1
	{
		get ;
		set ;
	}

	void	ft_met();
}

interface intf2
{
	string	prop2
	{
		get ;
		set ;
	}

	void	ft_met();
}

class MyClass: intf1, intf2
{
	int	nm;
	string	st;

	public int	prop1
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

	public string	prop2
	{
		get
		{
			return (st);
		}
		set
		{
			st = value;
		}
	}
	public void	ft_met()
	{
		Console.WriteLine(prop1 + "\t" + prop2);
	}
}

class Program
{
	static void	Main()
	{
		MyClass m = new MyClass();
		m.prop1 = 33;
		m.prop2 = "Summer";
		m.ft_met();
	}
}
