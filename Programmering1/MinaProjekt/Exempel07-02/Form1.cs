using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exempel07_02
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnOk_Click(object sender, EventArgs e)
		{
			double mankHojd = double.Parse(TbxHojd.Text);
			if (mankHojd > 28 && mankHojd < 35)
			{
				LblResultat.Text = "Det är en dvärgpudel";
			}
			else
			{
				LblResultat.Text = "Det är inte en dvärgpudel";
			}
		}

		private void TbxHojd_TextChanged(object sender, EventArgs e)
		{
			LblResultat.Text = "";
		}
	}
}
