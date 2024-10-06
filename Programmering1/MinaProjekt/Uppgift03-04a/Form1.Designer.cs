namespace Uppgift03_04a
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
			this.lblBelopp = new System.Windows.Forms.Label();
			this.lblUttag = new System.Windows.Forms.Label();
			this.tbxBelopp = new System.Windows.Forms.TextBox();
			this.tbxUttag = new System.Windows.Forms.TextBox();
			this.BtnRun = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblBelopp
			// 
			this.lblBelopp.AutoSize = true;
			this.lblBelopp.Location = new System.Drawing.Point(13, 13);
			this.lblBelopp.Name = "lblBelopp";
			this.lblBelopp.Size = new System.Drawing.Size(43, 13);
			this.lblBelopp.TabIndex = 0;
			this.lblBelopp.Text = "Belopp:";
			// 
			// lblUttag
			// 
			this.lblUttag.AutoSize = true;
			this.lblUttag.Location = new System.Drawing.Point(16, 63);
			this.lblUttag.Name = "lblUttag";
			this.lblUttag.Size = new System.Drawing.Size(36, 13);
			this.lblUttag.TabIndex = 1;
			this.lblUttag.Text = "Uttag:";
			// 
			// tbxBelopp
			// 
			this.tbxBelopp.Location = new System.Drawing.Point(74, 5);
			this.tbxBelopp.Name = "tbxBelopp";
			this.tbxBelopp.Size = new System.Drawing.Size(100, 20);
			this.tbxBelopp.TabIndex = 2;
			// 
			// tbxUttag
			// 
			this.tbxUttag.Location = new System.Drawing.Point(74, 55);
			this.tbxUttag.Name = "tbxUttag";
			this.tbxUttag.Size = new System.Drawing.Size(100, 20);
			this.tbxUttag.TabIndex = 3;
			// 
			// BtnRun
			// 
			this.BtnRun.Location = new System.Drawing.Point(74, 120);
			this.BtnRun.Name = "BtnRun";
			this.BtnRun.Size = new System.Drawing.Size(127, 23);
			this.BtnRun.TabIndex = 4;
			this.BtnRun.Text = "Ta ut beloppet";
			this.BtnRun.UseVisualStyleBackColor = true;
			this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(330, 195);
			this.Controls.Add(this.BtnRun);
			this.Controls.Add(this.tbxUttag);
			this.Controls.Add(this.tbxBelopp);
			this.Controls.Add(this.lblUttag);
			this.Controls.Add(this.lblBelopp);
			this.Name = "Form1";
			this.Text = "Uppgift 3.4a";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblBelopp;
		private System.Windows.Forms.Label lblUttag;
		private System.Windows.Forms.TextBox tbxBelopp;
		private System.Windows.Forms.TextBox tbxUttag;
		private System.Windows.Forms.Button BtnRun;
	}
}

