namespace ovning07_03
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
			this.LblPrickar = new System.Windows.Forms.Label();
			this.TbxPrickar = new System.Windows.Forms.TextBox();
			this.BtnRun = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LblPrickar
			// 
			this.LblPrickar.AutoSize = true;
			this.LblPrickar.Location = new System.Drawing.Point(54, 75);
			this.LblPrickar.Name = "LblPrickar";
			this.LblPrickar.Size = new System.Drawing.Size(84, 16);
			this.LblPrickar.TabIndex = 0;
			this.LblPrickar.Text = "Antal prickar:";
			// 
			// TbxPrickar
			// 
			this.TbxPrickar.Location = new System.Drawing.Point(181, 72);
			this.TbxPrickar.Name = "TbxPrickar";
			this.TbxPrickar.Size = new System.Drawing.Size(51, 22);
			this.TbxPrickar.TabIndex = 1;
			// 
			// BtnRun
			// 
			this.BtnRun.Location = new System.Drawing.Point(100, 118);
			this.BtnRun.Name = "BtnRun";
			this.BtnRun.Size = new System.Drawing.Size(145, 39);
			this.BtnRun.TabIndex = 2;
			this.BtnRun.Text = "Kasta tärning";
			this.BtnRun.UseVisualStyleBackColor = true;
			this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(332, 251);
			this.Controls.Add(this.BtnRun);
			this.Controls.Add(this.TbxPrickar);
			this.Controls.Add(this.LblPrickar);
			this.Name = "Form1";
			this.Text = "Övning 7.3";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LblPrickar;
		private System.Windows.Forms.TextBox TbxPrickar;
		private System.Windows.Forms.Button BtnRun;
	}
}

