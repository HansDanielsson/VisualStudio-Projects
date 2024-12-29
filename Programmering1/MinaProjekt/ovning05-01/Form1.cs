using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ovning05_01
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnRun_Click(object sender, EventArgs e)
		{
			int allMonths = int.Parse(tbxTid.Text);
			int years = allMonths / 12;
			int months = allMonths % 12;
			lblSvar.Text = $"Det är {years} år och {months} månader.";
		}
	}
}
