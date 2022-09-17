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

		public static bool RefreshColoursFromRAM = false;

		//Global colours?
		public static bool GlobalMode = false;
		public static Int32 GlobalColour1 = 0;
		public static Int32 GlobalColour2 = 0;

		//Pattern Modes
		public static int GlobalPattern = 0;
		public static int LasersPattern = 0;
		public static int BackLightsPattern = 0;
		public static int TopLightsPattern = 0;
		public static int LeftLightsPattern = 0;
		public static int RightLightsPattern = 0;
		public static int BoothLightsPattern = 0;


		//Light Toggles
		public static bool LasersToggle = false;
		public static bool BacklightsToggle = false;
		public static bool ToplightsToggle = false;
		public static bool LeftlightsToggle = false;
		public static bool RightlightsToggle = false;
		public static bool BoothlightsToggle = false;

		//IIS Toggles (Included In Strobe)
		public static bool LasersIIS = true;
		public static bool BacklightsIIS = true;
		public static bool ToplightsIIS = true;
		public static bool LeftlightsIIS = true;
		public static bool RightlightsIIS = true;
		public static bool BoothlightsIIS = true;

		//Colour Vars
		public static Int32 LasersColour1 = 0;
		public static Int32 LasersColour2 = 0;
		public static Int32 BacklightsColour1 = 0;
		public static Int32 BacklightsColour2 = 0;
		public static Int32 ToplightsColour1 = 0;
		public static Int32 ToplightsColour2 = 0;
		public static Int32 LeftlightsColour1 = 0;
		public static Int32 LeftlightsColour2 = 0;
		public static Int32 RightlightsColour1 = 0;
		public static Int32 RightlightsColour2 = 0;
		public static Int32 BoothlightsColour1 = 0;
		public static Int32 BoothlightsColour2 = 0;

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

		public static Int32 ColourSelectMulti()
		{
			ColorDialog MasterSelector = new ColorDialog();
			MasterSelector.ShowDialog();
			Int32 code = Convert.ToInt32(MasterSelector.Color.ToArgb());

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
				if (Convert.ToInt32(BPMReadable) > 1000)
				{
					BPMReadable = 1000;
				}
				BPMSetVal.Value = Convert.ToInt32(BPMReadable);
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

		private void button14_Click(object sender, EventArgs e)
		{
			GlobalColour2 = ColourSelectMulti();
			GlobalColour2Button.BackColor = Color.FromArgb(Convert.ToInt32(GlobalColour2));
			Debug.WriteLine("Global Colour 2: " + GlobalColour2.ToString());
		}

		private void GlobalColour1Button_Click(object sender, EventArgs e)
		{
			GlobalColour1 = ColourSelectMulti();
			GlobalColour1Button.BackColor = Color.FromArgb(Convert.ToInt32(GlobalColour1));
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
			LasersColour1Button.BackColor = Color.FromArgb(Convert.ToInt32(LasersColour1));
		}

		private void LasersColour2Button_Click(object sender, EventArgs e)
		{
			LasersColour2 = ColourSelectMulti();
			LasersColour2Button.BackColor = Color.FromArgb(Convert.ToInt32(LasersColour2));
		}

		private void BacklightsColour1Button_Click(object sender, EventArgs e)
		{
			BacklightsColour1 = ColourSelectMulti();
			BacklightsColour1Button.BackColor = Color.FromArgb(Convert.ToInt32(BacklightsColour1));
		}

		private void BacklightsColour2Button_Click(object sender, EventArgs e)
		{
			BacklightsColour2 = ColourSelectMulti();
			BacklightsColour2Button.BackColor = Color.FromArgb(Convert.ToInt32(BacklightsColour2));
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

			if(RefreshColoursFromRAM == true)
			{
				RefreshColoursFromRAM = false;

				//Global Stuff

				if(GlobalMode)
				{
					GlobalModeToggleButton.ForeColor = Color.Lime;
					GlobalModeToggleButton.Text = "Global Mode On";
				}
				else
				{
					GlobalModeToggleButton.ForeColor = Color.Red;
					GlobalModeToggleButton.Text = "Global Mode Off";
				}
				GlobalColour1Button.BackColor = Color.FromArgb(Convert.ToInt32(GlobalColour1));
				GlobalColour2Button.BackColor = Color.FromArgb(Convert.ToInt32(GlobalColour2));
				GlobalPatternMode.SelectedIndex = GlobalPattern;

				//Lasers
				LasersColour1Button.BackColor = Color.FromArgb(Convert.ToInt32(LasersColour1));
				LasersColour2Button.BackColor = Color.FromArgb(Convert.ToInt32(LasersColour2));
				LasersPatternMode.SelectedIndex = LasersPattern;

				if (LasersToggle)
				{
					LasersToggleButton.ForeColor = Color.Lime;
				}
				else
				{
					LasersToggleButton.ForeColor = Color.Red;
				}

				//Back Lights
				BacklightsColour1Button.BackColor = Color.FromArgb(Convert.ToInt32(BacklightsColour1));
				BacklightsColour2Button.BackColor = Color.FromArgb(Convert.ToInt32(BacklightsColour2));
				BacklightsPatternMode.SelectedIndex = BackLightsPattern;

				if (BacklightsToggle)
				{
					BackLightsToggleButton.ForeColor = Color.Lime;
				}
				else
				{
					BackLightsToggleButton.ForeColor = Color.Red;
				}

				//Booth Lights
				BoothlightsColour1Button.BackColor = Color.FromArgb(Convert.ToInt32(BoothlightsColour1));
				BoothlightsColour2Button.BackColor = Color.FromArgb(Convert.ToInt32(BoothlightsColour2));
				BoothlightsPatternMode.SelectedIndex = BoothLightsPattern;

				if (BoothlightsToggle)
				{
					BoothLightsToggleButton.ForeColor = Color.Lime;
				}
				else
				{
					BoothLightsToggleButton.ForeColor = Color.Red;
				}

				//Top Lights
				ToplightsColour1Button.BackColor = Color.FromArgb(Convert.ToInt32(ToplightsColour1));
				ToplightsColour2Button.BackColor = Color.FromArgb(Convert.ToInt32(ToplightsColour2));
				ToplightsPatternMode.SelectedIndex = TopLightsPattern;

				if (ToplightsToggle)
				{
					TopLightsToggleButton.ForeColor = Color.Lime;
				}
				else
				{
					TopLightsToggleButton.ForeColor = Color.Red;
				}

				//Left Lights
				LeftlightsColour1Button.BackColor = Color.FromArgb(Convert.ToInt32(LeftlightsColour1));
				LeftlightsColour2Button.BackColor = Color.FromArgb(Convert.ToInt32(LeftlightsColour2));
				LeftlightsPatternMode.SelectedIndex = LeftLightsPattern;

				if (LeftlightsToggle)
				{
					LeftLightsToggleButton.ForeColor = Color.Lime;
				}
				else
				{
					LeftLightsToggleButton.ForeColor = Color.Red;
				}

				//Right Lights
				RightlightsColour1Button.BackColor = Color.FromArgb(Convert.ToInt32(RightlightsColour1));
				RightlightsColour2Button.BackColor = Color.FromArgb(Convert.ToInt32(RightlightsColour2));
				RightlightsPatternMode.SelectedIndex = RightLightsPattern;

				if (RightlightsToggle)
				{
					RightLightsToggleButton.ForeColor = Color.Lime;
				}
				else
				{
					RightLightsToggleButton.ForeColor = Color.Red;
				}


			}

			if (GlobalMode)
			{
				//Global Mode On

				//Check Which Pattern Is Selected, IF BPM based then it works somewhere here
				if (GlobalPattern == 0) //Solid Colour
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
				else if (GlobalPattern == 1) //Split
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
				else if (GlobalPattern == 2) //Alternating
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
				else if (GlobalPattern == 3) //Alternating Split
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
					if (LasersPattern == 0)
					{
						Laser1 = Convert.ToInt32(LasersColour1);
						Laser2 = Convert.ToInt32(LasersColour1);
					}
					if (LasersPattern == 1)
					{
						Laser1 = Convert.ToInt32(LasersColour1);
						Laser2 = Convert.ToInt32(LasersColour2);
					}
					if (LasersPattern == 2)
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

					if (LasersPattern == 3)
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
					if (BackLightsPattern == 0)
					{
						Back1 = Convert.ToInt32(BacklightsColour1);
						Back2 = Convert.ToInt32(BacklightsColour1);
					}
					if (BackLightsPattern == 1)
					{
						Back1 = Convert.ToInt32(BacklightsColour1);
						Back2 = Convert.ToInt32(BacklightsColour2);
					}
					if (BackLightsPattern == 2)
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

					if (BackLightsPattern == 3)
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
					if (BoothLightsPattern == 0)
					{
						BoothLeft = Convert.ToInt32(BoothlightsColour1);
						BoothRight = Convert.ToInt32(BoothlightsColour1);
					}
					if (BoothLightsPattern == 1)
					{
						BoothLeft = Convert.ToInt32(BoothlightsColour1);
						BoothRight = Convert.ToInt32(BoothlightsColour2);
					}
					if (BoothLightsPattern == 2)
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

					if (BoothLightsPattern == 3)
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
					if(TopLightsPattern == 0)
					{
						Top1 = Convert.ToInt32(ToplightsColour1);
						Top2 = Convert.ToInt32(ToplightsColour1);
						Top3 = Convert.ToInt32(ToplightsColour1);
						Top4 = Convert.ToInt32(ToplightsColour1);
					}
					if (TopLightsPattern == 1)
					{
						Top1 = Convert.ToInt32(ToplightsColour1);
						Top2 = Convert.ToInt32(ToplightsColour1);
						Top3 = Convert.ToInt32(ToplightsColour2);
						Top4 = Convert.ToInt32(ToplightsColour2);
					}
					if (TopLightsPattern == 2)
					{
						Top1 = Convert.ToInt32(ToplightsColour1);
						Top2 = Convert.ToInt32(ToplightsColour2);
						Top3 = Convert.ToInt32(ToplightsColour2);
						Top4 = Convert.ToInt32(ToplightsColour1);
					}
					if (TopLightsPattern == 3)
					{
						Top1 = Convert.ToInt32(ToplightsColour1);
						Top2 = 0;
						Top3 = 0;
						Top4 = Convert.ToInt32(ToplightsColour2);
					}
					if (TopLightsPattern == 4)
					{
						Top1 = 0;
						Top2 = Convert.ToInt32(ToplightsColour1);
						Top3 = Convert.ToInt32(ToplightsColour2);
						Top4 = 0;
					}
					if (TopLightsPattern == 5)
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
					if (TopLightsPattern == 6)
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
					if (TopLightsPattern == 7)
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
					if (LeftLightsPattern == 0)
					{
						Left1 = Convert.ToInt32(LeftlightsColour1);
						Left2 = Convert.ToInt32(LeftlightsColour1);
						Left3 = Convert.ToInt32(LeftlightsColour1);
					}
					if (LeftLightsPattern == 1)
					{
						Left1 = Convert.ToInt32(LeftlightsColour1);
						Left2 = Convert.ToInt32(LeftlightsColour2);
						Left3 = Convert.ToInt32(LeftlightsColour1);
					}
					if (LeftLightsPattern == 2)
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
					if (LeftLightsPattern == 3)
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
					if (LeftLightsPattern == 4)
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
					if (LeftLightsPattern == 5)
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
					if (RightLightsPattern == 0)
					{
						Right1 = Convert.ToInt32(RightlightsColour1);
						Right2 = Convert.ToInt32(RightlightsColour1);
						Right3 = Convert.ToInt32(RightlightsColour1);
					}
					if (RightLightsPattern == 1)
					{
						Right1 = Convert.ToInt32(RightlightsColour1);
						Right2 = Convert.ToInt32(RightlightsColour2);
						Right3 = Convert.ToInt32(RightlightsColour1);
					}
					if (RightLightsPattern == 2)
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
					if (RightLightsPattern == 3)
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
					if (RightLightsPattern  == 4)
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
					if (RightLightsPattern == 5)
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


		private void ToplightsColour1Button_Click(object sender, EventArgs e)
		{
			ToplightsColour1 = ColourSelectMulti();
			this.ToplightsColour1Button.BackColor = Color.FromArgb(ToplightsColour1);
		}

		private void ToplightsColour2Button_Click(object sender, EventArgs e)
		{
			ToplightsColour2 = ColourSelectMulti();
			this.ToplightsColour2Button.BackColor = Color.FromArgb(ToplightsColour2);
		}

		private void LeftlightsColour1Button_Click(object sender, EventArgs e)
		{
			LeftlightsColour1 = ColourSelectMulti();
			LeftlightsColour1Button.BackColor = Color.FromArgb(LeftlightsColour1);
		}

		private void LeftlightsColour2Button_Click(object sender, EventArgs e)
		{
			LeftlightsColour2 = ColourSelectMulti();
			LeftlightsColour2Button.BackColor = Color.FromArgb(LeftlightsColour2);
		}

		private void RightlightsColour1Button_Click(object sender, EventArgs e)
		{
			RightlightsColour1 = ColourSelectMulti();
			RightlightsColour1Button.BackColor = Color.FromArgb(RightlightsColour1);
		}

		private void RightlightsColour2Button_Click(object sender, EventArgs e)
		{
			RightlightsColour2 = ColourSelectMulti();
			RightlightsColour2Button.BackColor = Color.FromArgb(RightlightsColour2);
		}

		private void BoothlightsColour1Button_Click(object sender, EventArgs e)
		{
			BoothlightsColour1 = ColourSelectMulti();
			BoothlightsColour1Button.BackColor = Color.FromArgb(BoothlightsColour1);
		}

		private void BoothlightsColour2Button_Click(object sender, EventArgs e)
		{
			BoothlightsColour2 = ColourSelectMulti();
			BoothlightsColour2Button.BackColor = Color.FromArgb(BoothlightsColour2);
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
					if (BoothlightsIIS)
					{
						BoothLeft = 0;
						BoothRight = 0;
					}
					if (LasersIIS)
					{
						Laser1 = 0;
						Laser2 = 0;
					}
					if (ToplightsIIS)
					{
						Top1 = 0;
						Top2 = 0;
						Top3 = 0;
						Top4 = 0;
					}
					if (LeftlightsIIS)
					{
						Left1 = 0;
						Left2 = 0;
						Left3 = 0;
					}
					if (RightlightsIIS)
					{
						Right1 = 0;
						Right2 = 0;
						Right3 = 0;
					}
					if (BacklightsIIS)
					{
						Back1 = 0;
						Back2 = 0;
					}

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
			if (e.KeyCode == Keys.Space)
			{
				BPMTapButton.PerformClick();
			}

			if (e.KeyCode == Keys.S)
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

		private void showOBSLayerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Tailbass_Lighting_Control.OBSLayer boop = new Tailbass_Lighting_Control.OBSLayer();
			boop.Show();
		}

		private void openSceneControllerToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Tailbass_Lighting_Control.SceneController boop = new Tailbass_Lighting_Control.SceneController();
			boop.Show();
		}

		private void LaserToggleButton_Click(object sender, EventArgs e)
		{
			if (LasersToggle)
			{
				LasersToggleButton.ForeColor = Color.Red;
				LasersToggle = false;
			}
			else
			{
				LasersToggleButton.ForeColor = Color.LimeGreen;
				LasersToggle = true;
			}
			PatternEngineBPMPushColours = true;
		}

		private void BackLightsToggleButton_Click(object sender, EventArgs e)
		{
			if (BacklightsToggle)
			{
				BackLightsToggleButton.ForeColor = Color.Red;
				BacklightsToggle = false;
			}
			else
			{
				BackLightsToggleButton.ForeColor = Color.LimeGreen;
				BacklightsToggle = true;
			}
			PatternEngineBPMPushColours = true;
		}

		private void TopLightsToggleButton_Click(object sender, EventArgs e)
		{
			if (ToplightsToggle)
			{
				TopLightsToggleButton.ForeColor = Color.Red;
				ToplightsToggle = false;
			}
			else
			{
				TopLightsToggleButton.ForeColor = Color.LimeGreen;
				ToplightsToggle = true;
			}
			PatternEngineBPMPushColours = true;
		}

		private void LeftLightsToggleButton_Click(object sender, EventArgs e)
		{
			if (LeftlightsToggle)
			{
				LeftLightsToggleButton.ForeColor = Color.Red;
				LeftlightsToggle = false;
			}
			else
			{
				LeftLightsToggleButton.ForeColor = Color.LimeGreen;
				LeftlightsToggle = true;
			}
			PatternEngineBPMPushColours = true;
		}

		private void RightLightsToggleButton_Click(object sender, EventArgs e)
		{
			if (RightlightsToggle)
			{
				RightLightsToggleButton.ForeColor = Color.Red;
				RightlightsToggle = false;
			}
			else
			{
				RightLightsToggleButton.ForeColor = Color.LimeGreen;
				RightlightsToggle = true;
			}
			PatternEngineBPMPushColours = true;
		}

		private void BoothLightsToggleButton_Click(object sender, EventArgs e)
		{
			if (BoothlightsToggle)
			{
				BoothLightsToggleButton.ForeColor = Color.Red;
				BoothlightsToggle = false;
			}
			else
			{
				BoothLightsToggleButton.ForeColor = Color.LimeGreen;
				BoothlightsToggle = true;
			}
			PatternEngineBPMPushColours = true;
		}

		private void LasersIISToggle_Click(object sender, EventArgs e)
		{
			if (LasersIIS)
			{
				LasersIISToggle.ForeColor = Color.Red;
				LasersIIS = false;
			}
			else
			{
				LasersIISToggle.ForeColor = Color.LimeGreen;
				LasersIIS = true;
			}
		}

		private void BackLightsIISToggle_Click(object sender, EventArgs e)
		{
			if (BacklightsIIS)
			{
				BackLightsIISToggle.ForeColor = Color.Red;
				BacklightsIIS = false;
			}
			else
			{
				BackLightsIISToggle.ForeColor = Color.LimeGreen;
				BacklightsIIS = true;
			}
		}

		private void TopLightsIISToggle_Click(object sender, EventArgs e)
		{
			if (ToplightsIIS)
			{
				TopLightsIISToggle.ForeColor = Color.Red;
				ToplightsIIS = false;
			}
			else
			{
				TopLightsIISToggle.ForeColor = Color.LimeGreen;
				ToplightsIIS = true;
			}
		}

		private void LeftLightsIISToggle_Click(object sender, EventArgs e)
		{
			if (LeftlightsIIS)
			{
				LeftLightsIISToggle.ForeColor = Color.Red;
				LeftlightsIIS = false;
			}
			else
			{
				LeftLightsIISToggle.ForeColor = Color.LimeGreen;
				LeftlightsIIS = true;
			}
		}

		private void RightLightsIISToggle_Click(object sender, EventArgs e)
		{
			if (RightlightsIIS)
			{
				RightLightsIISToggle.ForeColor = Color.Red;
				RightlightsIIS = false;
			}
			else
			{
				RightLightsIISToggle.ForeColor = Color.LimeGreen;
				RightlightsIIS = true;
			}
		}

		private void BoothLightsIISToggle_Click(object sender, EventArgs e)
		{
			if (BoothlightsIIS)
			{
				BoothLightsIISToggle.ForeColor = Color.Red;
				BoothlightsIIS = false;
			}
			else
			{
				BoothLightsIISToggle.ForeColor = Color.LimeGreen;
				BoothlightsIIS = true;
			}
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			//GlobalMode Toggle
			if (GlobalMode)
			{
				GlobalModeToggleButton.ForeColor = Color.Red;
				GlobalModeToggleButton.Text = "Global Mode Off";
				GlobalMode = false;
			}
			else
			{
				GlobalModeToggleButton.ForeColor = Color.LimeGreen;
				GlobalModeToggleButton.Text = "Global Mode On";
				GlobalMode = true;
			}


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

		private void BPMLabel_Click(object sender, EventArgs e)
		{
			if (BPMPanel.Visible)
			{
				BPMPanel.Visible = false;
			}
			else
			{
				BPMPanel.Visible = true;
			}
			
		}

		private void SetBPMButton_Click(object sender, EventArgs e)
		{
			Int32 BPMinMS = 0;

			BPMinMS = (60000 / Convert.ToInt32(BPMSetVal.Value));
			BPMLabel.Text = BPMSetVal.Value.ToString();
			BPMTimer.Interval = BPMinMS;
			PatternEngineBPM.Interval = BPMinMS;
		}

		private void BPMDouble_Click(object sender, EventArgs e)
		{
			Int32 BPMinMS = 0;
			Int32 Doubley = (2 * Convert.ToInt32(BPMSetVal.Value)); 

			if(Doubley > 1000)
			{
				Doubley = 1000;
			}

			BPMinMS = (60000 / Doubley);
			BPMSetVal.Value = Doubley;
			BPMLabel.Text = Doubley.ToString();
			BPMTimer.Interval = BPMinMS;
			PatternEngineBPM.Interval = BPMinMS;
		}

		private void BPMHalf_Click(object sender, EventArgs e)
		{
			Int32 BPMinMS = 0;
			Int32 Halfey = (Convert.ToInt32(BPMSetVal.Value) / 2);

			if (Halfey < 1)
			{
				Halfey = 1;
			}

			BPMinMS = (60000 / Halfey);
			BPMSetVal.Value = Halfey;
			BPMLabel.Text = Halfey.ToString();
			BPMTimer.Interval = BPMinMS;
			PatternEngineBPM.Interval = BPMinMS;
		}

		private void GlobalPatternMode_SelectedIndexChanged(object sender, EventArgs e)
		{
			GlobalPattern = GlobalPatternMode.SelectedIndex;
		}

		private void LasersPatternMode_SelectedIndexChanged(object sender, EventArgs e)
		{
			LasersPattern = LasersPatternMode.SelectedIndex;
		}

		private void BacklightsPatternMode_SelectedIndexChanged(object sender, EventArgs e)
		{
			BackLightsPattern = BacklightsPatternMode.SelectedIndex;	
		}

		private void ToplightsPatternMode_SelectedIndexChanged(object sender, EventArgs e)
		{
			TopLightsPattern = ToplightsPatternMode.SelectedIndex;
		}

		private void LeftlightsPatternMode_SelectedIndexChanged(object sender, EventArgs e)
		{
			LeftLightsPattern = LeftlightsPatternMode.SelectedIndex;
		}

		private void RightlightsPatternMode_SelectedIndexChanged(object sender, EventArgs e)
		{
			RightLightsPattern = RightlightsPatternMode.SelectedIndex;
		}

		private void BoothlightsPatternMode_SelectedIndexChanged(object sender, EventArgs e)
		{
			BoothLightsPattern = BoothlightsPatternMode.SelectedIndex;	
		}

		private void toolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Tailbass_Lighting_Control.Settings arf = new Tailbass_Lighting_Control.Settings();
			arf.Show();
		}
	}
}