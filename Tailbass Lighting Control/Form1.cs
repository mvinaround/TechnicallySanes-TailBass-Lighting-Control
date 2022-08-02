using System;
using System.Diagnostics;
using System.Threading;



namespace Tailbass_Lighting_Control
{

	public partial class MainUI : Form
	{
		

		public static bool BPMStopwatchActive;
		public static Int64 BPMTimeInMS = 420;
		public static double BPMReadable = 0.0;
		public static bool ticktock = false;
		public static bool StrobeClockTok = false;
		public static bool StrobeActive = false;
		public static int BeatNo = 1;
		public static bool PatternEngineBPMPushColours = true;

		//Global colours?
		public static bool GlobalMode = false;
		public static string GlobalColour1 = "000000000";
		public static string GlobalColour2 = "000000000";

		//Light Toggles
		public static bool LasersToggle = false;
		public static bool BacklightsToggle = false;
		public static bool ToplightsToggle = false;
		public static bool LeftlightsToggle = false;
		public static bool RightlightsToggle = false;
		public static bool BoothlightsToggle = false;

		//Colour Vars
		public static string LasersColour1 = "000000000";
		public static string LasersColour2 = "000000000";
		public static string BacklightsColour1 = "000000000";
		public static string BacklightsColour2 = "000000000";
		public static string ToplightsColour1 = "000000000";
		public static string ToplightsColour2 = "000000000";
		public static string LeftlightsColour1 = "000000000";
		public static string LeftlightsColour2 = "000000000";
		public static string RightlightsColour1 = "000000000";
		public static string RightlightsColour2 = "000000000";
		public static string BoothlightsColour1 = "000000000";
		public static string BoothlightsColour2 = "000000000";

		//LightOutput
		public static Int32 Laser1 = 0;
		public static Int32 Laser2 = 0;
		public static Int32 Back1 = 0;
		public static Int32 Back2 = 0;
		public static Int32 Top1 = 0;
		public static Int32 Top2 = 0;
		public static Int32 Top3 = 0;
		public static Int32 Top4 = 0;
		public static Int32 Left1 = 0;
		public static Int32 Left2 = 0;
		public static Int32 Left3 = 0;
		public static Int32 Right1 = 0;
		public static Int32 Right2 = 0;
		public static Int32 Right3 = 0;
		public static Int32 BoothLeft = 0;
		public static Int32 BoothRight = 0;

		public static Int32 OldLaser1 = 0;
		public static Int32 OldLaser2 = 0;
		public static Int32 OldBack1 = 0;
		public static Int32 OldBack2 = 0;
		public static Int32 OldTop1 = 0;
		public static Int32 OldTop2 = 0;
		public static Int32 OldTop3 = 0;
		public static Int32 OldTop4 = 0;
		public static Int32 OldLeft1 = 0;
		public static Int32 OldLeft2 = 0;
		public static Int32 OldLeft3 = 0;
		public static Int32 OldRight1 = 0;
		public static Int32 OldRight2 = 0;
		public static Int32 OldRight3 = 0;
		public static Int32 OldBoothLeft = 0;
		public static Int32 OldBoothRight = 0;


		public MainUI()
		{
			InitializeComponent();
			BPMStopwatchActive = false;
			BPMReadable = 128.00;
			this.KeyPreview = true;
		}

		public static string ColourSelectMulti()
		{
			ColorDialog MasterSelector = new ColorDialog();
			MasterSelector.ShowDialog();
			string code = MasterSelector.Color.ToArgb().ToString();

			return code;
		}

		private void button1_Click(object sender, EventArgs e)
		{


			if (!BPMStopwatchActive)
			{
				StopwatchManager.RunWorkerAsync();
			}
			else
			{
				BPMStopwatchActive = false;
				BPMLabel.Text = BPMReadable.ToString();
				BPMTimer.Interval = Convert.ToInt32(BPMTimeInMS);
				PatternEngineBPM.Interval = Convert.ToInt32(BPMTimeInMS);

			}
		}

		private void StopwatchManager_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			Stopwatch TestSW = new Stopwatch();
			TestSW.Start();
			BPMStopwatchActive = true;
			while (BPMStopwatchActive)
			{

			}
			TestSW.Stop();
			BPMTimeInMS = TestSW.ElapsedMilliseconds;
			Debug.WriteLine("TestSW: " + TestSW.ElapsedMilliseconds);
			BPMReadable = (60000 / TestSW.ElapsedMilliseconds);

		}

		private void BPMTimer_Tick(object sender, EventArgs e)
		{


			if (ticktock)
			{
				BPMLabel.BackColor = Color.DarkGreen;
				ticktock = false;
			}
			else
			{
				BPMLabel.BackColor = Color.Gray;
				ticktock = true;
			}

		}

		private void MainUI_Load(object sender, EventArgs e)
		{
			BPMTimer.Start();
			PatternEngineBPM.Start();
			StrobeClock.Start();
		}

		private void ToggleLasers_CheckedChanged(object sender, EventArgs e)
		{
			LasersToggle = ToggleLasers.Checked;
			PatternEngineBPMPushColours = true;
		}

