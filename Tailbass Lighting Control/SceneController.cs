using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace Tailbass_Lighting_Control
{
	public partial class SceneController : Form
	{

		public static string ShowFile = "";
		public static bool DisplayOnClick = false;
		public static string WriteSceneString = "";
		public static string CurrentFile = "";

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

				//Uh Reload the file!
				SceneListView.Items.Clear();

				int linecount = 0;
				foreach (string line in System.IO.File.ReadLines(ShowFile))
				{
					linecount++;
					if (line.Split(",").First() == "[Scene]")
					{
						string[] parts = line.Split(",");

						ListViewItem lvi = new ListViewItem(parts[2]);
						lvi.SubItems.Add(parts[1]);
						int fuckmeaddallthetings = 3;

						while (fuckmeaddallthetings < 31)
						{
							lvi.SubItems.Add(parts[fuckmeaddallthetings]);
							fuckmeaddallthetings++;
						}

						SceneListView.Items.Add(lvi);


					}
					else
					{
						//Do nothing. For now!
					}
				}
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
					fs.WriteLine("TailBass Lighting Control Scenes File! OwO \n");
				}

				ShowFileLoaderPanel.Visible = false;

				UpdateText.Text = "Show File Created ";
				ShowFileStatus.Text = "Show File: " + ShowFile;
			}
		}


		private void SceneController_Load(object sender, EventArgs e)
		{

		}

		private void SaveCurrentSceneButton_Click(object sender, EventArgs e)
		{
			//Create String for file.

			//Fetch all colours and modes.

			// Line Layout:
			// uid, global_toggle, global_mode, global_colour1, global_colour2
			// lasers_toggle,lasers_mode,col1,col2
			// etc etc for all lights.


			string ReadShowFile = File.ReadAllText(ShowFile);

			Random rnd = new Random();
			//chances of this number being the same? very low!
			string UID = rnd.Next(1000000, 9999999).ToString();


			//Build the string for the file
			StringBuilder sb = new StringBuilder();

			//add existing file
			sb.Append(ReadShowFile);

			//append global mode:
			sb.Append("[Scene],");
			sb.Append(UID);
			sb.Append(",");
			if(SceneNameTextbox.Text.Length > 0)
			{
				sb.Append(SceneNameTextbox.Text);
				SceneNameTextbox.Clear();
			}
			else
			{
				sb.Append("Scene " + UID);
			}
			sb.Append(",");
			sb.Append(Convert.ToInt16(MainUI.GlobalMode));
			sb.Append(",");
			sb.Append(MainUI.GlobalPattern);
			sb.Append(",");
			sb.Append(MainUI.GlobalColour1);
			sb.Append(",");
			sb.Append(MainUI.GlobalColour2);

			//append lasers:
			sb.Append(",");
			sb.Append(Convert.ToInt16(MainUI.LasersToggle));
			sb.Append(",");
			sb.Append(MainUI.LasersPattern);
			sb.Append(",");
			sb.Append(MainUI.LasersColour1);
			sb.Append(",");
			sb.Append(MainUI.LasersColour2);

			//append back lights:
			sb.Append(",");
			sb.Append(Convert.ToInt16(MainUI.BacklightsToggle));
			sb.Append(",");
			sb.Append(MainUI.BackLightsPattern);
			sb.Append(",");
			sb.Append(MainUI.BacklightsColour1);
			sb.Append(",");
			sb.Append(MainUI.BacklightsColour2);

			//append top lights:
			sb.Append(",");
			sb.Append(Convert.ToInt16(MainUI.ToplightsToggle));
			sb.Append(",");
			sb.Append(MainUI.TopLightsPattern);
			sb.Append(",");
			sb.Append(MainUI.ToplightsColour1);
			sb.Append(",");
			sb.Append(MainUI.ToplightsColour2);

			//append left lights:
			sb.Append(",");
			sb.Append(Convert.ToInt16(MainUI.LeftlightsToggle));
			sb.Append(",");
			sb.Append(MainUI.LeftLightsPattern);
			sb.Append(",");
			sb.Append(MainUI.LeftlightsColour1);
			sb.Append(",");
			sb.Append(MainUI.LeftlightsColour2);

			//append right lights:
			sb.Append(",");
			sb.Append(Convert.ToInt16(MainUI.RightlightsToggle));
			sb.Append(",");
			sb.Append(MainUI.RightLightsPattern);
			sb.Append(",");
			sb.Append(MainUI.RightlightsColour1);
			sb.Append(",");
			sb.Append(MainUI.RightlightsColour2);

			//append booth lights:
			sb.Append(",");
			sb.Append(Convert.ToInt16(MainUI.BoothlightsToggle));
			sb.Append(",");
			sb.Append(MainUI.BoothLightsPattern);
			sb.Append(",");
			sb.Append(MainUI.BoothlightsColour1);
			sb.Append(",");
			sb.Append(MainUI.BoothlightsColour2);
			sb.Append("\n");

			File.WriteAllText(ShowFile, sb.ToString());

			Debug.WriteLine("File Written!");
			Debug.WriteLine("Reloading File!");
			//LoadShowFile(); 

			//Uh Reload the file!
			SceneListView.Items.Clear();

			int linecount = 0;
			foreach (string line in System.IO.File.ReadLines(ShowFile))
			{
				linecount++;
				if (line.Split(",").First() == "[Scene]")
				{
					string[] parts = line.Split(",");

					ListViewItem lvi = new ListViewItem(parts[2]);
					lvi.SubItems.Add(parts[1]);
					int fuckmeaddallthetings = 3;

					while(fuckmeaddallthetings < 31)
					{
						lvi.SubItems.Add(parts[fuckmeaddallthetings]);
						fuckmeaddallthetings++;
					}

					SceneListView.Items.Add(lvi);


				}
				else
				{
					//Do nothing. For now!
				}
			}
		}

		public static bool LoadShowFile()
		{
			
			return true;
		}

		private void SceneListView_ItemActivate(object sender, EventArgs e)
		{

			MainUI.GlobalMode = Convert.ToBoolean(Convert.ToInt16(SceneListView.SelectedItems[0].SubItems[2].Text));
			MainUI.GlobalPattern = Convert.ToInt32(SceneListView.SelectedItems[0].SubItems[3].Text);
			MainUI.GlobalColour1 = Convert.ToInt32(SceneListView.SelectedItems[0].SubItems[4].Text);
			MainUI.GlobalColour2 = Convert.ToInt32(SceneListView.SelectedItems[0].SubItems[5].Text);

			MainUI.LasersToggle = Convert.ToBoolean(Convert.ToInt16(SceneListView.SelectedItems[0].SubItems[6].Text));
			MainUI.LasersPattern = Convert.ToInt32(SceneListView.SelectedItems[0].SubItems[7].Text);
			MainUI.LasersColour1 = Convert.ToInt32(SceneListView.SelectedItems[0].SubItems[8].Text);
			MainUI.LasersColour2 = Convert.ToInt32(SceneListView.SelectedItems[0].SubItems[9].Text);

			MainUI.BacklightsToggle = Convert.ToBoolean(Convert.ToInt16(SceneListView.SelectedItems[0].SubItems[10].Text));
			MainUI.BackLightsPattern = Convert.ToInt32(SceneListView.SelectedItems[0].SubItems[11].Text);
			MainUI.BacklightsColour1 = Convert.ToInt32(SceneListView.SelectedItems[0].SubItems[12].Text);
			MainUI.BacklightsColour2 = Convert.ToInt32(SceneListView.SelectedItems[0].SubItems[13].Text);

			MainUI.ToplightsToggle = Convert.ToBoolean(Convert.ToInt16(SceneListView.SelectedItems[0].SubItems[14].Text));
			MainUI.TopLightsPattern = Convert.ToInt32(SceneListView.SelectedItems[0].SubItems[15].Text);
			MainUI.ToplightsColour1 = Convert.ToInt32(SceneListView.SelectedItems[0].SubItems[16].Text);
			MainUI.ToplightsColour2 = Convert.ToInt32(SceneListView.SelectedItems[0].SubItems[17].Text);

			MainUI.LeftlightsToggle = Convert.ToBoolean(Convert.ToInt16(SceneListView.SelectedItems[0].SubItems[18].Text));
			MainUI.LeftLightsPattern = Convert.ToInt32(SceneListView.SelectedItems[0].SubItems[19].Text);
			MainUI.LeftlightsColour1 = Convert.ToInt32(SceneListView.SelectedItems[0].SubItems[20].Text);
			MainUI.LeftlightsColour2 = Convert.ToInt32(SceneListView.SelectedItems[0].SubItems[21].Text);

			MainUI.RightlightsToggle = Convert.ToBoolean(Convert.ToInt16(SceneListView.SelectedItems[0].SubItems[22].Text));
			MainUI.RightLightsPattern = Convert.ToInt32(SceneListView.SelectedItems[0].SubItems[23].Text);
			MainUI.RightlightsColour1 = Convert.ToInt32(SceneListView.SelectedItems[0].SubItems[24].Text);
			MainUI.RightlightsColour2 = Convert.ToInt32(SceneListView.SelectedItems[0].SubItems[25].Text);

			MainUI.BoothlightsToggle = Convert.ToBoolean(Convert.ToInt16(SceneListView.SelectedItems[0].SubItems[26].Text));
			MainUI.BoothLightsPattern = Convert.ToInt32(SceneListView.SelectedItems[0].SubItems[27].Text);
			MainUI.BoothlightsColour1 = Convert.ToInt32(SceneListView.SelectedItems[0].SubItems[28].Text);
			MainUI.BoothlightsColour2 = Convert.ToInt32(SceneListView.SelectedItems[0].SubItems[29].Text);


			//Refresh Main Clock to refresh Main UI 
			MainUI.RefreshColoursFromRAM = true;
		}

		
	}
}
