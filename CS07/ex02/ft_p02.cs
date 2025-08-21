using System;

class Base
{
	public int[]	ms;

	public Base(int[] mms)
	{
		ms = new int[mms.Length];
		for (int i = 0; i < ms.Length; i++)
			ms[i] = mms[i];
	}

	public override string	ToString()
	{
		string	res;

		res = "";
		foreach (var n in ms)
			res += (n + " ");
		return (res);
	}
}

class MyClass: Base
{
	public char[]	cms;

	public MyClass(int[] ms, char[] mms): base(ms)
	{
		cms = new char[mms.Length];
		for (int i = 0; i < cms.Length; i++)
			cms[i] = mms[i];
	}

	public override string	ToString()
	{
		string	res;

		res = base.ToString() + "\n";
		foreach (var n in cms)
			res += (n + " ");
		return (res);
	}
}

class Program
{
	public static void	Main()
	{
		MyClass	m;

		int[]	ms = {1, 2, 3, 0, -2};
		char[]	cms = new char[]{'A', 'B', 'e', '5', '!'};
		m = new MyClass(ms, cms);
		Console.WriteLine(m);
	}
}
