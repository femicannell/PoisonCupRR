namespace PoisonCup1
{
	partial class Form3
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
			this.btnReset = new System.Windows.Forms.Button();
			this.lblLose = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnReset
			// 
			this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReset.ForeColor = System.Drawing.Color.Red;
			this.btnReset.Location = new System.Drawing.Point(311, 289);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(151, 48);
			this.btnReset.TabIndex = 3;
			this.btnReset.Text = "Play Again";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
			// 
			// lblLose
			// 
			this.lblLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblLose.ForeColor = System.Drawing.Color.LightSalmon;
			this.lblLose.Location = new System.Drawing.Point(127, 103);
			this.lblLose.Name = "lblLose";
			this.lblLose.Size = new System.Drawing.Size(572, 130);
			this.lblLose.TabIndex = 2;
			this.lblLose.Text = "YOU LOSE!";
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Red;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.lblLose);
			this.Name = "Form3";
			this.Text = "Form3";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.Label lblLose;
	}
}