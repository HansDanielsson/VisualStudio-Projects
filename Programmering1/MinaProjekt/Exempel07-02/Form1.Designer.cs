namespace Exempel07_02
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
			this.LblHojd = new System.Windows.Forms.Label();
			this.TbxHojd = new System.Windows.Forms.TextBox();
			this.LblResultat = new System.Windows.Forms.Label();
			this.BtnOk = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LblHojd
			// 
			this.LblHojd.AutoSize = true;
			this.LblHojd.Location = new System.Drawing.Point(36, 49);
			this.LblHojd.Name = "LblHojd";
			this.LblHojd.Size = new System.Drawing.Size(151, 20);
			this.LblHojd.TabIndex = 0;
			this.LblHojd.Text = "Pudelns mankhöjd:";
			// 
			// TbxHojd
			// 
			this.TbxHojd.Location = new System.Drawing.Point(174, 46);
			this.TbxHojd.Name = "TbxHojd";
			this.TbxHojd.Size = new System.Drawing.Size(155, 22);
			this.TbxHojd.TabIndex = 1;
			this.TbxHojd.TextChanged += new System.EventHandler(this.TbxHojd_TextChanged);
			// 
			// LblResultat
			// 
			this.LblResultat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.LblResultat.Location = new System.Drawing.Point(36, 122);
			this.LblResultat.Name = "LblResultat";
			this.LblResultat.Size = new System.Drawing.Size(293, 22);
			this.LblResultat.TabIndex = 2;
			this.LblResultat.Text = "Det är en dvärgpudel";
			this.LblResultat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// BtnOk
			// 
			this.BtnOk.Location = new System.Drawing.Point(160, 225);
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
			this.ClientSize = new System.Drawing.Size(437, 353);
			this.Controls.Add(this.BtnOk);
			this.Controls.Add(this.LblResultat);
			this.Controls.Add(this.TbxHojd);
			this.Controls.Add(this.LblHojd);
			this.Name = "Form1";
			this.Text = "Exempel 7.2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LblHojd;
		private System.Windows.Forms.TextBox TbxHojd;
		private System.Windows.Forms.Label LblResultat;
		private System.Windows.Forms.Button BtnOk;
	}
}

