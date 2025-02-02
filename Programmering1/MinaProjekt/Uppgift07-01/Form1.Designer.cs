namespace Uppgift07_01
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
			this.LblTal = new System.Windows.Forms.Label();
			this.TbxTal = new System.Windows.Forms.TextBox();
			this.LblResult = new System.Windows.Forms.Label();
			this.BtnRun = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LblTal
			// 
			this.LblTal.AutoSize = true;
			this.LblTal.Location = new System.Drawing.Point(35, 56);
			this.LblTal.Name = "LblTal";
			this.LblTal.Size = new System.Drawing.Size(30, 16);
			this.LblTal.TabIndex = 0;
			this.LblTal.Text = "Tal:";
			// 
			// TbxTal
			// 
			this.TbxTal.Location = new System.Drawing.Point(116, 50);
			this.TbxTal.Name = "TbxTal";
			this.TbxTal.Size = new System.Drawing.Size(84, 22);
			this.TbxTal.TabIndex = 1;
			// 
			// LblResult
			// 
			this.LblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.LblResult.Location = new System.Drawing.Point(38, 86);
			this.LblResult.Name = "LblResult";
			this.LblResult.Size = new System.Drawing.Size(125, 29);
			this.LblResult.TabIndex = 2;
			this.LblResult.Text = "Talet är negativt";
			this.LblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// BtnRun
			// 
			this.BtnRun.Location = new System.Drawing.Point(70, 132);
			this.BtnRun.Name = "BtnRun";
			this.BtnRun.Size = new System.Drawing.Size(93, 46);
			this.BtnRun.TabIndex = 3;
			this.BtnRun.Text = "OK";
			this.BtnRun.UseVisualStyleBackColor = true;
			this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(331, 228);
			this.Controls.Add(this.BtnRun);
			this.Controls.Add(this.LblResult);
			this.Controls.Add(this.TbxTal);
			this.Controls.Add(this.LblTal);
			this.Name = "Form1";
			this.Text = "Uppgift 7.1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LblTal;
		private System.Windows.Forms.TextBox TbxTal;
		private System.Windows.Forms.Label LblResult;
		private System.Windows.Forms.Button BtnRun;
	}
}

