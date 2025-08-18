using System;

class MyClass
{
	int[,]	ms;

	public MyClass(int n1, int n2)
	{
		Random	r;

		r = new Random();
		ms = new int[n1, n2];
		for (int i = 0; i < n1; i++)
			for(int j = 0; j < n2; j++)
				ms[i, j] = r.Next(10, 100);
	}

	public int	this[int i, int j]
	{
		get
		{
			return (ms[i % ms.GetLength(0), j % ms.GetLength(1)]);
		}
		set
		{
			ms[i % ms.GetLength(0), j % ms.GetLength(1)] = value;
		}
	}

	public int	this[int i]
	{
		get
		{
			int	max;

			i = i % ms.GetLength(0);
			max = ms[i, 0];
			for (int j = 1; j < ms.GetLength(1); j++)
				if (max < ms[i, j])
					max = ms[i, j];
			return (max);
		}
		set
		{
			int	j;

			j = 0;
			i = i % ms.GetLength(0);
			for (; j < ms.GetLength(1); j++)
				if (this[i] == ms[i, j])
					break ;
			ms[i, j] = value;
		}
	}
	public override string	ToString()
	{
		string	res;

		res = "";
		for (int i = 0; i < ms.GetLength(0); i++)
		{
			for (int j = 0; j < ms.GetLength(1); j++)
				res += (ms[i, j] + " ");
			res += ("\t" + this[i] + "\n");
		}
		return (res);
	}
}

class Program
{
	static void	Main()
	{
		MyClass	m;

		m = new MyClass(5, 7);
		Console.WriteLine(m);
		m[4] = -1;
		Console.WriteLine(m);
	}
}
