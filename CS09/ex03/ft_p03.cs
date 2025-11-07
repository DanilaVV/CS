using System;

delegate int	delega(int nm);

class MyClass
{
	public delega	this[int i]
	{
		get
		{
			return (nm => (int)Math.Pow(nm, i));
		}
	}
}

class Program
{
	static void	Main()
	{
		MyClass	m;

		m = new MyClass();
		for(int i = 0; i < 10; i++)
			Console.WriteLine(m[i](3));
	}
}
