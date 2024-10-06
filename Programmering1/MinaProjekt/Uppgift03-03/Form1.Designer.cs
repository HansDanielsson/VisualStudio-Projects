namespace Uppgift03_03
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
			this.btnRun = new System.Windows.Forms.Button();
			this.lblAvrunda = new System.Windows.Forms.Label();
			this.tbxAvrunda = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblTal
			// 
			this.lblTal.AutoSize = true;
			this.lblTal.Location = new System.Drawing.Point(13, 29);
			this.lblTal.Name = "lblTal";
			this.lblTal.Size = new System.Drawing.Size(53, 13);
			this.lblTal.TabIndex = 0;
			this.lblTal.Text = "Ange Tal:";
			// 
			// tbxTal
			// 
			this.tbxTal.Location = new System.Drawing.Point(94, 21);
			this.tbxTal.Name = "tbxTal";
			this.tbxTal.Size = new System.Drawing.Size(100, 20);
			this.tbxTal.TabIndex = 1;
			// 
			// btnRun
			// 
			this.btnRun.Location = new System.Drawing.Point(94, 176);
			this.btnRun.Name = "btnRun";
			this.btnRun.Size = new System.Drawing.Size(122, 23);
			this.btnRun.TabIndex = 2;
			this.btnRun.Text = "Utför avrundning";
			this.btnRun.UseVisualStyleBackColor = true;
			this.btnRun.Click += new System.EventHandler(this.BtnRun_Click);
			// 
			// lblAvrunda
			// 
			this.lblAvrunda.AutoSize = true;
			this.lblAvrunda.Location = new System.Drawing.Point(16, 90);
			this.lblAvrunda.Name = "lblAvrunda";
			this.lblAvrunda.Size = new System.Drawing.Size(47, 13);
			this.lblAvrunda.TabIndex = 3;
			this.lblAvrunda.Text = "Avrunda";
			// 
			// tbxAvrunda
			// 
			this.tbxAvrunda.Location = new System.Drawing.Point(94, 82);
			this.tbxAvrunda.Name = "tbxAvrunda";
			this.tbxAvrunda.Size = new System.Drawing.Size(100, 20);
			this.tbxAvrunda.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(394, 269);
			this.Controls.Add(this.tbxAvrunda);
			this.Controls.Add(this.lblAvrunda);
			this.Controls.Add(this.btnRun);
			this.Controls.Add(this.tbxTal);
			this.Controls.Add(this.lblTal);
			this.Name = "Form1";
			this.Text = "Uppgift 3.3";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTal;
		private System.Windows.Forms.TextBox tbxTal;
		private System.Windows.Forms.Button btnRun;
		private System.Windows.Forms.Label lblAvrunda;
		private System.Windows.Forms.TextBox tbxAvrunda;
	}
}

