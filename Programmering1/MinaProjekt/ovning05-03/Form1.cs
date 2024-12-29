using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ovning05_03
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnRun_Click(object sender, EventArgs e)
		{
			double minaPengar = double.Parse(tbxPengar.Text);
			double varansPris = double.Parse(tbxPris.Text);
			bool jagHarRad = minaPengar >= varansPris;

			string info = jagHarRad ? "Du har råd" : "Du har inte råd";

			lblSvar.Text = info;
		}
	}
}
