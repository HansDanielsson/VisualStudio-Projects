using System;
using System.Windows.Forms;

namespace Uppgift05_02
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnRun_Click(object sender, EventArgs e)
		{
			double talA = Math.Round(double.Parse(tbxTal.Text) / 1000.0) * 1000.0;
			lblSvar.Text = talA.ToString();
		}
	}
}
