using System;
using System.Windows.Forms;
using System.Drawing;

class MyForm: Form
{
	public MyForm(): base()
	{
		Size = new Size(400, 400);
		Text = "MyForm";
		FormBorderStyle = FormBorderStyle.Fixed3D;
		BackColor = Color.Yellow;
		
		MouseEnter += (n1, n2) => {
			BackColor = Color.Green;
		};
		MouseLeave += (n1, n2) => {
			BackColor = Color.Yellow;
		};
		MouseClick += (n1, n2) => {
			Width = (int)(Width * 1.1);
			Height = (int)(Height * 1.1);
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
