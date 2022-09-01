using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tailbass_Lighting_Control
{
	public partial class SceneController : Form
	{

		public static string ShowFile = "";
		public static bool DisplayOnClick = false;

		public SceneController()
		{
			InitializeComponent();
		}

		private void SelectShowFile_Click(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
		}

		private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
			if(openFileDialog1.FileName.Length > 0)
			{
				ShowFile = openFileDialog1.FileName.ToString();
				UpdateText.Text = "Show File Loaded!";
				ShowFileStatus.Text = "Show File: " + ShowFile;

				ShowFileLoaderPanel.Visible = false;
			}
		}

		private void CreateShowFile_Click(object sender, EventArgs e)
		{
			saveFileDialog1.ShowDialog();
		}

		private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
			if (saveFileDialog1.FileName.Length > 0)
			{
				ShowFile = saveFileDialog1.FileName.ToString();

				using(StreamWriter fs = File.CreateText(saveFileDialog1.FileName))
				{
					fs.WriteLine("TailBass Lighting Control Scenes File! OwO");
				}

				ShowFileLoaderPanel.Visible = false;

				UpdateText.Text = "Show File Created ";
				ShowFileStatus.Text = "Show File: " + ShowFile;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (DisplayOnClick)
			{
				DisplayOnClickToggle.ForeColor = Color.Red;
				DisplayOnClickToggle.Text = "Output On Click - Disabled";
				DisplayOnClick = false;
			}
			else
			{
				DisplayOnClickToggle.ForeColor = Color.LimeGreen;
				DisplayOnClickToggle.Text = "Output On Click - Enabled";
				DisplayOnClick = true;
			}
		}

		private void SceneController_Load(object sender, EventArgs e)
		{

		}
	}
}
