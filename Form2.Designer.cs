namespace PoisonCup1
{
	partial class Form2
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
			this.lblWinLose = new System.Windows.Forms.Label();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblWinLose
			// 
			this.lblWinLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWinLose.ForeColor = System.Drawing.Color.PaleGreen;
			this.lblWinLose.Location = new System.Drawing.Point(149, 83);
			this.lblWinLose.Name = "lblWinLose";
			this.lblWinLose.Size = new System.Drawing.Size(503, 130);
			this.lblWinLose.TabIndex = 0;
			this.lblWinLose.Text = "YOU WIN!";
			// 
			// btnReset
			// 
			this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReset.ForeColor = System.Drawing.Color.LimeGreen;
			this.btnReset.Location = new System.Drawing.Point(248, 258);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(151, 48);
			this.btnReset.TabIndex = 1;
			this.btnReset.Text = "Play Again";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
			// 
			// btnClose
			// 
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.ForeColor = System.Drawing.Color.LimeGreen;
			this.btnClose.Location = new System.Drawing.Point(414, 258);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(151, 48);
			this.btnClose.TabIndex = 2;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LimeGreen;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.lblWinLose);
			this.Name = "Form2";
			this.Text = "Form2";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblWinLose;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Button btnClose;
	}
}