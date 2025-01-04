namespace ovning06_01
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
			this.label1 = new System.Windows.Forms.Label();
			this.TbxTal1 = new System.Windows.Forms.TextBox();
			this.TbxTal2 = new System.Windows.Forms.TextBox();
			this.TbxTal3 = new System.Windows.Forms.TextBox();
			this.LblSvar = new System.Windows.Forms.Label();
			this.TbxSvaret = new System.Windows.Forms.TextBox();
			this.BtnRun = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Talen är:";
			// 
			// TbxTal1
			// 
			this.TbxTal1.Location = new System.Drawing.Point(136, 57);
			this.TbxTal1.Name = "TbxTal1";
			this.TbxTal1.Size = new System.Drawing.Size(90, 22);
			this.TbxTal1.TabIndex = 1;
			// 
			// TbxTal2
			// 
			this.TbxTal2.Location = new System.Drawing.Point(247, 57);
			this.TbxTal2.Name = "TbxTal2";
			this.TbxTal2.Size = new System.Drawing.Size(100, 22);
			this.TbxTal2.TabIndex = 2;
			// 
			// TbxTal3
			// 
			this.TbxTal3.Location = new System.Drawing.Point(375, 57);
			this.TbxTal3.Name = "TbxTal3";
			this.TbxTal3.Size = new System.Drawing.Size(100, 22);
			this.TbxTal3.TabIndex = 3;
			// 
			// LblSvar
			// 
			this.LblSvar.AutoSize = true;
			this.LblSvar.Location = new System.Drawing.Point(12, 138);
			this.LblSvar.Name = "LblSvar";
			this.LblSvar.Size = new System.Drawing.Size(49, 16);
			this.LblSvar.TabIndex = 4;
			this.LblSvar.Text = "Svaret:";
			// 
			// TbxSvaret
			// 
			this.TbxSvaret.Location = new System.Drawing.Point(136, 132);
			this.TbxSvaret.Name = "TbxSvaret";
			this.TbxSvaret.Size = new System.Drawing.Size(100, 22);
			this.TbxSvaret.TabIndex = 5;
			// 
			// BtnRun
			// 
			this.BtnRun.Location = new System.Drawing.Point(136, 214);
			this.BtnRun.Name = "BtnRun";
			this.BtnRun.Size = new System.Drawing.Size(75, 23);
			this.BtnRun.TabIndex = 6;
			this.BtnRun.Text = "Kör";
			this.BtnRun.UseVisualStyleBackColor = true;
			this.BtnRun.Click += new System.EventHandler(this.BtnRun_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(518, 314);
			this.Controls.Add(this.BtnRun);
			this.Controls.Add(this.TbxSvaret);
			this.Controls.Add(this.LblSvar);
			this.Controls.Add(this.TbxTal3);
			this.Controls.Add(this.TbxTal2);
			this.Controls.Add(this.TbxTal1);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Övning 6.1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox TbxTal1;
		private System.Windows.Forms.TextBox TbxTal2;
		private System.Windows.Forms.TextBox TbxTal3;
		private System.Windows.Forms.Label LblSvar;
		private System.Windows.Forms.TextBox TbxSvaret;
		private System.Windows.Forms.Button BtnRun;
	}
}

