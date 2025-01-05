using System;
using System.Windows.Forms;

namespace ovning07_05
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnVeckodag_Click(object sender, EventArgs e)
		{
			if (int.TryParse(TbxVeckodag.Text, out int veckoNr))
			{
				switch (veckoNr)
				{
					case 1:
						LblResult.Text = "Måndag";
						break;
					case 2:
						LblResult.Text = "Tisdag";
						break;
					case 3:
						LblResult.Text = "Onsdag";
						break;
					case 4:
						LblResult.Text = "Torsdag";
						break;
					case 5:
						LblResult.Text = "Fredag";
						break;
					case 6:
						LblResult.Text = "Lördag";
						break;
					case 7:
						LblResult.Text = "Söndag";
						break;
					default:
						LblResult.Text = "Det är inte en veckodag";
						break;
				}
			}
			else
			{
				MessageBox.Show("Det är inte en veckodag");
			}
		}
	}
}
