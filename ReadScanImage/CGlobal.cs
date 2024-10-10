namespace ReadScanImage
{
	public class CGlobal : ICGlobalService
	{
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

		public void WriteErrorLog(Exception ex)
		{
			var errorLogFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ErrorLog");
			var errorLogFileName = string.Format("ErrorLog_{0}.txt", DateTime.Now.ToString("ddMMyyyy"));
			var errorLogFilePath = Path.Combine(errorLogFolder, errorLogFileName);
			var errorLogEntry = string.Format("[Error Date: {0:dd/MM/yyyy HH:mm:ss.fff}]{1}Error Message: {1}{2}{1}Stack Trace: {1}{3}{1}",
				DateTime.Now,
				Environment.NewLine,
				ex.Message,
				ex.StackTrace);

			try
			{
				if (!Directory.Exists(errorLogFolder)) Directory.CreateDirectory(errorLogFolder);

				File.AppendAllText(errorLogFilePath, errorLogEntry);
			}
			catch
			{
			}
		}

		public bool IsEmptyString(string input)
		{
			try {
				return string.IsNullOrWhiteSpace(input) && string.IsNullOrEmpty(input);
			}
			catch {
				return false;
			}
		}
	}
}
