using System;

class Program
{
	unsafe static void	Main()
	{
		int[]	ms;

		ms = new int[2];
		fixed (void *uk = ms)
		{
			for (byte i = 0; i < ms.Length * sizeof(int); i++)
				{
					((byte*)uk)[i] = (byte)(i + 1);
					Console.WriteLine(((byte*)uk)[i]);
				}
		}
		Console.WriteLine(ms[0] + "\t" + ms[1]);
	}
}
