using System;
using System.Windows.Forms;

namespace ovning03_06
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnRun_Click(object sender, EventArgs e)
		{
			char FirstChar = tbxFirstName.Text[0];
			char LastChar = tbxLastName.Text[0];
			lblSvar.Text = tbxFirstName.Text + " " + tbxLastName.Text + " har initialerna " + FirstChar.ToString() + "." + LastChar.ToString() + ".";
		}
	}
}
