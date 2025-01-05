namespace Exempel07_06
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
			this.LblNamn = new System.Windows.Forms.Label();
			this.TbxNamn = new System.Windows.Forms.TextBox();
			this.LblPassword = new System.Windows.Forms.Label();
			this.TbxPassword = new System.Windows.Forms.TextBox();
			this.LblResultat = new System.Windows.Forms.Label();
			this.BtnKontrollera = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LblNamn
			// 
			this.LblNamn.AutoSize = true;
			this.LblNamn.Location = new System.Drawing.Point(38, 55);
			this.LblNamn.Name = "LblNamn";
			this.LblNamn.Size = new System.Drawing.Size(58, 20);
			this.LblNamn.TabIndex = 0;
			this.LblNamn.Text = "Namn:";
			// 
			// TbxNamn
			// 
			this.TbxNamn.Location = new System.Drawing.Point(138, 52);
			this.TbxNamn.Name = "TbxNamn";
			this.TbxNamn.Size = new System.Drawing.Size(156, 22);
			this.TbxNamn.TabIndex = 1;
			this.TbxNamn.TextChanged += new System.EventHandler(this.TbxNamn_TextChanged);
			// 
			// LblPassword
			// 
			this.LblPassword.AutoSize = true;
			this.LblPassword.Location = new System.Drawing.Point(38, 108);
			this.LblPassword.Name = "LblPassword";
			this.LblPassword.Size = new System.Drawing.Size(67, 16);
			this.LblPassword.TabIndex = 2;
			this.LblPassword.Text = "Lösenord:";
			// 
			// TbxPassword
			// 
			this.TbxPassword.Location = new System.Drawing.Point(138, 102);
			this.TbxPassword.Name = "TbxPassword";
			this.TbxPassword.Size = new System.Drawing.Size(156, 22);
			this.TbxPassword.TabIndex = 3;
			this.TbxPassword.TextChanged += new System.EventHandler(this.TbxPassword_TextChanged);
			// 
			// LblResultat
			// 
			this.LblResultat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.LblResultat.Location = new System.Drawing.Point(41, 151);
			this.LblResultat.Name = "LblResultat";
			this.LblResultat.Size = new System.Drawing.Size(190, 29);
			this.LblResultat.TabIndex = 4;
			this.LblResultat.Text = "Felaktigt namn eller lösenord";
			this.LblResultat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// BtnKontrollera
			// 
			this.BtnKontrollera.Location = new System.Drawing.Point(79, 218);
			this.BtnKontrollera.Name = "BtnKontrollera";
			this.BtnKontrollera.Size = new System.Drawing.Size(125, 48);
			this.BtnKontrollera.TabIndex = 5;
			this.BtnKontrollera.Text = "Kontrollera";
			this.BtnKontrollera.UseVisualStyleBackColor = true;
			this.BtnKontrollera.Click += new System.EventHandler(this.BtnKontrollera_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(332, 333);
			this.Controls.Add(this.BtnKontrollera);
			this.Controls.Add(this.LblResultat);
			this.Controls.Add(this.TbxPassword);
			this.Controls.Add(this.LblPassword);
			this.Controls.Add(this.TbxNamn);
			this.Controls.Add(this.LblNamn);
			this.Name = "Form1";
			this.Text = "Exempel 7.6";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LblNamn;
		private System.Windows.Forms.TextBox TbxNamn;
		private System.Windows.Forms.Label LblPassword;
		private System.Windows.Forms.TextBox TbxPassword;
		private System.Windows.Forms.Label LblResultat;
		private System.Windows.Forms.Button BtnKontrollera;
	}
}

