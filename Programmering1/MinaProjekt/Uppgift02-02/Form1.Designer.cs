namespace Uppgift02_02
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
			this.BtnLeft = new System.Windows.Forms.Button();
			this.BtnRight = new System.Windows.Forms.Button();
			this.LblMove = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// BtnLeft
			// 
			this.BtnLeft.Location = new System.Drawing.Point(42, 64);
			this.BtnLeft.Name = "BtnLeft";
			this.BtnLeft.Size = new System.Drawing.Size(75, 23);
			this.BtnLeft.TabIndex = 0;
			this.BtnLeft.Text = "Vänster";
			this.BtnLeft.UseVisualStyleBackColor = true;
			this.BtnLeft.Click += new System.EventHandler(this.BtnLeft_Click);
			// 
			// BtnRight
			// 
			this.BtnRight.Location = new System.Drawing.Point(168, 63);
			this.BtnRight.Name = "BtnRight";
			this.BtnRight.Size = new System.Drawing.Size(75, 23);
			this.BtnRight.TabIndex = 1;
			this.BtnRight.Text = "Höger";
			this.BtnRight.UseVisualStyleBackColor = true;
			this.BtnRight.Click += new System.EventHandler(this.BtnRight_Click);
			// 
			// LblMove
			// 
			this.LblMove.AutoSize = true;
			this.LblMove.Location = new System.Drawing.Point(94, 125);
			this.LblMove.Name = "LblMove";
			this.LblMove.Size = new System.Drawing.Size(95, 13);
			this.LblMove.TabIndex = 2;
			this.LblMove.Text = "Vänster eller höger";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.LblMove);
			this.Controls.Add(this.BtnRight);
			this.Controls.Add(this.BtnLeft);
			this.Name = "Form1";
			this.Text = "Uppgift";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnLeft;
		private System.Windows.Forms.Button BtnRight;
		private System.Windows.Forms.Label LblMove;
	}
}

