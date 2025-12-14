using System;
using System.Windows.Forms;
using System.Drawing;

class MyForm: Form
{
	public MyForm(): base()
	{
		Size = new Size (400, 400);
		FormBorderStyle = FormBorderStyle.Fixed3D;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "MyForm";

		var lb = new Label();
		lb.Size = new Size(ClientSize.Width - 10, 30);
		lb.Top = 10;
		lb.Left = 5;
		lb.BorderStyle = BorderStyle.Fixed3D;
		Controls.Add(lb);

		var tb = new TextBox();
		tb.Size = lb.Size;
		tb.Top = lb.Bottom + 10;
		tb.Left = lb.Left;
		tb.TextChanged += (n1, n2) => {
			lb.Text = tb.Text;
		};
		Controls.Add(tb);

		CheckBox[] cb = new CheckBox[2];
		for (int i = 0; i < cb.Length; i++)
		{
			cb[i] = new CheckBox();
			cb[i].Width = lb.Width / 3;
			cb[i].Left = lb.Left + lb.Width / 2 * i;
			cb[i].Top = tb.Bottom + 10;
			cb[i].CheckedChanged += (n1, n2) => {
				FontStyle f;

				if (cb[0].Checked && cb[1].Checked)
					f = FontStyle.Bold | FontStyle.Italic;
				else if (cb[0].Checked)
					f = FontStyle.Bold;
				else if (cb[1].Checked)
					f = FontStyle.Italic;
				else
					f = FontStyle.Regular;
				lb.Font = new Font (lb.Font.FontFamily, lb.Font.Size, f);
			};
			Controls.Add(cb[i]);
		}
		cb[0].Text = "Bold";
		cb[1].Text = "Italic";

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
