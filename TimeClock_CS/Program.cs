using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace TimeClock_CS
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] comparams)
		{
			// If there's a command-line parameter, assume it's a path to a document - open that document (used for editing the text files associated with this program)
			if (comparams.Length > 0)
			{
				string filename = comparams[0];
				Process p = new Process();
				p.StartInfo.FileName = filename;
				p.Start();
			}
			else
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new frmMain());
			}
		}
	}
}
