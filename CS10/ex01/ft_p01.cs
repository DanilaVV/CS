using System;

struct MyStruct
{
	int	nm;
	string	st;
	char	ch;

	public MyStruct(int n, string s, char c)
	{
		nm = n;
		st = s;
		ch = c;
	}

	public MyStruct(int n, string s)
	{
		nm = n;
		st = s;
		ch = s[n % s.Length];
	}

	public MyStruct(string st)
	{
		this.st = st;
		nm = st.Length;
		ch = st[0];
	}

	public void	ft_show()
	{
		Console.WriteLine("Integer: " + nm);
		Console.WriteLine("String: " + st);
		Console.WriteLine("Char: " + ch);
	}
}

class Program
{
	static void	Main()
	{
		MyStruct	ms;

		ms = new MyStruct ("Elbow");
		ms.ft_show();
		ms = new MyStruct (33, "Power");
		ms.ft_show();
	}
}
