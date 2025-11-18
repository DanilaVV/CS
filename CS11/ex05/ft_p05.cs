using System;

class MyClass
{
	public int	nm;
}

class Program
{
	unsafe static void	Main()
	{
		MyClass	m;

		m = new MyClass();
		Console.WriteLine(m.nm);
		fixed (void *uk = &m.nm)
		{
			((char*)uk)[0] = 'A';
			((char*)uk)[1] = 'B';
		}
		Console.WriteLine(m.nm);
	}
}
