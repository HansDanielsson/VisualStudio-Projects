using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift07_01
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnRun_Click(object sender, EventArgs e)
		{
			if (double.TryParse(TbxTal.Text, out double input))
			{
				if (input < 0)
				{
					LblResult.Text = "Talet är negativt.";
				}
				else if (input > 0)
				{
					LblResult.Text = "Talet är positivt.";
				}
				else
				{
					LblResult.Text = "Talet är noll.";
				}
			}
			else
			{
				MessageBox.Show("Felaktig inmatning.");
			}
		}
	}
}
