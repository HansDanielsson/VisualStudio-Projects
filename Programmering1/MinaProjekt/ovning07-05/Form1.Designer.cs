namespace ovning07_05
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
			this.LblVeckodag = new System.Windows.Forms.Label();
			this.TbxVeckodag = new System.Windows.Forms.TextBox();
			this.LblResult = new System.Windows.Forms.Label();
			this.BtnVeckodag = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LblVeckodag
			// 
			this.LblVeckodag.AutoSize = true;
			this.LblVeckodag.Location = new System.Drawing.Point(45, 49);
			this.LblVeckodag.Name = "LblVeckodag";
			this.LblVeckodag.Size = new System.Drawing.Size(136, 20);
			this.LblVeckodag.TabIndex = 0;
			this.LblVeckodag.Text = "Veckodagens nr:";
			// 
			// TbxVeckodag
			// 
			this.TbxVeckodag.Location = new System.Drawing.Point(202, 46);
			this.TbxVeckodag.Name = "TbxVeckodag";
			this.TbxVeckodag.Size = new System.Drawing.Size(100, 22);
			this.TbxVeckodag.TabIndex = 1;
			// 
			// LblResult
			// 
			this.LblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.LblResult.Location = new System.Drawing.Point(48, 80);
			this.LblResult.Name = "LblResult";
			this.LblResult.Size = new System.Drawing.Size(254, 32);
			this.LblResult.TabIndex = 2;
			this.LblResult.Text = "Torsdag";
			this.LblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// BtnVeckodag
			// 
			this.BtnVeckodag.Location = new System.Drawing.Point(83, 160);
			this.BtnVeckodag.Name = "BtnVeckodag";
			this.BtnVeckodag.Size = new System.Drawing.Size(170, 59);
			this.BtnVeckodag.TabIndex = 3;
			this.BtnVeckodag.Text = "Visa veckodag";
			this.BtnVeckodag.UseVisualStyleBackColor = true;
			this.BtnVeckodag.Click += new System.EventHandler(this.BtnVeckodag_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(353, 302);
			this.Controls.Add(this.BtnVeckodag);
			this.Controls.Add(this.LblResult);
			this.Controls.Add(this.TbxVeckodag);
			this.Controls.Add(this.LblVeckodag);
			this.Name = "Form1";
			this.Text = "Övning 7.5";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LblVeckodag;
		private System.Windows.Forms.TextBox TbxVeckodag;
		private System.Windows.Forms.Label LblResult;
		private System.Windows.Forms.Button BtnVeckodag;
	}
}

