using System;
using System.Windows.Forms;

namespace ovning07_06
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnJmf_Click(object sender, EventArgs e)
		{
			string namn1 = TbxNamn1.Text;
			string namn2 = TbxNamn2.Text;
			int resultat = namn1.CompareTo(namn2);
			if (resultat < 0)
			{
				LblResult.Text = namn1 + " " + namn2;
			}
			else if (resultat > 0)
			{
				LblResult.Text = namn2 + " " + namn1;
			}
			else
			{
				LblResult.Text = "Namnen är lika";
			}
		}
	}
}
