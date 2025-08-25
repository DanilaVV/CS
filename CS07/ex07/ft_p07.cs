using System;

class Base
{
	protected string	st;

	public virtual string	prop
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

	public override string	ToString()
	{
		return ("Base: " + st);
	}
}

class MyClass: Base
{
	string	st2;

	public override string	prop
	{
		get
		{
			return (st + " " + st2);
		}
		set
		{
			int	i;

			st = "";
			st2 = "";
			for (i = 0; i < value.Length; i++)
			{
				if (value[i] == ' ')
					break ;
					st += value[i];
			}
			if (i != value.Length - 1)
				for (i++; i < value.Length; i++)
					st2 += value[i];
		}
	}

	public override string	ToString()
	{
		return ("MyClass: " + st + "\t\t" + st2);
	}
}

class Program
{
	static void	Main()
	{
		MyClass	m;

		m = new MyClass();
		m.prop = "Hello, I'm here!";
		Console.WriteLine(m);
		Console.WriteLine(m.prop);
		m.prop = "!";
		Console.WriteLine(m);
		Console.WriteLine(m.prop);
	}
}
