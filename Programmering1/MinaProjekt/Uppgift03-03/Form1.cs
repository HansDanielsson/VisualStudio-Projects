using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift03_03
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnRun_Click(object sender, EventArgs e)
		{
			double tal = double.Parse(tbxTal.Text) + 0.5;
			int omvTal = (int)tal;
			tbxAvrunda.Text = omvTal.ToString();
		}
	}
}
