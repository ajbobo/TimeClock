using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace TimeClock_CS
{
	public partial class frmMain : Form
	{
		private enum ButtonState
		{
			Active,
			Inactive,
			Pressed
		}

		public frmMain()
		{
			InitializeComponent();

			PopulateLabelList();
			cboLabel.SelectedIndex = 0;

			SetButtonImage(btnIn, ButtonState.Inactive);
			SetButtonImage(btnOut, ButtonState.Inactive);
		}

		private void btn_Enter(object sender, EventArgs e)
		{
			SetButtonImage((Button)sender, ButtonState.Active);
		}

		private void btn_Leave(object sender, EventArgs e)
		{
			SetButtonImage((Button)sender, ButtonState.Inactive);
		}

		private void btn_Down(object sender, MouseEventArgs e)
		{
			SetButtonImage((Button)sender, ButtonState.Pressed);
		}

		private void btn_Up(object sender, MouseEventArgs e)
		{
			SetButtonImage((Button)sender, ButtonState.Active);
		}

		private void btn_Click(object sender, EventArgs e)
		{
			if ((Button)sender == btnIn)
				WriteToFile("IN");
			else
				WriteToFile("OUT");
		}

		private void timerUpdateDisplay_Tick(object sender, EventArgs e)
		{
			DateTime now = DateTime.Now;
			lblTime.Text = now.ToShortDateString() + " " + now.Hour + ":" + now.Minute.ToString("D2");
		}

		private void PopulateLabelList()
		{
			string userdir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			FileInfo labelfile = new FileInfo(userdir + "\\TimeClockLabels.txt");
			if (!labelfile.Exists)
				return;

			StreamReader reader = labelfile.OpenText();

			string label = reader.ReadLine();
			while (label != null)
			{
				cboLabel.Items.Add(label);
				label = reader.ReadLine();
			}

			reader.Close();
		}

		private void SetButtonImage(Button button, ButtonState state)
		{
			int offset = (button == btnIn ? 0 : 3);
			button.Image = imgButtons.Images[offset + (int)state];
			button.BackColor = SystemColors.Control;
		}

		private void WriteToFile(string direction)
		{
			// Open the file for writing
			string userdir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			string filepath = userdir + "\\TimeClock.csv";
			bool needheader = (File.Exists(filepath) ? false : true);
			StreamWriter writer = new StreamWriter(filepath, true); // true = append to the end

			// Write the headers if needed
			if (needheader)
				writer.WriteLine("Date,Time,In/Out,Label");

			// Write the time information
			DateTime now = DateTime.Now;
			writer.Write(now.ToShortDateString() + ",");
			writer.Write(now.Hour + ":" + now.Minute.ToString("D2") + ",");
			writer.Write(direction + ",");
			if (direction == "IN")
				writer.WriteLine(cboLabel.Text);
			else
				writer.WriteLine("");

			writer.Close();
		}

	}
}
