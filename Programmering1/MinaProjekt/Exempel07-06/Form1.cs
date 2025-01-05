using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exempel07_06
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnKontrollera_Click(object sender, EventArgs e)
		{
			string namn = TbxNamn.Text;
			string password = TbxPassword.Text;
			if (namn.Equals("Mia") && password.Equals("Hemligt"))
			{
				LblResultat.Text = "Hej Mia";
			}
			else
			{
				LblResultat.Text = "Felaktigt användarnamn eller lösenord!";
			}
		}

		private void TbxNamn_TextChanged(object sender, EventArgs e)
		{
			LblResultat.Text = "";
		}

		private void TbxPassword_TextChanged(object sender, EventArgs e)
		{
			LblResultat.Text = "";
		}
	}
}
