using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tailbass_Lighting_Control
{
	public partial class Settings : Form
	{
		public Settings()
		{
			InitializeComponent();
		}

		private void Settings_Load(object sender, EventArgs e)
		{
			//Load All Settings from Application
			AutoLoadPrevShowFileCheckBox.Checked = Properties.Settings.Default.AutoLoadPreviousShowFile;
			CurrentShowFile.Text = Properties.Settings.Default.PreviousShowFile;
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.AutoLoadPreviousShowFile = AutoLoadPrevShowFileCheckBox.Checked;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.Save();
		}
	}
}
