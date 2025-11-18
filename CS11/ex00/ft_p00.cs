using System;

class Program
{
	unsafe static void	Main()
	{
		int	n;
		void	*uk;

		uk = &n;
		((byte*)uk)[0] = 1;
		((byte*)uk)[3] = 1;
		((char*)((byte*)uk + 1))[0] = 'A';
		Console.WriteLine(n);
	}
}
