namespace ScrollNumTextbox
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
			this.scrollNumText1 = new System.Windows.Forms.ScrollNumText();
			this.SuspendLayout();
			// 
			// scrollNumText1
			// 
			this.scrollNumText1.Location = new System.Drawing.Point(102, 58);
			this.scrollNumText1.Name = "scrollNumText1";
			this.scrollNumText1.ShortcutsEnabled = false;
			this.scrollNumText1.Size = new System.Drawing.Size(100, 20);
			this.scrollNumText1.TabIndex = 0;
			this.scrollNumText1.Text = "0";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(290, 269);
			this.Controls.Add(this.scrollNumText1);
			this.Name = "Form1";
			this.Text = "Test";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ScrollNumText scrollNumText1;
	}
}

