namespace Exempel07_03
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
			this.LblPengar = new System.Windows.Forms.Label();
			this.TbxPengar = new System.Windows.Forms.TextBox();
			this.LblKostnad = new System.Windows.Forms.Label();
			this.TbxKostnad = new System.Windows.Forms.TextBox();
			this.LblResultat = new System.Windows.Forms.Label();
			this.BtnOk = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LblPengar
			// 
			this.LblPengar.AutoSize = true;
			this.LblPengar.Location = new System.Drawing.Point(34, 51);
			this.LblPengar.Name = "LblPengar";
			this.LblPengar.Size = new System.Drawing.Size(209, 20);
			this.LblPengar.TabIndex = 0;
			this.LblPengar.Text = "Hur mycket pengar har du?";
			// 
			// TbxPengar
			// 
			this.TbxPengar.Location = new System.Drawing.Point(226, 48);
			this.TbxPengar.Name = "TbxPengar";
			this.TbxPengar.Size = new System.Drawing.Size(117, 22);
			this.TbxPengar.TabIndex = 1;
			this.TbxPengar.TextChanged += new System.EventHandler(this.TbxPengar_TextChanged);
			// 
			// LblKostnad
			// 
			this.LblKostnad.AutoSize = true;
			this.LblKostnad.Location = new System.Drawing.Point(34, 104);
			this.LblKostnad.Name = "LblKostnad";
			this.LblKostnad.Size = new System.Drawing.Size(186, 16);
			this.LblKostnad.TabIndex = 2;
			this.LblKostnad.Text = "Hur mycket ska du handla för?";
			// 
			// TbxKostnad
			// 
			this.TbxKostnad.Location = new System.Drawing.Point(226, 98);
			this.TbxKostnad.Name = "TbxKostnad";
			this.TbxKostnad.Size = new System.Drawing.Size(117, 22);
			this.TbxKostnad.TabIndex = 3;
			this.TbxKostnad.TextChanged += new System.EventHandler(this.TbxKostnad_TextChanged);
			// 
			// LblResultat
			// 
			this.LblResultat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.LblResultat.Location = new System.Drawing.Point(34, 154);
			this.LblResultat.Name = "LblResultat";
			this.LblResultat.Size = new System.Drawing.Size(309, 22);
			this.LblResultat.TabIndex = 4;
			this.LblResultat.Text = "Ta ut 400 kronor. Efter köpet återstår 42 kronor";
			this.LblResultat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// BtnOk
			// 
			this.BtnOk.Location = new System.Drawing.Point(107, 225);
			this.BtnOk.Name = "BtnOk";
			this.BtnOk.Size = new System.Drawing.Size(75, 23);
			this.BtnOk.TabIndex = 5;
			this.BtnOk.Text = "OK";
			this.BtnOk.UseVisualStyleBackColor = true;
			this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(400, 329);
			this.Controls.Add(this.BtnOk);
			this.Controls.Add(this.LblResultat);
			this.Controls.Add(this.TbxKostnad);
			this.Controls.Add(this.LblKostnad);
			this.Controls.Add(this.TbxPengar);
			this.Controls.Add(this.LblPengar);
			this.Name = "Form1";
			this.Text = "Exempel 7.3";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LblPengar;
		private System.Windows.Forms.TextBox TbxPengar;
		private System.Windows.Forms.Label LblKostnad;
		private System.Windows.Forms.TextBox TbxKostnad;
		private System.Windows.Forms.Label LblResultat;
		private System.Windows.Forms.Button BtnOk;
	}
}

