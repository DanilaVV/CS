using System;
using System.Windows.Forms;

class Program
{
	static void	Main()
	{
		DialogResult res;
		int	rnd;
		int	nm;

		rnd = (new Random()).Next(0, 10);
		while (true)
		{
			Console.Write("Write your number: ");
			nm = Int32.Parse(Console.ReadLine());
			if (nm == rnd)
				break ;
			res = MessageBox.Show("One else?", "Fail!", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
			if (res == DialogResult.Yes)
				Console.Clear();
			else
				break ;
		}
	}
}
