﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift02_01
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnRed_Click(object sender, EventArgs e)
		{
			BackColor = Color.Red;
		}

		private void BtnBlue_Click(object sender, EventArgs e)
		{
			BackColor = Color.Blue;
		}
	}
}
