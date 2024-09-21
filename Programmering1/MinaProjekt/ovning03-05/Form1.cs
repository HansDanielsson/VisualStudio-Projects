using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ovning03_05
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnRun_Click(object sender, EventArgs e)
		{
			int born = int.Parse(tbxBorn.Text) + 50;
			lblInfo.Text = born.ToString() + " fyller " + tbxNamn.Text + " 50 år";
		}
	}
}