		private void ToggleBack_CheckedChanged(object sender, EventArgs e)
		{
			BacklightsToggle = ToggleBack.Checked;
			PatternEngineBPMPushColours = true;
		}

		private void ToggleTopLights_CheckedChanged(object sender, EventArgs e)
		{
			ToplightsToggle = ToggleTopLights.Checked;
			PatternEngineBPMPushColours = true;
		}

		private void ToggleLeftLights_CheckedChanged(object sender, EventArgs e)
		{
			LeftlightsToggle = ToggleLeftLights.Checked;
			PatternEngineBPMPushColours = true;
		}

		private void ToggleRightLights_CheckedChanged(object sender, EventArgs e)
		{
			RightlightsToggle = ToggleRightLights.Checked;
			PatternEngineBPMPushColours = true;
		}

		private void ToggleBoothLights_CheckedChanged(object sender, EventArgs e)
		{
			BoothlightsToggle = ToggleBoothLights.Checked;
			PatternEngineBPMPushColours = true;
		}

		private void button15_Click(object sender, EventArgs e)
		{

		}

		private void button14_Click(object sender, EventArgs e)
		{
			GlobalColour2 = ColourSelectMulti();
			this.GlobalColour2Button.BackColor = Color.FromArgb(Convert.ToInt32(GlobalColour2));
			Debug.WriteLine("Global Colour 2: " + GlobalColour2.ToString());
		}

		private void GlobalColour1Button_Click(object sender, EventArgs e)
		{
			GlobalColour1 = ColourSelectMulti();
			this.GlobalColour1Button.BackColor = Color.FromArgb(Convert.ToInt32(GlobalColour1));
			Debug.WriteLine("Global Colour 1: " + GlobalColour1.ToString());
		}

		private void ShowOBS_Click(object sender, EventArgs e)
		{

			Tailbass_Lighting_Control.OBSLayer boop = new Tailbass_Lighting_Control.OBSLayer();
			boop.Show();
		}

		private void LasersColour1Button_Click(object sender, EventArgs e)
		{
			LasersColour1 = ColourSelectMulti();
			this.LasersColour1Button.BackColor = Color.FromArgb(Convert.ToInt32(LasersColour1));
		}

		private void LasersColour2Button_Click(object sender, EventArgs e)
		{
			LasersColour2 = ColourSelectMulti();
			this.LasersColour2Button.BackColor = Color.FromArgb(Convert.ToInt32(LasersColour2));
		}

		private void BacklightsColour1Button_Click(object sender, EventArgs e)
		{
			BacklightsColour1 = ColourSelectMulti();
			this.BacklightsColour1Button.BackColor = Color.FromArgb(Convert.ToInt32(BacklightsColour1));
		}

		private void BacklightsColour2Button_Click(object sender, EventArgs e)
		{
			BacklightsColour2 = ColourSelectMulti();
			this.BacklightsColour2Button.BackColor = Color.FromArgb(Convert.ToInt32(BacklightsColour2));
		}

		private void PatternEngine_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
		{

		}

