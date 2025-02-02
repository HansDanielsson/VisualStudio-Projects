namespace Uppgift07_02
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
			this.LblSlag = new System.Windows.Forms.Label();
			this.TbxSlag = new System.Windows.Forms.TextBox();
			this.LblResult = new System.Windows.Forms.Label();
			this.BtnRun = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LblSlag
			// 
			this.LblSlag.AutoSize = true;
			this.LblSlag.Location = new System.Drawing.Point(25, 28);
			this.LblSlag.Name = "LblSlag";
			this.LblSlag.Size = new System.Drawing.Size(93, 16);
			this.LblSlag.TabIndex = 0;
			this.LblSlag.Text = "Slagets längd:";
			// 
			// TbxSlag
			// 
			this.TbxSlag.Location = new System.Drawing.Point(149, 22);
			this.TbxSlag.Name = "TbxSlag";
			this.TbxSlag.Size = new System.Drawing.Size(106, 22);
			this.TbxSlag.TabIndex = 1;
			// 
			// LblResult
			// 
			this.LblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.LblResult.Location = new System.Drawing.Point(25, 61);
			this.LblResult.Name = "LblResult";
			this.LblResult.Size = new System.Drawing.Size(125, 29);
			this.LblResult.TabIndex = 2;
			this.LblResult.Text = "Grattis!";
			this.LblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// BtnRun
			// 
			this.BtnRun.Location = new System.Drawing.Point(60, 131);
			this.BtnRun.Name = "BtnRun";
			this.BtnRun.Size = new System.Drawing.Size(90, 42);
			this.BtnRun.TabIndex = 3;
			this.BtnRun.Text = "OK";
			this.BtnRun.UseVisualStyleBackColor = true;
			this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(375, 245);
			this.Controls.Add(this.BtnRun);
			this.Controls.Add(this.LblResult);
			this.Controls.Add(this.TbxSlag);
			this.Controls.Add(this.LblSlag);
			this.Name = "Form1";
			this.Text = "Uppgift 7.2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LblSlag;
		private System.Windows.Forms.TextBox TbxSlag;
		private System.Windows.Forms.Label LblResult;
		private System.Windows.Forms.Button BtnRun;
	}
}

