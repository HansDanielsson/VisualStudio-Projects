namespace ovning03_07
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
			this.lblTecken = new System.Windows.Forms.Label();
			this.lblSvar = new System.Windows.Forms.Label();
			this.btnRun = new System.Windows.Forms.Button();
			this.tbxTecken = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblTecken
			// 
			this.lblTecken.AutoSize = true;
			this.lblTecken.Location = new System.Drawing.Point(33, 36);
			this.lblTecken.Name = "lblTecken";
			this.lblTecken.Size = new System.Drawing.Size(44, 13);
			this.lblTecken.TabIndex = 0;
			this.lblTecken.Text = "Tecken";
			// 
			// lblSvar
			// 
			this.lblSvar.AutoSize = true;
			this.lblSvar.Location = new System.Drawing.Point(94, 86);
			this.lblSvar.Name = "lblSvar";
			this.lblSvar.Size = new System.Drawing.Size(35, 13);
			this.lblSvar.TabIndex = 1;
			this.lblSvar.Text = "label2";
			// 
			// btnRun
			// 
			this.btnRun.Location = new System.Drawing.Point(79, 133);
			this.btnRun.Name = "btnRun";
			this.btnRun.Size = new System.Drawing.Size(75, 23);
			this.btnRun.TabIndex = 2;
			this.btnRun.Text = "Kör";
			this.btnRun.UseVisualStyleBackColor = true;
			this.btnRun.Click += new System.EventHandler(this.BtnRun_Click);
			// 
			// tbxTecken
			// 
			this.tbxTecken.Location = new System.Drawing.Point(97, 29);
			this.tbxTecken.Name = "tbxTecken";
			this.tbxTecken.Size = new System.Drawing.Size(100, 20);
			this.tbxTecken.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(367, 280);
			this.Controls.Add(this.tbxTecken);
			this.Controls.Add(this.btnRun);
			this.Controls.Add(this.lblSvar);
			this.Controls.Add(this.lblTecken);
			this.Name = "Form1";
			this.Text = "Övning";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblTecken;
		private System.Windows.Forms.Label lblSvar;
		private System.Windows.Forms.Button btnRun;
		private System.Windows.Forms.TextBox tbxTecken;
	}
}

