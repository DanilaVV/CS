using System;

struct MyStruct
{
	int	n1;
	int	n2;

	public MyStruct(int n1, int n2)
	{
		this.n1 = n1;
		this.n2 = n2;
	}

	public override string	ToString()
	{
		return ("MyStruct: " + n1 + "\t" + n2);
	}
}

class Program
{

	static MyStruct	ft_met(int[] ms)
	{
		int	max;
		int	imax;

		max = ms[0];
		imax = 0;
		for (int i = 1; i < ms.Length; i++)
		{
			if (max < ms[i])
			{
				max = ms[i];
				imax = i;
			}
		}

		return (new MyStruct(max, imax));
	}

	static void	Main()
	{
		Console.WriteLine(ft_met(new int[]{1, -2, 4, 10, -7}));
	}
}
