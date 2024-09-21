namespace ovning03_05
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
			this.lblNamn = new System.Windows.Forms.Label();
			this.lblBorn = new System.Windows.Forms.Label();
			this.tbxNamn = new System.Windows.Forms.TextBox();
			this.tbxBorn = new System.Windows.Forms.TextBox();
			this.lblInfo = new System.Windows.Forms.Label();
			this.btnRun = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblNamn
			// 
			this.lblNamn.AutoSize = true;
			this.lblNamn.Location = new System.Drawing.Point(26, 26);
			this.lblNamn.Name = "lblNamn";
			this.lblNamn.Size = new System.Drawing.Size(35, 13);
			this.lblNamn.TabIndex = 0;
			this.lblNamn.Text = "Namn";
			// 
			// lblBorn
			// 
			this.lblBorn.AutoSize = true;
			this.lblBorn.Location = new System.Drawing.Point(29, 64);
			this.lblBorn.Name = "lblBorn";
			this.lblBorn.Size = new System.Drawing.Size(53, 13);
			this.lblBorn.TabIndex = 1;
			this.lblBorn.Text = "Födelseår";
			// 
			// tbxNamn
			// 
			this.tbxNamn.Location = new System.Drawing.Point(103, 18);
			this.tbxNamn.Name = "tbxNamn";
			this.tbxNamn.Size = new System.Drawing.Size(100, 20);
			this.tbxNamn.TabIndex = 2;
			// 
			// tbxBorn
			// 
			this.tbxBorn.Location = new System.Drawing.Point(103, 56);
			this.tbxBorn.Name = "tbxBorn";
			this.tbxBorn.Size = new System.Drawing.Size(100, 20);
			this.tbxBorn.TabIndex = 3;
			// 
			// lblInfo
			// 
			this.lblInfo.AutoSize = true;
			this.lblInfo.Location = new System.Drawing.Point(61, 115);
			this.lblInfo.Name = "lblInfo";
			this.lblInfo.Size = new System.Drawing.Size(25, 13);
			this.lblInfo.TabIndex = 4;
			this.lblInfo.Text = "Info";
			// 
			// btnRun
			// 
			this.btnRun.Location = new System.Drawing.Point(103, 177);
			this.btnRun.Name = "btnRun";
			this.btnRun.Size = new System.Drawing.Size(75, 23);
			this.btnRun.TabIndex = 5;
			this.btnRun.Text = "Kör";
			this.btnRun.UseVisualStyleBackColor = true;
			this.btnRun.Click += new System.EventHandler(this.BtnRun_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(364, 292);
			this.Controls.Add(this.btnRun);
			this.Controls.Add(this.lblInfo);
			this.Controls.Add(this.tbxBorn);
			this.Controls.Add(this.tbxNamn);
			this.Controls.Add(this.lblBorn);
			this.Controls.Add(this.lblNamn);
			this.Name = "Form1";
			this.Text = "Övning";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblNamn;
		private System.Windows.Forms.Label lblBorn;
		private System.Windows.Forms.TextBox tbxNamn;
		private System.Windows.Forms.TextBox tbxBorn;
		private System.Windows.Forms.Label lblInfo;
		private System.Windows.Forms.Button btnRun;
	}
}

