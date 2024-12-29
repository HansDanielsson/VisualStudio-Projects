namespace ovning05_02
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
			this.label1 = new System.Windows.Forms.Label();
			this.tbxTal = new System.Windows.Forms.TextBox();
			this.lblSvar = new System.Windows.Forms.Label();
			this.BtnRun = new System.Windows.Forms.Button();
			this.lblSvar2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(37, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Heltal:";
			// 
			// tbxTal
			// 
			this.tbxTal.Location = new System.Drawing.Point(154, 60);
			this.tbxTal.Name = "tbxTal";
			this.tbxTal.Size = new System.Drawing.Size(100, 22);
			this.tbxTal.TabIndex = 1;
			// 
			// lblSvar
			// 
			this.lblSvar.AutoSize = true;
			this.lblSvar.Location = new System.Drawing.Point(151, 129);
			this.lblSvar.Name = "lblSvar";
			this.lblSvar.Size = new System.Drawing.Size(35, 16);
			this.lblSvar.TabIndex = 2;
			this.lblSvar.Text = "Svar";
			// 
			// BtnRun
			// 
			this.BtnRun.Location = new System.Drawing.Point(154, 181);
			this.BtnRun.Name = "BtnRun";
			this.BtnRun.Size = new System.Drawing.Size(45, 23);
			this.BtnRun.TabIndex = 3;
			this.BtnRun.Text = "Kör";
			this.BtnRun.UseVisualStyleBackColor = true;
			this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
			// 
			// lblSvar2
			// 
			this.lblSvar2.AutoSize = true;
			this.lblSvar2.Location = new System.Drawing.Point(293, 129);
			this.lblSvar2.Name = "lblSvar2";
			this.lblSvar2.Size = new System.Drawing.Size(53, 20);
			this.lblSvar2.TabIndex = 4;
			this.lblSvar2.Text = "Svar2";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(437, 290);
			this.Controls.Add(this.lblSvar2);
			this.Controls.Add(this.BtnRun);
			this.Controls.Add(this.lblSvar);
			this.Controls.Add(this.tbxTal);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Övning";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbxTal;
		private System.Windows.Forms.Label lblSvar;
		private System.Windows.Forms.Button BtnRun;
		private System.Windows.Forms.Label lblSvar2;
	}
}

