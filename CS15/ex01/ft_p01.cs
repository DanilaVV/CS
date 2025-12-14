using System;
using System.Windows.Forms;
using System.Drawing;

class MyForm: Form
{
	public MyForm(): base()
	{
		Font f = new Font("Arial", 10, FontStyle.Italic);
		int	nm;

		nm = 0;
		Size = new Size(400, 400);
		Text = "MyForm";
		FormBorderStyle = FormBorderStyle.Fixed3D;
		StartPosition = FormStartPosition.CenterScreen;

		Label lb = new Label();
		lb.BorderStyle = BorderStyle.Fixed3D;
		lb.Size = new Size(200, 20);
		lb.Top = 10;
		lb.Left = ClientSize.Width / 2 - lb.Width / 2;
		lb.Font = f;
		lb.Text = nm + "";
		Controls.Add(lb);

		Button[] bt = new Button[3];
		for (int i = 0; i < bt.Length; i++)
		{
			bt[i] = new Button();
			bt[i].Size = new Size(60, 20);
			bt[i].Top = lb.Bottom + 10;
			bt[i].Left = lb.Left + (bt[i].Width * i + 10 * i);
			bt[i].Font = f;
			Controls.Add(bt[i]);
		}
		bt[0].Text = "+1";
		bt[1].Text = "-1";
		bt[2].Text = "Exit";
		bt[0].Click += (n1, n2) => {
			nm++;
			lb.Text = nm + "";
		};
		bt[1].Click += (n1, n2) => {
			nm--;
			lb.Text = nm + "";
		};
		bt[2].Click += (n1, n2) => {
			Application.Exit();
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
