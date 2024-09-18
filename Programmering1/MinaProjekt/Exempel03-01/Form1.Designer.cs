namespace Exempel03_01
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
			this.lblTal = new System.Windows.Forms.Label();
			this.tbxTal = new System.Windows.Forms.TextBox();
			this.lblKvadrat = new System.Windows.Forms.Label();
			this.btnRun = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblTal
			// 
			this.lblTal.AutoSize = true;
			this.lblTal.Location = new System.Drawing.Point(42, 36);
			this.lblTal.Name = "lblTal";
			this.lblTal.Size = new System.Drawing.Size(22, 13);
			this.lblTal.TabIndex = 0;
			this.lblTal.Text = "Tal";
			// 
			// tbxTal
			// 
			this.tbxTal.Location = new System.Drawing.Point(93, 28);
			this.tbxTal.Name = "tbxTal";
			this.tbxTal.Size = new System.Drawing.Size(100, 20);
			this.tbxTal.TabIndex = 1;
			// 
			// lblKvadrat
			// 
			this.lblKvadrat.AutoSize = true;
			this.lblKvadrat.Location = new System.Drawing.Point(90, 99);
			this.lblKvadrat.Name = "lblKvadrat";
			this.lblKvadrat.Size = new System.Drawing.Size(44, 13);
			this.lblKvadrat.TabIndex = 2;
			this.lblKvadrat.Text = "Kvadrat";
			// 
			// btnRun
			// 
			this.btnRun.Location = new System.Drawing.Point(58, 180);
			this.btnRun.Name = "btnRun";
			this.btnRun.Size = new System.Drawing.Size(135, 23);
			this.btnRun.TabIndex = 3;
			this.btnRun.Text = "Beräkna kvadraten";
			this.btnRun.UseVisualStyleBackColor = true;
			this.btnRun.Click += new System.EventHandler(this.BtnRun_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(256, 241);
			this.Controls.Add(this.btnRun);
			this.Controls.Add(this.lblKvadrat);
			this.Controls.Add(this.tbxTal);
			this.Controls.Add(this.lblTal);
			this.Name = "Form1";
			this.Text = "Exempel";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTal;
		private System.Windows.Forms.TextBox tbxTal;
		private System.Windows.Forms.Label lblKvadrat;
		private System.Windows.Forms.Button btnRun;
	}
}

