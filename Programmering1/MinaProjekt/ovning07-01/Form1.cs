using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ovning07_01
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnOk_Click(object sender, EventArgs e)
		{
			if (double.TryParse(TbxLiter.Text, out double literKvar))
			{
				if (literKvar < 10)
				{
					double priset = 14.50;
					double maxLiter = 50;
					double attTanka = maxLiter - literKvar;
					double attBetala = attTanka * priset;
					LblResult.Text = $"Tanka {attTanka} liter. Det kostar {attBetala} kr.";
				}
				else
				{
					LblResult.Text = "Kör vidare.";
				}
			}
			else
			{
				LblResult.Text = "Fel inmatning.";
			}
		}
	}
}
