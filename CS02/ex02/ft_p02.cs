using System;

class Program
{

	static int[]	ft_met(int[] ms, int n)
	{
		int[]	mms;

		if (n > ms.Length)
			n = ms.Length;
		mms = new int[n];
		for (int i = 0; i < n; i++)
			mms[i] = ms[i];
		return (mms);
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
		ms = new int[]{1, 2, 3, 4, 5};
		ft_show(ms);
		ft_show(ft_met(ms, 3));
	}
}
