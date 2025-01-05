using System;
using System.Windows.Forms;

namespace Exempel07_04
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnPorto_Click(object sender, EventArgs e)
		{
			double vikt = double.Parse(TbxVikt.Text);
			double porto;
			if (vikt <= 50)
			{
				porto = 15;
			}
			else if (vikt <= 100)
			{
				porto = 30;
			}
			else
			{
				porto = 60;
			}
			LblResultat.Text = "Ett brev som väger " + vikt + " gram kostar " + porto + " kronor";
		}

		private void TbxVikt_TextChanged(object sender, EventArgs e)
		{
			LblResultat.Text = "";
		}
	}
}
