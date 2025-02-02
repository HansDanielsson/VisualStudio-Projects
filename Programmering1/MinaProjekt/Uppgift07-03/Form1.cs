using System;
using System.Windows.Forms;

namespace Uppgift07_03
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnRun_Click(object sender, EventArgs e)
		{
			if (double.TryParse(TbxLength.Text, out double jumpLength))
			{
				if (double.TryParse(TbxWind.Text, out double windSpeed))
				{
					if (jumpLength > 7.92 && windSpeed < 2)
					{
						LblResult.Text = "Grattis, nytt rekord";
					}
					else
					{
						LblResult.Text = "Tyvärr, inget nytt rekord";
					}
				}
				else
				{
					LblResult.Text = "Vindstyrkan är inte ett giltigt tal.";
				}
			}
			else
			{
				LblResult.Text = "Längden är inte ett giltigt tal.";
			}
		}
	}
}
