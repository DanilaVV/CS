using System;

class Program
{
	unsafe static void	Main()
	{
		double	nm;
		byte	*uk;

		uk = (byte*)&nm;
		uk[0] = 1;
		((char*)(uk + 1))[0] = 'A';
		((int*)(uk + 3))[0] = 2;
		uk[7] = 3;
		Console.WriteLine(nm);
	}
}
