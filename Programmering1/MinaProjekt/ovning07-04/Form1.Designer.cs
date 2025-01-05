namespace ovning07_04
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
			this.BtnPriset = new System.Windows.Forms.Button();
			this.LblAntal = new System.Windows.Forms.Label();
			this.TbxAntal = new System.Windows.Forms.TextBox();
			this.LblResult = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// BtnPriset
			// 
			this.BtnPriset.Location = new System.Drawing.Point(98, 150);
			this.BtnPriset.Name = "BtnPriset";
			this.BtnPriset.Size = new System.Drawing.Size(162, 57);
			this.BtnPriset.TabIndex = 0;
			this.BtnPriset.Text = "Beräkna priset";
			this.BtnPriset.UseVisualStyleBackColor = true;
			this.BtnPriset.Click += new System.EventHandler(this.BtnPriset_Click);
			// 
			// LblAntal
			// 
			this.LblAntal.AutoSize = true;
			this.LblAntal.Location = new System.Drawing.Point(46, 51);
			this.LblAntal.Name = "LblAntal";
			this.LblAntal.Size = new System.Drawing.Size(86, 20);
			this.LblAntal.TabIndex = 1;
			this.LblAntal.Text = "Antal låtar:";
			// 
			// TbxAntal
			// 
			this.TbxAntal.Location = new System.Drawing.Point(160, 48);
			this.TbxAntal.Name = "TbxAntal";
			this.TbxAntal.Size = new System.Drawing.Size(100, 22);
			this.TbxAntal.TabIndex = 2;
			// 
			// LblResult
			// 
			this.LblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.LblResult.Location = new System.Drawing.Point(49, 103);
			this.LblResult.Name = "LblResult";
			this.LblResult.Size = new System.Drawing.Size(254, 29);
			this.LblResult.TabIndex = 3;
			this.LblResult.Text = "Kostnaden för 45 låtar är 400.95 kronor";
			this.LblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(375, 299);
			this.Controls.Add(this.LblResult);
			this.Controls.Add(this.TbxAntal);
			this.Controls.Add(this.LblAntal);
			this.Controls.Add(this.BtnPriset);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnPriset;
		private System.Windows.Forms.Label LblAntal;
		private System.Windows.Forms.TextBox TbxAntal;
		private System.Windows.Forms.Label LblResult;
	}
}

