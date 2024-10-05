namespace Uppgift03_01
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
			this.lblBas = new System.Windows.Forms.Label();
			this.lblHeight = new System.Windows.Forms.Label();
			this.tbxBase = new System.Windows.Forms.TextBox();
			this.tbxHeight = new System.Windows.Forms.TextBox();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.lblArea = new System.Windows.Forms.Label();
			this.tbxArea = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblBas
			// 
			this.lblBas.AutoSize = true;
			this.lblBas.Location = new System.Drawing.Point(26, 23);
			this.lblBas.Name = "lblBas";
			this.lblBas.Size = new System.Drawing.Size(25, 13);
			this.lblBas.TabIndex = 0;
			this.lblBas.Text = "Bas";
			// 
			// lblHeight
			// 
			this.lblHeight.AutoSize = true;
			this.lblHeight.Location = new System.Drawing.Point(26, 61);
			this.lblHeight.Name = "lblHeight";
			this.lblHeight.Size = new System.Drawing.Size(29, 13);
			this.lblHeight.TabIndex = 1;
			this.lblHeight.Text = "Höjd";
			// 
			// tbxBase
			// 
			this.tbxBase.Location = new System.Drawing.Point(100, 15);
			this.tbxBase.Name = "tbxBase";
			this.tbxBase.Size = new System.Drawing.Size(100, 20);
			this.tbxBase.TabIndex = 2;
			// 
			// tbxHeight
			// 
			this.tbxHeight.Location = new System.Drawing.Point(100, 54);
			this.tbxHeight.Name = "tbxHeight";
			this.tbxHeight.Size = new System.Drawing.Size(100, 20);
			this.tbxHeight.TabIndex = 3;
			// 
			// btnCalculate
			// 
			this.btnCalculate.Location = new System.Drawing.Point(100, 152);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(75, 23);
			this.btnCalculate.TabIndex = 4;
			this.btnCalculate.Text = "Area";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
			// 
			// lblArea
			// 
			this.lblArea.AutoSize = true;
			this.lblArea.Location = new System.Drawing.Point(26, 97);
			this.lblArea.Name = "lblArea";
			this.lblArea.Size = new System.Drawing.Size(32, 13);
			this.lblArea.TabIndex = 5;
			this.lblArea.Text = "Area:";
			// 
			// tbxArea
			// 
			this.tbxArea.Location = new System.Drawing.Point(100, 89);
			this.tbxArea.Name = "tbxArea";
			this.tbxArea.Size = new System.Drawing.Size(100, 20);
			this.tbxArea.TabIndex = 6;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(378, 254);
			this.Controls.Add(this.tbxArea);
			this.Controls.Add(this.lblArea);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.tbxHeight);
			this.Controls.Add(this.tbxBase);
			this.Controls.Add(this.lblHeight);
			this.Controls.Add(this.lblBas);
			this.Name = "Form1";
			this.Text = "Uppgift Area";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblBas;
		private System.Windows.Forms.Label lblHeight;
		private System.Windows.Forms.TextBox tbxBase;
		private System.Windows.Forms.TextBox tbxHeight;
		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.Label lblArea;
		private System.Windows.Forms.TextBox tbxArea;
	}
}

