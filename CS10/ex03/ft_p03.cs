using System;

struct MyStruct
{
	int[]	ms;

	public MyStruct(int n)
	{
		Random	r;

		r = new Random();
		ms = new int[n];
		for (int i = 0; i < n; i++)
			ms[i] = r.Next(10, 100);
	}

	public int	ft_Max()
	{
		int	n;

		n = ms[0];
		foreach (var l in ms)
			if (l > n)
				n = l;
		return (n);
	}

	public int	ft_Min()
	{
		int	n;

		n = ms[0];
		foreach (var l in ms)
			if (l < n)
				n = l;
		return (n);
	}

	public double	ft_average()
	{
		double	res;

		res = 0;
		foreach (var n in ms)
			res += n;
		return (res / ms.Length);
	}

	public override string	ToString()
	{
		string	res;

		res = "";
		foreach (var n in ms)
			res += (n + " ");
		res += "\nMax: ";
		res += (ft_Max() + "\nMin: " + ft_Min() + "\nAverage: ");
		res += ft_average();
		return (res);
	}
}

class Program
{
	static void	Main()
	{
		MyStruct	m;

		m = new MyStruct(11);
		Console.WriteLine(m);
	}
}
