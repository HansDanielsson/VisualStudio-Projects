namespace ovning03_09
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
			this.lblX = new System.Windows.Forms.Label();
			this.lblY = new System.Windows.Forms.Label();
			this.tbxX = new System.Windows.Forms.TextBox();
			this.tbxY = new System.Windows.Forms.TextBox();
			this.btnMove = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblX
			// 
			this.lblX.AutoSize = true;
			this.lblX.Location = new System.Drawing.Point(80, 22);
			this.lblX.Name = "lblX";
			this.lblX.Size = new System.Drawing.Size(14, 13);
			this.lblX.TabIndex = 0;
			this.lblX.Text = "X";
			// 
			// lblY
			// 
			this.lblY.AutoSize = true;
			this.lblY.Location = new System.Drawing.Point(186, 22);
			this.lblY.Name = "lblY";
			this.lblY.Size = new System.Drawing.Size(14, 13);
			this.lblY.TabIndex = 1;
			this.lblY.Text = "Y";
			// 
			// tbxX
			// 
			this.tbxX.Location = new System.Drawing.Point(83, 65);
			this.tbxX.Name = "tbxX";
			this.tbxX.Size = new System.Drawing.Size(100, 20);
			this.tbxX.TabIndex = 2;
			// 
			// tbxY
			// 
			this.tbxY.Location = new System.Drawing.Point(189, 65);
			this.tbxY.Name = "tbxY";
			this.tbxY.Size = new System.Drawing.Size(100, 20);
			this.tbxY.TabIndex = 3;
			// 
			// btnMove
			// 
			this.btnMove.Location = new System.Drawing.Point(-7, 125);
			this.btnMove.Name = "btnMove";
			this.btnMove.Size = new System.Drawing.Size(75, 23);
			this.btnMove.TabIndex = 4;
			this.btnMove.Text = "Flytta";
			this.btnMove.UseVisualStyleBackColor = true;
			this.btnMove.Click += new System.EventHandler(this.BtnMove_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(308, 218);
			this.Controls.Add(this.btnMove);
			this.Controls.Add(this.tbxY);
			this.Controls.Add(this.tbxX);
			this.Controls.Add(this.lblY);
			this.Controls.Add(this.lblX);
			this.Name = "Form1";
			this.Text = "Övning";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblX;
		private System.Windows.Forms.Label lblY;
		private System.Windows.Forms.TextBox tbxX;
		private System.Windows.Forms.TextBox tbxY;
		private System.Windows.Forms.Button btnMove;
	}
}

