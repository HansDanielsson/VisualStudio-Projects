using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exempel07_03
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnOk_Click(object sender, EventArgs e)
		{
			double pengar = double.Parse(TbxPengar.Text);
			double kostnad = double.Parse(TbxKostnad.Text);
			int uttag = 0;
			string meddelande = "";
			if (pengar < kostnad)
			{
				double diff = kostnad - pengar;
				int hundratal = (int) (diff / 100);
				uttag = (hundratal + 1) * 100;
				meddelande = "Ta ut " + uttag + " kronor. ";
			}
			double pengarKvar = pengar + uttag - kostnad;
			meddelande += "Efter köpet återstår " + pengarKvar + " kronor.";
			LblResultat.Text = meddelande;
		}

		private void TbxPengar_TextChanged(object sender, EventArgs e)
		{
			LblResultat.Text = "";
		}

		private void TbxKostnad_TextChanged(object sender, EventArgs e)
		{
			LblResultat.Text = "";
		}
	}
}
