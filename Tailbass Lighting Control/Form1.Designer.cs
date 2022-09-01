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
			this.LasersPatternMode = new System.Windows.Forms.ComboBox();
			this.GlobalPatternMode = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.GlobalColour1Button = new System.Windows.Forms.Button();
			this.PatternEngineBPM = new System.Windows.Forms.Timer(this.components);
			this.BacklightsPatternMode = new System.Windows.Forms.ComboBox();
			this.BoothlightsPatternMode = new System.Windows.Forms.ComboBox();
			this.ToplightsPatternMode = new System.Windows.Forms.ComboBox();
			this.LeftlightsPatternMode = new System.Windows.Forms.ComboBox();
			this.RightlightsPatternMode = new System.Windows.Forms.ComboBox();
			this.StrobeButton = new System.Windows.Forms.Button();
			this.StrobeClock = new System.Windows.Forms.Timer(this.components);
			this.label5 = new System.Windows.Forms.Label();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.showOBSLayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openSceneControllerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.LasersToggleButton = new System.Windows.Forms.Button();
			this.BackLightsToggleButton = new System.Windows.Forms.Button();
			this.TopLightsToggleButton = new System.Windows.Forms.Button();
			this.LeftLightsToggleButton = new System.Windows.Forms.Button();
			this.RightLightsToggleButton = new System.Windows.Forms.Button();
			this.BoothLightsToggleButton = new System.Windows.Forms.Button();
			this.LasersIISToggle = new System.Windows.Forms.Button();
			this.BackLightsIISToggle = new System.Windows.Forms.Button();
			this.TopLightsIISToggle = new System.Windows.Forms.Button();
			this.LeftLightsIISToggle = new System.Windows.Forms.Button();
			this.RightLightsIISToggle = new System.Windows.Forms.Button();
			this.BoothLightsIISToggle = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.GlobalModeToggleButton = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.SetBPMButton = new System.Windows.Forms.Button();
			this.BPMPanel = new System.Windows.Forms.Panel();
			this.BPMHalf = new System.Windows.Forms.Button();
			this.BPMDouble = new System.Windows.Forms.Button();
			this.BPMSetVal = new System.Windows.Forms.NumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
			this.menuStrip1.SuspendLayout();
			this.BPMPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.BPMSetVal)).BeginInit();
			this.SuspendLayout();
			// 
			// BPMTapButton
			// 
			this.BPMTapButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BPMTapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BPMTapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BPMTapButton.Location = new System.Drawing.Point(12, 997);
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
			this.BPMLabel.Location = new System.Drawing.Point(12, 934);
			this.BPMLabel.Name = "BPMLabel";
			this.BPMLabel.Size = new System.Drawing.Size(200, 60);
			this.BPMLabel.TabIndex = 1;
			this.BPMLabel.Text = "128";
			this.BPMLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.BPMLabel.Click += new System.EventHandler(this.BPMLabel_Click);
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
			this.PreviewGrid.Location = new System.Drawing.Point(1571, 45);
			this.PreviewGrid.Margin = new System.Windows.Forms.Padding(1);
			this.PreviewGrid.MultiSelect = false;
			this.PreviewGrid.Name = "PreviewGrid";
			this.PreviewGrid.Scrollable = false;
			this.PreviewGrid.ShowGroups = false;
			this.PreviewGrid.ShowItemToolTips = true;
			this.PreviewGrid.Size = new System.Drawing.Size(613, 1164);
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
			// LasersColour1Button
			// 
			this.LasersColour1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LasersColour1Button.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LasersColour1Button.Location = new System.Drawing.Point(867, 473);
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
			this.LasersColour2Button.Location = new System.Drawing.Point(1050, 473);
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
			this.BacklightsColour2Button.Location = new System.Drawing.Point(1050, 549);
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
			this.BacklightsColour1Button.Location = new System.Drawing.Point(867, 549);
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
			this.ToplightsColour2Button.Location = new System.Drawing.Point(1050, 625);
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
			this.ToplightsColour1Button.Location = new System.Drawing.Point(867, 625);
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
			this.LeftlightsColour2Button.Location = new System.Drawing.Point(1050, 701);
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
			this.LeftlightsColour1Button.Location = new System.Drawing.Point(867, 701);
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
			this.RightlightsColour2Button.Location = new System.Drawing.Point(1050, 777);
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
			this.RightlightsColour1Button.Location = new System.Drawing.Point(867, 777);
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
			this.BoothlightsColour2Button.Location = new System.Drawing.Point(1050, 853);
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
			this.BoothlightsColour1Button.Location = new System.Drawing.Point(867, 853);
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
			this.GlobalColour2Button.Location = new System.Drawing.Point(1377, 154);
			this.GlobalColour2Button.Name = "GlobalColour2Button";
			this.GlobalColour2Button.Size = new System.Drawing.Size(177, 70);
			this.GlobalColour2Button.TabIndex = 24;
			this.GlobalColour2Button.Text = "Colour 2";
			this.GlobalColour2Button.UseVisualStyleBackColor = true;
			this.GlobalColour2Button.Click += new System.EventHandler(this.button14_Click);
			// 
			// LasersPatternMode
			// 
			this.LasersPatternMode.BackColor = System.Drawing.Color.Black;
			this.LasersPatternMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.LasersPatternMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LasersPatternMode.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LasersPatternMode.ForeColor = System.Drawing.Color.White;
			this.LasersPatternMode.FormattingEnabled = true;
			this.LasersPatternMode.Items.AddRange(new object[] {
            "Solid",
            "Colour For Each",
            "Alternating",
            "Alternating Swap"});
			this.LasersPatternMode.Location = new System.Drawing.Point(319, 480);
			this.LasersPatternMode.Name = "LasersPatternMode";
			this.LasersPatternMode.Size = new System.Drawing.Size(542, 58);
			this.LasersPatternMode.TabIndex = 26;
			this.LasersPatternMode.SelectedIndexChanged += new System.EventHandler(this.LasersPatternMode_SelectedIndexChanged);
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
			this.GlobalPatternMode.Location = new System.Drawing.Point(646, 161);
			this.GlobalPatternMode.Name = "GlobalPatternMode";
			this.GlobalPatternMode.Size = new System.Drawing.Size(542, 58);
			this.GlobalPatternMode.TabIndex = 27;
			this.GlobalPatternMode.SelectedIndexChanged += new System.EventHandler(this.GlobalPatternMode_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Black", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.label1.Location = new System.Drawing.Point(356, 164);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(284, 50);
			this.label1.TabIndex = 28;
			this.label1.Text = "Global Pattern";
			// 
			// GlobalColour1Button
			// 
			this.GlobalColour1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.GlobalColour1Button.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.GlobalColour1Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.GlobalColour1Button.Location = new System.Drawing.Point(1194, 154);
			this.GlobalColour1Button.Name = "GlobalColour1Button";
			this.GlobalColour1Button.Size = new System.Drawing.Size(177, 70);
			this.GlobalColour1Button.TabIndex = 30;
			this.GlobalColour1Button.Text = "Colour 1";
			this.GlobalColour1Button.UseVisualStyleBackColor = true;
			this.GlobalColour1Button.Click += new System.EventHandler(this.GlobalColour1Button_Click);
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
			this.BacklightsPatternMode.ForeColor = System.Drawing.Color.White;
			this.BacklightsPatternMode.FormattingEnabled = true;
			this.BacklightsPatternMode.Items.AddRange(new object[] {
            "Solid",
            "Colour For Each",
            "Alternating",
            "Alternating Swap"});
			this.BacklightsPatternMode.Location = new System.Drawing.Point(319, 556);
			this.BacklightsPatternMode.Name = "BacklightsPatternMode";
			this.BacklightsPatternMode.Size = new System.Drawing.Size(542, 58);
			this.BacklightsPatternMode.TabIndex = 35;
			this.BacklightsPatternMode.SelectedIndexChanged += new System.EventHandler(this.BacklightsPatternMode_SelectedIndexChanged);
			// 
			// BoothlightsPatternMode
			// 
			this.BoothlightsPatternMode.BackColor = System.Drawing.Color.Black;
			this.BoothlightsPatternMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.BoothlightsPatternMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BoothlightsPatternMode.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BoothlightsPatternMode.ForeColor = System.Drawing.Color.White;
			this.BoothlightsPatternMode.FormattingEnabled = true;
			this.BoothlightsPatternMode.Items.AddRange(new object[] {
            "Solid",
            "Colour For Each",
            "Alternating",
            "Alternating Swap"});
			this.BoothlightsPatternMode.Location = new System.Drawing.Point(319, 858);
			this.BoothlightsPatternMode.Name = "BoothlightsPatternMode";
			this.BoothlightsPatternMode.Size = new System.Drawing.Size(542, 58);
			this.BoothlightsPatternMode.TabIndex = 36;
			this.BoothlightsPatternMode.SelectedIndexChanged += new System.EventHandler(this.BoothlightsPatternMode_SelectedIndexChanged);
			// 
			// ToplightsPatternMode
			// 
			this.ToplightsPatternMode.BackColor = System.Drawing.Color.Black;
			this.ToplightsPatternMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ToplightsPatternMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ToplightsPatternMode.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.ToplightsPatternMode.ForeColor = System.Drawing.Color.White;
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
			this.ToplightsPatternMode.Location = new System.Drawing.Point(319, 632);
			this.ToplightsPatternMode.Name = "ToplightsPatternMode";
			this.ToplightsPatternMode.Size = new System.Drawing.Size(542, 58);
			this.ToplightsPatternMode.TabIndex = 37;
			this.ToplightsPatternMode.SelectedIndexChanged += new System.EventHandler(this.ToplightsPatternMode_SelectedIndexChanged);
			// 
			// LeftlightsPatternMode
			// 
			this.LeftlightsPatternMode.BackColor = System.Drawing.Color.Black;
			this.LeftlightsPatternMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.LeftlightsPatternMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LeftlightsPatternMode.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LeftlightsPatternMode.ForeColor = System.Drawing.Color.White;
			this.LeftlightsPatternMode.FormattingEnabled = true;
			this.LeftlightsPatternMode.Items.AddRange(new object[] {
            "Solid",
            "Solid Split",
            "Alternating",
            "Alternating Swap",
            "Top > Bottom Chase",
            "Bottom > Top Chase"});
			this.LeftlightsPatternMode.Location = new System.Drawing.Point(319, 708);
			this.LeftlightsPatternMode.Name = "LeftlightsPatternMode";
			this.LeftlightsPatternMode.Size = new System.Drawing.Size(542, 58);
			this.LeftlightsPatternMode.TabIndex = 38;
			this.LeftlightsPatternMode.SelectedIndexChanged += new System.EventHandler(this.LeftlightsPatternMode_SelectedIndexChanged);
			// 
			// RightlightsPatternMode
			// 
			this.RightlightsPatternMode.BackColor = System.Drawing.Color.Black;
			this.RightlightsPatternMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.RightlightsPatternMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RightlightsPatternMode.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.RightlightsPatternMode.ForeColor = System.Drawing.Color.White;
			this.RightlightsPatternMode.FormattingEnabled = true;
			this.RightlightsPatternMode.Items.AddRange(new object[] {
            "Solid",
            "Solid Split",
            "Alternating",
            "Alternating Swap",
            "Top > Bottom Chase",
            "Bottom > Top Chase"});
			this.RightlightsPatternMode.Location = new System.Drawing.Point(319, 784);
			this.RightlightsPatternMode.Name = "RightlightsPatternMode";
			this.RightlightsPatternMode.Size = new System.Drawing.Size(542, 58);
			this.RightlightsPatternMode.TabIndex = 39;
			this.RightlightsPatternMode.SelectedIndexChanged += new System.EventHandler(this.RightlightsPatternMode_SelectedIndexChanged);
			// 
			// StrobeButton
			// 
			this.StrobeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.StrobeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.StrobeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.StrobeButton.ForeColor = System.Drawing.Color.White;
			this.StrobeButton.Location = new System.Drawing.Point(1233, 997);
			this.StrobeButton.Name = "StrobeButton";
			this.StrobeButton.Size = new System.Drawing.Size(327, 200);
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
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label5.Location = new System.Drawing.Point(17, 48);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(755, 60);
			this.label5.TabIndex = 50;
			this.label5.Text = "TechSane\'s TailBass Lighting Control ";
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showOBSLayerToolStripMenuItem,
            this.openSceneControllerToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(2184, 45);
			this.menuStrip1.TabIndex = 51;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// showOBSLayerToolStripMenuItem
			// 
			this.showOBSLayerToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
			this.showOBSLayerToolStripMenuItem.Name = "showOBSLayerToolStripMenuItem";
			this.showOBSLayerToolStripMenuItem.Size = new System.Drawing.Size(228, 41);
			this.showOBSLayerToolStripMenuItem.Text = "Show OBS Layer";
			this.showOBSLayerToolStripMenuItem.Click += new System.EventHandler(this.showOBSLayerToolStripMenuItem_Click);
			// 
			// openSceneControllerToolStripMenuItem
			// 
			this.openSceneControllerToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
			this.openSceneControllerToolStripMenuItem.Name = "openSceneControllerToolStripMenuItem";
			this.openSceneControllerToolStripMenuItem.Size = new System.Drawing.Size(304, 41);
			this.openSceneControllerToolStripMenuItem.Text = "Open Scene Controller";
			this.openSceneControllerToolStripMenuItem.Click += new System.EventHandler(this.openSceneControllerToolStripMenuItem_Click);
			// 
			// LasersToggleButton
			// 
			this.LasersToggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LasersToggleButton.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LasersToggleButton.ForeColor = System.Drawing.Color.Red;
			this.LasersToggleButton.Location = new System.Drawing.Point(17, 473);
			this.LasersToggleButton.Name = "LasersToggleButton";
			this.LasersToggleButton.Size = new System.Drawing.Size(296, 70);
			this.LasersToggleButton.TabIndex = 52;
			this.LasersToggleButton.Text = "Lasers";
			this.LasersToggleButton.UseVisualStyleBackColor = true;
			this.LasersToggleButton.Click += new System.EventHandler(this.LaserToggleButton_Click);
			// 
			// BackLightsToggleButton
			// 
			this.BackLightsToggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BackLightsToggleButton.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BackLightsToggleButton.ForeColor = System.Drawing.Color.Red;
			this.BackLightsToggleButton.Location = new System.Drawing.Point(17, 549);
			this.BackLightsToggleButton.Name = "BackLightsToggleButton";
			this.BackLightsToggleButton.Size = new System.Drawing.Size(296, 70);
			this.BackLightsToggleButton.TabIndex = 53;
			this.BackLightsToggleButton.Text = "Back Lights";
			this.BackLightsToggleButton.UseVisualStyleBackColor = true;
			this.BackLightsToggleButton.Click += new System.EventHandler(this.BackLightsToggleButton_Click);
			// 
			// TopLightsToggleButton
			// 
			this.TopLightsToggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.TopLightsToggleButton.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TopLightsToggleButton.ForeColor = System.Drawing.Color.Red;
			this.TopLightsToggleButton.Location = new System.Drawing.Point(17, 625);
			this.TopLightsToggleButton.Name = "TopLightsToggleButton";
			this.TopLightsToggleButton.Size = new System.Drawing.Size(296, 70);
			this.TopLightsToggleButton.TabIndex = 54;
			this.TopLightsToggleButton.Text = "Top Lights";
			this.TopLightsToggleButton.UseVisualStyleBackColor = true;
			this.TopLightsToggleButton.Click += new System.EventHandler(this.TopLightsToggleButton_Click);
			// 
			// LeftLightsToggleButton
			// 
			this.LeftLightsToggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LeftLightsToggleButton.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LeftLightsToggleButton.ForeColor = System.Drawing.Color.Red;
			this.LeftLightsToggleButton.Location = new System.Drawing.Point(17, 701);
			this.LeftLightsToggleButton.Name = "LeftLightsToggleButton";
			this.LeftLightsToggleButton.Size = new System.Drawing.Size(296, 70);
			this.LeftLightsToggleButton.TabIndex = 55;
			this.LeftLightsToggleButton.Text = "Left Lights";
			this.LeftLightsToggleButton.UseVisualStyleBackColor = true;
			this.LeftLightsToggleButton.Click += new System.EventHandler(this.LeftLightsToggleButton_Click);
			// 
			// RightLightsToggleButton
			// 
			this.RightLightsToggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RightLightsToggleButton.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.RightLightsToggleButton.ForeColor = System.Drawing.Color.Red;
			this.RightLightsToggleButton.Location = new System.Drawing.Point(17, 777);
			this.RightLightsToggleButton.Name = "RightLightsToggleButton";
			this.RightLightsToggleButton.Size = new System.Drawing.Size(296, 70);
			this.RightLightsToggleButton.TabIndex = 56;
			this.RightLightsToggleButton.Text = "Right Lights";
			this.RightLightsToggleButton.UseVisualStyleBackColor = true;
			this.RightLightsToggleButton.Click += new System.EventHandler(this.RightLightsToggleButton_Click);
			// 
			// BoothLightsToggleButton
			// 
			this.BoothLightsToggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BoothLightsToggleButton.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BoothLightsToggleButton.ForeColor = System.Drawing.Color.Red;
			this.BoothLightsToggleButton.Location = new System.Drawing.Point(17, 851);
			this.BoothLightsToggleButton.Name = "BoothLightsToggleButton";
			this.BoothLightsToggleButton.Size = new System.Drawing.Size(296, 70);
			this.BoothLightsToggleButton.TabIndex = 57;
			this.BoothLightsToggleButton.Text = "Booth Lights";
			this.BoothLightsToggleButton.UseVisualStyleBackColor = true;
			this.BoothLightsToggleButton.Click += new System.EventHandler(this.BoothLightsToggleButton_Click);
			// 
			// LasersIISToggle
			// 
			this.LasersIISToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LasersIISToggle.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LasersIISToggle.ForeColor = System.Drawing.Color.Lime;
			this.LasersIISToggle.Location = new System.Drawing.Point(1233, 473);
			this.LasersIISToggle.Name = "LasersIISToggle";
			this.LasersIISToggle.Size = new System.Drawing.Size(327, 70);
			this.LasersIISToggle.TabIndex = 58;
			this.LasersIISToggle.Text = "Include In Strobe";
			this.LasersIISToggle.UseVisualStyleBackColor = true;
			this.LasersIISToggle.Click += new System.EventHandler(this.LasersIISToggle_Click);
			// 
			// BackLightsIISToggle
			// 
			this.BackLightsIISToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BackLightsIISToggle.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BackLightsIISToggle.ForeColor = System.Drawing.Color.Lime;
			this.BackLightsIISToggle.Location = new System.Drawing.Point(1233, 549);
			this.BackLightsIISToggle.Name = "BackLightsIISToggle";
			this.BackLightsIISToggle.Size = new System.Drawing.Size(327, 70);
			this.BackLightsIISToggle.TabIndex = 59;
			this.BackLightsIISToggle.Text = "Include In Strobe";
			this.BackLightsIISToggle.UseVisualStyleBackColor = true;
			this.BackLightsIISToggle.Click += new System.EventHandler(this.BackLightsIISToggle_Click);
			// 
			// TopLightsIISToggle
			// 
			this.TopLightsIISToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.TopLightsIISToggle.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.TopLightsIISToggle.ForeColor = System.Drawing.Color.Lime;
			this.TopLightsIISToggle.Location = new System.Drawing.Point(1233, 625);
			this.TopLightsIISToggle.Name = "TopLightsIISToggle";
			this.TopLightsIISToggle.Size = new System.Drawing.Size(327, 70);
			this.TopLightsIISToggle.TabIndex = 60;
			this.TopLightsIISToggle.Text = "Include In Strobe";
			this.TopLightsIISToggle.UseVisualStyleBackColor = true;
			this.TopLightsIISToggle.Click += new System.EventHandler(this.TopLightsIISToggle_Click);
			// 
			// LeftLightsIISToggle
			// 
			this.LeftLightsIISToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LeftLightsIISToggle.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LeftLightsIISToggle.ForeColor = System.Drawing.Color.Lime;
			this.LeftLightsIISToggle.Location = new System.Drawing.Point(1233, 701);
			this.LeftLightsIISToggle.Name = "LeftLightsIISToggle";
			this.LeftLightsIISToggle.Size = new System.Drawing.Size(327, 70);
			this.LeftLightsIISToggle.TabIndex = 61;
			this.LeftLightsIISToggle.Text = "Include In Strobe";
			this.LeftLightsIISToggle.UseVisualStyleBackColor = true;
			this.LeftLightsIISToggle.Click += new System.EventHandler(this.LeftLightsIISToggle_Click);
			// 
			// RightLightsIISToggle
			// 
			this.RightLightsIISToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.RightLightsIISToggle.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.RightLightsIISToggle.ForeColor = System.Drawing.Color.Lime;
			this.RightLightsIISToggle.Location = new System.Drawing.Point(1233, 777);
			this.RightLightsIISToggle.Name = "RightLightsIISToggle";
			this.RightLightsIISToggle.Size = new System.Drawing.Size(327, 70);
			this.RightLightsIISToggle.TabIndex = 62;
			this.RightLightsIISToggle.Text = "Include In Strobe";
			this.RightLightsIISToggle.UseVisualStyleBackColor = true;
			this.RightLightsIISToggle.Click += new System.EventHandler(this.RightLightsIISToggle_Click);
			// 
			// BoothLightsIISToggle
			// 
			this.BoothLightsIISToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BoothLightsIISToggle.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BoothLightsIISToggle.ForeColor = System.Drawing.Color.Lime;
			this.BoothLightsIISToggle.Location = new System.Drawing.Point(1233, 851);
			this.BoothLightsIISToggle.Name = "BoothLightsIISToggle";
			this.BoothLightsIISToggle.Size = new System.Drawing.Size(327, 70);
			this.BoothLightsIISToggle.TabIndex = 63;
			this.BoothLightsIISToggle.Text = "Include In Strobe";
			this.BoothLightsIISToggle.UseVisualStyleBackColor = true;
			this.BoothLightsIISToggle.Click += new System.EventHandler(this.BoothLightsIISToggle_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(17, 410);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(219, 60);
			this.label2.TabIndex = 64;
			this.label2.Text = "Toggle On";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(319, 410);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(305, 60);
			this.label3.TabIndex = 65;
			this.label3.Text = "Pattern Select";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(862, 410);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(180, 60);
			this.label4.TabIndex = 66;
			this.label4.Text = "Colours";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label6.Location = new System.Drawing.Point(1233, 410);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(216, 60);
			this.label6.TabIndex = 67;
			this.label6.Text = "On Strobe";
			// 
			// GlobalModeToggleButton
			// 
			this.GlobalModeToggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.GlobalModeToggleButton.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.GlobalModeToggleButton.ForeColor = System.Drawing.Color.Red;
			this.GlobalModeToggleButton.Location = new System.Drawing.Point(17, 154);
			this.GlobalModeToggleButton.Name = "GlobalModeToggleButton";
			this.GlobalModeToggleButton.Size = new System.Drawing.Size(333, 70);
			this.GlobalModeToggleButton.TabIndex = 68;
			this.GlobalModeToggleButton.Text = "Global Mode Off";
			this.GlobalModeToggleButton.UseVisualStyleBackColor = true;
			this.GlobalModeToggleButton.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.label7.Location = new System.Drawing.Point(17, 112);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(596, 39);
			this.label7.TabIndex = 69;
			this.label7.Text = "Global Mode - All Lights Follow These Colours";
			// 
			// SetBPMButton
			// 
			this.SetBPMButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.SetBPMButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SetBPMButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.SetBPMButton.Location = new System.Drawing.Point(3, 59);
			this.SetBPMButton.Name = "SetBPMButton";
			this.SetBPMButton.Size = new System.Drawing.Size(146, 138);
			this.SetBPMButton.TabIndex = 70;
			this.SetBPMButton.Text = "Set BPM";
			this.SetBPMButton.UseVisualStyleBackColor = true;
			this.SetBPMButton.Click += new System.EventHandler(this.SetBPMButton_Click);
			// 
			// BPMPanel
			// 
			this.BPMPanel.BackColor = System.Drawing.Color.DimGray;
			this.BPMPanel.Controls.Add(this.BPMHalf);
			this.BPMPanel.Controls.Add(this.BPMDouble);
			this.BPMPanel.Controls.Add(this.BPMSetVal);
			this.BPMPanel.Controls.Add(this.SetBPMButton);
			this.BPMPanel.Location = new System.Drawing.Point(224, 997);
			this.BPMPanel.Name = "BPMPanel";
			this.BPMPanel.Size = new System.Drawing.Size(438, 200);
			this.BPMPanel.TabIndex = 71;
			this.BPMPanel.Visible = false;
			// 
			// BPMHalf
			// 
			this.BPMHalf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BPMHalf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BPMHalf.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BPMHalf.Location = new System.Drawing.Point(155, 115);
			this.BPMHalf.Name = "BPMHalf";
			this.BPMHalf.Size = new System.Drawing.Size(273, 50);
			this.BPMHalf.TabIndex = 72;
			this.BPMHalf.Text = "1/2 BPM";
			this.BPMHalf.UseVisualStyleBackColor = true;
			this.BPMHalf.Click += new System.EventHandler(this.BPMHalf_Click);
			// 
			// BPMDouble
			// 
			this.BPMDouble.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.BPMDouble.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BPMDouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BPMDouble.Location = new System.Drawing.Point(155, 59);
			this.BPMDouble.Name = "BPMDouble";
			this.BPMDouble.Size = new System.Drawing.Size(273, 50);
			this.BPMDouble.TabIndex = 71;
			this.BPMDouble.Text = "2 x BPM";
			this.BPMDouble.UseVisualStyleBackColor = true;
			this.BPMDouble.Click += new System.EventHandler(this.BPMDouble_Click);
			// 
			// BPMSetVal
			// 
			this.BPMSetVal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.BPMSetVal.Location = new System.Drawing.Point(3, 3);
			this.BPMSetVal.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.BPMSetVal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.BPMSetVal.Name = "BPMSetVal";
			this.BPMSetVal.Size = new System.Drawing.Size(146, 50);
			this.BPMSetVal.TabIndex = 0;
			this.BPMSetVal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.label8.ForeColor = System.Drawing.Color.Gray;
			this.label8.Location = new System.Drawing.Point(218, 948);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(393, 32);
			this.label8.TabIndex = 72;
			this.label8.Text = "<-- Click for more BPM settings ^_^";
			// 
			// MainUI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(2184, 1209);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.BPMPanel);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.GlobalModeToggleButton);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.BoothLightsIISToggle);
			this.Controls.Add(this.RightLightsIISToggle);
			this.Controls.Add(this.LeftLightsIISToggle);
			this.Controls.Add(this.TopLightsIISToggle);
			this.Controls.Add(this.BackLightsIISToggle);
			this.Controls.Add(this.LasersIISToggle);
			this.Controls.Add(this.BoothLightsToggleButton);
			this.Controls.Add(this.RightLightsToggleButton);
			this.Controls.Add(this.LeftLightsToggleButton);
			this.Controls.Add(this.TopLightsToggleButton);
			this.Controls.Add(this.BackLightsToggleButton);
			this.Controls.Add(this.LasersToggleButton);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.StrobeButton);
			this.Controls.Add(this.RightlightsPatternMode);
			this.Controls.Add(this.LeftlightsPatternMode);
			this.Controls.Add(this.ToplightsPatternMode);
			this.Controls.Add(this.BoothlightsPatternMode);
			this.Controls.Add(this.BacklightsPatternMode);
			this.Controls.Add(this.GlobalColour1Button);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.GlobalPatternMode);
			this.Controls.Add(this.LasersPatternMode);
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
			this.Controls.Add(this.PreviewGrid);
			this.Controls.Add(this.BPMLabel);
			this.Controls.Add(this.BPMTapButton);
			this.Controls.Add(this.menuStrip1);
			this.ForeColor = System.Drawing.Color.White;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MinimumSize = new System.Drawing.Size(2210, 1128);
			this.Name = "MainUI";
			this.Text = "TechnicallySane\'s TailBass Lighting Control - v1 - WIP - UwU";
			this.Load += new System.EventHandler(this.MainUI_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainUI_KeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainUI_KeyUp);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.BPMPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.BPMSetVal)).EndInit();
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
		private ComboBox LasersPatternMode;
		private ComboBox GlobalPatternMode;
		private Label label1;
		private Button GlobalColour1Button;
		private System.Windows.Forms.Timer PatternEngineBPM;
		private ImageList imageList1;
		private ComboBox BacklightsPatternMode;
		private ComboBox BoothlightsPatternMode;
		private ComboBox ToplightsPatternMode;
		private ComboBox LeftlightsPatternMode;
		private ComboBox RightlightsPatternMode;
		private Button StrobeButton;
		private System.Windows.Forms.Timer StrobeClock;
		private Label label5;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem openSceneControllerToolStripMenuItem;
		private ToolStripMenuItem showOBSLayerToolStripMenuItem;
		private Button LasersToggleButton;
		private Button BackLightsToggleButton;
		private Button TopLightsToggleButton;
		private Button LeftLightsToggleButton;
		private Button RightLightsToggleButton;
		private Button BoothLightsToggleButton;
		private Button LasersIISToggle;
		private Button BackLightsIISToggle;
		private Button TopLightsIISToggle;
		private Button LeftLightsIISToggle;
		private Button RightLightsIISToggle;
		private Button BoothLightsIISToggle;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label6;
		private Button GlobalModeToggleButton;
		private Label label7;
		private Button SetBPMButton;
		private Panel BPMPanel;
		private NumericUpDown BPMSetVal;
		private Button BPMHalf;
		private Button BPMDouble;
		private Label label8;
	}
}