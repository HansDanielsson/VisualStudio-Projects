namespace ovning05_03
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
			this.lblPengar = new System.Windows.Forms.Label();
			this.tbxPengar = new System.Windows.Forms.TextBox();
			this.lblPris = new System.Windows.Forms.Label();
			this.tbxPris = new System.Windows.Forms.TextBox();
			this.lblSvar = new System.Windows.Forms.Label();
			this.BtnRun = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblPengar
			// 
			this.lblPengar.AutoSize = true;
			this.lblPengar.Location = new System.Drawing.Point(58, 70);
			this.lblPengar.Name = "lblPengar";
			this.lblPengar.Size = new System.Drawing.Size(103, 20);
			this.lblPengar.TabIndex = 0;
			this.lblPengar.Text = "Mina pengar";
			// 
			// tbxPengar
			// 
			this.tbxPengar.Location = new System.Drawing.Point(253, 67);
			this.tbxPengar.Name = "tbxPengar";
			this.tbxPengar.Size = new System.Drawing.Size(100, 22);
			this.tbxPengar.TabIndex = 1;
			// 
			// lblPris
			// 
			this.lblPris.AutoSize = true;
			this.lblPris.Location = new System.Drawing.Point(58, 119);
			this.lblPris.Name = "lblPris";
			this.lblPris.Size = new System.Drawing.Size(75, 16);
			this.lblPris.TabIndex = 2;
			this.lblPris.Text = "Varans pris";
			// 
			// tbxPris
			// 
			this.tbxPris.Location = new System.Drawing.Point(253, 113);
			this.tbxPris.Name = "tbxPris";
			this.tbxPris.Size = new System.Drawing.Size(100, 22);
			this.tbxPris.TabIndex = 3;
			// 
			// lblSvar
			// 
			this.lblSvar.AutoSize = true;
			this.lblSvar.Location = new System.Drawing.Point(140, 208);
			this.lblSvar.Name = "lblSvar";
			this.lblSvar.Size = new System.Drawing.Size(98, 20);
			this.lblSvar.TabIndex = 4;
			this.lblSvar.Text = "Jag har råd:";
			// 
			// BtnRun
			// 
			this.BtnRun.Location = new System.Drawing.Point(138, 285);
			this.BtnRun.Name = "BtnRun";
			this.BtnRun.Size = new System.Drawing.Size(75, 23);
			this.BtnRun.TabIndex = 5;
			this.BtnRun.Text = "Kör";
			this.BtnRun.UseVisualStyleBackColor = true;
			this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(438, 410);
			this.Controls.Add(this.BtnRun);
			this.Controls.Add(this.lblSvar);
			this.Controls.Add(this.tbxPris);
			this.Controls.Add(this.lblPris);
			this.Controls.Add(this.tbxPengar);
			this.Controls.Add(this.lblPengar);
			this.Name = "Form1";
			this.Text = "Övning";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblPengar;
		private System.Windows.Forms.TextBox tbxPengar;
		private System.Windows.Forms.Label lblPris;
		private System.Windows.Forms.TextBox tbxPris;
		private System.Windows.Forms.Label lblSvar;
		private System.Windows.Forms.Button BtnRun;
	}
}

