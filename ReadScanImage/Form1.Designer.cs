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
			this.panel1 = new System.Windows.Forms.Panel();
			this.cbLanguages = new System.Windows.Forms.ComboBox();
			this.pbLoading = new System.Windows.Forms.ProgressBar();
			this.btnHistoryLog = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnCopyText = new System.Windows.Forms.Button();
			this.btnChooseImage = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.rtbPlainText = new System.Windows.Forms.RichTextBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cbLanguages);
			this.panel1.Controls.Add(this.pbLoading);
			this.panel1.Controls.Add(this.btnHistoryLog);
			this.panel1.Controls.Add(this.btnClear);
			this.panel1.Controls.Add(this.btnCopyText);
			this.panel1.Controls.Add(this.btnChooseImage);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 44);
			this.panel1.TabIndex = 0;
			// 
			// cbLanguages
			// 
			this.cbLanguages.FormattingEnabled = true;
			this.cbLanguages.Location = new System.Drawing.Point(417, 11);
			this.cbLanguages.Name = "cbLanguages";
			this.cbLanguages.Size = new System.Drawing.Size(121, 22);
			this.cbLanguages.TabIndex = 5;
			// 
			// pbLoading
			// 
			this.pbLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pbLoading.Location = new System.Drawing.Point(601, 11);
			this.pbLoading.Name = "pbLoading";
			this.pbLoading.Size = new System.Drawing.Size(187, 23);
			this.pbLoading.TabIndex = 4;
			this.pbLoading.Visible = false;
			// 
			// btnHistoryLog
			// 
			this.btnHistoryLog.AutoSize = true;
			this.btnHistoryLog.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnHistoryLog.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.btnHistoryLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnHistoryLog.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnHistoryLog.Location = new System.Drawing.Point(301, 11);
			this.btnHistoryLog.Name = "btnHistoryLog";
			this.btnHistoryLog.Size = new System.Drawing.Size(110, 24);
			this.btnHistoryLog.TabIndex = 3;
			this.btnHistoryLog.Text = "Today\'s history";
			this.btnHistoryLog.UseVisualStyleBackColor = false;
			this.btnHistoryLog.Click += new System.EventHandler(this.btnHistoryLog_Click);
			// 
			// btnClear
			// 
			this.btnClear.AutoSize = true;
			this.btnClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnClear.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnClear.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnClear.Location = new System.Drawing.Point(218, 11);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(77, 24);
			this.btnClear.TabIndex = 2;
			this.btnClear.Text = "Clear text";
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
			this.btnCopyText.Location = new System.Drawing.Point(134, 11);
			this.btnCopyText.Name = "btnCopyText";
			this.btnCopyText.Size = new System.Drawing.Size(78, 24);
			this.btnCopyText.TabIndex = 1;
			this.btnCopyText.Text = "Copy text";
			this.btnCopyText.UseVisualStyleBackColor = false;
			this.btnCopyText.Click += new System.EventHandler(this.btnCopyText_Click);
			// 
			// btnChooseImage
			// 
			this.btnChooseImage.AutoSize = true;
			this.btnChooseImage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.btnChooseImage.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.btnChooseImage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnChooseImage.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btnChooseImage.Location = new System.Drawing.Point(12, 11);
			this.btnChooseImage.Name = "btnChooseImage";
			this.btnChooseImage.Size = new System.Drawing.Size(116, 24);
			this.btnChooseImage.TabIndex = 0;
			this.btnChooseImage.Text = "Choose Image...";
			this.btnChooseImage.UseVisualStyleBackColor = false;
			this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.rtbPlainText);
			this.panel2.Location = new System.Drawing.Point(0, 44);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(800, 376);
			this.panel2.TabIndex = 1;
			// 
			// rtbPlainText
			// 
			this.rtbPlainText.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbPlainText.Location = new System.Drawing.Point(0, 0);
			this.rtbPlainText.Name = "rtbPlainText";
			this.rtbPlainText.Size = new System.Drawing.Size(800, 376);
			this.rtbPlainText.TabIndex = 0;
			this.rtbPlainText.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 420);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Read Scan Image";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Panel panel1;
		private Button btnChooseImage;
		private Button btnCopyText;
		private Panel panel2;
		private Button btnClear;
		private Button btnHistoryLog;
		private ProgressBar pbLoading;
		private RichTextBox rtbPlainText;
		private ComboBox cbLanguages;
	}
}