		private void PatternEngineBPM_Tick(object sender, EventArgs e)
		{
			//BEAT ENGINE
			if (BeatNo == 4) { BeatNo = 1; }
			else if (BeatNo == 3) { BeatNo = 4; }
			else if (BeatNo == 2) { BeatNo = 3; }
			else if (BeatNo == 1) { BeatNo = 2; }

			if (GlobalMode)
			{
				//Global Mode On

				//Check Which Pattern Is Selected, IF BPM based then it works somewhere here
				if (GlobalPatternMode.SelectedIndex == 0) //Solid Colour
				{
					Laser1 = Convert.ToInt32(GlobalColour1);
					Laser2 = Convert.ToInt32(GlobalColour1);
					Back1 = Convert.ToInt32(GlobalColour1);
					Back2 = Convert.ToInt32(GlobalColour1);
					Top1 = Convert.ToInt32(GlobalColour1);
					Top2 = Convert.ToInt32(GlobalColour1);
					Top3 = Convert.ToInt32(GlobalColour1);
					Top4 = Convert.ToInt32(GlobalColour1);
					Left1 = Convert.ToInt32(GlobalColour1);
					Left2 = Convert.ToInt32(GlobalColour1);
					Left3 = Convert.ToInt32(GlobalColour1);
					Right1 = Convert.ToInt32(GlobalColour1);
					Right2 = Convert.ToInt32(GlobalColour1);
					Right3 = Convert.ToInt32(GlobalColour1);
					BoothLeft = Convert.ToInt32(GlobalColour1);
					BoothRight = Convert.ToInt32(GlobalColour1);

					PatternEngineBPMPushColours = true;
				}
				else if (GlobalPatternMode.SelectedIndex == 1) //Split
				{
					Laser1 = Convert.ToInt32(GlobalColour1);
					Laser2 = Convert.ToInt32(GlobalColour2);
					Back1 = Convert.ToInt32(GlobalColour1);
					Back2 = Convert.ToInt32(GlobalColour2);
					Top1 = Convert.ToInt32(GlobalColour1);
					Top2 = Convert.ToInt32(GlobalColour2);
					Top3 = Convert.ToInt32(GlobalColour1);
					Top4 = Convert.ToInt32(GlobalColour2);
					Left1 = Convert.ToInt32(GlobalColour1);
					Left2 = Convert.ToInt32(GlobalColour2);
					Left3 = Convert.ToInt32(GlobalColour1);
					Right1 = Convert.ToInt32(GlobalColour1);
					Right2 = Convert.ToInt32(GlobalColour2);
					Right3 = Convert.ToInt32(GlobalColour1);
					BoothLeft = Convert.ToInt32(GlobalColour1);
					BoothRight = Convert.ToInt32(GlobalColour2);

					PatternEngineBPMPushColours = true;
				}
				else if (GlobalPatternMode.SelectedIndex == 2) //Alternating
				{
					if (BeatNo == 1 || BeatNo == 3)
					{
						Laser1 = Convert.ToInt32(GlobalColour1);
						Laser2 = Convert.ToInt32(GlobalColour1);
						Back1 = Convert.ToInt32(GlobalColour1);
						Back2 = Convert.ToInt32(GlobalColour1);
						Top1 = Convert.ToInt32(GlobalColour1);
						Top2 = Convert.ToInt32(GlobalColour1);
						Top3 = Convert.ToInt32(GlobalColour1);
						Top4 = Convert.ToInt32(GlobalColour1);
						Left1 = Convert.ToInt32(GlobalColour1);
						Left2 = Convert.ToInt32(GlobalColour1);
						Left3 = Convert.ToInt32(GlobalColour1);
						Right1 = Convert.ToInt32(GlobalColour1);
						Right2 = Convert.ToInt32(GlobalColour1);
						Right3 = Convert.ToInt32(GlobalColour1);
						BoothLeft = Convert.ToInt32(GlobalColour1);
						BoothRight = Convert.ToInt32(GlobalColour1);

						PatternEngineBPMPushColours = true;
					}
					else
					{
						Laser1 = Convert.ToInt32(GlobalColour2);
						Laser2 = Convert.ToInt32(GlobalColour2);
						Back1 = Convert.ToInt32(GlobalColour2);
						Back2 = Convert.ToInt32(GlobalColour2);
						Top1 = Convert.ToInt32(GlobalColour2);
						Top2 = Convert.ToInt32(GlobalColour2);
						Top3 = Convert.ToInt32(GlobalColour2);
						Top4 = Convert.ToInt32(GlobalColour2);
						Left1 = Convert.ToInt32(GlobalColour2);
						Left2 = Convert.ToInt32(GlobalColour2);
						Left3 = Convert.ToInt32(GlobalColour2);
						Right1 = Convert.ToInt32(GlobalColour2);
						Right2 = Convert.ToInt32(GlobalColour2);
						Right3 = Convert.ToInt32(GlobalColour2);
						BoothLeft = Convert.ToInt32(GlobalColour2);
						BoothRight = Convert.ToInt32(GlobalColour2);

						PatternEngineBPMPushColours = true;
					}
				}
				else if (GlobalPatternMode.SelectedIndex == 3) //Alternating Split
				{
					if (BeatNo == 1 || BeatNo == 3)
					{
						Laser1 = Convert.ToInt32(GlobalColour1);
						Laser2 = Convert.ToInt32(GlobalColour2);
						Back1 = Convert.ToInt32(GlobalColour1);
						Back2 = Convert.ToInt32(GlobalColour2);
						Top1 = Convert.ToInt32(GlobalColour1);
						Top2 = Convert.ToInt32(GlobalColour2);
						Top3 = Convert.ToInt32(GlobalColour1);
						Top4 = Convert.ToInt32(GlobalColour2);
						Left1 = Convert.ToInt32(GlobalColour1);
						Left2 = Convert.ToInt32(GlobalColour2);
						Left3 = Convert.ToInt32(GlobalColour1);
						Right1 = Convert.ToInt32(GlobalColour1);
						Right2 = Convert.ToInt32(GlobalColour2);
						Right3 = Convert.ToInt32(GlobalColour1);
						BoothLeft = Convert.ToInt32(GlobalColour1);
						BoothRight = Convert.ToInt32(GlobalColour2);

						PatternEngineBPMPushColours = true;
					}
					else
					{
						Laser1 = Convert.ToInt32(GlobalColour2);
						Laser2 = Convert.ToInt32(GlobalColour1);
						Back1 = Convert.ToInt32(GlobalColour2);
						Back2 = Convert.ToInt32(GlobalColour1);
						Top1 = Convert.ToInt32(GlobalColour2);
						Top2 = Convert.ToInt32(GlobalColour1);
						Top3 = Convert.ToInt32(GlobalColour2);
						Top4 = Convert.ToInt32(GlobalColour1);
						Left1 = Convert.ToInt32(GlobalColour2);
						Left2 = Convert.ToInt32(GlobalColour1);
						Left3 = Convert.ToInt32(GlobalColour2);
						Right1 = Convert.ToInt32(GlobalColour2);
						Right2 = Convert.ToInt32(GlobalColour1);
						Right3 = Convert.ToInt32(GlobalColour2);
						BoothLeft = Convert.ToInt32(GlobalColour2);
						BoothRight = Convert.ToInt32(GlobalColour1);

						PatternEngineBPMPushColours = true;
					}
				}
			}
			//GlobalMode ELSE
			else
			{
				//Non Global Mode Patterns
				//Lasers
				if (LasersToggle)
				{
					if (LasersPatternMode.SelectedIndex == 0)
					{
						Laser1 = Convert.ToInt32(LasersColour1);
						Laser2 = Convert.ToInt32(LasersColour1);
					}
					if (LasersPatternMode.SelectedIndex == 1)
					{
						Laser1 = Convert.ToInt32(LasersColour1);
						Laser2 = Convert.ToInt32(LasersColour2);
					}
					if (LasersPatternMode.SelectedIndex == 2)
					{
						if (BeatNo == 1 || BeatNo == 3)
						{
							Laser1 = Convert.ToInt32(LasersColour1);
							Laser2 = Convert.ToInt32(LasersColour1);
						}
						else
						{
							Laser1 = Convert.ToInt32(LasersColour2);
							Laser2 = Convert.ToInt32(LasersColour2);
						}
					}

					if (LasersPatternMode.SelectedIndex == 3)
					{
						if (BeatNo == 1 || BeatNo == 3)
						{
							Laser1 = Convert.ToInt32(LasersColour1);
							Laser2 = Convert.ToInt32(LasersColour2);
						}
						else
						{
							Laser1 = Convert.ToInt32(LasersColour2);
							Laser2 = Convert.ToInt32(LasersColour1);
						}
					}

					PatternEngineBPMPushColours = true;
				}

				//Back Lights
				if (BacklightsToggle)
				{
					if (BacklightsPatternMode.SelectedIndex == 0)
					{
						Back1 = Convert.ToInt32(BacklightsColour1);
						Back2 = Convert.ToInt32(BacklightsColour1);
					}
					if (BacklightsPatternMode.SelectedIndex == 1)
					{
						Back1 = Convert.ToInt32(BacklightsColour1);
						Back2 = Convert.ToInt32(BacklightsColour2);
					}
					if (BacklightsPatternMode.SelectedIndex == 2)
					{
						if (BeatNo == 1 || BeatNo == 3)
						{
							Back1 = Convert.ToInt32(BacklightsColour1);
							Back2 = Convert.ToInt32(BacklightsColour1);
						}
						else
						{
							Back1 = Convert.ToInt32(BacklightsColour2);
							Back2 = Convert.ToInt32(BacklightsColour2);
						}
					}

					if (BacklightsPatternMode.SelectedIndex == 3)
					{
						if (BeatNo == 1 || BeatNo == 3)
						{
							Back1 = Convert.ToInt32(BacklightsColour1);
							Back2 = Convert.ToInt32(BacklightsColour2);
						}
						else
						{
							Back1 = Convert.ToInt32(BacklightsColour2);
							Back2 = Convert.ToInt32(BacklightsColour1);
						}
					}

					PatternEngineBPMPushColours = true;
				}

				//Booth Lights
				if (BoothlightsToggle)
				{
					if (BoothlightsPatternMode.SelectedIndex == 0)
					{
						BoothLeft = Convert.ToInt32(BoothlightsColour1);
						BoothRight = Convert.ToInt32(BoothlightsColour1);
					}
					if (BoothlightsPatternMode.SelectedIndex == 1)
					{
						BoothLeft = Convert.ToInt32(BoothlightsColour1);
						BoothRight = Convert.ToInt32(BoothlightsColour2);
					}
					if (BoothlightsPatternMode.SelectedIndex == 2)
					{
						if (BeatNo == 1 || BeatNo == 3)
						{
							BoothLeft = Convert.ToInt32(BoothlightsColour1);
							BoothRight = Convert.ToInt32(BoothlightsColour1);
						}
						else
						{
							BoothLeft = Convert.ToInt32(BoothlightsColour2);
							BoothRight = Convert.ToInt32(BoothlightsColour2);
						}
					}

					if (BoothlightsPatternMode.SelectedIndex == 3)
					{
						if (BeatNo == 1 || BeatNo == 3)
						{
							BoothLeft = Convert.ToInt32(BoothlightsColour1);
							BoothRight = Convert.ToInt32(BoothlightsColour2);
						}
						else
						{
							BoothLeft = Convert.ToInt32(BoothlightsColour2);
							BoothRight = Convert.ToInt32(BoothlightsColour1);
						}
					}

					PatternEngineBPMPushColours = true;
				}

				//Top Lights
				if (ToplightsToggle)
				{
					if(ToplightsPatternMode.SelectedIndex == 0)
					{
						Top1 = Convert.ToInt32(ToplightsColour1);
						Top2 = Convert.ToInt32(ToplightsColour1);
						Top3 = Convert.ToInt32(ToplightsColour1);
						Top4 = Convert.ToInt32(ToplightsColour1);
					}
					if (ToplightsPatternMode.SelectedIndex == 1)
					{
						Top1 = Convert.ToInt32(ToplightsColour1);
						Top2 = Convert.ToInt32(ToplightsColour1);
						Top3 = Convert.ToInt32(ToplightsColour2);
						Top4 = Convert.ToInt32(ToplightsColour2);
					}
					if (ToplightsPatternMode.SelectedIndex == 2)
					{
						Top1 = Convert.ToInt32(ToplightsColour1);
						Top2 = Convert.ToInt32(ToplightsColour2);
						Top3 = Convert.ToInt32(ToplightsColour2);
						Top4 = Convert.ToInt32(ToplightsColour1);
					}
					if (ToplightsPatternMode.SelectedIndex == 3)
					{
						Top1 = Convert.ToInt32(ToplightsColour1);
						Top2 = 0;
						Top3 = 0;
						Top4 = Convert.ToInt32(ToplightsColour2);
					}
					if (ToplightsPatternMode.SelectedIndex == 4)
					{
						Top1 = 0;
						Top2 = Convert.ToInt32(ToplightsColour1);
						Top3 = Convert.ToInt32(ToplightsColour2);
						Top4 = 0;
					}
					if (ToplightsPatternMode.SelectedIndex == 5)
					{
						if (BeatNo == 1 || BeatNo == 3)
						{
							Top1 = Convert.ToInt32(ToplightsColour1);
							Top2 = Convert.ToInt32(ToplightsColour2);
							Top3 = Convert.ToInt32(ToplightsColour1);
							Top4 = Convert.ToInt32(ToplightsColour2);
						}
						else
						{
							Top1 = Convert.ToInt32(ToplightsColour2);
							Top2 = Convert.ToInt32(ToplightsColour1);
							Top3 = Convert.ToInt32(ToplightsColour2);
							Top4 = Convert.ToInt32(ToplightsColour1);
						}
					}
					if (ToplightsPatternMode.SelectedIndex == 6)
					{
						if (BeatNo == 1)
						{
							Top1 = Convert.ToInt32(ToplightsColour1);
							Top2 = Convert.ToInt32(ToplightsColour2);
							Top3 = Convert.ToInt32(ToplightsColour2);
							Top4 = Convert.ToInt32(ToplightsColour2);
						}
						else if (BeatNo == 2)
						{
							Top1 = Convert.ToInt32(ToplightsColour2);
							Top2 = Convert.ToInt32(ToplightsColour1);
							Top3 = Convert.ToInt32(ToplightsColour2);
							Top4 = Convert.ToInt32(ToplightsColour2);
						}
						else if (BeatNo == 3)
						{
							Top1 = Convert.ToInt32(ToplightsColour2);
							Top2 = Convert.ToInt32(ToplightsColour2);
							Top3 = Convert.ToInt32(ToplightsColour1);
							Top4 = Convert.ToInt32(ToplightsColour2);
						}
						else if (BeatNo == 4)
						{
							Top1 = Convert.ToInt32(ToplightsColour2);
							Top2 = Convert.ToInt32(ToplightsColour2);
							Top3 = Convert.ToInt32(ToplightsColour2);
							Top4 = Convert.ToInt32(ToplightsColour1);
						}

					}
					if (ToplightsPatternMode.SelectedIndex == 7)
					{
						if (BeatNo == 4)
						{
							Top1 = Convert.ToInt32(ToplightsColour1);
							Top2 = Convert.ToInt32(ToplightsColour2);
							Top3 = Convert.ToInt32(ToplightsColour2);
							Top4 = Convert.ToInt32(ToplightsColour2);
						}
						else if (BeatNo == 3)
						{
							Top1 = Convert.ToInt32(ToplightsColour2);
							Top2 = Convert.ToInt32(ToplightsColour1);
							Top3 = Convert.ToInt32(ToplightsColour2);
							Top4 = Convert.ToInt32(ToplightsColour2);
						}
						else if (BeatNo == 2)
						{
							Top1 = Convert.ToInt32(ToplightsColour2);
							Top2 = Convert.ToInt32(ToplightsColour2);
							Top3 = Convert.ToInt32(ToplightsColour1);
							Top4 = Convert.ToInt32(ToplightsColour2);
						}
						else if (BeatNo == 1)
						{
							Top1 = Convert.ToInt32(ToplightsColour2);
							Top2 = Convert.ToInt32(ToplightsColour2);
							Top3 = Convert.ToInt32(ToplightsColour2);
							Top4 = Convert.ToInt32(ToplightsColour1);
						}

					}

					PatternEngineBPMPushColours = true;
				}

				//Left Lights
				if (LeftlightsToggle)
				{
					if (LeftlightsPatternMode.SelectedIndex == 0)
					{
						Left1 = Convert.ToInt32(LeftlightsColour1);
						Left2 = Convert.ToInt32(LeftlightsColour1);
						Left3 = Convert.ToInt32(LeftlightsColour1);
					}
					if (LeftlightsPatternMode.SelectedIndex == 1)
					{
						Left1 = Convert.ToInt32(LeftlightsColour1);
						Left2 = Convert.ToInt32(LeftlightsColour2);
						Left3 = Convert.ToInt32(LeftlightsColour1);
					}
					if (LeftlightsPatternMode.SelectedIndex == 2)
					{
						if (BeatNo == 1 || BeatNo == 3)
						{
							Left1 = Convert.ToInt32(LeftlightsColour1);
							Left2 = Convert.ToInt32(LeftlightsColour1);
							Left3 = Convert.ToInt32(LeftlightsColour1);
						}
						else
						{
							Left1 = Convert.ToInt32(LeftlightsColour2);
							Left2 = Convert.ToInt32(LeftlightsColour2);
							Left3 = Convert.ToInt32(LeftlightsColour2);
						}
					}
					if (LeftlightsPatternMode.SelectedIndex == 3)
					{
						if (BeatNo == 1 || BeatNo == 3)
						{
							Left1 = Convert.ToInt32(LeftlightsColour1);
							Left2 = Convert.ToInt32(LeftlightsColour2);
							Left3 = Convert.ToInt32(LeftlightsColour1);
						}
						else
						{
							Left1 = Convert.ToInt32(LeftlightsColour2);
							Left2 = Convert.ToInt32(LeftlightsColour1);
							Left3 = Convert.ToInt32(LeftlightsColour2);
						}
					}
					if (LeftlightsPatternMode.SelectedIndex == 4)
					{
						if (BeatNo == 1)
						{
							Left1 = Convert.ToInt32(LeftlightsColour1);
							Left2 = Convert.ToInt32(LeftlightsColour2);
							Left3 = Convert.ToInt32(LeftlightsColour2);
						}
						else if (BeatNo == 2)
						{
							Left1 = Convert.ToInt32(LeftlightsColour2);
							Left2 = Convert.ToInt32(LeftlightsColour1);
							Left3 = Convert.ToInt32(LeftlightsColour2);
						}
						else if (BeatNo == 3)
						{
							Left1 = Convert.ToInt32(LeftlightsColour2);
							Left2 = Convert.ToInt32(LeftlightsColour2);
							Left3 = Convert.ToInt32(LeftlightsColour1);
						}
						else if (BeatNo == 4)
						{
							Left1 = Convert.ToInt32(LeftlightsColour2);
							Left2 = Convert.ToInt32(LeftlightsColour2);
							Left3 = Convert.ToInt32(LeftlightsColour2);
						}
					}
					if (LeftlightsPatternMode.SelectedIndex == 5)
					{
						if (BeatNo == 4)
						{
							Left1 = Convert.ToInt32(LeftlightsColour1);
							Left2 = Convert.ToInt32(LeftlightsColour2);
							Left3 = Convert.ToInt32(LeftlightsColour2);
						}
						else if (BeatNo == 3)
						{
							Left1 = Convert.ToInt32(LeftlightsColour2);
							Left2 = Convert.ToInt32(LeftlightsColour1);
							Left3 = Convert.ToInt32(LeftlightsColour2);
						}
						else if (BeatNo == 2)
						{
							Left1 = Convert.ToInt32(LeftlightsColour2);
							Left2 = Convert.ToInt32(LeftlightsColour2);
							Left3 = Convert.ToInt32(LeftlightsColour1);
						}
						else if (BeatNo == 1)
						{
							Left1 = Convert.ToInt32(LeftlightsColour2);
							Left2 = Convert.ToInt32(LeftlightsColour2);
							Left3 = Convert.ToInt32(LeftlightsColour2);
						}
					}

					PatternEngineBPMPushColours = true;
				}

				//Right Lights
				if (RightlightsToggle)
				{
					if (RightlightsPatternMode.SelectedIndex == 0)
					{
						Right1 = Convert.ToInt32(RightlightsColour1);
						Right2 = Convert.ToInt32(RightlightsColour1);
						Right3 = Convert.ToInt32(RightlightsColour1);
					}
					if (RightlightsPatternMode.SelectedIndex == 1)
					{
						Right1 = Convert.ToInt32(RightlightsColour1);
						Right2 = Convert.ToInt32(RightlightsColour2);
						Right3 = Convert.ToInt32(RightlightsColour1);
					}
					if (RightlightsPatternMode.SelectedIndex == 2)
					{
						if (BeatNo == 1 || BeatNo == 3)
						{
							Right1 = Convert.ToInt32(RightlightsColour1);
							Right2 = Convert.ToInt32(RightlightsColour1);
							Right3 = Convert.ToInt32(RightlightsColour1);
						}
						else
						{
							Right1 = Convert.ToInt32(RightlightsColour2);
							Right2 = Convert.ToInt32(RightlightsColour2);
							Right3 = Convert.ToInt32(RightlightsColour2);
						}
					}
					if (RightlightsPatternMode.SelectedIndex == 3)
					{
						if (BeatNo == 1 || BeatNo == 3)
						{
							Right1 = Convert.ToInt32(RightlightsColour1);
							Right2 = Convert.ToInt32(RightlightsColour2);
							Right3 = Convert.ToInt32(RightlightsColour1);
						}
						else
						{
							Right1 = Convert.ToInt32(RightlightsColour2);
							Right2 = Convert.ToInt32(RightlightsColour1);
							Right3 = Convert.ToInt32(RightlightsColour2);
						}
					}
					if (RightlightsPatternMode.SelectedIndex == 4)
					{
						if (BeatNo == 1)
						{
							Right1 = Convert.ToInt32(RightlightsColour1);
							Right2 = Convert.ToInt32(RightlightsColour2);
							Right3 = Convert.ToInt32(RightlightsColour2);
						}
						else if (BeatNo == 2)
						{
							Right1 = Convert.ToInt32(RightlightsColour2);
							Right2 = Convert.ToInt32(RightlightsColour1);
							Right3 = Convert.ToInt32(RightlightsColour2);
						}
						else if (BeatNo == 3)
						{
							Right1 = Convert.ToInt32(RightlightsColour2);
							Right2 = Convert.ToInt32(RightlightsColour2);
							Right3 = Convert.ToInt32(RightlightsColour1);
						}
						else if (BeatNo == 4)
						{
							Right1 = Convert.ToInt32(RightlightsColour2);
							Right2 = Convert.ToInt32(RightlightsColour2);
							Right3 = Convert.ToInt32(RightlightsColour2);
						}
					}
					if (RightlightsPatternMode.SelectedIndex == 5)
					{
						if (BeatNo == 4)
						{
							Right1 = Convert.ToInt32(RightlightsColour1);
							Right2 = Convert.ToInt32(RightlightsColour2);
							Right3 = Convert.ToInt32(RightlightsColour2);
						}
						else if (BeatNo == 3)
						{
							Right1 = Convert.ToInt32(RightlightsColour2);
							Right2 = Convert.ToInt32(RightlightsColour1);
							Right3 = Convert.ToInt32(RightlightsColour2);
						}
						else if (BeatNo == 2)
						{
							Right1 = Convert.ToInt32(RightlightsColour2);
							Right2 = Convert.ToInt32(RightlightsColour2);
							Right3 = Convert.ToInt32(RightlightsColour1);
						}
						else if (BeatNo == 1)
						{
							Right1 = Convert.ToInt32(RightlightsColour2);
							Right2 = Convert.ToInt32(RightlightsColour2);
							Right3 = Convert.ToInt32(RightlightsColour2);
						}
					}

					PatternEngineBPMPushColours = true;
				}
			}

			//Push Colours to Nodes/Preview
			//Check if Booth Lights are enabled
			if (!BoothlightsToggle)
			{
				BoothLeft = 0;
				BoothRight = 0;
			}

			//check if lasers are enabled
			if (!LasersToggle)
			{
				Laser1 = 0;
				Laser2 = 0;
			}


			//Check if left lights are enabled
			if (!LeftlightsToggle)
			{
				Left1 = 0;
				Left2 = 0;
				Left3 = 0;
			}

			//Check if right lights are enabled
			if (!RightlightsToggle)
			{
				Right1 = 0;
				Right2 = 0;
				Right3 = 0;
			}

			//check if top lights are enabled
			if (!ToplightsToggle)
			{
				Top1 = 0;
				Top2 = 0;
				Top3 = 0;
				Top4 = 0;
			}

			//yada yada
			if (!BacklightsToggle)
			{
				Back1 = 0;
				Back2 = 0;
			}

			//Push Patterns otherwise
			if (PatternEngineBPMPushColours)
			{
				PatternEngineBPMPushColours = false;

				PreviewGrid.Items[0].BackColor = Color.FromArgb(BoothLeft);
				PreviewGrid.Items[1].BackColor = Color.FromArgb(BoothRight);
				PreviewGrid.Items[2].BackColor = Color.FromArgb(Laser1);
				PreviewGrid.Items[3].BackColor = Color.FromArgb(Laser2);
				PreviewGrid.Items[4].BackColor = Color.FromArgb(Left1);
				PreviewGrid.Items[5].BackColor = Color.FromArgb(Left2);
				PreviewGrid.Items[6].BackColor = Color.FromArgb(Left3);
				PreviewGrid.Items[7].BackColor = Color.FromArgb(Back1);
				PreviewGrid.Items[8].BackColor = Color.FromArgb(Back2);
				PreviewGrid.Items[9].BackColor = Color.FromArgb(Right1);
				PreviewGrid.Items[10].BackColor = Color.FromArgb(Right2);
				PreviewGrid.Items[11].BackColor = Color.FromArgb(Right3);
				PreviewGrid.Items[12].BackColor = Color.FromArgb(Top1);
				PreviewGrid.Items[13].BackColor = Color.FromArgb(Top2);
				PreviewGrid.Items[14].BackColor = Color.FromArgb(Top3);
				PreviewGrid.Items[15].BackColor = Color.FromArgb(Top4);

				OldBoothLeft = BoothLeft;
				OldBoothRight = BoothRight;
				OldLaser1 = Laser1;
				OldLaser2 = Laser2;
				OldTop1 = Top1;
				OldTop2 = Top2;
				OldTop3 = Top3;
				OldTop4 = Top4;
				OldLeft1 = Left1;
				OldLeft2 = Left2;
				OldLeft3 = Left3;
				OldRight1 = Right1;
				OldRight2 = Right2;
				OldRight3 = Right3;
				OldBack1 = Back1;
				OldBack2 = Back2;


			}
		}

