namespace Uppgift03_02
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
			this.lblCharNr = new System.Windows.Forms.Label();
			this.tbxCharNr = new System.Windows.Forms.TextBox();
			this.lblResult = new System.Windows.Forms.Label();
			this.btnRun = new System.Windows.Forms.Button();
			this.tbxResult = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblCharNr
			// 
			this.lblCharNr.AutoSize = true;
			this.lblCharNr.Location = new System.Drawing.Point(28, 31);
			this.lblCharNr.Name = "lblCharNr";
			this.lblCharNr.Size = new System.Drawing.Size(46, 13);
			this.lblCharNr.TabIndex = 0;
			this.lblCharNr.Text = "Char Nr:";
			// 
			// tbxCharNr
			// 
			this.tbxCharNr.Location = new System.Drawing.Point(110, 23);
			this.tbxCharNr.Name = "tbxCharNr";
			this.tbxCharNr.Size = new System.Drawing.Size(100, 20);
			this.tbxCharNr.TabIndex = 1;
			// 
			// lblResult
			// 
			this.lblResult.AutoSize = true;
			this.lblResult.Location = new System.Drawing.Point(28, 110);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(37, 13);
			this.lblResult.TabIndex = 2;
			this.lblResult.Text = "Result";
			// 
			// btnRun
			// 
			this.btnRun.Location = new System.Drawing.Point(110, 155);
			this.btnRun.Name = "btnRun";
			this.btnRun.Size = new System.Drawing.Size(75, 23);
			this.btnRun.TabIndex = 3;
			this.btnRun.Text = "Kör";
			this.btnRun.UseVisualStyleBackColor = true;
			this.btnRun.Click += new System.EventHandler(this.BtnRun_Click);
			// 
			// tbxResult
			// 
			this.tbxResult.Location = new System.Drawing.Point(110, 103);
			this.tbxResult.Name = "tbxResult";
			this.tbxResult.Size = new System.Drawing.Size(100, 20);
			this.tbxResult.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(402, 347);
			this.Controls.Add(this.tbxResult);
			this.Controls.Add(this.btnRun);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.tbxCharNr);
			this.Controls.Add(this.lblCharNr);
			this.Name = "Form1";
			this.Text = "Övning 3.2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblCharNr;
		private System.Windows.Forms.TextBox tbxCharNr;
		private System.Windows.Forms.Label lblResult;
		private System.Windows.Forms.Button btnRun;
		private System.Windows.Forms.TextBox tbxResult;
	}
}

