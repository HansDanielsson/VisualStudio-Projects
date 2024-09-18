using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ovning02_02
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnMeddelande_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Är det roligt att programmera?","Övning", MessageBoxButtons.YesNo ,MessageBoxIcon.Question );
		}
	}
}
