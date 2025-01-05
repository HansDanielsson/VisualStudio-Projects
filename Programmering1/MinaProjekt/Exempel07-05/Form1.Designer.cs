namespace Exempel07_05
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
			this.LblAntalPersoner = new System.Windows.Forms.Label();
			this.TbxAntalPersoner = new System.Windows.Forms.TextBox();
			this.LblResultat = new System.Windows.Forms.Label();
			this.BtnHyreskostnad = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LblAntalPersoner
			// 
			this.LblAntalPersoner.AutoSize = true;
			this.LblAntalPersoner.Location = new System.Drawing.Point(44, 51);
			this.LblAntalPersoner.Name = "LblAntalPersoner";
			this.LblAntalPersoner.Size = new System.Drawing.Size(118, 20);
			this.LblAntalPersoner.TabIndex = 0;
			this.LblAntalPersoner.Text = "Antal personer";
			// 
			// TbxAntalPersoner
			// 
			this.TbxAntalPersoner.Location = new System.Drawing.Point(177, 48);
			this.TbxAntalPersoner.Name = "TbxAntalPersoner";
			this.TbxAntalPersoner.Size = new System.Drawing.Size(120, 22);
			this.TbxAntalPersoner.TabIndex = 1;
			this.TbxAntalPersoner.TextChanged += new System.EventHandler(this.TbxAntalPersoner_TextChanged);
			// 
			// LblResultat
			// 
			this.LblResultat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.LblResultat.Location = new System.Drawing.Point(47, 87);
			this.LblResultat.Name = "LblResultat";
			this.LblResultat.Size = new System.Drawing.Size(149, 29);
			this.LblResultat.TabIndex = 2;
			this.LblResultat.Text = "Det kostar 150 kr";
			this.LblResultat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// BtnHyreskostnad
			// 
			this.BtnHyreskostnad.Location = new System.Drawing.Point(99, 144);
			this.BtnHyreskostnad.Name = "BtnHyreskostnad";
			this.BtnHyreskostnad.Size = new System.Drawing.Size(137, 47);
			this.BtnHyreskostnad.TabIndex = 3;
			this.BtnHyreskostnad.Text = "Hyreskostnad";
			this.BtnHyreskostnad.UseVisualStyleBackColor = true;
			this.BtnHyreskostnad.Click += new System.EventHandler(this.BtnHyreskostnad_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 232);
			this.Controls.Add(this.BtnHyreskostnad);
			this.Controls.Add(this.LblResultat);
			this.Controls.Add(this.TbxAntalPersoner);
			this.Controls.Add(this.LblAntalPersoner);
			this.Name = "Form1";
			this.Text = "Exempel 7.5";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LblAntalPersoner;
		private System.Windows.Forms.TextBox TbxAntalPersoner;
		private System.Windows.Forms.Label LblResultat;
		private System.Windows.Forms.Button BtnHyreskostnad;
	}
}