		private void GlobalModeToggle_CheckedChanged(object sender, EventArgs e)
		{
			GlobalMode = GlobalModeToggle.Checked;
			if (!GlobalMode)
			{
				BoothLeft = 0;
				BoothRight = 0;
				Laser1 = 0;
				Laser2 = 0;
				Top1 = 0;
				Top2 = 0;
				Top3 = 0;
				Top4 = 0;
				Left1 = 0;
				Left2 = 0;
				Left3 = 0;
				Right1 = 0;
				Right2 = 0;
				Right3 = 0;
				Back1 = 0;
				Back2 = 0;
				PatternEngineBPMPushColours = true;
			}
		}

		private void ToplightsColour1Button_Click(object sender, EventArgs e)
		{
			ToplightsColour1 = ColourSelectMulti();
			this.ToplightsColour1Button.BackColor = Color.FromArgb(Convert.ToInt32(ToplightsColour1));
		}

		private void ToplightsColour2Button_Click(object sender, EventArgs e)
		{
			ToplightsColour2 = ColourSelectMulti();
			this.ToplightsColour2Button.BackColor = Color.FromArgb(Convert.ToInt32(ToplightsColour2));
		}

		private void LeftlightsColour1Button_Click(object sender, EventArgs e)
		{
			LeftlightsColour1 = ColourSelectMulti();
			this.LeftlightsColour1Button.BackColor = Color.FromArgb(Convert.ToInt32(LeftlightsColour1));
		}

