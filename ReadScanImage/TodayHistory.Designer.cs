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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TodayHistory));
			panel1 = new Panel();
			panel5 = new Panel();
			btnExport = new Button();
			panel4 = new Panel();
			btnClear = new Button();
			panel3 = new Panel();
			btnCopyText = new Button();
			panel2 = new Panel();
			rtbHistory = new RichTextBox();
			pbLoading = new ProgressBar();
			panel1.SuspendLayout();
			panel5.SuspendLayout();
			panel4.SuspendLayout();
			panel3.SuspendLayout();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(pbLoading);
			panel1.Controls.Add(panel5);
			panel1.Controls.Add(panel4);
			panel1.Controls.Add(panel3);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(800, 45);
			panel1.TabIndex = 0;
			// 
			// panel5
			// 
			panel5.AutoSize = true;
			panel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			panel5.Controls.Add(btnExport);
			panel5.Dock = DockStyle.Left;
			panel5.Location = new Point(329, 0);
			panel5.Name = "panel5";
			panel5.Size = new Size(118, 45);
			panel5.TabIndex = 6;
			// 
			// btnExport
			// 
			btnExport.AutoSize = true;
			btnExport.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			btnExport.BackColor = SystemColors.GradientInactiveCaption;
			btnExport.FlatStyle = FlatStyle.Popup;
			btnExport.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnExport.Location = new Point(6, 7);
			btnExport.Name = "btnExport";
			btnExport.Size = new Size(109, 32);
			btnExport.TabIndex = 3;
			btnExport.Text = "Export txt";
			btnExport.UseVisualStyleBackColor = false;
			btnExport.Click += btnExport_Click;
			// 
			// panel4
			// 
			panel4.AutoSize = true;
			panel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			panel4.Controls.Add(btnClear);
			panel4.Dock = DockStyle.Left;
			panel4.Location = new Point(117, 0);
			panel4.Name = "panel4";
			panel4.Size = new Size(212, 45);
			panel4.TabIndex = 5;
			// 
			// btnClear
			// 
			btnClear.AutoSize = true;
			btnClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			btnClear.BackColor = SystemColors.GradientInactiveCaption;
			btnClear.FlatStyle = FlatStyle.Popup;
			btnClear.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnClear.Location = new Point(6, 7);
			btnClear.Name = "btnClear";
			btnClear.Size = new Size(203, 32);
			btnClear.TabIndex = 3;
			btnClear.Text = "Clear today's history";
			btnClear.UseVisualStyleBackColor = false;
			btnClear.Click += btnClear_Click;
			// 
			// panel3
			// 
			panel3.AutoSize = true;
			panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			panel3.Controls.Add(btnCopyText);
			panel3.Dock = DockStyle.Left;
			panel3.Location = new Point(0, 0);
			panel3.Name = "panel3";
			panel3.Size = new Size(117, 45);
			panel3.TabIndex = 4;
			// 
			// btnCopyText
			// 
			btnCopyText.AutoSize = true;
			btnCopyText.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			btnCopyText.BackColor = SystemColors.GradientInactiveCaption;
			btnCopyText.FlatStyle = FlatStyle.Popup;
			btnCopyText.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnCopyText.Location = new Point(9, 7);
			btnCopyText.Name = "btnCopyText";
			btnCopyText.Size = new Size(105, 32);
			btnCopyText.TabIndex = 2;
			btnCopyText.Text = "Copy text";
			btnCopyText.UseVisualStyleBackColor = false;
			btnCopyText.Click += btnCopyText_Click;
			// 
			// panel2
			// 
			panel2.Controls.Add(rtbHistory);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(0, 45);
			panel2.Name = "panel2";
			panel2.Size = new Size(800, 375);
			panel2.TabIndex = 2;
			// 
			// rtbHistory
			// 
			rtbHistory.Dock = DockStyle.Fill;
			rtbHistory.Location = new Point(0, 0);
			rtbHistory.Name = "rtbHistory";
			rtbHistory.ReadOnly = true;
			rtbHistory.Size = new Size(800, 375);
			rtbHistory.TabIndex = 0;
			rtbHistory.Text = "";
			// 
			// pbLoading
			// 
			pbLoading.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			pbLoading.Location = new Point(601, 12);
			pbLoading.Name = "pbLoading";
			pbLoading.Size = new Size(187, 23);
			pbLoading.TabIndex = 7;
			pbLoading.Visible = false;
			// 
			// TodayHistory
			// 
			AutoScaleDimensions = new SizeF(10F, 22F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 420);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "TodayHistory";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Today's History";
			Load += TodayHistory_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel5.ResumeLayout(false);
			panel5.PerformLayout();
			panel4.ResumeLayout(false);
			panel4.PerformLayout();
			panel3.ResumeLayout(false);
			panel3.PerformLayout();
			panel2.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Button btnCopyText;
		private Panel panel2;
		private Button btnClear;
		private RichTextBox rtbHistory;
		private Panel panel4;
		private Panel panel3;
		private Panel panel5;
		private Button btnExport;
		private ProgressBar pbLoading;
	}
}