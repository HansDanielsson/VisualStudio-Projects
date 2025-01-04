using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ovning06_01
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnRun_Click(object sender, EventArgs e)
		{
			int tal1 = int.Parse(TbxTal1.Text);
			int tal2 = int.Parse(TbxTal2.Text);
			int tal3 = int.Parse(TbxTal3.Text);
			int sum = (tal1 * 2) + (tal2 * 3) + (tal3 * 4);
			TbxSvaret.Text = sum.ToString();
		}
	}
}
