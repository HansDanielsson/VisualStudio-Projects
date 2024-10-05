using System;
using System.Windows.Forms;

namespace Uppgift03_01
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnCalculate_Click(object sender, EventArgs e)
		{
			float baseTr = float.Parse(tbxBase.Text);
			float heightTr = float.Parse(tbxHeight.Text);
			float area = baseTr * heightTr / 2.0f;
			tbxArea.Text = area.ToString();
		}
	}
}
