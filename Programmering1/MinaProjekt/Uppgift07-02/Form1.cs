using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift07_02
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnRun_Click(object sender, EventArgs e)
		{
			if (double.TryParse(TbxSlag.Text, out double input))
			{
				if (input < 150 || input > 190)
				{
					LblResult.Text = "Grattis!";
				}
				else
				{
					LblResult.Text = "I plurret!";
				}
			}
			else
			{
				LblResult.Text = "Felaktig inmatning.";
			}
		}
	}
}