		private void LeftlightsColour2Button_Click(object sender, EventArgs e)
		{
			LeftlightsColour2 = ColourSelectMulti();
			this.LeftlightsColour2Button.BackColor = Color.FromArgb(Convert.ToInt32(LeftlightsColour2));
		}

		private void RightlightsColour1Button_Click(object sender, EventArgs e)
		{
			RightlightsColour1 = ColourSelectMulti();
			this.RightlightsColour1Button.BackColor = Color.FromArgb(Convert.ToInt32(RightlightsColour1));
		}

		private void RightlightsColour2Button_Click(object sender, EventArgs e)
		{
			RightlightsColour2 = ColourSelectMulti();
			this.RightlightsColour2Button.BackColor = Color.FromArgb(Convert.ToInt32(RightlightsColour2));
		}

		private void BoothlightsColour1Button_Click(object sender, EventArgs e)
		{
			BoothlightsColour1 = ColourSelectMulti();
			this.BoothlightsColour1Button.BackColor = Color.FromArgb(Convert.ToInt32(BoothlightsColour1));
		}

		private void BoothlightsColour2Button_Click(object sender, EventArgs e)
		{
			BoothlightsColour2 = ColourSelectMulti();
			this.BoothlightsColour2Button.BackColor = Color.FromArgb(Convert.ToInt32(BoothlightsColour2));
		}

