using System;
using System.Windows.Forms;
using System.Drawing;

class MyForm: Form
{
	public MyForm(): base()
	{
		string[] ms = {"Arial", "Times New Roman", "Courier New"};
		string[] mc = {"Black", "Red", "Green", "Blue", "Pink"};
		Font fnt = new Font("Arial", 12, FontStyle.Regular);

		Size = new Size(400, 400);
		FormBorderStyle = FormBorderStyle.Fixed3D;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "MyForm";

		var tb = new TextBox();
		tb.Size = new Size(ClientSize.Width - 20, 50);
		tb.Top = 10;
		tb.Left = 10;
		tb.Font = fnt;
		Controls.Add(tb);

		var cb = new ComboBox();
		cb.Left = tb.Left;
		cb.Top = tb.Bottom + 5;
		cb.Items.AddRange(ms);
		cb.DropDownStyle = ComboBoxStyle.DropDownList;
		cb.SelectedIndex = 0;
		cb.SelectedIndexChanged += (n1, n2) => {
			tb.Font = new Font(ms[cb.SelectedIndex], 12, FontStyle.Regular);
		};
		Controls.Add(cb);

		var lb = new ListBox();
		lb.Left = cb.Right + 10;
		lb.Top = cb.Top;
		lb.Items.AddRange(mc);
		lb.SelectedIndex = 0;
		lb.SelectedIndexChanged += (n1, n2) => {
			switch (lb.SelectedIndex)
			{
				case 0: tb.ForeColor = Color.Black;
					break ;
				case 1: tb.ForeColor = Color.Red;
					break ;
				case 2: tb.ForeColor = Color.Green;
					break ;
				case 3: tb.ForeColor = Color.Blue;
					break ;
				case 4: tb.ForeColor = Color.Pink;
					break ;
			}
		};
		Controls.Add(lb);
		
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
