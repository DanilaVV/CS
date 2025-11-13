using System;

struct MyStruct
{
	public char	ch;

	public MyStruct(char c)
	{
		ch = c;
	}
}

class Program
{

	static MyStruct[]	ft_stringToStruct(string st)
	{
		MyStruct[]	ms;

		ms = new MyStruct[st.Length];
		for (int i = 0; i < st.Length; i++)
		{
			ms[i] = new MyStruct(st[i]);
		}
		return (ms);
	}

	static string	ft_structToString(MyStruct[] ms)
	{
		string	st;

		st = "";
		foreach (var n in ms)
			st += n.ch;
		return (st);
	}

	static void	Main()
	{
		string	st;

		st = "My level is less now than I had before";
		Console.WriteLine(ft_structToString(ft_stringToStruct(st)));
	}
}
