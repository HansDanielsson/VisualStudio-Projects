namespace ovning05_04
{
	partial class Övning
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
			this.lblA = new System.Windows.Forms.Label();
			this.lblB = new System.Windows.Forms.Label();
			this.lblC = new System.Windows.Forms.Label();
			this.lblSvar = new System.Windows.Forms.Label();
			this.tbxA = new System.Windows.Forms.TextBox();
			this.tbxB = new System.Windows.Forms.TextBox();
			this.tbxC = new System.Windows.Forms.TextBox();
			this.BtnRun = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblA
			// 
			this.lblA.AutoSize = true;
			this.lblA.Location = new System.Drawing.Point(49, 40);
			this.lblA.Name = "lblA";
			this.lblA.Size = new System.Drawing.Size(49, 20);
			this.lblA.TabIndex = 0;
			this.lblA.Text = "Tal A";
			// 
			// lblB
			// 
			this.lblB.AutoSize = true;
			this.lblB.Location = new System.Drawing.Point(49, 85);
			this.lblB.Name = "lblB";
			this.lblB.Size = new System.Drawing.Size(39, 16);
			this.lblB.TabIndex = 1;
			this.lblB.Text = "Tal B";
			// 
			// lblC
			// 
			this.lblC.AutoSize = true;
			this.lblC.Location = new System.Drawing.Point(49, 130);
			this.lblC.Name = "lblC";
			this.lblC.Size = new System.Drawing.Size(39, 16);
			this.lblC.TabIndex = 2;
			this.lblC.Text = "Tal C";
			// 
			// lblSvar
			// 
			this.lblSvar.AutoSize = true;
			this.lblSvar.Location = new System.Drawing.Point(94, 200);
			this.lblSvar.Name = "lblSvar";
			this.lblSvar.Size = new System.Drawing.Size(146, 16);
			this.lblSvar.TabIndex = 3;
			this.lblSvar.Text = "Talen är i ordningsföljd:";
			// 
			// tbxA
			// 
			this.tbxA.Location = new System.Drawing.Point(177, 43);
			this.tbxA.Name = "tbxA";
			this.tbxA.Size = new System.Drawing.Size(100, 22);
			this.tbxA.TabIndex = 4;
			// 
			// tbxB
			// 
			this.tbxB.Location = new System.Drawing.Point(177, 79);
			this.tbxB.Name = "tbxB";
			this.tbxB.Size = new System.Drawing.Size(100, 22);
			this.tbxB.TabIndex = 5;
			// 
			// tbxC
			// 
			this.tbxC.Location = new System.Drawing.Point(177, 124);
			this.tbxC.Name = "tbxC";
			this.tbxC.Size = new System.Drawing.Size(100, 22);
			this.tbxC.TabIndex = 6;
			// 
			// BtnRun
			// 
			this.BtnRun.Location = new System.Drawing.Point(97, 258);
			this.BtnRun.Name = "BtnRun";
			this.BtnRun.Size = new System.Drawing.Size(75, 23);
			this.BtnRun.TabIndex = 7;
			this.BtnRun.Text = "Kör";
			this.BtnRun.UseVisualStyleBackColor = true;
			this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
			// 
			// Övning
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.BtnRun);
			this.Controls.Add(this.tbxC);
			this.Controls.Add(this.tbxB);
			this.Controls.Add(this.tbxA);
			this.Controls.Add(this.lblSvar);
			this.Controls.Add(this.lblC);
			this.Controls.Add(this.lblB);
			this.Controls.Add(this.lblA);
			this.Name = "Övning";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblA;
		private System.Windows.Forms.Label lblB;
		private System.Windows.Forms.Label lblC;
		private System.Windows.Forms.Label lblSvar;
		private System.Windows.Forms.TextBox tbxA;
		private System.Windows.Forms.TextBox tbxB;
		private System.Windows.Forms.TextBox tbxC;
		private System.Windows.Forms.Button BtnRun;
	}
}

