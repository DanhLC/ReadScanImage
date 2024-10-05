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

		private void Form1_Load(object sender, EventArgs e)
		{
			var languages = new string[] { "English", "Japanese" };
			cbLanguages.Items.AddRange(languages);
			cbLanguages.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			cbLanguages.AutoCompleteSource = AutoCompleteSource.ListItems;
			cbLanguages.SelectedIndex = 0;
		}

		/// <summary>
		/// Button choose image on click
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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
					rtbPlainText.Enabled = btnChooseImage.Enabled = btnClear.Enabled = btnCopyText.Enabled = btnHistoryLog.Enabled = cbLanguages.Enabled = false;

					#endregion

					await ExtractTextFromImage(imagePath);

					#region Enable & hide loading

					pbLoading.Visible = false;
					rtbPlainText.Enabled = btnChooseImage.Enabled = btnClear.Enabled = btnCopyText.Enabled = btnHistoryLog.Enabled = cbLanguages.Enabled = true;

					#endregion
				}
			}
		}

		/// <summary>
		/// Extract text from image and write log history
		/// </summary>
		/// <param name="imagePath"></param>
		/// <returns></returns>
		private async Task ExtractTextFromImage(string imagePath)
		{
			try
			{
				// Library: --https://tesseract-ocr.github.io/tessdoc/Data-Files, add more to tessdata
				var tessdataPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tessdata");
				var language = cbLanguages.SelectedItem.ToString();
				var selectedLanguage = language.ToLower() == "english" ? "eng" : "jpn";

				var text = await Task.Run(() =>
				{
					using (var engine = new TesseractEngine(tessdataPath, selectedLanguage, EngineMode.Default))
					{
						using (var img = Pix.LoadFromFile(imagePath))
						{
							using (var page = engine.Process(img))
							{
								var plainText = page.GetText();

								try
								{
									var fileName = Path.GetFileName(imagePath);
									var message = string.Format("Action: Extract text to image,{0}File name: {1},{0}Language: {2} ", Environment.NewLine, fileName, language);
									_cglobalService.WriteHistoryLog("Log", "HistoryLog", message, plainText);
								}
								catch { }

								return plainText;
							}
						}
					}
				});

				rtbPlainText.Text = text;
				MessageBox.Show("Text has been successfully extracted from the image.");
			}
			catch (Exception ex)
			{
				_cglobalService.WriteErrorLog(ex);
				MessageBox.Show(ex.Message);
			}
		}

		/// <summary>
		/// Copy text from text box
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnCopyText_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(rtbPlainText.Text);
			MessageBox.Show(this, "Copied", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		/// <summary>
		/// Clear text from text box
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnClear_Click(object sender, EventArgs e)
		{
			rtbPlainText.Text = string.Empty;
			MessageBox.Show(this, "Cleared successfully", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		/// <summary>
		/// Call pop up today's history log
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnHistoryLog_Click(object sender, EventArgs e)
		{
			var todayHistory = new TodayHistory();
			todayHistory.ShowDialog();
		}
	}
}