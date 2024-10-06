using System;
using System.Windows.Forms;

namespace Uppgift03_04a
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnRun_Click(object sender, EventArgs e)
		{
			int belopp = int.Parse(tbxBelopp.Text);
			belopp = (belopp/100)*100;
			tbxUttag.Text = belopp.ToString() + " kr";
		}
	}
}
