namespace ReadScanImage
{
	public partial class TodayHistory : Form
	{
		public TodayHistory()
		{
			InitializeComponent();
		}

		private async void TodayHistory_Load(object sender, EventArgs e)
		{
			await LoadLogToHistory();
		}

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
					tbHistory.Text = logContent;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error reading log: " + ex.Message);
			}
		}

		private void btnCopyText_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(tbHistory.Text);
			MessageBox.Show(this, "Copied", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

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
						tbHistory.Text = string.Empty;
					}

					MessageBox.Show("Cleared today's history successfully");
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}
	}
}
