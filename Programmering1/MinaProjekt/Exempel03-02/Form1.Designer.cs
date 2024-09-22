namespace Exempel03_02
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
			this.lblNamn = new System.Windows.Forms.Label();
			this.lblSvar = new System.Windows.Forms.Label();
			this.tbxNamn = new System.Windows.Forms.TextBox();
			this.btnVisaInitial = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblNamn
			// 
			this.lblNamn.AutoSize = true;
			this.lblNamn.Location = new System.Drawing.Point(52, 35);
			this.lblNamn.Name = "lblNamn";
			this.lblNamn.Size = new System.Drawing.Size(48, 13);
			this.lblNamn.TabIndex = 0;
			this.lblNamn.Text = "Förnamn";
			// 
			// lblSvar
			// 
			this.lblSvar.AutoSize = true;
			this.lblSvar.Location = new System.Drawing.Point(100, 124);
			this.lblSvar.Name = "lblSvar";
			this.lblSvar.Size = new System.Drawing.Size(35, 13);
			this.lblSvar.TabIndex = 1;
			this.lblSvar.Text = "label2";
			// 
			// tbxNamn
			// 
			this.tbxNamn.Location = new System.Drawing.Point(128, 27);
			this.tbxNamn.Name = "tbxNamn";
			this.tbxNamn.Size = new System.Drawing.Size(100, 20);
			this.tbxNamn.TabIndex = 2;
			// 
			// btnVisaInitial
			// 
			this.btnVisaInitial.Location = new System.Drawing.Point(138, 186);
			this.btnVisaInitial.Name = "btnVisaInitial";
			this.btnVisaInitial.Size = new System.Drawing.Size(75, 23);
			this.btnVisaInitial.TabIndex = 3;
			this.btnVisaInitial.Text = "Kör";
			this.btnVisaInitial.UseVisualStyleBackColor = true;
			this.btnVisaInitial.Click += new System.EventHandler(this.BtnVisaInitial_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(354, 253);
			this.Controls.Add(this.btnVisaInitial);
			this.Controls.Add(this.tbxNamn);
			this.Controls.Add(this.lblSvar);
			this.Controls.Add(this.lblNamn);
			this.Name = "Form1";
			this.Text = "Exempel3-2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblNamn;
		private System.Windows.Forms.Label lblSvar;
		private System.Windows.Forms.TextBox tbxNamn;
		private System.Windows.Forms.Button btnVisaInitial;
	}
}

