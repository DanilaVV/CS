using System;

interface intf1
{
	int	this[char c]
	{
		get ;
	}
}

interface intf2
{
	char	this[int i]
	{
		get ;
	}
}

class MyClass: intf1, intf2
{
	public int	this[char c]
	{
		get
		{
			return ((int)c);
		}
	}

	public char	this[int i]
	{
		get
		{
			return ((char)i);
		}
	}
}

class Program
{
	static void	Main()
	{
		MyClass m = new MyClass();
		Console.WriteLine(m['a'] + "\t" + m[(int)'a']);
	}
}
