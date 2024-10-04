using Tesseract;
using static System.Net.Mime.MediaTypeNames;

namespace ReadScanImage
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
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
									WriteHistoryLog("Log", "HistoryLog", message, plainText);
								}
								catch { }

								return plainText; 
							}
						}
					}
				});

				tbPlainText.Text = text;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
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
			MessageBox.Show(this, "Clear successed", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		public void WriteHistoryLog(string folderName, string fileName, string action, string value)
		{
			var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
			var folderPath = Path.Combine(baseDirectory, folderName);
			var dateSuffix = DateTime.Now.ToString("ddMMyyyy");
			var logFileName = string.Format("{0}_{1}.txt", fileName, dateSuffix);
			var logFilePath = Path.Combine(folderPath, logFileName);
			var logEntry = string.Format("[{0}{1}Action Date: {2:dd/MM/yyyy HH:mm:ss.fff}]", action, Environment.NewLine, DateTime.Now);
			logEntry += Environment.NewLine + value + Environment.NewLine;

			try
			{
				if (!Directory.Exists(folderPath)) Directory.CreateDirectory(folderPath);

				File.AppendAllText(logFilePath, logEntry);
			}
			catch { }
		}
	}
}