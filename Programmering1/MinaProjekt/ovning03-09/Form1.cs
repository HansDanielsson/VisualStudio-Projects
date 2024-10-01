using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ovning03_09
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnMove_Click(object sender, EventArgs e)
		{
			btnMove.Location = new Point(int.Parse(tbxX.Text), int.Parse(tbxY.Text));
		}
	}
}
