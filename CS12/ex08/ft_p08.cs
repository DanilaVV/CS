using	System;

class MyEx1: Exception
{

}

class MyEx2: ApplicationException
{

}

class MyClass
{
	char[]	ms;

	public MyClass(int n)
	{
		ms = new char[n];
	}

	public char	this[int i]
	{
		get
		{
			if (i > ms.Length - 1)
				throw (new MyEx1());
			if (i < 0)
				throw (new MyEx2());
			return (ms[i]);
		}
		set
		{
			if (i > ms.Length - 1)
				throw (new MyEx1());
			if (i < 0)
				throw (new MyEx2());
			ms[i] = value;
		}
	}
}

class Program
{
	static void	Main()
	{
		MyClass	m;
		int	i;

		i = 0;
		m = new MyClass(Int32.Parse(Console.ReadLine()));
		try
		{
			try
			{
				for (;; i++)
					m[i] = (char)('a' + i);
			}
			catch (MyEx1)
			{
				i--;
				for (;; i--)
				Console.Write(m[i] + " ");
			}
		}
		catch (MyEx2)
		{
			Console.WriteLine();
		}
	}
}
