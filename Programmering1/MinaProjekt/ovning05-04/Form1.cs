using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ovning05_04
{
	public partial class Övning : Form
	{
		public Övning()
		{
			InitializeComponent();
		}

		private void BtnRun_Click(object sender, EventArgs e)
		{
			int talA = int.Parse(tbxA.Text);
			int talB = int.Parse(tbxB.Text);
			int talC = int.Parse(tbxC.Text);
			bool isLined = talA < talB && talB < talC;

			lblSvar.Text = isLined ? "Talen är i stigande ordning." : "Talen är inte i stigande ordning.";

		}
	}
}
