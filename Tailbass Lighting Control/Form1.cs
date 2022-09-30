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
		public static int GlobalColour2 = 0;

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
		public static int LasersColour1 = 0;
		public static int LasersColour2 = 0;
		public static int BacklightsColour1 = 0;
		public static int BacklightsColour2 = 0;
		public static int ToplightsColour1 = 0;
		public static int ToplightsColour2 = 0;
		public static int LeftlightsColour1 = 0;
		public static int LeftlightsColour2 = 0;
		public static int RightlightsColour1 = 0;
		public static int RightlightsColour2 = 0;
		public static int BoothlightsColour1 = 0;
		public static int BoothlightsColour2 = 0;
		public static List<int> ColorVars = new List<int>() { LasersColour1, LasersColour2, BacklightsColour1, BacklightsColour2, ToplightsColour1, ToplightsColour2, LeftlightsColour1, LeftlightsColour2, RightlightsColour1, RightlightsColour2, BoothlightsColour1, BoothlightsColour2 };

		//LightOutput
		public static int Laser1 = 0;
		public static int Laser2 = 0;
		public static int Back1 = 0;
		public static int Back2 = 0;
		public static int Top1 = 0;
		public static int Top2 = 0;
		public static int Top3 = 0;
		public static int Top4 = 0;
		public static int Left1 = 0;
		public static int Left2 = 0;
		public static int Left3 = 0;
		public static int Right1 = 0;
		public static int Right2 = 0;
		public static int Right3 = 0;
		public static int BoothLeft = 0;
		public static int BoothRight = 0;
		public static List<int> Lights = new List<int>() { Laser1, Laser2, Back1, Back2, Top1, Top2, Top3, Top4, Left1, Left2, Left3, Right1, Right2, Right3, BoothLeft, BoothRight };

		public static int OldLaser1 = 0;
		public static int OldLaser2 = 0;
		public static int OldBack1 = 0;
		public static int OldBack2 = 0;
		public static int OldTop1 = 0;
		public static int OldTop2 = 0;
		public static int OldTop3 = 0;
		public static int OldTop4 = 0;
		public static int OldLeft1 = 0;
		public static int OldLeft2 = 0;
		public static int OldLeft3 = 0;
		public static int OldRight1 = 0;
		public static int OldRight2 = 0;
		public static int OldRight3 = 0;
		public static int OldBoothLeft = 0;
		public static int OldBoothRight = 0;
		public static List<int> OldLights = new List<int>() { OldLaser1, OldLaser2, OldBack1, OldBack2, OldTop1, OldTop2, OldTop3, OldTop4, OldLeft1, OldLeft2, OldLeft3, OldRight1, OldRight2, OldRight3, OldBoothLeft, OldBoothRight };

		public MainUI()
		{
			InitializeComponent();
			BPMStopwatchActive = false;
			BPMReadable = 128.00;
			this.KeyPreview = true;
			this.AutoScaleMode = AutoScaleMode.Dpi;
		}

		public static int ColourSelectMulti()
		{
			ColorDialog MasterSelector = new ColorDialog();
			MasterSelector.ShowDialog();

			return MasterSelector.Color.ToArgb();
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
			BPMLabel.BackColor = ticktock ? Color.DarkGreen : Color.Gray;
			ticktock ^= ticktock;
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
			GlobalColour2Button.BackColor = Color.FromArgb(GlobalColour2);
			Debug.WriteLine("Global Colour 2: " + GlobalColour2);
		}

		private void GlobalColour1Button_Click(object sender, EventArgs e)
		{
			GlobalColour1 = ColourSelectMulti();
			GlobalColour1Button.BackColor = Color.FromArgb(GlobalColour1);
			Debug.WriteLine("Global Colour 1: " + GlobalColour1);
		}

		private void ShowOBS_Click(object sender, EventArgs e)
		{
			Tailbass_Lighting_Control.OBSLayer boop = new Tailbass_Lighting_Control.OBSLayer();
			boop.Show();
		}

		private void LasersColour1Button_Click(object sender, EventArgs e)
		{
			LasersColour1 = ColourSelectMulti();
			LasersColour1Button.BackColor = Color.FromArgb(LasersColour1);
		}

		private void LasersColour2Button_Click(object sender, EventArgs e)
		{
			LasersColour2 = ColourSelectMulti();
			LasersColour2Button.BackColor = Color.FromArgb(LasersColour2);
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
			//Ensure that the beat counts up from 1 to 4 and wraps around indefinitely
			BeatNo = (BeatNo % 4) + 1;

			if (RefreshColoursFromRAM)
			{
				RefreshColoursFromRAM = false;

				//Global Stuff
				if (GlobalMode)
				{
					GlobalModeToggleButton.ForeColor = Color.Lime;
					GlobalModeToggleButton.Text = "Global Mode On";
				}
				else
				{
					GlobalModeToggleButton.ForeColor = Color.Red;
					GlobalModeToggleButton.Text = "Global Mode Off";
				}
				GlobalColour1Button.BackColor = Color.FromArgb(GlobalColour1);
				GlobalColour2Button.BackColor = Color.FromArgb(GlobalColour2);
				GlobalPatternMode.SelectedIndex = GlobalPattern;

				//Lasers
				LasersColour1Button.BackColor = Color.FromArgb(LasersColour1);
				LasersColour2Button.BackColor = Color.FromArgb(LasersColour2);
				LasersPatternMode.SelectedIndex = LasersPattern;

				LasersToggleButton.ForeColor = LasersToggle ? Color.Lime : Color.Red;

				//Back Lights
				BacklightsColour1Button.BackColor = Color.FromArgb(BacklightsColour1);
				BacklightsColour2Button.BackColor = Color.FromArgb(BacklightsColour2);
				BacklightsPatternMode.SelectedIndex = BackLightsPattern;

				BackLightsToggleButton.ForeColor = BacklightsToggle ? Color.Lime : Color.Red;

				//Booth Lights
				BoothlightsColour1Button.BackColor = Color.FromArgb(BoothlightsColour1);
				BoothlightsColour2Button.BackColor = Color.FromArgb(BoothlightsColour2);
				BoothlightsPatternMode.SelectedIndex = BoothLightsPattern;

				BoothLightsToggleButton.ForeColor = BoothlightsToggle ? Color.Lime : Color.Red;

				//Top Lights
				ToplightsColour1Button.BackColor = Color.FromArgb(ToplightsColour1);
				ToplightsColour2Button.BackColor = Color.FromArgb(ToplightsColour2);
				ToplightsPatternMode.SelectedIndex = TopLightsPattern;

				TopLightsToggleButton.ForeColor = ToplightsToggle ? Color.Lime : Color.Red;

				//Left Lights
				LeftlightsColour1Button.BackColor = Color.FromArgb(LeftlightsColour1);
				LeftlightsColour2Button.BackColor = Color.FromArgb(LeftlightsColour2);
				LeftlightsPatternMode.SelectedIndex = LeftLightsPattern;

				LeftLightsToggleButton.ForeColor = LeftlightsToggle ? Color.Lime : Color.Red;

				//Right Lights
				RightlightsColour1Button.BackColor = Color.FromArgb(RightlightsColour1);
				RightlightsColour2Button.BackColor = Color.FromArgb(RightlightsColour2);
				RightlightsPatternMode.SelectedIndex = RightLightsPattern;

				RightLightsToggleButton.ForeColor = RightlightsToggle ? Color.Lime : Color.Red;
			}

			if (GlobalMode)
			{
				PatternEngineBPMPushColours = true;
				//Check Which Pattern Is Selected, IF BPM based then it works somewhere here
				if (GlobalPattern == 0) //Solid Colour
				{
					for (int i = 0; i < Lights.Count; i++)
					{
						Lights[i] = GlobalColour1;
					}
				}
				else if (GlobalPattern == 1) //Split
				{
					for (int i = 0; i < Lights.Count; i++)
					{
						Lights[i] = i % 2 == 0 ? GlobalColour1 : GlobalColour2;
					}
				}
				else if (GlobalPattern == 2) //Alternating
				{
					for (int i = 0; i < Lights.Count; i++)
					{
						Lights[i] = BeatNo % 2 == 1 ? GlobalColour1 : GlobalColour2;
					}
				}
				else if (GlobalPattern == 3) //Alternating Split
				{
					for (int i = 0; i < Lights.Count; i++)
					{
						//Firstly, the beat will be odd or even giving it a static 0 or 1 to add in to the evaluation.
						//Secondly, the i will be odd or even and alternate as it counts up, making the color assigned alternate in kind.
						Lights[i] = (BeatNo % 2) + (i % 2) == 1 ? GlobalColour1 : GlobalColour2;
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
					//The first laser is always laser color 1 when it's pattern 0 or 1, or when it's beat #1 otherwise.
					Laser1 = LasersPattern <= 2 || (LasersPattern >= 3 && BeatNo == 1) ? LasersColour1 : LasersColour2;
					//Laser 2 looks more complicated, but it's just always the same color when it's pattern 1 or 3, and the opposite otherwise.
					Laser2 = LasersPattern == 1 || LasersPattern == 3 ? Laser1 : (LasersColour1 + LasersColour2) - Laser1;

					PatternEngineBPMPushColours = true;
				}
				else
				{
					Laser1 = 0;
					Laser2 = 0;
				}

				//Back Lights
				if (BacklightsToggle)
				{
					Back1 = BackLightsPattern <= 2 || (BackLightsPattern >= 3 && BeatNo == 1) ? BacklightsColour1 : BacklightsColour2;
					Back2 = BackLightsPattern == 1 || BackLightsPattern == 3 ? Back1 : (BacklightsColour1 + BacklightsColour2) - Back1;

					PatternEngineBPMPushColours = true;
				}
				else
				{
					Back1 = 0;
					Back2 = 0;
				}

				//Booth Lights
				if (BoothlightsToggle)
				{
					BoothLeft = BoothLightsPattern <= 2 || (BoothLightsPattern >= 3 && BeatNo == 1) ? BoothlightsColour1 : BoothlightsColour2;
					BoothRight = BoothLightsPattern == 1 || BoothLightsPattern == 3 ? BoothLeft : (BoothlightsColour1 + BoothlightsColour2) - BoothLeft;

					PatternEngineBPMPushColours = true;
				}
				else
				{
					BoothLeft = 0;
					BoothRight = 0;
				}

				//Top Lights
				if (ToplightsToggle)
				{
					if (TopLightsPattern <= 3 || (TopLightsPattern == 5 && BeatNo % 2 == 1) || (TopLightsPattern == 6 && BeatNo == 1) || (TopLightsPattern == 7 && BeatNo == 4))
					{
						Top1 = ToplightsColour1;
					}
					else if (TopLightsPattern == 4)
					{
						Top1 = 0;
					}
					else
					{
						Top1 = ToplightsColour2;
					}

					if (TopLightsPattern <= 1 || (TopLightsPattern == 6 && BeatNo == 3) || (TopLightsPattern == 7 && BeatNo <= 2))
					{
						Top2 = Top1;
					}
					else if (TopLightsPattern == 3)
					{
						Top2 = 0;
					}
					else
					{
						Top2 = ToplightsColour1 + ToplightsColour2 - Top1;
					}

					if (TopLightsPattern == 1 || TopLightsPattern == 5 || (TopLightsPattern == 6 && BeatNo % 2 == 0) || (TopLightsPattern == 7 && BeatNo % 2 == 1))
					{
						Top3 = Top1;
					}
					else if (TopLightsPattern == 3)
					{
						Top3 = 0;
					}
					else
					{
						Top3 = ToplightsColour1 + ToplightsColour2 - Top1;
					}

					if (TopLightsPattern == 0 || TopLightsPattern == 2 || (TopLightsPattern <= 6 && (BeatNo == 2 || BeatNo == 3)))
					{
						Top4 = Top1;
					}
					else if (TopLightsPattern == 4)
					{
						Top4 = 0;
					}
					else
					{
						Top4 = ToplightsColour1 + ToplightsColour2 - Top1;
					}

					PatternEngineBPMPushColours = true;
				}
				else
				{
					Top1 = 0;
					Top2 = 0;
					Top3 = 0;
					Top4 = 0;
				}

				//Left Lights
				if (LeftlightsToggle)
				{
					if (LeftLightsPattern == 0)
					{
						Left1 = LeftlightsColour1;
						Left2 = LeftlightsColour1;
						Left3 = LeftlightsColour1;
					}
					if (LeftLightsPattern == 1)
					{
						Left1 = LeftlightsColour1;
						Left2 = LeftlightsColour2;
						Left3 = LeftlightsColour1;
					}
					if (LeftLightsPattern == 2)
					{
						if (BeatNo == 1 || BeatNo == 3)
						{
							Left1 = LeftlightsColour1;
							Left2 = LeftlightsColour1;
							Left3 = LeftlightsColour1;
						}
						else
						{
							Left1 = LeftlightsColour2;
							Left2 = LeftlightsColour2;
							Left3 = LeftlightsColour2;
						}
					}
					if (LeftLightsPattern == 3)
					{
						if (BeatNo == 1 || BeatNo == 3)
						{
							Left1 = LeftlightsColour1;
							Left2 = LeftlightsColour2;
							Left3 = LeftlightsColour1;
						}
						else
						{
							Left1 = LeftlightsColour2;
							Left2 = LeftlightsColour1;
							Left3 = LeftlightsColour2;
						}
					}
					if (LeftLightsPattern == 4)
					{
						if (BeatNo == 1)
						{
							Left1 = LeftlightsColour1;
							Left2 = LeftlightsColour2;
							Left3 = LeftlightsColour2;
						}
						else if (BeatNo == 2)
						{
							Left1 = LeftlightsColour2;
							Left2 = LeftlightsColour1;
							Left3 = LeftlightsColour2;
						}
						else if (BeatNo == 3)
						{
							Left1 = LeftlightsColour2;
							Left2 = LeftlightsColour2;
							Left3 = LeftlightsColour1;
						}
						else if (BeatNo == 4)
						{
							Left1 = LeftlightsColour2;
							Left2 = LeftlightsColour2;
							Left3 = LeftlightsColour2;
						}
					}
					if (LeftLightsPattern == 5)
					{
						if (BeatNo == 4)
						{
							Left1 = LeftlightsColour1;
							Left2 = LeftlightsColour2;
							Left3 = LeftlightsColour2;
						}
						else if (BeatNo == 3)
						{
							Left1 = LeftlightsColour2;
							Left2 = LeftlightsColour1;
							Left3 = LeftlightsColour2;
						}
						else if (BeatNo == 2)
						{
							Left1 = LeftlightsColour2;
							Left2 = LeftlightsColour2;
							Left3 = LeftlightsColour1;
						}
						else if (BeatNo == 1)
						{
							Left1 = LeftlightsColour2;
							Left2 = LeftlightsColour2;
							Left3 = LeftlightsColour2;
						}
					}

					PatternEngineBPMPushColours = true;
				}
				else
				{
					Left1 = 0;
					Left2 = 0;
					Left3 = 0;
				}

				//Right Lights
				if (RightlightsToggle)
				{
					if (RightLightsPattern == 0)
					{
						Right1 = RightlightsColour1;
						Right2 = RightlightsColour1;
						Right3 = RightlightsColour1;
					}
					if (RightLightsPattern == 1)
					{
						Right1 = RightlightsColour1;
						Right2 = RightlightsColour2;
						Right3 = RightlightsColour1;
					}
					if (RightLightsPattern == 2)
					{
						if (BeatNo == 1 || BeatNo == 3)
						{
							Right1 = RightlightsColour1;
							Right2 = RightlightsColour1;
							Right3 = RightlightsColour1;
						}
						else
						{
							Right1 = RightlightsColour2;
							Right2 = RightlightsColour2;
							Right3 = RightlightsColour2;
						}
					}
					if (RightLightsPattern == 3)
					{
						if (BeatNo == 1 || BeatNo == 3)
						{
							Right1 = RightlightsColour1;
							Right2 = RightlightsColour2;
							Right3 = RightlightsColour1;
						}
						else
						{
							Right1 = RightlightsColour2;
							Right2 = RightlightsColour1;
							Right3 = RightlightsColour2;
						}
					}
					if (RightLightsPattern == 4)
					{
						if (BeatNo == 1)
						{
							Right1 = RightlightsColour1;
							Right2 = RightlightsColour2;
							Right3 = RightlightsColour2;
						}
						else if (BeatNo == 2)
						{
							Right1 = RightlightsColour2;
							Right2 = RightlightsColour1;
							Right3 = RightlightsColour2;
						}
						else if (BeatNo == 3)
						{
							Right1 = RightlightsColour2;
							Right2 = RightlightsColour2;
							Right3 = RightlightsColour1;
						}
						else if (BeatNo == 4)
						{
							Right1 = RightlightsColour2;
							Right2 = RightlightsColour2;
							Right3 = RightlightsColour2;
						}
					}
					if (RightLightsPattern == 5)
					{
						if (BeatNo == 4)
						{
							Right1 = RightlightsColour1;
							Right2 = RightlightsColour2;
							Right3 = RightlightsColour2;
						}
						else if (BeatNo == 3)
						{
							Right1 = RightlightsColour2;
							Right2 = RightlightsColour1;
							Right3 = RightlightsColour2;
						}
						else if (BeatNo == 2)
						{
							Right1 = RightlightsColour2;
							Right2 = RightlightsColour2;
							Right3 = RightlightsColour1;
						}
						else if (BeatNo == 1)
						{
							Right1 = RightlightsColour2;
							Right2 = RightlightsColour2;
							Right3 = RightlightsColour2;
						}
					}

					PatternEngineBPMPushColours = true;
				}
				else
				{
					Right1 = 0;
					Right2 = 0;
					Right3 = 0;
				}
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

				PairOldLightValues();
			}
		}

		/// <summary>
		/// Assigns the value for each light in the old array to the values in the new light array.
		/// </summary>
		protected void PairOldLightValues()
		{
			for (int i = 0; i < OldLights.Count(); i++)
			{
				OldLights[i] = Lights[i];
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
			StrobeClockTok ^= StrobeClockTok;
			PairOldLightValues();

			PreviewGrid.Items[0].BackColor = Color.FromArgb(Convert.ToInt32(StrobeActive) * BoothLeft);
			PreviewGrid.Items[1].BackColor = Color.FromArgb(Convert.ToInt32(StrobeActive) * BoothRight);
			PreviewGrid.Items[2].BackColor = Color.FromArgb(Convert.ToInt32(StrobeActive) * Laser1);
			PreviewGrid.Items[3].BackColor = Color.FromArgb(Convert.ToInt32(StrobeActive) * Laser2);
			PreviewGrid.Items[4].BackColor = Color.FromArgb(Convert.ToInt32(StrobeActive) * Left1);
			PreviewGrid.Items[5].BackColor = Color.FromArgb(Convert.ToInt32(StrobeActive) * Left2);
			PreviewGrid.Items[6].BackColor = Color.FromArgb(Convert.ToInt32(StrobeActive) * Left3);
			PreviewGrid.Items[7].BackColor = Color.FromArgb(Convert.ToInt32(StrobeActive) * Back1);
			PreviewGrid.Items[8].BackColor = Color.FromArgb(Convert.ToInt32(StrobeActive) * Back2);
			PreviewGrid.Items[9].BackColor = Color.FromArgb(Convert.ToInt32(StrobeActive) * Right1);
			PreviewGrid.Items[10].BackColor = Color.FromArgb(Convert.ToInt32(StrobeActive) * Right2);
			PreviewGrid.Items[11].BackColor = Color.FromArgb(Convert.ToInt32(StrobeActive) * Right3);
			PreviewGrid.Items[12].BackColor = Color.FromArgb(Convert.ToInt32(StrobeActive) * Top1);
			PreviewGrid.Items[13].BackColor = Color.FromArgb(Convert.ToInt32(StrobeActive) * Top2);
			PreviewGrid.Items[14].BackColor = Color.FromArgb(Convert.ToInt32(StrobeActive) * Top3);
			PreviewGrid.Items[15].BackColor = Color.FromArgb(Convert.ToInt32(StrobeActive) * Top4);

			StrobeButton.ForeColor = StrobeActive ? Color.Black : Color.Lime;
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
			LasersToggleButton.ForeColor = LasersToggle ? Color.Red : Color.LimeGreen;
			LasersToggle ^= LasersToggle;
			PatternEngineBPMPushColours = true;
		}

		private void BackLightsToggleButton_Click(object sender, EventArgs e)
		{
			BackLightsToggleButton.ForeColor = BacklightsToggle ? Color.Red : Color.LimeGreen;
			BacklightsToggle ^= BacklightsToggle;
			PatternEngineBPMPushColours = true;
		}

		private void TopLightsToggleButton_Click(object sender, EventArgs e)
		{
			TopLightsToggleButton.ForeColor = ToplightsToggle ? Color.Red : Color.LimeGreen;
			ToplightsToggle ^= ToplightsToggle;
			PatternEngineBPMPushColours = true;
		}

		private void LeftLightsToggleButton_Click(object sender, EventArgs e)
		{
			LeftLightsToggleButton.ForeColor = LeftlightsToggle ? Color.Red : Color.LimeGreen;
			LeftlightsToggle ^= LeftlightsToggle;
			PatternEngineBPMPushColours = true;
		}

		private void RightLightsToggleButton_Click(object sender, EventArgs e)
		{
			RightLightsToggleButton.ForeColor = RightlightsToggle ? Color.Red : Color.LimeGreen;
			RightlightsToggle ^= RightlightsToggle;
			PatternEngineBPMPushColours = true;
		}

		private void BoothLightsToggleButton_Click(object sender, EventArgs e)
		{
			BoothLightsToggleButton.ForeColor = BoothlightsToggle ? Color.Red : Color.LimeGreen;
			BoothlightsToggle ^= BoothlightsToggle;
			PatternEngineBPMPushColours = true;
		}

		private void LasersIISToggle_Click(object sender, EventArgs e)
		{
			LasersIISToggle.ForeColor = LasersIIS ? Color.Red : Color.LimeGreen;
			LasersIIS ^= LasersIIS;
		}

		private void BackLightsIISToggle_Click(object sender, EventArgs e)
		{
			BackLightsIISToggle.ForeColor = BacklightsIIS ? Color.Red : Color.LimeGreen;
			BacklightsIIS ^= BacklightsIIS;
		}

		private void TopLightsIISToggle_Click(object sender, EventArgs e)
		{
			TopLightsIISToggle.ForeColor = ToplightsIIS ? Color.Red : Color.LimeGreen;
			ToplightsIIS ^= ToplightsIIS;
		}

		private void LeftLightsIISToggle_Click(object sender, EventArgs e)
		{
			LeftLightsIISToggle.ForeColor = LeftlightsIIS ? Color.Red : Color.LimeGreen;
			LeftlightsIIS ^= LeftlightsIIS;
		}

		private void RightLightsIISToggle_Click(object sender, EventArgs e)
		{
			RightLightsIISToggle.ForeColor = RightlightsIIS ? Color.Red : Color.LimeGreen;
			RightlightsIIS ^= RightlightsIIS;
		}

		private void BoothLightsIISToggle_Click(object sender, EventArgs e)
		{
			BoothLightsIISToggle.ForeColor = BoothlightsIIS ? Color.Red : Color.LimeGreen;
			BoothlightsIIS ^= BoothlightsIIS;
		}

		private void button1_Click_1(object sender, EventArgs e)
		{
			//GlobalMode Toggle
			if (GlobalMode)
			{
				GlobalModeToggleButton.ForeColor = Color.Red;
				GlobalModeToggleButton.Text = "Global Mode Off";
			}
			else
			{
				GlobalModeToggleButton.ForeColor = Color.LimeGreen;
				GlobalModeToggleButton.Text = "Global Mode On";
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

			GlobalMode ^= GlobalMode;
		}

		private void BPMLabel_Click(object sender, EventArgs e)
		{
			BPMPanel.Visible ^= BPMPanel.Visible;
		}

		private void SetBPMButton_Click(object sender, EventArgs e)
		{
			Int32 BPMinMS = 0;

			//Dividing int to int has different behaviour than dividing decimal to decimal
			BPMinMS = (60000 / Convert.ToInt32(BPMSetVal.Value));
			BPMLabel.Text = BPMSetVal.Value.ToString();
			BPMTimer.Interval = BPMinMS;
			PatternEngineBPM.Interval = BPMinMS;
		}

		private void BPMDouble_Click(object sender, EventArgs e)
		{
			Int32 BPMinMS = 0;
			Int32 Doubley = (2 * Convert.ToInt32(BPMSetVal.Value));

			if (Doubley > 1000)
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

		private void BPMPanel_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}