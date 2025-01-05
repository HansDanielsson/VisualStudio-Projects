namespace ovning07_06
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
			this.LblNamn1 = new System.Windows.Forms.Label();
			this.LblNamn2 = new System.Windows.Forms.Label();
			this.TbxNamn1 = new System.Windows.Forms.TextBox();
			this.TbxNamn2 = new System.Windows.Forms.TextBox();
			this.LblResult = new System.Windows.Forms.Label();
			this.BtnJmf = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LblNamn1
			// 
			this.LblNamn1.AutoSize = true;
			this.LblNamn1.Location = new System.Drawing.Point(37, 54);
			this.LblNamn1.Name = "LblNamn1";
			this.LblNamn1.Size = new System.Drawing.Size(70, 20);
			this.LblNamn1.TabIndex = 0;
			this.LblNamn1.Text = "Namn 1:";
			// 
			// LblNamn2
			// 
			this.LblNamn2.AutoSize = true;
			this.LblNamn2.Location = new System.Drawing.Point(37, 98);
			this.LblNamn2.Name = "LblNamn2";
			this.LblNamn2.Size = new System.Drawing.Size(56, 16);
			this.LblNamn2.TabIndex = 1;
			this.LblNamn2.Text = "Namn 2:";
			// 
			// TbxNamn1
			// 
			this.TbxNamn1.Location = new System.Drawing.Point(120, 51);
			this.TbxNamn1.Name = "TbxNamn1";
			this.TbxNamn1.Size = new System.Drawing.Size(153, 22);
			this.TbxNamn1.TabIndex = 2;
			// 
			// TbxNamn2
			// 
			this.TbxNamn2.Location = new System.Drawing.Point(120, 92);
			this.TbxNamn2.Name = "TbxNamn2";
			this.TbxNamn2.Size = new System.Drawing.Size(153, 22);
			this.TbxNamn2.TabIndex = 3;
			// 
			// LblResult
			// 
			this.LblResult.AutoSize = true;
			this.LblResult.Location = new System.Drawing.Point(37, 151);
			this.LblResult.Name = "LblResult";
			this.LblResult.Size = new System.Drawing.Size(106, 20);
			this.LblResult.TabIndex = 4;
			this.LblResult.Text = "Anna Helena";
			// 
			// BtnJmf
			// 
			this.BtnJmf.Location = new System.Drawing.Point(64, 195);
			this.BtnJmf.Name = "BtnJmf";
			this.BtnJmf.Size = new System.Drawing.Size(139, 40);
			this.BtnJmf.TabIndex = 5;
			this.BtnJmf.Text = "Jämför namnen";
			this.BtnJmf.UseVisualStyleBackColor = true;
			this.BtnJmf.Click += new System.EventHandler(this.BtnJmf_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(348, 296);
			this.Controls.Add(this.BtnJmf);
			this.Controls.Add(this.LblResult);
			this.Controls.Add(this.TbxNamn2);
			this.Controls.Add(this.TbxNamn1);
			this.Controls.Add(this.LblNamn2);
			this.Controls.Add(this.LblNamn1);
			this.Name = "Form1";
			this.Text = "Övning 7.6";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LblNamn1;
		private System.Windows.Forms.Label LblNamn2;
		private System.Windows.Forms.TextBox TbxNamn1;
		private System.Windows.Forms.TextBox TbxNamn2;
		private System.Windows.Forms.Label LblResult;
		private System.Windows.Forms.Button BtnJmf;
	}
}

