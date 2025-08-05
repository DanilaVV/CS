using System;

class Program
{

	static int[]	ft_met(char[] ms)
	{
		int[]	mms;

		mms = new int[ms.Length];
		for (int i = 0; i < mms.Length; i++)
			mms[i] = (int)ms[i];
		return (mms);
	}

	static void	ft_show(char[] ms)
	{
		for (int i = 0; i < ms.Length; i++)
			Console.Write(ms[i] + " ");
		Console.WriteLine();
	}

	static void	ft_show(int[] ms)
	{
		for (int i = 0; i < ms.Length; i++)
			Console.Write(ms[i] + " ");
		Console.WriteLine();
	}

	static void	Main()
	{
		char[]	ms;

		ms = new char[]{'A', 'c', 'D', '5', '!'};
		ft_show(ms);
		ft_show(ft_met(ms));
	}
}
