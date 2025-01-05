using System;
using System.Windows.Forms;

namespace Exempel07_05
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnHyreskostnad_Click(object sender, EventArgs e)
		{
			if (int.TryParse(TbxAntalPersoner.Text, out int antal))
			{
				switch (antal)
				{
					case 1:
						LblResultat.Text = "Det kostar 70 kr";
						break;
					case 2:
						LblResultat.Text = "Det kostar 120 kr";
						break;
					case 3:
						LblResultat.Text = "Det kostar 150 kr";
						break;
					default:
						LblResultat.Text = "Fel antal personer";
						break;
				}
			}
			else
			{
				MessageBox.Show("Antal måste vara ett heltal mellan 1 och 3");
			}
		}

		private void TbxAntalPersoner_TextChanged(object sender, EventArgs e)
		{
			LblResultat.Text = "";
		}
	}
}
