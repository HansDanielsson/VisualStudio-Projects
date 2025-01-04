namespace Uppgift05_02
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
			this.BtnRun = new System.Windows.Forms.Button();
			this.lblTal = new System.Windows.Forms.Label();
			this.tbxTal = new System.Windows.Forms.TextBox();
			this.lblSvar = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// BtnRun
			// 
			this.BtnRun.Location = new System.Drawing.Point(105, 257);
			this.BtnRun.Name = "BtnRun";
			this.BtnRun.Size = new System.Drawing.Size(75, 23);
			this.BtnRun.TabIndex = 0;
			this.BtnRun.Text = "Avrunda";
			this.BtnRun.UseVisualStyleBackColor = true;
			this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
			// 
			// lblTal
			// 
			this.lblTal.AutoSize = true;
			this.lblTal.Location = new System.Drawing.Point(28, 65);
			this.lblTal.Name = "lblTal";
			this.lblTal.Size = new System.Drawing.Size(164, 20);
			this.lblTal.TabIndex = 1;
			this.lblTal.Text = "Ange hela tusentalet:";
			// 
			// tbxTal
			// 
			this.tbxTal.Location = new System.Drawing.Point(198, 62);
			this.tbxTal.Name = "tbxTal";
			this.tbxTal.Size = new System.Drawing.Size(100, 22);
			this.tbxTal.TabIndex = 2;
			// 
			// lblSvar
			// 
			this.lblSvar.AutoSize = true;
			this.lblSvar.Location = new System.Drawing.Point(102, 191);
			this.lblSvar.Name = "lblSvar";
			this.lblSvar.Size = new System.Drawing.Size(44, 16);
			this.lblSvar.TabIndex = 3;
			this.lblSvar.Text = "label2";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(486, 355);
			this.Controls.Add(this.lblSvar);
			this.Controls.Add(this.tbxTal);
			this.Controls.Add(this.lblTal);
			this.Controls.Add(this.BtnRun);
			this.Name = "Form1";
			this.Text = "Uppgift 5.2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnRun;
		private System.Windows.Forms.Label lblTal;
		private System.Windows.Forms.TextBox tbxTal;
		private System.Windows.Forms.Label lblSvar;
	}
}

