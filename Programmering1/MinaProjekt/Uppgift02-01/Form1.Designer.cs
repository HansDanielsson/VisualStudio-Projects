namespace Uppgift02_01
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
			this.BtnRed = new System.Windows.Forms.Button();
			this.BtnBlue = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// BtnRed
			// 
			this.BtnRed.Location = new System.Drawing.Point(33, 54);
			this.BtnRed.Name = "BtnRed";
			this.BtnRed.Size = new System.Drawing.Size(75, 23);
			this.BtnRed.TabIndex = 0;
			this.BtnRed.Text = "Röd";
			this.BtnRed.UseVisualStyleBackColor = true;
			this.BtnRed.Click += new System.EventHandler(this.BtnRed_Click);
			// 
			// BtnBlue
			// 
			this.BtnBlue.Location = new System.Drawing.Point(158, 53);
			this.BtnBlue.Name = "BtnBlue";
			this.BtnBlue.Size = new System.Drawing.Size(75, 23);
			this.BtnBlue.TabIndex = 1;
			this.BtnBlue.Text = "Blå";
			this.BtnBlue.UseVisualStyleBackColor = true;
			this.BtnBlue.Click += new System.EventHandler(this.BtnBlue_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Red;
			this.ClientSize = new System.Drawing.Size(284, 161);
			this.Controls.Add(this.BtnBlue);
			this.Controls.Add(this.BtnRed);
			this.Name = "Form1";
			this.Text = "Uppgift";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button BtnRed;
		private System.Windows.Forms.Button BtnBlue;
	}
}

