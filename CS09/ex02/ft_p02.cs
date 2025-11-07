using System;

delegate char	delega();

class MyClass
{
	public string	st;
	delega	del;

	public MyClass(string st, bool bl)
	{
		this.st = st;
		if (bl)
		{
			del = () => this.st[0];
		}
		else
		{
			del = () => this.st[this.st.Length - 1];
		}
	}
	public delega	property
	{
		get
		{
			return (del);
		}
	}
}

class Program
{
	static void	Main()
	{
		MyClass	m;

		m = new MyClass("Lesson", true);
		Console.WriteLine(m.property());
		m = new MyClass("Lesson", false);
		Console.WriteLine(m.property());
	}
}
