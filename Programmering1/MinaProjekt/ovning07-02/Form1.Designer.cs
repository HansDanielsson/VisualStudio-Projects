namespace ovning07_02
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
			this.LblYear = new System.Windows.Forms.Label();
			this.TbxYear = new System.Windows.Forms.TextBox();
			this.LblResultAnd = new System.Windows.Forms.Label();
			this.LblResultOr = new System.Windows.Forms.Label();
			this.BtnOk = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LblYear
			// 
			this.LblYear.AutoSize = true;
			this.LblYear.Location = new System.Drawing.Point(48, 44);
			this.LblYear.Name = "LblYear";
			this.LblYear.Size = new System.Drawing.Size(53, 20);
			this.LblYear.TabIndex = 0;
			this.LblYear.Text = "Ålder:";
			// 
			// TbxYear
			// 
			this.TbxYear.Location = new System.Drawing.Point(95, 41);
			this.TbxYear.Name = "TbxYear";
			this.TbxYear.Size = new System.Drawing.Size(118, 22);
			this.TbxYear.TabIndex = 1;
			// 
			// LblResultAnd
			// 
			this.LblResultAnd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.LblResultAnd.Location = new System.Drawing.Point(51, 84);
			this.LblResultAnd.Name = "LblResultAnd";
			this.LblResultAnd.Size = new System.Drawing.Size(162, 33);
			this.LblResultAnd.TabIndex = 2;
			this.LblResultAnd.Text = "Resan kostar 30 kronor";
			this.LblResultAnd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LblResultOr
			// 
			this.LblResultOr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.LblResultOr.Location = new System.Drawing.Point(51, 154);
			this.LblResultOr.Name = "LblResultOr";
			this.LblResultOr.Size = new System.Drawing.Size(162, 33);
			this.LblResultOr.TabIndex = 3;
			this.LblResultOr.Text = "Resan kostar 30 kronor";
			this.LblResultOr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// BtnOk
			// 
			this.BtnOk.Location = new System.Drawing.Point(95, 225);
			this.BtnOk.Name = "BtnOk";
			this.BtnOk.Size = new System.Drawing.Size(75, 23);
			this.BtnOk.TabIndex = 4;
			this.BtnOk.Text = "OK";
			this.BtnOk.UseVisualStyleBackColor = true;
			this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(257, 298);
			this.Controls.Add(this.BtnOk);
			this.Controls.Add(this.LblResultOr);
			this.Controls.Add(this.LblResultAnd);
			this.Controls.Add(this.TbxYear);
			this.Controls.Add(this.LblYear);
			this.Name = "Form1";
			this.Text = "Övning 7.2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LblYear;
		private System.Windows.Forms.TextBox TbxYear;
		private System.Windows.Forms.Label LblResultAnd;
		private System.Windows.Forms.Label LblResultOr;
		private System.Windows.Forms.Button BtnOk;
	}
}

