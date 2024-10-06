using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift03_04b
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnRun_Click(object sender, EventArgs e)
		{
			int belopp = int.Parse(tbxBelopp.Text);
			int bel500 = (belopp / 500) * 500;
			belopp -= bel500;
			int bel100 = (belopp / 100) * 100;
			lbl500St.Text = bel500.ToString() + " kr.";
			lbl100St.Text = bel100.ToString() + " kr.";
		}
	}
}
