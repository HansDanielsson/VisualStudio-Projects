using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ovning03_03
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnRun_Click(object sender, EventArgs e)
		{
			int talA = int.Parse(tbxA.Text);
			int talB = int.Parse(tbxB.Text);
			int talC = int.Parse(tbxC.Text);

			int summan = talA + talB + talC;
			double medelSumma = summan / 3.0;

			lblSumma.Text = "Summan: " + summan.ToString();
			lblMedel.Text = "Medelvärde: " + medelSumma.ToString();
		}
	}
}
