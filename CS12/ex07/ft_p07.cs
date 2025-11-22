using System;

class MyException: ApplicationException
{
	public char[]	ms;

	public MyException(int n)
	{
		ms = new char[n];
		for (int i = 0; i < n; i++)
			ms[i] = (char)('A' + i);
	}
}

class Program
{
	static void	Main()
	{
		try
		{
			throw (new MyException(Int32.Parse(Console.ReadLine())));
		}
		catch (MyException e)
		{
			try
			{
				for (int i = 0;; i++)
					Console.Write(e.ms[i] + " ");
			}
			catch
			{
				Console.WriteLine();
			}
		}
	}
}
