namespace ovning07_07
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
			this.LblResult = new System.Windows.Forms.Label();
			this.TbxTal1 = new System.Windows.Forms.TextBox();
			this.TbxTal2 = new System.Windows.Forms.TextBox();
			this.BtnResult = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LblTal1
			// 
			this.LblTal1.AutoSize = true;
			this.LblTal1.Location = new System.Drawing.Point(45, 38);
			this.LblTal1.Name = "LblTal1";
			this.LblTal1.Size = new System.Drawing.Size(50, 20);
			this.LblTal1.TabIndex = 0;
			this.LblTal1.Text = "Tal 1:";
			// 
			// LblTal2
			// 
			this.LblTal2.AutoSize = true;
			this.LblTal2.Location = new System.Drawing.Point(45, 70);
			this.LblTal2.Name = "LblTal2";
			this.LblTal2.Size = new System.Drawing.Size(40, 16);
			this.LblTal2.TabIndex = 1;
			this.LblTal2.Text = "Tal 2:";
			// 
			// LblResult
			// 
			this.LblResult.AutoSize = true;
			this.LblResult.Location = new System.Drawing.Point(62, 115);
			this.LblResult.Name = "LblResult";
			this.LblResult.Size = new System.Drawing.Size(133, 16);
			this.LblResult.TabIndex = 2;
			this.LblResult.Text = "Det minsta talet är 4.9";
			// 
			// TbxTal1
			// 
			this.TbxTal1.Location = new System.Drawing.Point(115, 35);
			this.TbxTal1.Name = "TbxTal1";
			this.TbxTal1.Size = new System.Drawing.Size(100, 22);
			this.TbxTal1.TabIndex = 3;
			// 
			// TbxTal2
			// 
			this.TbxTal2.Location = new System.Drawing.Point(115, 67);
			this.TbxTal2.Name = "TbxTal2";
			this.TbxTal2.Size = new System.Drawing.Size(100, 22);
			this.TbxTal2.TabIndex = 4;
			// 
			// BtnResult
			// 
			this.BtnResult.Location = new System.Drawing.Point(65, 159);
			this.BtnResult.Name = "BtnResult";
			this.BtnResult.Size = new System.Drawing.Size(140, 23);
			this.BtnResult.TabIndex = 5;
			this.BtnResult.Text = "Hitta minsta talet";
			this.BtnResult.UseVisualStyleBackColor = true;
			this.BtnResult.Click += new System.EventHandler(this.BtnResult_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(361, 262);
			this.Controls.Add(this.BtnResult);
			this.Controls.Add(this.TbxTal2);
			this.Controls.Add(this.TbxTal1);
			this.Controls.Add(this.LblResult);
			this.Controls.Add(this.LblTal2);
			this.Controls.Add(this.LblTal1);
			this.Name = "Form1";
			this.Text = "Övning 7.7";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LblTal1;
		private System.Windows.Forms.Label LblTal2;
		private System.Windows.Forms.Label LblResult;
		private System.Windows.Forms.TextBox TbxTal1;
		private System.Windows.Forms.TextBox TbxTal2;
		private System.Windows.Forms.Button BtnResult;
	}
}

