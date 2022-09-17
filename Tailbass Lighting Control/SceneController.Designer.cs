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
			this.SaveCurrentSceneButton = new System.Windows.Forms.Button();
			this.SceneNameTextbox = new System.Windows.Forms.TextBox();
			this.SceneListView = new System.Windows.Forms.ListView();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.DeleteScene = new System.Windows.Forms.Button();
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
			this.statusStrip1.Size = new System.Drawing.Size(1197, 42);
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
			this.ShowFileLoaderPanel.Location = new System.Drawing.Point(620, 72);
			this.ShowFileLoaderPanel.Name = "ShowFileLoaderPanel";
			this.ShowFileLoaderPanel.Size = new System.Drawing.Size(544, 379);
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
			// SaveCurrentSceneButton
			// 
			this.SaveCurrentSceneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SaveCurrentSceneButton.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.SaveCurrentSceneButton.Location = new System.Drawing.Point(620, 177);
			this.SaveCurrentSceneButton.Name = "SaveCurrentSceneButton";
			this.SaveCurrentSceneButton.Size = new System.Drawing.Size(544, 70);
			this.SaveCurrentSceneButton.TabIndex = 9;
			this.SaveCurrentSceneButton.Text = "Save Current Scene";
			this.SaveCurrentSceneButton.UseVisualStyleBackColor = true;
			this.SaveCurrentSceneButton.Click += new System.EventHandler(this.SaveCurrentSceneButton_Click);
			// 
			// SceneNameTextbox
			// 
			this.SceneNameTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.SceneNameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.SceneNameTextbox.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.SceneNameTextbox.ForeColor = System.Drawing.Color.White;
			this.SceneNameTextbox.Location = new System.Drawing.Point(620, 114);
			this.SceneNameTextbox.Name = "SceneNameTextbox";
			this.SceneNameTextbox.Size = new System.Drawing.Size(544, 57);
			this.SceneNameTextbox.TabIndex = 11;
			// 
			// SceneListView
			// 
			this.SceneListView.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.SceneListView.Location = new System.Drawing.Point(22, 72);
			this.SceneListView.MultiSelect = false;
			this.SceneListView.Name = "SceneListView";
			this.SceneListView.Size = new System.Drawing.Size(581, 904);
			this.SceneListView.TabIndex = 12;
			this.SceneListView.UseCompatibleStateImageBehavior = false;
			this.SceneListView.View = System.Windows.Forms.View.List;
			this.SceneListView.ItemActivate += new System.EventHandler(this.SceneListView_ItemActivate);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label7.ForeColor = System.Drawing.Color.White;
			this.label7.Location = new System.Drawing.Point(620, 262);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(428, 78);
			this.label7.TabIndex = 70;
			this.label7.Text = "<--\r\nDouble Click to Output to lights!";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label5.ForeColor = System.Drawing.Color.White;
			this.label5.Location = new System.Drawing.Point(620, 72);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(185, 39);
			this.label5.TabIndex = 71;
			this.label5.Text = "Scene Name:";
			// 
			// DeleteScene
			// 
			this.DeleteScene.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DeleteScene.Font = new System.Drawing.Font("Segoe UI", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.DeleteScene.Location = new System.Drawing.Point(609, 906);
			this.DeleteScene.Name = "DeleteScene";
			this.DeleteScene.Size = new System.Drawing.Size(576, 70);
			this.DeleteScene.TabIndex = 72;
			this.DeleteScene.Text = "Delete Scene";
			this.DeleteScene.UseVisualStyleBackColor = true;
			this.DeleteScene.Click += new System.EventHandler(this.DeleteScene_Click);
			// 
			// SceneController
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.ClientSize = new System.Drawing.Size(1197, 1033);
			this.Controls.Add(this.DeleteScene);
			this.Controls.Add(this.ShowFileLoaderPanel);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.SceneNameTextbox);
			this.Controls.Add(this.SaveCurrentSceneButton);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.SceneListView);
			this.ForeColor = System.Drawing.Color.White;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "SceneController";
			this.Text = "Scene Controller";
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
		private Button SaveCurrentSceneButton;
		private TextBox SceneNameTextbox;
		private ListView SceneListView;
		private Label label7;
		private Label label5;
		private Button DeleteScene;
	}
}