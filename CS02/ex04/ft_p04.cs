using System;

class Program
{

	static double	ft_met(int[] ms)
	{
		double	res;

		res = 0.0;
		foreach (int n in ms)
			res += n;
		return (res / ms.Length);
	}
	
	static void	ft_show(int[] ms)
	{
		for (int i = 0; i < ms.Length; i++)
			Console.Write(ms[i] + " ");
		Console.WriteLine();
	}

	static void	Main()
	{
		int[]	ms;

		ms = new int[]{13, 17, 11};
		ft_show(ms);
		Console.WriteLine(ft_met(ms));
	}
}
