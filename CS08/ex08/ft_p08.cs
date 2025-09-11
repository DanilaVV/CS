using System;

abstract class Base
{
	protected char[]	ms;

	public Base(string st)
	{
		ms = st.ToCharArray();
	}

	public char	ft_getchar(int	i)
	{
		if (i < 0)
			return (ms[0]);
		if(i > ms.Length - 1)
			return (ms[ms.Length - 1]);
		return (ms[i]);
	}

	public abstract void	ft_met(int i, char c);
}

interface intf
{
	void	ft_met(string st);

	char	this[int i]
	{
		get ;
		set ;
	}
}

class MyClass: Base, intf
{
	public MyClass(string st): base(st)
	{}

	public override void	ft_met(int i, char c)
	{
		if (i < 0)
			ms[0] = c;
		if (i > ms.Length - 1)
			ms[ms.Length - 1] = c;
		ms[i] = c;
	}

	public void	ft_met(string st)
	{
		ms = st.ToCharArray();
	}

	public char	this[int i]
	{
		get
		{
			return (ft_getchar(i));
		}
		set
		{
			ft_met(i, value);
		}
	}

	public static string	operator~(MyClass m)
	{
		return (new string (m.ms));
	}
}

class Program
{
	static void	Main()
	{
		MyClass m = new MyClass("Hello, Everyone!");
		Console.WriteLine(~m);
		m[10] = '-';
		Console.WriteLine(m[10] + "\t" + ~m);
	}
}
