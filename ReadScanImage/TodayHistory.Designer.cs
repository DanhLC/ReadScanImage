namespace ReadScanImage
{
	partial class TodayHistory
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnCopyText = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.tbHistory = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnClear);
			this.panel1.Controls.Add(this.btnCopyText);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 45);
			this.panel1.TabIndex = 0;
			// 
			// btnClear
			// 
			this.btnClear.AutoSize = true;
			this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnClear.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnClear.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnClear.Location = new System.Drawing.Point(96, 12);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(143, 24);
			this.btnClear.TabIndex = 3;
			this.btnClear.Text = "Clear today\'s history";
			this.btnClear.UseVisualStyleBackColor = false;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnCopyText
			// 
			this.btnCopyText.AutoSize = true;
			this.btnCopyText.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnCopyText.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.btnCopyText.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCopyText.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnCopyText.Location = new System.Drawing.Point(12, 12);
			this.btnCopyText.Name = "btnCopyText";
			this.btnCopyText.Size = new System.Drawing.Size(78, 24);
			this.btnCopyText.TabIndex = 2;
			this.btnCopyText.Text = "Copy text";
			this.btnCopyText.UseVisualStyleBackColor = false;
			this.btnCopyText.Click += new System.EventHandler(this.btnCopyText_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.tbHistory);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 45);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(800, 375);
			this.panel2.TabIndex = 2;
			// 
			// tbHistory
			// 
			this.tbHistory.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbHistory.Location = new System.Drawing.Point(0, 0);
			this.tbHistory.Multiline = true;
			this.tbHistory.Name = "tbHistory";
			this.tbHistory.ReadOnly = true;
			this.tbHistory.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tbHistory.Size = new System.Drawing.Size(800, 375);
			this.tbHistory.TabIndex = 0;
			// 
			// TodayHistory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 420);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Name = "TodayHistory";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Today History";
			this.Load += new System.EventHandler(this.TodayHistory_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Panel panel1;
		private Button btnCopyText;
		private Panel panel2;
		private TextBox tbHistory;
		private Button btnClear;
	}
}