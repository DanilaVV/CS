using System;

delegate void	delega(char ch);

class MyClass
{
	char ch;

	public void	ft_set(char c)
	{
		ch = c;
	}

	public override string	ToString()
	{
		return ("MyClass: " + ch);
	}
}

class Program
{
	static void	Main()
	{
		MyClass[]	ms;
		delega	del;

		ms = new MyClass[10];
		del = null;
		for (int i = 0; i < ms.Length; i++)
		{
			ms[i] = new MyClass();
			del += ms[i].ft_set;
		}
		del('E');
		foreach (var m in ms)
			Console.WriteLine(m);
	}
}
