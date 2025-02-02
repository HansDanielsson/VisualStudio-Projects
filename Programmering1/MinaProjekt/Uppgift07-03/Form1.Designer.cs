namespace Uppgift07_03
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
			this.LblLength = new System.Windows.Forms.Label();
			this.LblWind = new System.Windows.Forms.Label();
			this.TbxLength = new System.Windows.Forms.TextBox();
			this.TbxWind = new System.Windows.Forms.TextBox();
			this.LblResult = new System.Windows.Forms.Label();
			this.BtnRun = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LblLength
			// 
			this.LblLength.AutoSize = true;
			this.LblLength.Location = new System.Drawing.Point(41, 56);
			this.LblLength.Name = "LblLength";
			this.LblLength.Size = new System.Drawing.Size(70, 16);
			this.LblLength.TabIndex = 0;
			this.LblLength.Text = "Längd (m):";
			// 
			// LblWind
			// 
			this.LblWind.AutoSize = true;
			this.LblWind.Location = new System.Drawing.Point(41, 93);
			this.LblWind.Name = "LblWind";
			this.LblWind.Size = new System.Drawing.Size(103, 16);
			this.LblWind.TabIndex = 1;
			this.LblWind.Text = "Vindstyrka (m/s)";
			// 
			// TbxLength
			// 
			this.TbxLength.Location = new System.Drawing.Point(177, 50);
			this.TbxLength.Name = "TbxLength";
			this.TbxLength.Size = new System.Drawing.Size(100, 22);
			this.TbxLength.TabIndex = 2;
			// 
			// TbxWind
			// 
			this.TbxWind.Location = new System.Drawing.Point(177, 87);
			this.TbxWind.Name = "TbxWind";
			this.TbxWind.Size = new System.Drawing.Size(100, 22);
			this.TbxWind.TabIndex = 3;
			// 
			// LblResult
			// 
			this.LblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.LblResult.Location = new System.Drawing.Point(44, 130);
			this.LblResult.Name = "LblResult";
			this.LblResult.Size = new System.Drawing.Size(168, 29);
			this.LblResult.TabIndex = 4;
			this.LblResult.Text = "Tyvärr, inget nytt rekord";
			this.LblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// BtnRun
			// 
			this.BtnRun.Location = new System.Drawing.Point(80, 182);
			this.BtnRun.Name = "BtnRun";
			this.BtnRun.Size = new System.Drawing.Size(75, 38);
			this.BtnRun.TabIndex = 5;
			this.BtnRun.Text = "OK";
			this.BtnRun.UseVisualStyleBackColor = true;
			this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(338, 283);
			this.Controls.Add(this.BtnRun);
			this.Controls.Add(this.LblResult);
			this.Controls.Add(this.TbxWind);
			this.Controls.Add(this.TbxLength);
			this.Controls.Add(this.LblWind);
			this.Controls.Add(this.LblLength);
			this.Name = "Form1";
			this.Text = "Uppgift 7.3";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LblLength;
		private System.Windows.Forms.Label LblWind;
		private System.Windows.Forms.TextBox TbxLength;
		private System.Windows.Forms.TextBox TbxWind;
		private System.Windows.Forms.Label LblResult;
		private System.Windows.Forms.Button BtnRun;
	}
}

