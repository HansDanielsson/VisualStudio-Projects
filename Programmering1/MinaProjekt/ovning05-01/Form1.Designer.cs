namespace ovning05_01
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
			this.lblTid = new System.Windows.Forms.Label();
			this.tbxTid = new System.Windows.Forms.TextBox();
			this.lblSvar = new System.Windows.Forms.Label();
			this.BtnRun = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblTid
			// 
			this.lblTid.AutoSize = true;
			this.lblTid.Location = new System.Drawing.Point(97, 69);
			this.lblTid.Name = "lblTid";
			this.lblTid.Size = new System.Drawing.Size(90, 16);
			this.lblTid.TabIndex = 0;
			this.lblTid.Text = "Tid i månader";
			// 
			// tbxTid
			// 
			this.tbxTid.Location = new System.Drawing.Point(215, 62);
			this.tbxTid.Name = "tbxTid";
			this.tbxTid.Size = new System.Drawing.Size(100, 22);
			this.tbxTid.TabIndex = 1;
			// 
			// lblSvar
			// 
			this.lblSvar.AutoSize = true;
			this.lblSvar.Location = new System.Drawing.Point(212, 121);
			this.lblSvar.Name = "lblSvar";
			this.lblSvar.Size = new System.Drawing.Size(52, 16);
			this.lblSvar.TabIndex = 2;
			this.lblSvar.Text = "Antal år";
			// 
			// BtnRun
			// 
			this.BtnRun.Location = new System.Drawing.Point(215, 172);
			this.BtnRun.Name = "BtnRun";
			this.BtnRun.Size = new System.Drawing.Size(75, 23);
			this.BtnRun.TabIndex = 3;
			this.BtnRun.Text = "Kör";
			this.BtnRun.UseVisualStyleBackColor = true;
			this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(668, 245);
			this.Controls.Add(this.BtnRun);
			this.Controls.Add(this.lblSvar);
			this.Controls.Add(this.tbxTid);
			this.Controls.Add(this.lblTid);
			this.Name = "Form1";
			this.Text = "Övning";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTid;
		private System.Windows.Forms.TextBox tbxTid;
		private System.Windows.Forms.Label lblSvar;
		private System.Windows.Forms.Button BtnRun;
	}
}

