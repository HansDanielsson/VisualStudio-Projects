namespace ovning03_06
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
			this.lblFirstName = new System.Windows.Forms.Label();
			this.lblLastName = new System.Windows.Forms.Label();
			this.lblSvar = new System.Windows.Forms.Label();
			this.tbxFirstName = new System.Windows.Forms.TextBox();
			this.tbxLastName = new System.Windows.Forms.TextBox();
			this.btnRun = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblFirstName
			// 
			this.lblFirstName.AutoSize = true;
			this.lblFirstName.Location = new System.Drawing.Point(24, 31);
			this.lblFirstName.Name = "lblFirstName";
			this.lblFirstName.Size = new System.Drawing.Size(48, 13);
			this.lblFirstName.TabIndex = 0;
			this.lblFirstName.Text = "Förnamn";
			// 
			// lblLastName
			// 
			this.lblLastName.AutoSize = true;
			this.lblLastName.Location = new System.Drawing.Point(27, 79);
			this.lblLastName.Name = "lblLastName";
			this.lblLastName.Size = new System.Drawing.Size(55, 13);
			this.lblLastName.TabIndex = 1;
			this.lblLastName.Text = "Efternamn";
			// 
			// lblSvar
			// 
			this.lblSvar.AutoSize = true;
			this.lblSvar.Location = new System.Drawing.Point(88, 133);
			this.lblSvar.Name = "lblSvar";
			this.lblSvar.Size = new System.Drawing.Size(35, 13);
			this.lblSvar.TabIndex = 2;
			this.lblSvar.Text = "label3";
			// 
			// tbxFirstName
			// 
			this.tbxFirstName.Location = new System.Drawing.Point(91, 24);
			this.tbxFirstName.Name = "tbxFirstName";
			this.tbxFirstName.Size = new System.Drawing.Size(100, 20);
			this.tbxFirstName.TabIndex = 3;
			// 
			// tbxLastName
			// 
			this.tbxLastName.Location = new System.Drawing.Point(91, 72);
			this.tbxLastName.Name = "tbxLastName";
			this.tbxLastName.Size = new System.Drawing.Size(100, 20);
			this.tbxLastName.TabIndex = 4;
			// 
			// btnRun
			// 
			this.btnRun.Location = new System.Drawing.Point(103, 193);
			this.btnRun.Name = "btnRun";
			this.btnRun.Size = new System.Drawing.Size(75, 23);
			this.btnRun.TabIndex = 5;
			this.btnRun.Text = "Kör";
			this.btnRun.UseVisualStyleBackColor = true;
			this.btnRun.Click += new System.EventHandler(this.BtnRun_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(387, 268);
			this.Controls.Add(this.btnRun);
			this.Controls.Add(this.tbxLastName);
			this.Controls.Add(this.tbxFirstName);
			this.Controls.Add(this.lblSvar);
			this.Controls.Add(this.lblLastName);
			this.Controls.Add(this.lblFirstName);
			this.Name = "Form1";
			this.Text = "Övning";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblFirstName;
		private System.Windows.Forms.Label lblLastName;
		private System.Windows.Forms.Label lblSvar;
		private System.Windows.Forms.TextBox tbxFirstName;
		private System.Windows.Forms.TextBox tbxLastName;
		private System.Windows.Forms.Button btnRun;
	}
}

