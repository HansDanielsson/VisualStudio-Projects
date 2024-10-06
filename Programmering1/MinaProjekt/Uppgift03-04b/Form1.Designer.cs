namespace Uppgift03_04b
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
			this.tbxBelopp = new System.Windows.Forms.TextBox();
			this.lbl500Ut = new System.Windows.Forms.Label();
			this.lbl100Ut = new System.Windows.Forms.Label();
			this.lbl500St = new System.Windows.Forms.Label();
			this.lbl100St = new System.Windows.Forms.Label();
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
			// tbxBelopp
			// 
			this.tbxBelopp.Location = new System.Drawing.Point(75, 6);
			this.tbxBelopp.Name = "tbxBelopp";
			this.tbxBelopp.Size = new System.Drawing.Size(100, 20);
			this.tbxBelopp.TabIndex = 1;
			// 
			// lbl500Ut
			// 
			this.lbl500Ut.AutoSize = true;
			this.lbl500Ut.Location = new System.Drawing.Point(13, 56);
			this.lbl500Ut.Name = "lbl500Ut";
			this.lbl500Ut.Size = new System.Drawing.Size(93, 13);
			this.lbl500Ut.TabIndex = 2;
			this.lbl500Ut.Text = "Uttag i 500-sedlar:";
			// 
			// lbl100Ut
			// 
			this.lbl100Ut.AutoSize = true;
			this.lbl100Ut.Location = new System.Drawing.Point(13, 99);
			this.lbl100Ut.Name = "lbl100Ut";
			this.lbl100Ut.Size = new System.Drawing.Size(93, 13);
			this.lbl100Ut.TabIndex = 3;
			this.lbl100Ut.Text = "Uttag i 100-sedlar:";
			// 
			// lbl500St
			// 
			this.lbl500St.AutoSize = true;
			this.lbl500St.Location = new System.Drawing.Point(144, 56);
			this.lbl500St.Name = "lbl500St";
			this.lbl500St.Size = new System.Drawing.Size(19, 13);
			this.lbl500St.TabIndex = 4;
			this.lbl500St.Text = "kr.";
			// 
			// lbl100St
			// 
			this.lbl100St.AutoSize = true;
			this.lbl100St.Location = new System.Drawing.Point(147, 99);
			this.lbl100St.Name = "lbl100St";
			this.lbl100St.Size = new System.Drawing.Size(19, 13);
			this.lbl100St.TabIndex = 5;
			this.lbl100St.Text = "kr.";
			// 
			// BtnRun
			// 
			this.BtnRun.Location = new System.Drawing.Point(75, 139);
			this.BtnRun.Name = "BtnRun";
			this.BtnRun.Size = new System.Drawing.Size(100, 23);
			this.BtnRun.TabIndex = 6;
			this.BtnRun.Text = "Ta ut beloppet";
			this.BtnRun.UseVisualStyleBackColor = true;
			this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(307, 181);
			this.Controls.Add(this.BtnRun);
			this.Controls.Add(this.lbl100St);
			this.Controls.Add(this.lbl500St);
			this.Controls.Add(this.lbl100Ut);
			this.Controls.Add(this.lbl500Ut);
			this.Controls.Add(this.tbxBelopp);
			this.Controls.Add(this.lblBelopp);
			this.Name = "Form1";
			this.Text = "Uppgift 3.4b";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblBelopp;
		private System.Windows.Forms.TextBox tbxBelopp;
		private System.Windows.Forms.Label lbl500Ut;
		private System.Windows.Forms.Label lbl100Ut;
		private System.Windows.Forms.Label lbl500St;
		private System.Windows.Forms.Label lbl100St;
		private System.Windows.Forms.Button BtnRun;
	}
}

