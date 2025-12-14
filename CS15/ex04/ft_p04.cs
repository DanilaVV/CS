using System;
using System.Windows.Forms;
using System.Drawing;

class MyForm: Form
{
	static string	ft_met(int n1, int n2)
	{
		if (n1 < n2)
			return ("<");
		else if (n1 > n2)
			return (">");
		return ("=");
	}
	public MyForm(): base()
	{
		int nm1, nm2;
		nm1 = 0;
		nm2 = 0;
		Font fnt = new Font("Arial", 8, FontStyle.Italic);
		Size = new Size(400, 400);
		FormBorderStyle = FormBorderStyle.Fixed3D;
		Text = "MyForm";
		StartPosition = FormStartPosition.CenterScreen;

		var tb1 = new TextBox();
		tb1.Font = fnt;
		tb1.Size = new Size(ClientSize.Width / 3, 30);
		tb1.Top = 20;
		tb1.Left = 10;
		tb1.Text = "0";
		Controls.Add(tb1);

		var tb2 = new TextBox();
		tb2.Font = fnt;
		tb2.Size = new Size(ClientSize.Width / 3, 30);
		tb2.Top = 20;
		tb2.Left = ClientSize.Width - 10 - tb2.Width;
		tb2.Text = "0";
		Controls.Add(tb2);

		var lb = new Label();
		lb.Font = fnt;
		lb.Size = new Size(ClientSize.Width - 2 * tb1.Width - 40, 30);
		lb.Top = 20;
		lb.Left = tb1.Right + 10;
		lb.BorderStyle = BorderStyle.Fixed3D;
		lb.TextAlign = ContentAlignment.MiddleCenter;
		lb.Text = "=";
		Controls.Add(lb);

		tb1.TextChanged += (n1, n2) => {
			try
			{
				nm1 = Int32.Parse(tb1.Text);
				lb.Text = ft_met(nm1, nm2);
			}
			catch
			{
				lb.Text = "Not a number";
			}
		};

		tb2.TextChanged += (n1, n2) => {
			try
			{
				nm2 = Int32.Parse(tb2.Text);
				lb.Text = ft_met(nm1, nm2);
			}
			catch
			{
				lb.Text = "Not a number";
			}
		};

		Application.Run(this);
	}
}

class Program
{
	static void	Main()
	{
		new MyForm();
	}
}
