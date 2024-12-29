using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ovning05_02
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnRun_Click(object sender, EventArgs e)
		{
			int a = int.Parse(tbxTal.Text);
			int b = a++;
			// int c = ++b + a;

			lblSvar.Text = a.ToString();
			lblSvar2.Text = b.ToString();
		}
	}
}
