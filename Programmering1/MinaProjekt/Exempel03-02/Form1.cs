using System;
using System.Windows.Forms;

namespace Exempel03_02
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnVisaInitial_Click(object sender, EventArgs e)
		{
			string namn = tbxNamn.Text;
			char initial = namn[0];
			string svar = namn + " har initialen " + initial.ToString();
			lblSvar.Text = svar;
		}
	}
}
