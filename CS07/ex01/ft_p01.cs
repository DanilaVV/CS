using System;

class Base
{
	protected string	st;

	public virtual void	ft_set()
	{
		st = "Base";
	}

	public virtual void	ft_set(string st)
	{
		this.st = st;
	}
	
	public Base(string st)
	{
		this.st = st;
	}

	public int	prop
	{
		get
		{
			return (st.Length);
		}
	}

	public char	this[int i]
	{
		get
		{
			return (st[i % this.prop]);
		}
	}
}

class MyClass: Base
{
	public int	nm;

	public MyClass(int nm, string st): base(st)
	{
		ft_set(nm);
		base.st = st;
	}

	public override void	ft_set()
	{
		nm = 0;
		base.ft_set("MyClass");
	}

	public override void	ft_set(string s)
	{
		nm = base.prop;
		base.ft_set(s);
	}

	public void	ft_set(int n)
	{
		ft_set();
		nm = n;
	}

	public override string	ToString()
	{
		return ("Int: " + nm + "\nString: " + base.st);
	}
}

class Program
{
	static void	Main()
	{
		MyClass	m;

		m = new MyClass(23, "Hello");
		Console.WriteLine(m);
		m.ft_set("14");
		Console.WriteLine(m);
		m.ft_set(-10);
		Console.WriteLine(m);
	}
}
