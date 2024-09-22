namespace ovning03_08
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
			this.lblVersal = new System.Windows.Forms.Label();
			this.lblSvar = new System.Windows.Forms.Label();
			this.tbxVersal = new System.Windows.Forms.TextBox();
			this.btnRun = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblVersal
			// 
			this.lblVersal.AutoSize = true;
			this.lblVersal.Location = new System.Drawing.Point(38, 39);
			this.lblVersal.Name = "lblVersal";
			this.lblVersal.Size = new System.Drawing.Size(73, 13);
			this.lblVersal.TabIndex = 0;
			this.lblVersal.Text = "Stora bokstav";
			// 
			// lblSvar
			// 
			this.lblSvar.AutoSize = true;
			this.lblSvar.Location = new System.Drawing.Point(142, 159);
			this.lblSvar.Name = "lblSvar";
			this.lblSvar.Size = new System.Drawing.Size(35, 13);
			this.lblSvar.TabIndex = 1;
			this.lblSvar.Text = "label2";
			// 
			// tbxVersal
			// 
			this.tbxVersal.Location = new System.Drawing.Point(126, 31);
			this.tbxVersal.Name = "tbxVersal";
			this.tbxVersal.Size = new System.Drawing.Size(100, 20);
			this.tbxVersal.TabIndex = 2;
			// 
			// btnRun
			// 
			this.btnRun.Location = new System.Drawing.Point(145, 212);
			this.btnRun.Name = "btnRun";
			this.btnRun.Size = new System.Drawing.Size(75, 23);
			this.btnRun.TabIndex = 3;
			this.btnRun.Text = "Kör";
			this.btnRun.UseVisualStyleBackColor = true;
			this.btnRun.Click += new System.EventHandler(this.BtnRun_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(440, 278);
			this.Controls.Add(this.btnRun);
			this.Controls.Add(this.tbxVersal);
			this.Controls.Add(this.lblSvar);
			this.Controls.Add(this.lblVersal);
			this.Name = "Form1";
			this.Text = "Övning";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblVersal;
		private System.Windows.Forms.Label lblSvar;
		private System.Windows.Forms.TextBox tbxVersal;
		private System.Windows.Forms.Button btnRun;
	}
}

