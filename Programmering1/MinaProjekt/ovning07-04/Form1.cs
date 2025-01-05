using System;
using System.Windows.Forms;

namespace ovning07_04
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnPriset_Click(object sender, EventArgs e)
		{
			if (double.TryParse(TbxAntal.Text, out double antal))
			{
				double rabatt;
				if (antal >= 100)
				{
					rabatt = 0.85;
				}
				else if (antal >= 10)
				{
					rabatt = 0.9;
				}
				else
				{
					rabatt = 1.0;
				}
				double aPris = 9.9;
				double rabattPris = aPris * antal * rabatt;
				LblResult.Text = $"Kostnaden för {antal} låtar är {rabattPris} kronor";
			}
			else
			{
				LblResult.Text = "Felaktigt pris";
			}
		}
	}
}
