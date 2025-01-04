using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exempel07_01
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void TbxTal_TextChanged(object sender, EventArgs e)
		{
			LblResultat.Text = "";
		}

		private void BtnOk_Click(object sender, EventArgs e)
		{
			string t = TbxTal.Text;
			double tal = double.Parse(t);
			if (tal > 0)
			{
				LblResultat.Text = "Ja";
			}
			else
			{
				LblResultat.Text = "Nej";
			}
		}
	}
}
