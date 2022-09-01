namespace Tailbass_Lighting_Control
{
	partial class SceneController
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SceneController));
			this.label1 = new System.Windows.Forms.Label();
			this.SelectShowFile = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.UpdateText = new System.Windows.Forms.ToolStripStatusLabel();
			this.ShowFileStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.CreateShowFile = new System.Windows.Forms.Button();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.ShowFileLoaderPanel = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.DisplayOnClickToggle = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.statusStrip1.SuspendLayout();
			this.ShowFileLoaderPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(359, 60);
			this.label1.TabIndex = 1;
			this.label1.Text = "Scene Controller";
			// 
			// SelectShowFile
			// 
			this.SelectShowFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SelectShowFile.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.SelectShowFile.Location = new System.Drawing.Point(20, 294);
			this.SelectShowFile.Name = "SelectShowFile";
			this.SelectShowFile.Size = new System.Drawing.Size(359, 70);
			this.SelectShowFile.TabIndex = 0;
			this.SelectShowFile.Text = "Select Show File";
			this.SelectShowFile.UseVisualStyleBackColor = true;
			this.SelectShowFile.Click += new System.EventHandler(this.SelectShowFile_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.Color.DimGray;
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UpdateText,
            this.ShowFileStatus});
			this.statusStrip1.Location = new System.Drawing.Point(0, 991);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(2209, 42);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// UpdateText
			// 
			this.UpdateText.Name = "UpdateText";
			this.UpdateText.Size = new System.Drawing.Size(63, 32);
			this.UpdateText.Text = "UwU";
			// 
			// ShowFileStatus
			// 
			this.ShowFileStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.ShowFileStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
			this.ShowFileStatus.ForeColor = System.Drawing.Color.DarkGray;
			this.ShowFileStatus.Name = "ShowFileStatus";
			this.ShowFileStatus.Size = new System.Drawing.Size(117, 32);
			this.ShowFileStatus.Text = "Show File:";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = "TBLC Files|*.tblc";
			this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
			// 
			// CreateShowFile
			// 
			this.CreateShowFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CreateShowFile.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.CreateShowFile.Location = new System.Drawing.Point(20, 117);
			this.CreateShowFile.Name = "CreateShowFile";
			this.CreateShowFile.Size = new System.Drawing.Size(359, 70);
			this.CreateShowFile.TabIndex = 3;
			this.CreateShowFile.Text = "Create Show File";
			this.CreateShowFile.UseVisualStyleBackColor = true;
			this.CreateShowFile.Click += new System.EventHandler(this.CreateShowFile_Click);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.FileName = "TailbassShowFile";
			this.saveFileDialog1.Filter = "TBLC Files|*.tblc";
			this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
			// 
			// ShowFileLoaderPanel
			// 
			this.ShowFileLoaderPanel.BackColor = System.Drawing.Color.DimGray;
			this.ShowFileLoaderPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.ShowFileLoaderPanel.Controls.Add(this.label4);
			this.ShowFileLoaderPanel.Controls.Add(this.label3);
			this.ShowFileLoaderPanel.Controls.Add(this.label2);
			this.ShowFileLoaderPanel.Controls.Add(this.CreateShowFile);
			this.ShowFileLoaderPanel.Controls.Add(this.SelectShowFile);
			this.ShowFileLoaderPanel.Location = new System.Drawing.Point(92, 286);
			this.ShowFileLoaderPanel.Name = "ShowFileLoaderPanel";
			this.ShowFileLoaderPanel.Size = new System.Drawing.Size(414, 381);
			this.ShowFileLoaderPanel.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(20, 82);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(209, 32);
			this.label4.TabIndex = 7;
			this.label4.Text = "Create a show file:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(20, 249);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(204, 32);
			this.label3.TabIndex = 6;
			this.label3.Text = "I have a show file:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(20, 22);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(375, 60);
			this.label2.TabIndex = 5;
			this.label2.Text = "Locate Show File...";
			this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// listBox1
			// 
			this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.listBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.listBox1.ForeColor = System.Drawing.Color.White;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 45;
			this.listBox1.Location = new System.Drawing.Point(12, 72);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(591, 904);
			this.listBox1.TabIndex = 5;
			// 
			// DisplayOnClickToggle
			// 
			this.DisplayOnClickToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DisplayOnClickToggle.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DisplayOnClickToggle.ForeColor = System.Drawing.Color.Red;
			this.DisplayOnClickToggle.Location = new System.Drawing.Point(609, 830);
			this.DisplayOnClickToggle.Name = "DisplayOnClickToggle";
			this.DisplayOnClickToggle.Size = new System.Drawing.Size(544, 70);
			this.DisplayOnClickToggle.TabIndex = 6;
			this.DisplayOnClickToggle.Text = "Output On Click - Disabled";
			this.DisplayOnClickToggle.UseVisualStyleBackColor = true;
			this.DisplayOnClickToggle.Click += new System.EventHandler(this.button1_Click);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.button1.Location = new System.Drawing.Point(609, 906);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(544, 70);
			this.button1.TabIndex = 8;
			this.button1.Text = "Output To Lights";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// button2
			// 
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.button2.Location = new System.Drawing.Point(609, 72);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(544, 70);
			this.button2.TabIndex = 9;
			this.button2.Text = "Save Current Scene";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.checkBox1.Location = new System.Drawing.Point(609, 148);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(498, 63);
			this.checkBox1.TabIndex = 10;
			this.checkBox1.Text = "Include Enabled Lights?";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// SceneController
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(2209, 1033);
			this.Controls.Add(this.ShowFileLoaderPanel);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.DisplayOnClickToggle);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.Color.White;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SceneController";
			this.Text = "Scene Controls";
			this.Load += new System.EventHandler(this.SceneController_Load);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ShowFileLoaderPanel.ResumeLayout(false);
			this.ShowFileLoaderPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Label label1;
		private Button SelectShowFile;
		private StatusStrip statusStrip1;
		private ToolStripStatusLabel UpdateText;
		private OpenFileDialog openFileDialog1;
		private Button CreateShowFile;
		private SaveFileDialog saveFileDialog1;
		private Panel ShowFileLoaderPanel;
		private Label label4;
		private Label label3;
		private Label label2;
		private ToolStripStatusLabel ShowFileStatus;
		private ListBox listBox1;
		private Button DisplayOnClickToggle;
		private Button button1;
		private Button button2;
		private CheckBox checkBox1;
	}
}