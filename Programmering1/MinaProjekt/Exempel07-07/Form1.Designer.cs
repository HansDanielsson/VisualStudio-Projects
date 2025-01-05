namespace Exempel07_07
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.LblTal1 = new System.Windows.Forms.Label();
			this.LblTal2 = new System.Windows.Forms.Label();
			this.LblResultat = new System.Windows.Forms.Label();
			this.TbxTal1 = new System.Windows.Forms.TextBox();
			this.TbxTal2 = new System.Windows.Forms.TextBox();
			this.BtnBigNumber = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LblTal1
			// 
			this.LblTal1.AutoSize = true;
			this.LblTal1.Location = new System.Drawing.Point(42, 43);
			this.LblTal1.Name = "LblTal1";
			this.LblTal1.Size = new System.Drawing.Size(46, 20);
			this.LblTal1.TabIndex = 0;
			this.LblTal1.Text = "Tal1:";
			// 
			// LblTal2
			// 
			this.LblTal2.AutoSize = true;
			this.LblTal2.Location = new System.Drawing.Point(42, 114);
			this.LblTal2.Name = "LblTal2";
			this.LblTal2.Size = new System.Drawing.Size(37, 16);
			this.LblTal2.TabIndex = 1;
			this.LblTal2.Text = "Tal2:";
			// 
			// LblResultat
			// 
			this.LblResultat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.LblResultat.Location = new System.Drawing.Point(48, 194);
			this.LblResultat.Name = "LblResultat";
			this.LblResultat.Size = new System.Drawing.Size(189, 24);
			this.LblResultat.TabIndex = 2;
			this.LblResultat.Text = "label3";
			this.LblResultat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// TbxTal1
			// 
			this.TbxTal1.Location = new System.Drawing.Point(109, 40);
			this.TbxTal1.Name = "TbxTal1";
			this.TbxTal1.Size = new System.Drawing.Size(128, 22);
			this.TbxTal1.TabIndex = 3;
			// 
			// TbxTal2
			// 
			this.TbxTal2.Location = new System.Drawing.Point(109, 108);
			this.TbxTal2.Name = "TbxTal2";
			this.TbxTal2.Size = new System.Drawing.Size(128, 22);
			this.TbxTal2.TabIndex = 4;
			// 
			// BtnBigNumber
			// 
			this.BtnBigNumber.Location = new System.Drawing.Point(83, 244);
			this.BtnBigNumber.Name = "BtnBigNumber";
			this.BtnBigNumber.Size = new System.Drawing.Size(133, 49);
			this.BtnBigNumber.TabIndex = 5;
			this.BtnBigNumber.Text = "Hitta största talet";
			this.BtnBigNumber.UseVisualStyleBackColor = true;
			this.BtnBigNumber.Click += new System.EventHandler(this.BtnBigNumber_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 336);
			this.Controls.Add(this.BtnBigNumber);
			this.Controls.Add(this.TbxTal2);
			this.Controls.Add(this.TbxTal1);
			this.Controls.Add(this.LblResultat);
			this.Controls.Add(this.LblTal2);
			this.Controls.Add(this.LblTal1);
			this.Name = "Form1";
			this.Text = "Exempel 7.7";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LblTal1;
		private System.Windows.Forms.Label LblTal2;
		private System.Windows.Forms.Label LblResultat;
		private System.Windows.Forms.TextBox TbxTal1;
		private System.Windows.Forms.TextBox TbxTal2;
		private System.Windows.Forms.Button BtnBigNumber;
	}
}

