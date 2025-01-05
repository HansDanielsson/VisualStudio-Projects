using System;
using System.Windows.Forms;

namespace Exempel07_07
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnBigNumber_Click(object sender, EventArgs e)
		{
			if (double.TryParse(TbxTal1.Text, out double number1))
			{
				if (double.TryParse(TbxTal2.Text, out double number2))
				{
					double biggestNumber = number1 > number2 ? number1 : number2;
					LblResultat.Text = "Det största talet är " + biggestNumber;
				}
				else
				{
					LblResultat.Text = "Felaktigt tal";
				}
			}
			else
			{
				LblResultat.Text = "Felaktigt tal";
			}
		}
	}
}
