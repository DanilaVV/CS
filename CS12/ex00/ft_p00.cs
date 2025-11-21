using System;

class MyClass
{
	static void	Main()
	{
		int[]	ms;

		try
		{
			ms = new int[Int32.Parse(Console.ReadLine())];
			for (int i = 0; i < ms.Length; i++)
			{
				ms[i] = i + 1;
				Console.Write(ms[i] + " ");
			}
			Console.WriteLine();
		}
		catch (Exception eobj)
		{
			Console.WriteLine(eobj.Message);
		}
	}
}
