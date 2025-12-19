using System;
using System.IO;

class MyClass
{
	int	nm;
	char	ch;
	string	st;

	public MyClass(int n, char c, string s)
	{
		nm = n;
		ch = c;
		st = s;
	}

	public override string	ToString()
	{
		return ("MyClass\nInteger: " + nm + "\nChar: " + ch + "\nString: " + st);
	}
}

class Program
{
	static void	Main()
	{
		int	n;
		char	c;
		string	s;
		MyClass	m;
		BinaryWriter	bw;
		BinaryReader	br;

		Console.Write("Write number: ");
		n = Int32.Parse(Console.ReadLine());
		Console.Write("Write character: ");
		c = (Console.ReadLine())[0];
		Console.Write("Write string: ");
		s = Console.ReadLine();
		bw = new BinaryWriter(new FileStream("File.txt", FileMode.OpenOrCreate));
		bw.Write(n);
		bw.Write(c);
		bw.Write(s);
		bw.Close();
		br = new BinaryReader(new FileStream("File.txt", FileMode.Open));
		m = new MyClass(br.ReadInt32(), br.ReadChar(), br.ReadString());
		Console.WriteLine(m);
	}
}
