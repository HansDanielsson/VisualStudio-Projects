using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ovning07_02
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnOk_Click(object sender, EventArgs e)
		{
			double personalYear = double.Parse(TbxYear.Text);
			if (personalYear >= 15 && personalYear <= 65)
			{
				LblResultAnd.Text = "Resan kostar 30 kronor";
			}
			else
			{
				LblResultAnd.Text = "Resan kostar 20 kronor";
			}
			if (personalYear < 15 || personalYear > 65)
			{
				LblResultOr.Text = "Resan kostar 20 kronor";
			}
			else
			{
				LblResultOr.Text = "Resan kostar 30 kronor";
			}
		}
	}
}
