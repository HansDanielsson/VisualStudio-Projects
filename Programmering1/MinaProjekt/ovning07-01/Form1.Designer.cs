namespace ovning07_01
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
			this.LblLiter = new System.Windows.Forms.Label();
			this.TbxLiter = new System.Windows.Forms.TextBox();
			this.LblResult = new System.Windows.Forms.Label();
			this.BtnOk = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LblLiter
			// 
			this.LblLiter.AutoSize = true;
			this.LblLiter.Location = new System.Drawing.Point(30, 40);
			this.LblLiter.Name = "LblLiter";
			this.LblLiter.Size = new System.Drawing.Size(98, 20);
			this.LblLiter.TabIndex = 0;
			this.LblLiter.Text = "Liter bensin:";
			// 
			// TbxLiter
			// 
			this.TbxLiter.Location = new System.Drawing.Point(134, 37);
			this.TbxLiter.Name = "TbxLiter";
			this.TbxLiter.Size = new System.Drawing.Size(100, 22);
			this.TbxLiter.TabIndex = 1;
			// 
			// LblResult
			// 
			this.LblResult.AutoSize = true;
			this.LblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.LblResult.Location = new System.Drawing.Point(30, 104);
			this.LblResult.Name = "LblResult";
			this.LblResult.Size = new System.Drawing.Size(280, 23);
			this.LblResult.TabIndex = 2;
			this.LblResult.Text = "Tanka 41.5 liter. Det kostar 601.75 kr.";
			// 
			// BtnOk
			// 
			this.BtnOk.Location = new System.Drawing.Point(134, 167);
			this.BtnOk.Name = "BtnOk";
			this.BtnOk.Size = new System.Drawing.Size(75, 23);
			this.BtnOk.TabIndex = 3;
			this.BtnOk.Text = "Ok";
			this.BtnOk.UseVisualStyleBackColor = true;
			this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(461, 254);
			this.Controls.Add(this.BtnOk);
			this.Controls.Add(this.LblResult);
			this.Controls.Add(this.TbxLiter);
			this.Controls.Add(this.LblLiter);
			this.Name = "Form1";
			this.Text = "Övning 7.1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LblLiter;
		private System.Windows.Forms.TextBox TbxLiter;
		private System.Windows.Forms.Label LblResult;
		private System.Windows.Forms.Button BtnOk;
	}
}

