using System;
using System.Windows.Forms;
using System.Drawing;

class MyForm: Form
{
	public MyForm(): base()
	{
		string[] mfm = {"Arial", "Times New Roman", "Courier New"};
		FontStyle[] mst = {FontStyle.Regular, FontStyle.Italic, FontStyle.Bold, FontStyle.Italic | FontStyle.Bold};
		int[] msz = {8, 10, 14, 20};
		Font fnt = new Font("Arial", 10, FontStyle.Regular);

		Size = new Size(400, 400);
		FormBorderStyle = FormBorderStyle.Fixed3D;
		StartPosition = FormStartPosition.CenterScreen;
		Text = "MyForm";

		var tb = new TextBox();
		tb.Size = new Size(ClientSize.Width - 20, 50);
		tb.Top = 100;
		tb.Left = 10;
		tb.Font = fnt;
		Controls.Add(tb);
		
		var menu = new MainMenu();
		MenuItem m1 = new MenuItem("Font");
		MenuItem m2 = new MenuItem("Size");
		MenuItem m3 = new MenuItem("Style");
		MenuItem m4 = new MenuItem("Program");
		menu.MenuItems.Add(m1);
		menu.MenuItems.Add(m2);
		menu.MenuItems.Add(m3);
		menu.MenuItems.Add(m4);
		m4.MenuItems.Add(new MenuItem("Exit", (n1, n2) => {Application.Exit();}));
		for (int i = 0; i < mfm.Length; i++)
		{
			int j = i;
			m1.MenuItems.Add(new MenuItem(mfm[j], (n1, n2) => {
							fnt =new Font(mfm[j], fnt.Size, fnt.Style);
							tb.Font = fnt;
						}));
		}
		for (int i = 0; i < msz.Length; i++)
		{
			int j = i;
			m2.MenuItems.Add(new MenuItem(msz[j] + "", (n1, n2) => {
							fnt =new Font(fnt.FontFamily, msz[j], fnt.Style);
							tb.Font = fnt;
						}));
		}
		for (int i = 0; i < mst.Length; i++)
		{
			int j = i;
			 m3.MenuItems.Add(new MenuItem( (j == 0) ? "Regular" : (j == 1) ? "Italic" : (j == 2) ? "Bold" : "Italic & Bold", (n1, n2) => {
							fnt =new Font(fnt.FontFamily, fnt.Size, mst[j]);
							tb.Font = fnt;
						}));
		}
		Menu = menu;

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
