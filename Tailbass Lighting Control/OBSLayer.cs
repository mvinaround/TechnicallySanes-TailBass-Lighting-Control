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
	public partial class OBSLayer : Form
	{
		public OBSLayer()
		{
			InitializeComponent();
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			RearLeftPixel.BackColor = Color.FromArgb(MainUI.Back1);
			RearRightPixel.BackColor = Color.FromArgb(MainUI.Back2);

			LaserLeftPixel.BackColor = Color.FromArgb(MainUI.Laser1);
			LaserRightPixel.BackColor = Color.FromArgb(MainUI.Laser2);

			Top1Pixel.BackColor = Color.FromArgb(MainUI.Top1);
			Top2Pixel.BackColor = Color.FromArgb(MainUI.Top2);
			Top3Pixel.BackColor = Color.FromArgb(MainUI.Top3);
			Top4Pixel.BackColor = Color.FromArgb(MainUI.Top4);

			Left1Pixel.BackColor = Color.FromArgb(MainUI.Left1);
			Left2Pixel.BackColor = Color.FromArgb(MainUI.Left2);
			Left3Pixel.BackColor = Color.FromArgb(MainUI.Left3);

			Right1Pixel.BackColor = Color.FromArgb(MainUI.Right1);
			Right2Pixel.BackColor = Color.FromArgb(MainUI.Right2);
			Right3Pixel.BackColor = Color.FromArgb(MainUI.Right3);

			BoothLeftPixel.BackColor = Color.FromArgb(MainUI.BoothLeft);
			BoothRightPixel.BackColor = Color.FromArgb(MainUI.BoothRight);

		}

		private void OBSLayer_Load(object sender, EventArgs e)
		{
			TickyTokky.Start();
		}
	}
}
