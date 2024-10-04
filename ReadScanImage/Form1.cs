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

		private void btnChooseImage_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog openFileDialog = new OpenFileDialog())
			{
				openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

				if (openFileDialog.ShowDialog() == DialogResult.OK)
				{
					var imagePath = openFileDialog.FileName;
					ExtractTextFromImage(imagePath);
				}
			}
		}

		private void ExtractTextFromImage(string imagePath)
		{
			try
			{
				var tessdataPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tessdata");

				using (var engine = new TesseractEngine(tessdataPath, "eng", 	EngineMode.Default))
				{
					using (var img = Pix.LoadFromFile(imagePath))
					{
						using (var page = engine.Process(img))
						{
							var text = page.GetText();
							tbPlainText.Text = text;
						}
					}
				}
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
	}
}