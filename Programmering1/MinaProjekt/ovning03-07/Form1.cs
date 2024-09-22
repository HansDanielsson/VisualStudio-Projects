using System;
using System.Windows.Forms;

namespace ovning03_07
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnRun_Click(object sender, EventArgs e)
		{
			int kod = (int)tbxTecken.Text[0];
			lblSvar.Text = tbxTecken.Text + " har koden " + kod.ToString();
		}
	}
}
