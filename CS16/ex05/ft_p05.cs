using System;
using System.IO;

class Program
{
	static void	Main()
	{
		string	st;
		StreamWriter	sw;
		StreamReader	sr;
		
		st = Console.ReadLine();
		sw = new StreamWriter("File1.txt");
		sw.Write(st);
		sw.Close();
		sr = new StreamReader("File1.txt");
		st = sr.ReadToEnd();
		sr.Close();
		st = st.ToLower();
		st = st.Replace(" ", "_");
		sw = new StreamWriter("File2.txt");
		sw.Write(st);
		sw.Close();
	}
}
