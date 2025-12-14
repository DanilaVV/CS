using System;
using System.Windows.Forms;
using System.Drawing;

class MyForm: Form
{
	public MyForm(): base()
	{
		string[] ms = {"Basic", "Red", "Green", "Blue", "Pink"};

		Size = new Size(400, 400);
		FormBorderStyle = FormBorderStyle.Fixed3D;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "MyForm";

		var lb = new Label();
		lb.Size = new Size(ClientSize.Width - 20, ClientSize.Height - 20);
		lb.Top = 10;
		lb.Left = 10;
		lb.BorderStyle = BorderStyle.Fixed3D;
		var cl = lb.BackColor;
		Controls.Add(lb);
		
		var cm = new ContextMenu();
		MenuItem[] mims = new MenuItem[5];
		for (int i = 0; i < mims.Length; i++)
		{
			int j = i;
			mims[i] = new MenuItem(ms[i]);
			mims[i].Click += (n1, n2) => {
				switch (j)
				{
					case 0: lb.BackColor = cl;
						break ;
					case 1: lb.BackColor = Color.Red;
						break ;
					case 2: lb.BackColor = Color.Green;
						break ;
					case 3: lb.BackColor = Color.Blue;
						break ;
					case 4: lb.BackColor = Color.Pink;
						break ;
				}
			};
			cm.MenuItems.Add(mims[i]);
		}
		lb.ContextMenu = cm;

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
