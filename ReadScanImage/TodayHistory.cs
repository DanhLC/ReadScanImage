using System.Windows.Forms;

namespace ReadScanImage
{
	public partial class TodayHistory : Form
	{
		private readonly ICGlobalService _service;

		public TodayHistory()
		{
			InitializeComponent();
			_service = new CGlobal();
		}

		private async void TodayHistory_Load(object sender, EventArgs e)
		{
			await LoadLogToHistory();
		}

		/// <summary>
		/// Load data from today's history log file (.txt)
		/// </summary>
		/// <returns></returns>
		private async Task LoadLogToHistory()
		{
			try
			{
				var dateSuffix = DateTime.Now.ToString("ddMMyyyy");
				var logFileName = $"HistoryLog_{dateSuffix}.txt";
				var logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log", logFileName);

				if (File.Exists(logFilePath))
				{
					string logContent = File.ReadAllText(logFilePath);
					rtbHistory.Text = logContent;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error reading log: " + ex.Message);
			}
		}

		/// <summary>
		/// Copy text from text box
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnCopyText_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(rtbHistory.Text);
			MessageBox.Show(this, "Copied", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		/// <summary>
		/// Clear data from today's history log file (.txt)
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnClear_Click(object sender, EventArgs e)
		{
			var result = MessageBox.Show("Are you sure you want to clear today's history?", "Confirm Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				try
				{
					var dateSuffix = DateTime.Now.ToString("ddMMyyyy");
					var logFileName = $"HistoryLog_{dateSuffix}.txt";
					var logFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log", logFileName);

					if (File.Exists(logFilePath))
					{
						File.WriteAllText(logFilePath, string.Empty);
						rtbHistory.Text = string.Empty;
					}

					MessageBox.Show("Cleared today's history successfully");
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

		private async void btnExport_Click(object sender, EventArgs e)
		{
			try
			{
				if (_service.IsEmptyString(rtbHistory.Text)) throw new Exception("No history available for export");

				using (var saveFileDialog = new SaveFileDialog())
				{
					saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
					saveFileDialog.DefaultExt = "txt";
					saveFileDialog.AddExtension = true;
					saveFileDialog.Title = "Choose location to export file";
					saveFileDialog.FileName = string.Format("ExportedHistory_{0:ddMMyyyy}_{0:hhMMsss}.txt", DateTime.Now);

					if (saveFileDialog.ShowDialog() == DialogResult.OK)
					{
						pbLoading.Style = ProgressBarStyle.Marquee;
						pbLoading.Visible = true;
						btnCopyText.Enabled = btnClear.Enabled = btnExport.Enabled = false;

						await System.IO.File.WriteAllTextAsync(saveFileDialog.FileName, rtbHistory.Text);

						pbLoading.Visible = false;
						btnCopyText.Enabled = btnClear.Enabled = btnExport.Enabled = true;

						MessageBox.Show("Export successfully!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error reading log: " + ex.Message);
			}
		}
	}
}
