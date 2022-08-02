namespace Tailbass_Lighting_Control
{
	partial class MainUI
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Booth Left"}, 0, System.Drawing.Color.Empty, System.Drawing.Color.Black, new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point));
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Booth Right"}, 0, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point));
			System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "Laser Left"}, 0, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point));
			System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "Laser Right"}, 0, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point));
			System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "Left Side 1"}, 0, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point));
			System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "Left Side 2"}, 0, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point));
			System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "Left Side 3"}, 0, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point));
			System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "Rear Left"}, 0, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point));
			System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "Rear Right"}, 0, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point));
			System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "Right Side 1"}, 0, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point));
			System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "Right Side 2"}, 0, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point));
			System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
            "Right Side 3"}, 0, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point));
			System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem(new string[] {
            "Top Left Inner"}, 0, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point));
			System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem(new string[] {
            "Top Left Outer"}, 0, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point));
			System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem(new string[] {
            "Top Right Inner"}, 0, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point));
			System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem(new string[] {
            "Top Right Outer"}, 0, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point));
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
			this.BPMTapButton = new System.Windows.Forms.Button();
			this.BPMLabel = new System.Windows.Forms.Label();
			this.PatternEngine = new System.ComponentModel.BackgroundWorker();
			this.BPMTimer = new System.Windows.Forms.Timer(this.components);
			this.StopwatchManager = new System.ComponentModel.BackgroundWorker();
			this.PreviewGrid = new System.Windows.Forms.ListView();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.ToggleLasers = new System.Windows.Forms.CheckBox();
			this.ToggleBack = new System.Windows.Forms.CheckBox();
			this.ToggleTopLights = new System.Windows.Forms.CheckBox();
			this.ToggleLeftLights = new System.Windows.Forms.CheckBox();
			this.ToggleRightLights = new System.Windows.Forms.CheckBox();
			this.ToggleBoothLights = new System.Windows.Forms.CheckBox();
			this.LasersColour1Button = new System.Windows.Forms.Button();
			this.LasersColour2Button = new System.Windows.Forms.Button();
			this.BacklightsColour2Button = new System.Windows.Forms.Button();
			this.BacklightsColour1Button = new System.Windows.Forms.Button();
			this.ToplightsColour2Button = new System.Windows.Forms.Button();
			this.ToplightsColour1Button = new System.Windows.Forms.Button();
			this.LeftlightsColour2Button = new System.Windows.Forms.Button();
			this.LeftlightsColour1Button = new System.Windows.Forms.Button();
			this.RightlightsColour2Button = new System.Windows.Forms.Button();
			this.RightlightsColour1Button = new System.Windows.Forms.Button();
			this.BoothlightsColour2Button = new System.Windows.Forms.Button();
			this.BoothlightsColour1Button = new System.Windows.Forms.Button();
			this.GlobalColour2Button = new System.Windows.Forms.Button();
			this.GlobalModeToggle = new System.Windows.Forms.CheckBox();
			this.LasersPatternMode = new System.Windows.Forms.ComboBox();
			this.GlobalPatternMode = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.GlobalColour1Button = new System.Windows.Forms.Button();
			this.ShowOBS = new System.Windows.Forms.Button();
			this.PatternEngineBPM = new System.Windows.Forms.Timer(this.components);
			this.BacklightsPatternMode = new System.Windows.Forms.ComboBox();
			this.BoothlightsPatternMode = new System.Windows.Forms.ComboBox();
			this.ToplightsPatternMode = new System.Windows.Forms.ComboBox();
			this.LeftlightsPatternMode = new System.Windows.Forms.ComboBox();
			this.RightlightsPatternMode = new System.Windows.Forms.ComboBox();
			this.LasersIIS = new System.Windows.Forms.CheckBox();
			this.BacklightsIIS = new System.Windows.Forms.CheckBox();
			this.ToplightsIIS = new System.Windows.Forms.CheckBox();
			this.LeftlightsIIS = new System.Windows.Forms.CheckBox();
			this.RightlighsIIS = new System.Windows.Forms.CheckBox();
			this.BoothlightsIIS = new System.Windows.Forms.CheckBox();
			this.StrobeButton = new System.Windows.Forms.Button();
			this.StrobeClock = new System.Windows.Forms.Timer(this.components);
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// BPMTapButton
			// 
			this.BPMTapButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BPMTapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BPMTapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BPMTapButton.Location = new System.Drawing.Point(12, 845);
			this.BPMTapButton.Name = "BPMTapButton";
			this.BPMTapButton.Size = new System.Drawing.Size(200, 200);
			this.BPMTapButton.TabIndex = 0;
			this.BPMTapButton.Text = "TAP BPM";
			this.BPMTapButton.UseVisualStyleBackColor = true;
			this.BPMTapButton.Click += new System.EventHandler(this.button1_Click);
			// 
			// BPMLabel
			// 
			this.BPMLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BPMLabel.BackColor = System.Drawing.Color.Gray;
			this.BPMLabel.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.BPMLabel.ForeColor = System.Drawing.Color.White;
			this.BPMLabel.Location = new System.Drawing.Point(12, 782);
			this.BPMLabel.Name = "BPMLabel";
			this.BPMLabel.Size = new System.Drawing.Size(200, 60);
			this.BPMLabel.TabIndex = 1;
			this.BPMLabel.Text = "128";
			this.BPMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// PatternEngine
			// 
			this.PatternEngine.WorkerReportsProgress = true;
			this.PatternEngine.WorkerSupportsCancellation = true;
			this.PatternEngine.DoWork += new System.ComponentModel.DoWorkEventHandler(this.PatternEngine_DoWork);
			// 
			// BPMTimer
			// 
			this.BPMTimer.Interval = 420;
			this.BPMTimer.Tick += new System.EventHandler(this.BPMTimer_Tick);
			// 
			// StopwatchManager
			// 
			this.StopwatchManager.WorkerReportsProgress = true;
			this.StopwatchManager.WorkerSupportsCancellation = true;
			this.StopwatchManager.DoWork += new System.ComponentModel.DoWorkEventHandler(this.StopwatchManager_DoWork);
			// 
			// PreviewGrid
			// 
			this.PreviewGrid.Activation = System.Windows.Forms.ItemActivation.TwoClick;
			this.PreviewGrid.BackColor = System.Drawing.Color.Black;
			this.PreviewGrid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PreviewGrid.Dock = System.Windows.Forms.DockStyle.Right;
			this.PreviewGrid.Font = new System.Drawing.Font("Segoe UI", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.PreviewGrid.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.PreviewGrid.GridLines = true;
			this.PreviewGrid.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.PreviewGrid.ImeMode = System.Windows.Forms.ImeMode.Off;
			listViewItem1.Checked = true;
			listViewItem1.StateImageIndex = 1;
			listViewItem2.Checked = true;
			listViewItem2.StateImageIndex = 1;
			listViewItem3.Checked = true;
			listViewItem3.StateImageIndex = 1;
			listViewItem4.Checked = true;
			listViewItem4.StateImageIndex = 1;
			listViewItem5.Checked = true;
			listViewItem5.StateImageIndex = 1;
			listViewItem6.Checked = true;
			listViewItem6.StateImageIndex = 1;
			listViewItem7.Checked = true;
			listViewItem7.StateImageIndex = 1;
			listViewItem8.Checked = true;
			listViewItem8.StateImageIndex = 1;
			listViewItem9.Checked = true;
			listViewItem9.StateImageIndex = 1;
			listViewItem10.Checked = true;
			listViewItem10.StateImageIndex = 1;
			listViewItem11.Checked = true;
			listViewItem11.StateImageIndex = 1;
			listViewItem12.Checked = true;
			listViewItem12.StateImageIndex = 1;
			listViewItem13.Checked = true;
			listViewItem13.StateImageIndex = 1;
			listViewItem14.Checked = true;
			listViewItem14.StateImageIndex = 1;
			listViewItem15.Checked = true;
			listViewItem15.StateImageIndex = 1;
			listViewItem16.Checked = true;
			listViewItem16.StateImageIndex = 1;
			this.PreviewGrid.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10,
            listViewItem11,
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16});
			this.PreviewGrid.Location = new System.Drawing.Point(1571, 0);
			this.PreviewGrid.Margin = new System.Windows.Forms.Padding(1);
			this.PreviewGrid.MultiSelect = false;
			this.PreviewGrid.Name = "PreviewGrid";
			this.PreviewGrid.Scrollable = false;
			this.PreviewGrid.ShowGroups = false;
			this.PreviewGrid.ShowItemToolTips = true;
			this.PreviewGrid.Size = new System.Drawing.Size(613, 1057);
			this.PreviewGrid.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.PreviewGrid.TabIndex = 2;
			this.PreviewGrid.TileSize = new System.Drawing.Size(300, 100);
			this.PreviewGrid.UseCompatibleStateImageBehavior = false;
			this.PreviewGrid.View = System.Windows.Forms.View.Tile;
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "lighticon.png");
			// 
			// ToggleLasers
			// 
			this.ToggleLasers.AutoSize = true;
			this.ToggleLasers.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ToggleLasers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.ToggleLasers.Location = new System.Drawing.Point(7, 325);
			this.ToggleLasers.Name = "ToggleLasers";
			this.ToggleLasers.Size = new System.Drawing.Size(154, 54);
			this.ToggleLasers.TabIndex = 5;
			this.ToggleLasers.Text = "Lasers";
			this.ToggleLasers.UseVisualStyleBackColor = true;
			this.ToggleLasers.CheckedChanged += new System.EventHandler(this.ToggleLasers_CheckedChanged);
			// 
			// ToggleBack
			// 
			this.ToggleBack.AutoSize = true;
			this.ToggleBack.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ToggleBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.ToggleBack.Location = new System.Drawing.Point(7, 401);
			this.ToggleBack.Name = "ToggleBack";
			this.ToggleBack.Size = new System.Drawing.Size(237, 54);
			this.ToggleBack.TabIndex = 6;
			this.ToggleBack.Text = "Back Lights";
			this.ToggleBack.UseVisualStyleBackColor = true;
			this.ToggleBack.CheckedChanged += new System.EventHandler(this.ToggleBack_CheckedChanged);
			// 
			// ToggleTopLights
			// 
			this.ToggleTopLights.AutoSize = true;
			this.ToggleTopLights.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ToggleTopLights.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.ToggleTopLights.Location = new System.Drawing.Point(7, 477);
			this.ToggleTopLights.Name = "ToggleTopLights";
			this.ToggleTopLights.Size = new System.Drawing.Size(221, 54);
			this.ToggleTopLights.TabIndex = 7;
			this.ToggleTopLights.Text = "Top Lights";
			this.ToggleTopLights.UseVisualStyleBackColor = true;
			this.ToggleTopLights.CheckedChanged += new System.EventHandler(this.ToggleTopLights_CheckedChanged);
			// 
			// ToggleLeftLights
			// 
			this.ToggleLeftLights.AutoSize = true;
			this.ToggleLeftLights.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ToggleLeftLights.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.ToggleLeftLights.Location = new System.Drawing.Point(7, 553);
			this.ToggleLeftLights.Name = "ToggleLeftLights";
			this.ToggleLeftLights.Size = new System.Drawing.Size(223, 54);
			this.ToggleLeftLights.TabIndex = 8;
			this.ToggleLeftLights.Text = "Left Lights";
			this.ToggleLeftLights.UseVisualStyleBackColor = true;
			this.ToggleLeftLights.CheckedChanged += new System.EventHandler(this.ToggleLeftLights_CheckedChanged);
			// 
			// ToggleRightLights
			// 
			this.ToggleRightLights.AutoSize = true;
			this.ToggleRightLights.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ToggleRightLights.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.ToggleRightLights.Location = new System.Drawing.Point(7, 629);
			this.ToggleRightLights.Name = "ToggleRightLights";
			this.ToggleRightLights.Size = new System.Drawing.Size(249, 54);
			this.ToggleRightLights.TabIndex = 9;
			this.ToggleRightLights.Text = "Right Lights";
			this.ToggleRightLights.UseVisualStyleBackColor = true;
			this.ToggleRightLights.CheckedChanged += new System.EventHandler(this.ToggleRightLights_CheckedChanged);
			// 
			// ToggleBoothLights
			// 
			this.ToggleBoothLights.AutoSize = true;
			this.ToggleBoothLights.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ToggleBoothLights.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.ToggleBoothLights.Location = new System.Drawing.Point(7, 705);
			this.ToggleBoothLights.Name = "ToggleBoothLights";
			this.ToggleBoothLights.Size = new System.Drawing.Size(261, 54);
			this.ToggleBoothLights.TabIndex = 10;
			this.ToggleBoothLights.Text = "Booth Lights";
			this.ToggleBoothLights.UseVisualStyleBackColor = true;
			this.ToggleBoothLights.CheckedChanged += new System.EventHandler(this.ToggleBoothLights_CheckedChanged);
			// 
			// LasersColour1Button
			// 
			this.LasersColour1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LasersColour1Button.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LasersColour1Button.Location = new System.Drawing.Point(862, 316);
			this.LasersColour1Button.Name = "LasersColour1Button";
			this.LasersColour1Button.Size = new System.Drawing.Size(177, 70);
			this.LasersColour1Button.TabIndex = 11;
			this.LasersColour1Button.Text = "Colour 1";
			this.LasersColour1Button.UseVisualStyleBackColor = true;
			this.LasersColour1Button.Click += new System.EventHandler(this.LasersColour1Button_Click);
			// 
			// LasersColour2Button
			// 
			this.LasersColour2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LasersColour2Button.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LasersColour2Button.Location = new System.Drawing.Point(1045, 316);
			this.LasersColour2Button.Name = "LasersColour2Button";
			this.LasersColour2Button.Size = new System.Drawing.Size(177, 70);
			this.LasersColour2Button.TabIndex = 12;
			this.LasersColour2Button.Text = "Colour 2";
			this.LasersColour2Button.UseVisualStyleBackColor = true;
			this.LasersColour2Button.Click += new System.EventHandler(this.LasersColour2Button_Click);
			// 
			// BacklightsColour2Button
			// 
			this.BacklightsColour2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BacklightsColour2Button.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BacklightsColour2Button.Location = new System.Drawing.Point(1045, 392);
			this.BacklightsColour2Button.Name = "BacklightsColour2Button";
			this.BacklightsColour2Button.Size = new System.Drawing.Size(177, 70);
			this.BacklightsColour2Button.TabIndex = 14;
			this.BacklightsColour2Button.Text = "Colour 2";
			this.BacklightsColour2Button.UseVisualStyleBackColor = true;
			this.BacklightsColour2Button.Click += new System.EventHandler(this.BacklightsColour2Button_Click);
			// 
			// BacklightsColour1Button
			// 
			this.BacklightsColour1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BacklightsColour1Button.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BacklightsColour1Button.Location = new System.Drawing.Point(862, 392);
			this.BacklightsColour1Button.Name = "BacklightsColour1Button";
			this.BacklightsColour1Button.Size = new System.Drawing.Size(177, 70);
			this.BacklightsColour1Button.TabIndex = 13;
			this.BacklightsColour1Button.Text = "Colour 1";
			this.BacklightsColour1Button.UseVisualStyleBackColor = true;
			this.BacklightsColour1Button.Click += new System.EventHandler(this.BacklightsColour1Button_Click);
			// 
			// ToplightsColour2Button
			// 
			this.ToplightsColour2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ToplightsColour2Button.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ToplightsColour2Button.Location = new System.Drawing.Point(1045, 468);
			this.ToplightsColour2Button.Name = "ToplightsColour2Button";
			this.ToplightsColour2Button.Size = new System.Drawing.Size(177, 70);
			this.ToplightsColour2Button.TabIndex = 16;
			this.ToplightsColour2Button.Text = "Colour 2";
			this.ToplightsColour2Button.UseVisualStyleBackColor = true;
			this.ToplightsColour2Button.Click += new System.EventHandler(this.ToplightsColour2Button_Click);
			// 
			// ToplightsColour1Button
			// 
			this.ToplightsColour1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ToplightsColour1Button.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ToplightsColour1Button.Location = new System.Drawing.Point(862, 468);
			this.ToplightsColour1Button.Name = "ToplightsColour1Button";
			this.ToplightsColour1Button.Size = new System.Drawing.Size(177, 70);
			this.ToplightsColour1Button.TabIndex = 15;
			this.ToplightsColour1Button.Text = "Colour 1";
			this.ToplightsColour1Button.UseVisualStyleBackColor = true;
			this.ToplightsColour1Button.Click += new System.EventHandler(this.ToplightsColour1Button_Click);
			// 
			// LeftlightsColour2Button
			// 
			this.LeftlightsColour2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LeftlightsColour2Button.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LeftlightsColour2Button.Location = new System.Drawing.Point(1045, 544);
			this.LeftlightsColour2Button.Name = "LeftlightsColour2Button";
			this.LeftlightsColour2Button.Size = new System.Drawing.Size(177, 70);
			this.LeftlightsColour2Button.TabIndex = 18;
			this.LeftlightsColour2Button.Text = "Colour 2";
			this.LeftlightsColour2Button.UseVisualStyleBackColor = true;
			this.LeftlightsColour2Button.Click += new System.EventHandler(this.LeftlightsColour2Button_Click);
			// 
			// LeftlightsColour1Button
			// 
			this.LeftlightsColour1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LeftlightsColour1Button.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LeftlightsColour1Button.Location = new System.Drawing.Point(862, 544);
			this.LeftlightsColour1Button.Name = "LeftlightsColour1Button";
			this.LeftlightsColour1Button.Size = new System.Drawing.Size(177, 70);
			this.LeftlightsColour1Button.TabIndex = 17;
			this.LeftlightsColour1Button.Text = "Colour 1";
			this.LeftlightsColour1Button.UseVisualStyleBackColor = true;
			this.LeftlightsColour1Button.Click += new System.EventHandler(this.LeftlightsColour1Button_Click);
			// 
			// RightlightsColour2Button
			// 
			this.RightlightsColour2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RightlightsColour2Button.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.RightlightsColour2Button.Location = new System.Drawing.Point(1045, 620);
			this.RightlightsColour2Button.Name = "RightlightsColour2Button";
			this.RightlightsColour2Button.Size = new System.Drawing.Size(177, 70);
			this.RightlightsColour2Button.TabIndex = 20;
			this.RightlightsColour2Button.Text = "Colour 2";
			this.RightlightsColour2Button.UseVisualStyleBackColor = true;
			this.RightlightsColour2Button.Click += new System.EventHandler(this.RightlightsColour2Button_Click);
			// 
			// RightlightsColour1Button
			// 
			this.RightlightsColour1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RightlightsColour1Button.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.RightlightsColour1Button.Location = new System.Drawing.Point(862, 620);
			this.RightlightsColour1Button.Name = "RightlightsColour1Button";
			this.RightlightsColour1Button.Size = new System.Drawing.Size(177, 70);
			this.RightlightsColour1Button.TabIndex = 19;
			this.RightlightsColour1Button.Text = "Colour 1";
			this.RightlightsColour1Button.UseVisualStyleBackColor = true;
			this.RightlightsColour1Button.Click += new System.EventHandler(this.RightlightsColour1Button_Click);
			// 
			// BoothlightsColour2Button
			// 
			this.BoothlightsColour2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BoothlightsColour2Button.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BoothlightsColour2Button.Location = new System.Drawing.Point(1045, 696);
			this.BoothlightsColour2Button.Name = "BoothlightsColour2Button";
			this.BoothlightsColour2Button.Size = new System.Drawing.Size(177, 70);
			this.BoothlightsColour2Button.TabIndex = 22;
			this.BoothlightsColour2Button.Text = "Colour 2";
			this.BoothlightsColour2Button.UseVisualStyleBackColor = true;
			this.BoothlightsColour2Button.Click += new System.EventHandler(this.BoothlightsColour2Button_Click);
			// 
			// BoothlightsColour1Button
			// 
			this.BoothlightsColour1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BoothlightsColour1Button.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BoothlightsColour1Button.Location = new System.Drawing.Point(862, 696);
			this.BoothlightsColour1Button.Name = "BoothlightsColour1Button";
			this.BoothlightsColour1Button.Size = new System.Drawing.Size(177, 70);
			this.BoothlightsColour1Button.TabIndex = 21;
			this.BoothlightsColour1Button.Text = "Colour 1";
			this.BoothlightsColour1Button.UseVisualStyleBackColor = true;
			this.BoothlightsColour1Button.Click += new System.EventHandler(this.BoothlightsColour1Button_Click);
			// 
			// GlobalColour2Button
			// 
			this.GlobalColour2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.GlobalColour2Button.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.GlobalColour2Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.GlobalColour2Button.Location = new System.Drawing.Point(1045, 74);
			this.GlobalColour2Button.Name = "GlobalColour2Button";
			this.GlobalColour2Button.Size = new System.Drawing.Size(177, 70);
			this.GlobalColour2Button.TabIndex = 24;
			this.GlobalColour2Button.Text = "Colour 2";
			this.GlobalColour2Button.UseVisualStyleBackColor = true;
			this.GlobalColour2Button.Click += new System.EventHandler(this.button14_Click);
			// 
			// GlobalModeToggle
			// 
			this.GlobalModeToggle.AutoSize = true;
			this.GlobalModeToggle.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.GlobalModeToggle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.GlobalModeToggle.Location = new System.Drawing.Point(12, 21);
			this.GlobalModeToggle.Name = "GlobalModeToggle";
			this.GlobalModeToggle.Size = new System.Drawing.Size(805, 54);
			this.GlobalModeToggle.TabIndex = 25;
			this.GlobalModeToggle.Text = "Global Mode (All Lights Follow These Colours)";
			this.GlobalModeToggle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.GlobalModeToggle.UseVisualStyleBackColor = true;
			this.GlobalModeToggle.CheckedChanged += new System.EventHandler(this.GlobalModeToggle_CheckedChanged);
			// 
			// LasersPatternMode
			// 
			this.LasersPatternMode.BackColor = System.Drawing.Color.Black;
			this.LasersPatternMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.LasersPatternMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LasersPatternMode.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LasersPatternMode.ForeColor = System.Drawing.Color.Aquamarine;
			this.LasersPatternMode.FormattingEnabled = true;
			this.LasersPatternMode.Items.AddRange(new object[] {
            "Solid",
            "Colour For Each",
            "Alternating",
            "Alternating Swap"});
			this.LasersPatternMode.Location = new System.Drawing.Point(314, 323);
			this.LasersPatternMode.Name = "LasersPatternMode";
			this.LasersPatternMode.Size = new System.Drawing.Size(542, 58);
			this.LasersPatternMode.TabIndex = 26;
			// 
			// GlobalPatternMode
			// 
			this.GlobalPatternMode.BackColor = System.Drawing.Color.Black;
			this.GlobalPatternMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.GlobalPatternMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.GlobalPatternMode.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.GlobalPatternMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.GlobalPatternMode.FormattingEnabled = true;
			this.GlobalPatternMode.Items.AddRange(new object[] {
            "Solid",
            "Static Split",
            "Alternating",
            "Alternating Split"});
			this.GlobalPatternMode.Location = new System.Drawing.Point(314, 81);
			this.GlobalPatternMode.Name = "GlobalPatternMode";
			this.GlobalPatternMode.Size = new System.Drawing.Size(542, 58);
			this.GlobalPatternMode.TabIndex = 27;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Black", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.label1.Location = new System.Drawing.Point(24, 84);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(284, 50);
			this.label1.TabIndex = 28;
			this.label1.Text = "Global Pattern";
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.ForeColor = System.Drawing.Color.Aquamarine;
			this.label2.Location = new System.Drawing.Point(314, 241);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(542, 72);
			this.label2.TabIndex = 29;
			this.label2.Text = "Pattern Selection";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// GlobalColour1Button
			// 
			this.GlobalColour1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.GlobalColour1Button.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.GlobalColour1Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.GlobalColour1Button.Location = new System.Drawing.Point(862, 74);
			this.GlobalColour1Button.Name = "GlobalColour1Button";
			this.GlobalColour1Button.Size = new System.Drawing.Size(177, 70);
			this.GlobalColour1Button.TabIndex = 30;
			this.GlobalColour1Button.Text = "Colour 1";
			this.GlobalColour1Button.UseVisualStyleBackColor = true;
			this.GlobalColour1Button.Click += new System.EventHandler(this.GlobalColour1Button_Click);
			// 
			// ShowOBS
			// 
			this.ShowOBS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ShowOBS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ShowOBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ShowOBS.ForeColor = System.Drawing.Color.Yellow;
			this.ShowOBS.Location = new System.Drawing.Point(1871, 846);
			this.ShowOBS.Name = "ShowOBS";
			this.ShowOBS.Size = new System.Drawing.Size(301, 200);
			this.ShowOBS.TabIndex = 31;
			this.ShowOBS.Text = "Show OBS Layer";
			this.ShowOBS.UseVisualStyleBackColor = true;
			this.ShowOBS.Click += new System.EventHandler(this.ShowOBS_Click);
			// 
			// PatternEngineBPM
			// 
			this.PatternEngineBPM.Interval = 420;
			this.PatternEngineBPM.Tick += new System.EventHandler(this.PatternEngineBPM_Tick);
			// 
			// BacklightsPatternMode
			// 
			this.BacklightsPatternMode.BackColor = System.Drawing.Color.Black;
			this.BacklightsPatternMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.BacklightsPatternMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BacklightsPatternMode.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BacklightsPatternMode.ForeColor = System.Drawing.Color.Aquamarine;
			this.BacklightsPatternMode.FormattingEnabled = true;
			this.BacklightsPatternMode.Items.AddRange(new object[] {
            "Solid",
            "Colour For Each",
            "Alternating",
            "Alternating Swap"});
			this.BacklightsPatternMode.Location = new System.Drawing.Point(314, 399);
			this.BacklightsPatternMode.Name = "BacklightsPatternMode";
			this.BacklightsPatternMode.Size = new System.Drawing.Size(542, 58);
			this.BacklightsPatternMode.TabIndex = 35;
			// 
			// BoothlightsPatternMode
			// 
			this.BoothlightsPatternMode.BackColor = System.Drawing.Color.Black;
			this.BoothlightsPatternMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.BoothlightsPatternMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BoothlightsPatternMode.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BoothlightsPatternMode.ForeColor = System.Drawing.Color.Aquamarine;
			this.BoothlightsPatternMode.FormattingEnabled = true;
			this.BoothlightsPatternMode.Items.AddRange(new object[] {
            "Solid",
            "Colour For Each",
            "Alternating",
            "Alternating Swap"});
			this.BoothlightsPatternMode.Location = new System.Drawing.Point(314, 701);
			this.BoothlightsPatternMode.Name = "BoothlightsPatternMode";
			this.BoothlightsPatternMode.Size = new System.Drawing.Size(542, 58);
			this.BoothlightsPatternMode.TabIndex = 36;
			// 
			// ToplightsPatternMode
			// 
			this.ToplightsPatternMode.BackColor = System.Drawing.Color.Black;
			this.ToplightsPatternMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ToplightsPatternMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ToplightsPatternMode.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ToplightsPatternMode.ForeColor = System.Drawing.Color.Aquamarine;
			this.ToplightsPatternMode.FormattingEnabled = true;
			this.ToplightsPatternMode.Items.AddRange(new object[] {
            "Solid",
            "Left Right Split",
            "Inside Outside Split",
            "Outside Only Split",
            "Inside Only Split",
            "Alternating Swap",
            "L>R Chase",
            "R>L Chase"});
			this.ToplightsPatternMode.Location = new System.Drawing.Point(314, 475);
			this.ToplightsPatternMode.Name = "ToplightsPatternMode";
			this.ToplightsPatternMode.Size = new System.Drawing.Size(542, 58);
			this.ToplightsPatternMode.TabIndex = 37;
			// 
			// LeftlightsPatternMode
			// 
			this.LeftlightsPatternMode.BackColor = System.Drawing.Color.Black;
			this.LeftlightsPatternMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.LeftlightsPatternMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LeftlightsPatternMode.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LeftlightsPatternMode.ForeColor = System.Drawing.Color.Aquamarine;
			this.LeftlightsPatternMode.FormattingEnabled = true;
			this.LeftlightsPatternMode.Items.AddRange(new object[] {
            "Solid",
            "Solid Split",
            "Alternating",
            "Alternating Swap",
            "Top > Bottom Chase",
            "Bottom > Top Chase"});
			this.LeftlightsPatternMode.Location = new System.Drawing.Point(314, 551);
			this.LeftlightsPatternMode.Name = "LeftlightsPatternMode";
			this.LeftlightsPatternMode.Size = new System.Drawing.Size(542, 58);
			this.LeftlightsPatternMode.TabIndex = 38;
			// 
			// RightlightsPatternMode
			// 
			this.RightlightsPatternMode.BackColor = System.Drawing.Color.Black;
			this.RightlightsPatternMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.RightlightsPatternMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RightlightsPatternMode.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.RightlightsPatternMode.ForeColor = System.Drawing.Color.Aquamarine;
			this.RightlightsPatternMode.FormattingEnabled = true;
			this.RightlightsPatternMode.Items.AddRange(new object[] {
            "Solid",
            "Solid Split",
            "Alternating",
            "Alternating Swap",
            "Top > Bottom Chase",
            "Bottom > Top Chase"});
			this.RightlightsPatternMode.Location = new System.Drawing.Point(314, 627);
			this.RightlightsPatternMode.Name = "RightlightsPatternMode";
			this.RightlightsPatternMode.Size = new System.Drawing.Size(542, 58);
			this.RightlightsPatternMode.TabIndex = 39;
			// 
			// LasersIIS
			// 
			this.LasersIIS.AutoSize = true;
			this.LasersIIS.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LasersIIS.ForeColor = System.Drawing.Color.Lime;
			this.LasersIIS.Location = new System.Drawing.Point(1228, 325);
			this.LasersIIS.Name = "LasersIIS";
			this.LasersIIS.Size = new System.Drawing.Size(332, 54);
			this.LasersIIS.TabIndex = 40;
			this.LasersIIS.Text = "Include In Strobe";
			this.LasersIIS.UseVisualStyleBackColor = true;
			// 
			// BacklightsIIS
			// 
			this.BacklightsIIS.AutoSize = true;
			this.BacklightsIIS.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BacklightsIIS.ForeColor = System.Drawing.Color.Lime;
			this.BacklightsIIS.Location = new System.Drawing.Point(1228, 401);
			this.BacklightsIIS.Name = "BacklightsIIS";
			this.BacklightsIIS.Size = new System.Drawing.Size(332, 54);
			this.BacklightsIIS.TabIndex = 41;
			this.BacklightsIIS.Text = "Include In Strobe";
			this.BacklightsIIS.UseVisualStyleBackColor = true;
			// 
			// ToplightsIIS
			// 
			this.ToplightsIIS.AutoSize = true;
			this.ToplightsIIS.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ToplightsIIS.ForeColor = System.Drawing.Color.Lime;
			this.ToplightsIIS.Location = new System.Drawing.Point(1228, 477);
			this.ToplightsIIS.Name = "ToplightsIIS";
			this.ToplightsIIS.Size = new System.Drawing.Size(332, 54);
			this.ToplightsIIS.TabIndex = 42;
			this.ToplightsIIS.Text = "Include In Strobe";
			this.ToplightsIIS.UseVisualStyleBackColor = true;
			// 
			// LeftlightsIIS
			// 
			this.LeftlightsIIS.AutoSize = true;
			this.LeftlightsIIS.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LeftlightsIIS.ForeColor = System.Drawing.Color.Lime;
			this.LeftlightsIIS.Location = new System.Drawing.Point(1228, 553);
			this.LeftlightsIIS.Name = "LeftlightsIIS";
			this.LeftlightsIIS.Size = new System.Drawing.Size(332, 54);
			this.LeftlightsIIS.TabIndex = 43;
			this.LeftlightsIIS.Text = "Include In Strobe";
			this.LeftlightsIIS.UseVisualStyleBackColor = true;
			// 
			// RightlighsIIS
			// 
			this.RightlighsIIS.AutoSize = true;
			this.RightlighsIIS.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.RightlighsIIS.ForeColor = System.Drawing.Color.Lime;
			this.RightlighsIIS.Location = new System.Drawing.Point(1228, 629);
			this.RightlighsIIS.Name = "RightlighsIIS";
			this.RightlighsIIS.Size = new System.Drawing.Size(332, 54);
			this.RightlighsIIS.TabIndex = 44;
			this.RightlighsIIS.Text = "Include In Strobe";
			this.RightlighsIIS.UseVisualStyleBackColor = true;
			// 
			// BoothlightsIIS
			// 
			this.BoothlightsIIS.AutoSize = true;
			this.BoothlightsIIS.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BoothlightsIIS.ForeColor = System.Drawing.Color.Lime;
			this.BoothlightsIIS.Location = new System.Drawing.Point(1228, 703);
			this.BoothlightsIIS.Name = "BoothlightsIIS";
			this.BoothlightsIIS.Size = new System.Drawing.Size(332, 54);
			this.BoothlightsIIS.TabIndex = 45;
			this.BoothlightsIIS.Text = "Include In Strobe";
			this.BoothlightsIIS.UseVisualStyleBackColor = true;
			// 
			// StrobeButton
			// 
			this.StrobeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.StrobeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.StrobeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.StrobeButton.ForeColor = System.Drawing.Color.Lime;
			this.StrobeButton.Location = new System.Drawing.Point(1228, 838);
			this.StrobeButton.Name = "StrobeButton";
			this.StrobeButton.Size = new System.Drawing.Size(332, 200);
			this.StrobeButton.TabIndex = 46;
			this.StrobeButton.Text = "Strobe";
			this.StrobeButton.UseVisualStyleBackColor = true;
			this.StrobeButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StrobeButton_MouseDown);
			this.StrobeButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.StrobeButton_MouseUp);
			// 
			// StrobeClock
			// 
			this.StrobeClock.Interval = 60;
			this.StrobeClock.Tick += new System.EventHandler(this.StrobeClock_Tick);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.label3.Location = new System.Drawing.Point(7, 248);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(301, 72);
			this.label3.TabIndex = 47;
			this.label3.Text = "Toggle On";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(862, 241);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(360, 72);
			this.label4.TabIndex = 48;
			this.label4.Text = "Colours";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(2184, 1057);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.StrobeButton);
			this.Controls.Add(this.BoothlightsIIS);
			this.Controls.Add(this.RightlighsIIS);
			this.Controls.Add(this.LeftlightsIIS);
			this.Controls.Add(this.ToplightsIIS);
			this.Controls.Add(this.BacklightsIIS);
			this.Controls.Add(this.LasersIIS);
			this.Controls.Add(this.RightlightsPatternMode);
			this.Controls.Add(this.LeftlightsPatternMode);
			this.Controls.Add(this.ToplightsPatternMode);
			this.Controls.Add(this.BoothlightsPatternMode);
			this.Controls.Add(this.BacklightsPatternMode);
			this.Controls.Add(this.ShowOBS);
			this.Controls.Add(this.GlobalColour1Button);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.GlobalPatternMode);
			this.Controls.Add(this.LasersPatternMode);
			this.Controls.Add(this.GlobalModeToggle);
			this.Controls.Add(this.GlobalColour2Button);
			this.Controls.Add(this.BoothlightsColour2Button);
			this.Controls.Add(this.BoothlightsColour1Button);
			this.Controls.Add(this.RightlightsColour2Button);
			this.Controls.Add(this.RightlightsColour1Button);
			this.Controls.Add(this.LeftlightsColour2Button);
			this.Controls.Add(this.LeftlightsColour1Button);
			this.Controls.Add(this.ToplightsColour2Button);
			this.Controls.Add(this.ToplightsColour1Button);
			this.Controls.Add(this.BacklightsColour2Button);
			this.Controls.Add(this.BacklightsColour1Button);
			this.Controls.Add(this.LasersColour2Button);
			this.Controls.Add(this.LasersColour1Button);
			this.Controls.Add(this.ToggleBoothLights);
			this.Controls.Add(this.ToggleRightLights);
			this.Controls.Add(this.ToggleLeftLights);
			this.Controls.Add(this.ToggleTopLights);
			this.Controls.Add(this.ToggleBack);
			this.Controls.Add(this.ToggleLasers);
			this.Controls.Add(this.PreviewGrid);
			this.Controls.Add(this.BPMLabel);
			this.Controls.Add(this.BPMTapButton);
			this.ForeColor = System.Drawing.Color.White;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(2210, 1128);
			this.MinimumSize = new System.Drawing.Size(2210, 1128);
			this.Name = "MainUI";
			this.Text = "TechnicallySane\'s TailBass Lighting Control - v1 - WIP - UwU";
			this.Load += new System.EventHandler(this.MainUI_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainUI_KeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainUI_KeyUp);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button BPMTapButton;
		private Label BPMLabel;
		private System.ComponentModel.BackgroundWorker PatternEngine;
		private System.Windows.Forms.Timer BPMTimer;
		private System.ComponentModel.BackgroundWorker StopwatchManager;
		private ListView PreviewGrid;
		private CheckBox ToggleLasers;
		private CheckBox ToggleBack;
		private CheckBox ToggleTopLights;
		private CheckBox ToggleLeftLights;
		private CheckBox ToggleRightLights;
		private CheckBox ToggleBoothLights;
		private Button LasersColour1Button;
		private Button LasersColour2Button;
		private Button BacklightsColour2Button;
		private Button BacklightsColour1Button;
		private Button ToplightsColour2Button;
		private Button ToplightsColour1Button;
		private Button LeftlightsColour2Button;
		private Button LeftlightsColour1Button;
		private Button RightlightsColour2Button;
		private Button RightlightsColour1Button;
		private Button BoothlightsColour2Button;
		private Button BoothlightsColour1Button;
		private Button GlobalColour2Button;
		private CheckBox GlobalModeToggle;
		private ComboBox LasersPatternMode;
		private ComboBox GlobalPatternMode;
		private Label label1;
		private Label label2;
		private Button GlobalColour1Button;
		private Button ShowOBS;
		private System.Windows.Forms.Timer PatternEngineBPM;
		private ImageList imageList1;
		private ComboBox BacklightsPatternMode;
		private ComboBox BoothlightsPatternMode;
		private ComboBox ToplightsPatternMode;
		private ComboBox LeftlightsPatternMode;
		private ComboBox RightlightsPatternMode;
		private CheckBox LasersIIS;
		private CheckBox BacklightsIIS;
		private CheckBox ToplightsIIS;
		private CheckBox LeftlightsIIS;
		private CheckBox RightlighsIIS;
		private CheckBox BoothlightsIIS;
		private Button StrobeButton;
		private System.Windows.Forms.Timer StrobeClock;
		private Label label3;
		private Label label4;
	}
}