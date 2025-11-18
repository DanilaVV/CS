using System;

struct MyStruct
{
	public char	ch;
	public int	nm;

	public void	ft_show()
	{
		Console.WriteLine("Char: " + ch);
		Console.WriteLine("Integer: " + nm);
	}
}

class Program
{

	unsafe static void	Main()
	{
		MyStruct	m;
		MyStruct	*uk;

		uk = &m;
		uk -> ch = 'D';
		uk -> nm = 231;
		uk -> ft_show();
	}
}
