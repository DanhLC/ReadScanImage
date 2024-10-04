using Tesseract;

namespace ReadScanImage
{
	public partial class Form1 : Form
	{
		private readonly ICGlobalService _cglobalService;

		public Form1(ICGlobalService cglobalService)
		{
			InitializeComponent();
			_cglobalService = cglobalService;
		}

		private async void btnChooseImage_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					var imagePath = openFileDialog.FileName;

					#region Disable & show loading

					pbLoading.Style = ProgressBarStyle.Marquee;
					pbLoading.Visible = true;
					tbPlainText.Enabled = btnChooseImage.Enabled = btnClear.Enabled = btnCopyText.Enabled = btnHistoryLog.Enabled =  false;

					#endregion

					await ExtractTextFromImage(imagePath);

					#region Enable & hide loading

					pbLoading.Visible = false;
					tbPlainText.Enabled = btnChooseImage.Enabled = btnClear.Enabled = btnCopyText.Enabled = btnHistoryLog.Enabled = true;

					#endregion
				}
			}
		}

		private async Task ExtractTextFromImage(string imagePath)
		{
			try
			{
				var tessdataPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tessdata");

				var text = await Task.Run(() =>
				{
					using (var engine = new TesseractEngine(tessdataPath, "eng", EngineMode.Default))
					{
						using (var img = Pix.LoadFromFile(imagePath))
						{
							using (var page = engine.Process(img))
							{
								var plainText = page.GetText();

								try
								{
									var fileName = Path.GetFileName(imagePath);
									var message = string.Format("Action: Extract text to image,{0}File name: {1} ", Environment.NewLine, fileName);
									_cglobalService.WriteHistoryLog("Log", "HistoryLog", message, plainText);
								}
								catch { }

								return plainText; 
							}
						}
					}
				});

				tbPlainText.Text = text;

				MessageBox.Show("Text has been successfully extracted from the image.");
			}
			catch (Exception ex)
			{
				_cglobalService.WriteErrorLog(ex);
				MessageBox.Show(ex.Message);
			}
		}

		private void btnCopyText_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(tbPlainText.Text);
			MessageBox.Show(this, "Copied", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			tbPlainText.Text = string.Empty;
			MessageBox.Show(this, "Cleared successfully", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void btnHistoryLog_Click(object sender, EventArgs e)
		{
			var todayHistory = new TodayHistory();
			todayHistory.ShowDialog();
		}
	}
}