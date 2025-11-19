using System;

class Program
{
	unsafe static void	Main()
	{
		string	st;
		char	c;

		st = Console.ReadLine();
		fixed (char *uk = st)
		{
			for (int i = 0, j = st.Length - 1; i < st.Length / 2; i++, j--)
			{
				c = uk[i];
				uk[i] = uk[j];
				uk[j] = c;
			}
		}
		Console.WriteLine(st);
	}
}
