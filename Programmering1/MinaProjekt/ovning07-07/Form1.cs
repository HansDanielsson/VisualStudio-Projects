using System;
using System.Windows.Forms;

namespace ovning07_07
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnResult_Click(object sender, EventArgs e)
		{
			if (double.TryParse(TbxTal1.Text, out double input1))
			{
				if (double.TryParse(TbxTal2.Text, out double input2))
				{
					double result = input1 < input2 ? input1 : input2;
					LblResult.Text = "Det minsta talet är: " + result;
				}
				else
				{
					LblResult.Text = "Felaktig inmatning";
				}
			}
			else
			{
				LblResult.Text = "Felaktig inmatning";
			}
		}
	}
}
