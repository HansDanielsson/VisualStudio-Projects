﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ovning03_08
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnRun_Click(object sender, EventArgs e)
		{
			int versal = (int)tbxVersal.Text[0] + 32;
			char te = (char)versal;
			lblSvar.Text = te.ToString();

			// lblSvar.Text = tbxVersal.Text.ToLower();
		}
	}
}
