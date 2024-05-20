using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.IO;
using wpfui;
namespace Merged
{
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void LaunchProject1Button_Click(object sender, RoutedEventArgs e)
		{ 
			wpfui.MainWindow mainWindow = new wpfui.MainWindow();

			mainWindow.Show(); 
		}

		private void LaunchProject2Button_Click(object sender, RoutedEventArgs e)
		{
			StartProject(@"C:\General\Facultate\ISS\Merged\UBB-SE-2024-83X\wildcats\ISS Wildcats\bin\Debug\net8.0-windows\ISS Wildcats.exe");
		}

		private void StartProject(string projectPath)
		{
			try
			{
				if (!File.Exists(projectPath))
				{
					MessageBox.Show($"The file '{projectPath}' does not exist.", "File Not Found", MessageBoxButton.OK, MessageBoxImage.Error);
					return;
				}

				ProcessStartInfo startInfo = new ProcessStartInfo
				{
					FileName = projectPath,
					UseShellExecute = false,
					RedirectStandardOutput = true,
					RedirectStandardError = true
				};

				using (Process process = new Process { StartInfo = startInfo })
				{
					process.OutputDataReceived += (sender, e) =>
					{
						if (!string.IsNullOrEmpty(e.Data))
						{
							Console.WriteLine($"Output: {e.Data}");
						}
					};
					process.ErrorDataReceived += (sender, e) =>
					{
						if (!string.IsNullOrEmpty(e.Data))
						{
							Console.WriteLine($"Error: {e.Data}");
						}
					};

					process.Start();
					process.BeginOutputReadLine();
					process.BeginErrorReadLine();
					process.WaitForExit();

					int exitCode = process.ExitCode;
					if (exitCode != 0)
					{
						MessageBox.Show($"Project exited with code: {exitCode}", "Process Exit Code", MessageBoxButton.OK, MessageBoxImage.Information);
					}
				}
			}
			catch (Win32Exception win32Ex)
			{
				MessageBox.Show($"Win32 error while trying to start the project: {win32Ex.Message}", "Win32 Error", MessageBoxButton.OK, MessageBoxImage.Error);
			}
			catch (Exception ex)
			{
				string errorMessage = $"Failed to start project: {ex.Message}\n\n";
				if (ex.InnerException != null)
				{
					errorMessage += $"Inner Exception: {ex.InnerException.Message}\n\n";
				}
				errorMessage += $"Stack Trace:\n{ex.StackTrace}";
				MessageBox.Show(errorMessage, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
			}
		}
	}
}
