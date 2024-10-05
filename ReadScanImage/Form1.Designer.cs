namespace ReadScanImage
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			panel1 = new Panel();
			panel7 = new Panel();
			cbLanguages = new ComboBox();
			panel6 = new Panel();
			btnHistoryLog = new Button();
			panel5 = new Panel();
			btnClear = new Button();
			panel4 = new Panel();
			btnCopyText = new Button();
			panel3 = new Panel();
			btnChooseImage = new Button();
			pbLoading = new ProgressBar();
			panel2 = new Panel();
			rtbPlainText = new RichTextBox();
			panel1.SuspendLayout();
			panel7.SuspendLayout();
			panel6.SuspendLayout();
			panel5.SuspendLayout();
			panel4.SuspendLayout();
			panel3.SuspendLayout();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.Controls.Add(panel7);
			panel1.Controls.Add(panel6);
			panel1.Controls.Add(panel5);
			panel1.Controls.Add(panel4);
			panel1.Controls.Add(panel3);
			panel1.Controls.Add(pbLoading);
			panel1.Dock = DockStyle.Top;
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(831, 44);
			panel1.TabIndex = 0;
			// 
			// panel7
			// 
			panel7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			panel7.Controls.Add(cbLanguages);
			panel7.Dock = DockStyle.Left;
			panel7.Location = new Point(414, 0);
			panel7.Name = "panel7";
			panel7.Size = new Size(133, 44);
			panel7.TabIndex = 10;
			// 
			// cbLanguages
			// 
			cbLanguages.FormattingEnabled = true;
			cbLanguages.Location = new Point(6, 12);
			cbLanguages.Name = "cbLanguages";
			cbLanguages.Size = new Size(121, 22);
			cbLanguages.TabIndex = 5;
			// 
			// panel6
			// 
			panel6.AutoSize = true;
			panel6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			panel6.Controls.Add(btnHistoryLog);
			panel6.Dock = DockStyle.Left;
			panel6.Location = new Point(295, 0);
			panel6.Name = "panel6";
			panel6.Size = new Size(119, 44);
			panel6.TabIndex = 9;
			// 
			// btnHistoryLog
			// 
			btnHistoryLog.AutoSize = true;
			btnHistoryLog.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			btnHistoryLog.BackColor = SystemColors.GradientInactiveCaption;
			btnHistoryLog.FlatStyle = FlatStyle.Popup;
			btnHistoryLog.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnHistoryLog.Location = new Point(6, 10);
			btnHistoryLog.Name = "btnHistoryLog";
			btnHistoryLog.Size = new Size(110, 24);
			btnHistoryLog.TabIndex = 3;
			btnHistoryLog.Text = "Today's history";
			btnHistoryLog.UseVisualStyleBackColor = false;
			btnHistoryLog.Click += btnHistoryLog_Click;
			// 
			// panel5
			// 
			panel5.AutoSize = true;
			panel5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			panel5.Controls.Add(btnClear);
			panel5.Dock = DockStyle.Left;
			panel5.Location = new Point(215, 0);
			panel5.Name = "panel5";
			panel5.Size = new Size(80, 44);
			panel5.TabIndex = 8;
			// 
			// btnClear
			// 
			btnClear.AutoSize = true;
			btnClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			btnClear.BackColor = SystemColors.GradientInactiveCaption;
			btnClear.FlatStyle = FlatStyle.Popup;
			btnClear.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnClear.Location = new Point(0, 10);
			btnClear.Name = "btnClear";
			btnClear.Size = new Size(77, 24);
			btnClear.TabIndex = 3;
			btnClear.Text = "Clear text";
			btnClear.UseVisualStyleBackColor = false;
			btnClear.Click += btnClear_Click;
			// 
			// panel4
			// 
			panel4.AutoSize = true;
			panel4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			panel4.Controls.Add(btnCopyText);
			panel4.Dock = DockStyle.Left;
			panel4.Location = new Point(131, 0);
			panel4.Name = "panel4";
			panel4.Size = new Size(84, 44);
			panel4.TabIndex = 7;
			// 
			// btnCopyText
			// 
			btnCopyText.AutoSize = true;
			btnCopyText.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			btnCopyText.BackColor = SystemColors.GradientInactiveCaption;
			btnCopyText.FlatStyle = FlatStyle.Popup;
			btnCopyText.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnCopyText.Location = new Point(3, 10);
			btnCopyText.Name = "btnCopyText";
			btnCopyText.Size = new Size(78, 24);
			btnCopyText.TabIndex = 2;
			btnCopyText.Text = "Copy text";
			btnCopyText.UseVisualStyleBackColor = false;
			btnCopyText.Click += btnCopyText_Click;
			// 
			// panel3
			// 
			panel3.AutoSize = true;
			panel3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			panel3.Controls.Add(btnChooseImage);
			panel3.Dock = DockStyle.Left;
			panel3.Location = new Point(0, 0);
			panel3.Name = "panel3";
			panel3.Size = new Size(131, 44);
			panel3.TabIndex = 6;
			// 
			// btnChooseImage
			// 
			btnChooseImage.AutoSize = true;
			btnChooseImage.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			btnChooseImage.BackColor = SystemColors.GradientInactiveCaption;
			btnChooseImage.FlatStyle = FlatStyle.Popup;
			btnChooseImage.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnChooseImage.Location = new Point(12, 10);
			btnChooseImage.Name = "btnChooseImage";
			btnChooseImage.Size = new Size(116, 24);
			btnChooseImage.TabIndex = 0;
			btnChooseImage.Text = "Choose Image...";
			btnChooseImage.UseVisualStyleBackColor = false;
			btnChooseImage.Click += btnChooseImage_Click;
			// 
			// pbLoading
			// 
			pbLoading.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			pbLoading.Location = new Point(632, 11);
			pbLoading.Name = "pbLoading";
			pbLoading.Size = new Size(187, 23);
			pbLoading.TabIndex = 4;
			pbLoading.Visible = false;
			// 
			// panel2
			// 
			panel2.Controls.Add(rtbPlainText);
			panel2.Dock = DockStyle.Fill;
			panel2.Location = new Point(0, 44);
			panel2.Name = "panel2";
			panel2.Size = new Size(831, 514);
			panel2.TabIndex = 1;
			// 
			// rtbPlainText
			// 
			rtbPlainText.Dock = DockStyle.Fill;
			rtbPlainText.Location = new Point(0, 0);
			rtbPlainText.Name = "rtbPlainText";
			rtbPlainText.Size = new Size(831, 514);
			rtbPlainText.TabIndex = 0;
			rtbPlainText.Text = "";
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 14F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSizeMode = AutoSizeMode.GrowAndShrink;
			ClientSize = new Size(831, 558);
			Controls.Add(panel2);
			Controls.Add(panel1);
			Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Read Scan Image";
			Load += Form1_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel7.ResumeLayout(false);
			panel6.ResumeLayout(false);
			panel6.PerformLayout();
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
		private Panel panel2;
		private Button btnHistoryLog;
		private ProgressBar pbLoading;
		private RichTextBox rtbPlainText;
		private ComboBox cbLanguages;
		private Panel panel5;
		private Panel panel4;
		private Button btnCopyText;
		private Panel panel3;
		private Button btnChooseImage;
		private Button btnClear;
		private Panel panel7;
		private Panel panel6;
	}
}