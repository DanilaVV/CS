using System;
using System.Windows.Forms;
using System.Drawing;

class MyForm: Form
{
	public MyForm(): base()
	{
		Color cl = BackColor;
		string[] ms = {"Base", "Red", "Green", "Blue"};

		Size = new Size(400, 400);
		StartPosition = FormStartPosition.CenterScreen;
		FormBorderStyle = FormBorderStyle.Fixed3D;
		Text = "MyForm";

		Label lb = new Label();
		lb.Size = new Size(200, 200);
		lb.Top = 5;
		lb.Left = 5;
		lb.BorderStyle = BorderStyle.Fixed3D;
		Controls.Add(lb);

		ComboBox cb = new ComboBox();
		cb.Top = lb.Top;
		cb.Left = lb.Right + 10;
		cb.Width = 70;
		cb.Items.AddRange(ms);
		cb.DropDownStyle = ComboBoxStyle.DropDownList;
		cb.SelectedIndexChanged += (n1, n2) => {
			if (cb.SelectedIndex == 0)
				lb.BackColor = cl;
			if (cb.SelectedIndex == 1)
				lb.BackColor = Color.Red;
			if (cb.SelectedIndex == 2)
				lb.BackColor = Color.Green;
			if (cb.SelectedIndex == 3)
				lb.BackColor = Color.Blue;
		};
		Controls.Add(cb);
		cb.SelectedIndex = 0;

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
