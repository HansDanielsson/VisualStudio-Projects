﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ovning03_02
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnRun_Click(object sender, EventArgs e)
		{
			int tal1 = int.Parse(tbxTal1.Text);
			int tal2 = int.Parse(tbxTal2.Text);

			int summa = tal1 + tal2;
			string strSumma = summa.ToString();
			lblSumma.Text = strSumma;
		}
	}
}
