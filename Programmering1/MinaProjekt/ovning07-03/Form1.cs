using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ovning07_03
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnRun_Click(object sender, EventArgs e)
		{
			Random random = new Random();
			int resultat = random.Next(1, 7);
			TbxPrickar.Text = resultat.ToString();
			if (resultat == 6)
			{
				MessageBox.Show("Grattis!", "Meddelande", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}
