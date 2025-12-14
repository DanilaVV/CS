using System;
using System.Windows.Forms;
using System.Drawing;

class MyForm: Form
{
	public MyForm(): base()
	{
		string	fmt;
		int	ch;
		string[] ms = {"One", "Two", "Three", "Four"};
		Image[] img = new Image[4];
		fmt = ".jpg";
		ch = 0;
		Size = new Size(600, 400);
		StartPosition = FormStartPosition.CenterScreen;
		FormBorderStyle = FormBorderStyle.Fixed3D;
		Text = "MyForm";
		for (int i = 0; i < img.Length; i++)
			img[i] = Image.FromFile(ms[i] + fmt);

		Size sz = new Size(ClientSize.Width - 50, ClientSize.Height - 50);
		var btm = new Bitmap(img[0], sz);
		var lb = new Label();
		lb.BorderStyle = BorderStyle.Fixed3D;
		lb.Size = sz;
		lb.Top = 10;
		lb.Left = 25;
		lb.Image = btm;
		Controls.Add(lb);

		var bt = new Button[2];
		for (int i = 0; i < bt.Length; i++)
		{
			bt[i] = new Button();
			bt[i].Size = new Size(50, 30);
			bt[i].Font = new Font("Arial", 12, FontStyle.Bold);
			bt[i].Top = lb.Bottom + 5;
			bt[i].Left = (i == 0) ? lb.Left : lb.Right - bt[i].Width;
			bt[i].Text = (i == 0) ? "<" : ">";
			Controls.Add(bt[i]);
		}
		bt[0].Click += (n1, n2) => {
			ch = (ch == 0) ? ms.Length - 1 : (ch - 1);
			btm = new Bitmap(img[ch], sz);
			lb.Image = btm;
		};
		bt[1].Click += (n1, n2) => {
			ch = (ch == ms.Length - 1) ? 0 : (ch + 1);
			btm = new Bitmap(img[ch], sz);
			lb.Image = btm;
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