		private void StrobeClock_Tick(object sender, EventArgs e)
		{
			if (StrobeClockTok)
			{
				StrobeClockTok = false;
				OldBoothLeft = BoothLeft;
				OldBoothRight = BoothRight;
				OldLaser1 = Laser1;
				OldLaser2 = Laser2;
				OldTop1 = Top1;
				OldTop2 = Top2;
				OldTop3 = Top3;
				OldTop4 = Top4;
				OldLeft1 = Left1;
				OldLeft2 = Left2;
				OldLeft3 = Left3;
				OldRight1 = Right1;
				OldRight2 = Right2;
				OldRight3 = Right3;
				OldBack1 = Back1;
				OldBack2 = Back2;

				if (StrobeActive)
				{
					StrobeButton.ForeColor = Color.Black;
					if (BoothlightsIIS.Checked)
					{
						BoothLeft = 0;
						BoothRight = 0;
					}
					if (LasersIIS.Checked)
					{
						Laser1 = 0;
						Laser2 = 0;
					}
					if (ToplightsIIS.Checked)
					{
						Top1 = 0;
						Top2 = 0;
						Top3 = 0;
						Top4 = 0;
					}
					if (LeftlightsIIS.Checked)
					{
						Left1 = 0;
						Left2 = 0;
						Left3 = 0;
					}
					if (RightlighsIIS.Checked)
					{
						Right1 = 0;
						Right2 = 0;
						Right3 = 0;
					}
					if (BacklightsIIS.Checked)
					{
						Back1 = 0;
						Back2 = 0;
					}
				}
			}
			else
			{
				StrobeClockTok = true;
				StrobeButton.ForeColor = Color.Lime;
				BoothLeft = OldBoothLeft;
				BoothRight = OldBoothRight;
				Laser1 = OldLaser1;
				Laser2 = OldLaser2;
				Top1 = OldTop1;
				Top2 = OldTop2;
				Top3 = OldTop3;
				Top4 = OldTop4;
				Left1 = OldLeft1;
				Left2 = OldLeft2;
				Left3 = OldLeft3;
				Right1 = OldRight1;
				Right2 = OldRight2;
				Right3 = OldRight3;
				Back1 = OldBack1;
				Back2 = OldBack2;

			}
		}
		private void StrobeButton_MouseUp(object sender, MouseEventArgs e)
		{
			StrobeActive = false;
		}

		private void StrobeButton_MouseDown(object sender, MouseEventArgs e)
		{
			StrobeActive = true;
		}

		private void MainUI_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode == Keys.Space)
			{
				BPMTapButton.PerformClick();
			}

			if (e.Control && e.KeyCode == Keys.S)
			{
				StrobeActive = true;
			}
		}

		private void MainUI_KeyUp(object sender, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode == Keys.S)
			{
				StrobeActive = false;
			}
		}
	}
}