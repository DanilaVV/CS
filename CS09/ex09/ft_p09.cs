using System;

delegate void	delega(string st);

class MyClass
{
	string	st;
	//delega	del;

	public MyClass(string st)
	{
		this.st = st;
	}
	
	public event delega	MyEvent;
	/*{
		add
		{
			del += value ;
		}
		remove
		{
			del -= value ;
		}
	}*/

	public void	startEvent()
	{
		if (MyEvent == null)//if (del == null)
			Console.WriteLine("The event doesn'n contain methods");
		else
			MyEvent(st);//del(st);
	}
}

class NewClass
{
	public void	show(string st)
	{
		Console.WriteLine(st);
	}
}

class Program
{
	static void	Main()
	{
		MyClass	m1;
		MyClass	m2;
		NewClass	m;

		m1 = new MyClass("Alpha");
		m2 = new MyClass("Betha");
		m = new NewClass();
		m1.MyEvent += m.show;
		m2.MyEvent += m.show;
		m1.startEvent();
		m2.startEvent();
	}
}
