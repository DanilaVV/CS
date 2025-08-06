using System;

class Program
{
	static int[]	ft_met(params int[] ms)
	{
		int[]	mms;

		mms = new int[2];
		mms[0] = ms[0];
		mms[1] = ms[0];
		foreach (int n in ms)
		{
			if (n > mms[0])
				mms[0] = n;
			if (n < mms[1])
				mms[1] = n;
		}
		return (mms);
	}
	static void	Main()
	{
		int[]	ms;

		ms = ft_met(23, -8, 0, 11, 4, 7);
		Console.WriteLine("Max: " + ms[0] + "\nMin: " + ms[1]);
	}
}
