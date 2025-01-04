namespace Exempel07_01
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
			this.LblTal = new System.Windows.Forms.Label();
			this.LblStorreAnNoll = new System.Windows.Forms.Label();
			this.TbxTal = new System.Windows.Forms.TextBox();
			this.LblResultat = new System.Windows.Forms.Label();
			this.BtnOk = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LblTal
			// 
			this.LblTal.AutoSize = true;
			this.LblTal.Location = new System.Drawing.Point(32, 33);
			this.LblTal.Name = "LblTal";
			this.LblTal.Size = new System.Drawing.Size(38, 20);
			this.LblTal.TabIndex = 0;
			this.LblTal.Text = "Tal:";
			// 
			// LblStorreAnNoll
			// 
			this.LblStorreAnNoll.AutoSize = true;
			this.LblStorreAnNoll.Location = new System.Drawing.Point(32, 95);
			this.LblStorreAnNoll.Name = "LblStorreAnNoll";
			this.LblStorreAnNoll.Size = new System.Drawing.Size(92, 16);
			this.LblStorreAnNoll.TabIndex = 1;
			this.LblStorreAnNoll.Text = "Större än noll?";
			// 
			// TbxTal
			// 
			this.TbxTal.Location = new System.Drawing.Point(149, 30);
			this.TbxTal.Name = "TbxTal";
			this.TbxTal.Size = new System.Drawing.Size(100, 22);
			this.TbxTal.TabIndex = 2;
			this.TbxTal.TextChanged += new System.EventHandler(this.TbxTal_TextChanged);
			// 
			// LblResultat
			// 
			this.LblResultat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.LblResultat.CausesValidation = false;
			this.LblResultat.Location = new System.Drawing.Point(146, 95);
			this.LblResultat.Name = "LblResultat";
			this.LblResultat.Size = new System.Drawing.Size(125, 29);
			this.LblResultat.TabIndex = 3;
			this.LblResultat.Text = "label1";
			this.LblResultat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// BtnOk
			// 
			this.BtnOk.Location = new System.Drawing.Point(98, 177);
			this.BtnOk.Name = "BtnOk";
			this.BtnOk.Size = new System.Drawing.Size(90, 35);
			this.BtnOk.TabIndex = 4;
			this.BtnOk.Text = "OK";
			this.BtnOk.UseVisualStyleBackColor = true;
			this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(640, 360);
			this.Controls.Add(this.BtnOk);
			this.Controls.Add(this.LblResultat);
			this.Controls.Add(this.TbxTal);
			this.Controls.Add(this.LblStorreAnNoll);
			this.Controls.Add(this.LblTal);
			this.Name = "Form1";
			this.Text = "Exempel";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LblTal;
		private System.Windows.Forms.Label LblStorreAnNoll;
		private System.Windows.Forms.TextBox TbxTal;
		private System.Windows.Forms.Label LblResultat;
		private System.Windows.Forms.Button BtnOk;
	}
}

