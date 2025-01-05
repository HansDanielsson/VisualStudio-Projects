namespace Exempel07_04
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
			this.LblVikt = new System.Windows.Forms.Label();
			this.TbxVikt = new System.Windows.Forms.TextBox();
			this.LblResultat = new System.Windows.Forms.Label();
			this.BtnPorto = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LblVikt
			// 
			this.LblVikt.AutoSize = true;
			this.LblVikt.Location = new System.Drawing.Point(39, 67);
			this.LblVikt.Name = "LblVikt";
			this.LblVikt.Size = new System.Drawing.Size(123, 20);
			this.LblVikt.TabIndex = 0;
			this.LblVikt.Text = "Brevets vikt (g):";
			// 
			// TbxVikt
			// 
			this.TbxVikt.Location = new System.Drawing.Point(177, 64);
			this.TbxVikt.Name = "TbxVikt";
			this.TbxVikt.Size = new System.Drawing.Size(100, 22);
			this.TbxVikt.TabIndex = 1;
			this.TbxVikt.TextChanged += new System.EventHandler(this.TbxVikt_TextChanged);
			// 
			// LblResultat
			// 
			this.LblResultat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.LblResultat.Location = new System.Drawing.Point(39, 113);
			this.LblResultat.Name = "LblResultat";
			this.LblResultat.Size = new System.Drawing.Size(298, 29);
			this.LblResultat.TabIndex = 2;
			this.LblResultat.Text = "Ett brev som väger 25 gram kostar 15 kronor";
			this.LblResultat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// BtnPorto
			// 
			this.BtnPorto.Location = new System.Drawing.Point(135, 186);
			this.BtnPorto.Name = "BtnPorto";
			this.BtnPorto.Size = new System.Drawing.Size(142, 41);
			this.BtnPorto.TabIndex = 3;
			this.BtnPorto.Text = "Beräkna portot";
			this.BtnPorto.UseVisualStyleBackColor = true;
			this.BtnPorto.Click += new System.EventHandler(this.BtnPorto_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(395, 306);
			this.Controls.Add(this.BtnPorto);
			this.Controls.Add(this.LblResultat);
			this.Controls.Add(this.TbxVikt);
			this.Controls.Add(this.LblVikt);
			this.Name = "Form1";
			this.Text = "Exempel 7.4";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LblVikt;
		private System.Windows.Forms.TextBox TbxVikt;
		private System.Windows.Forms.Label LblResultat;
		private System.Windows.Forms.Button BtnPorto;
	}
}

