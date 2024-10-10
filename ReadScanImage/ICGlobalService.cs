namespace ReadScanImage
{
	public interface ICGlobalService
	{
		void WriteHistoryLog(string folderName, string fileName, string action, string value);
		void WriteErrorLog(Exception ex);
		bool IsEmptyString(string input);
	}
}
