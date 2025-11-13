using System;

struct MyStruct
{
	int	n1;
	int	n2;
	int	n3;

	public MyStruct(int n1, int n2, int n3)
	{
		this.n1 = n1;
		this.n2 = n2;
		this.n3 = n3;
	}

	public MyStruct(int n1, int n2)
	{
		this.n1 = n1;
		this.n2 = n2;
		n3 = n1 - n2;
	}

	public MyStruct(int n)
	{
		n1 = n % 10;
		n2 = (n % 100) / 10;
		n3 = (n % 1000) / 100;
	}

	public int	ft_max(int n1, int n2)
	{
		if (n1 > n2)
			return (n1);
		return (n2);
	}

	public int	ft_min(int n1, int n2)
	{
		if (n1 < n2)
			return (n1);
		return (n2);
	}

	public int	Max
	{
		get
		{
			return (ft_max(ft_max(n1, n2), n3));
		}
		set
		{
			if (n1 == Max) 
				n1 = value;
			else if (n2 == Max)
				n2 = value;
			else if (n3 == Max)
				n3 = value;
		}
	}

	public int	Min
	{
		get
		{
			return (ft_min(ft_min(n1, n2), n3));
		}
		set
		{
			if (n1 == Min)
			       n1 = value;
			else if (n2 == Min)
				n2 = value;
			else if (n3 == Min)
				n3 = value;
		}
	}

	public override string	ToString()
	{
		return (n1 + " " + n2 + " " + n3);
	}
}

class Program
{
	static void	Main()
	{
		MyStruct	m;

		m = new MyStruct(4567);
		Console.WriteLine(m);
		Console.WriteLine("Max: " + m.Max + "\tMin: " +  m.Min);
		m.Max = 300;
		m.Min = -1000;
		Console.WriteLine(m);
		Console.WriteLine("Max: " + m.Max + "\tMin: " +  m.Min);
	}
}
