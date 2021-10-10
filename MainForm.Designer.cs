
namespace RDR2AnimationNameFinder
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			this.loadButton = new System.Windows.Forms.Button();
			this.animationList = new System.Windows.Forms.ListBox();
			this.fileNameLabel = new System.Windows.Forms.Label();
			this.exportToFile = new System.Windows.Forms.Button();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.refresh = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// loadButton
			// 
			this.loadButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.loadButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.loadButton.Location = new System.Drawing.Point(115, 386);
			this.loadButton.Name = "loadButton";
			this.loadButton.Size = new System.Drawing.Size(111, 23);
			this.loadButton.TabIndex = 1;
			this.loadButton.Text = "Load Dictionary";
			this.toolTip1.SetToolTip(this.loadButton, "Load dictionaries such as expressions, animations, and clips");
			this.loadButton.UseVisualStyleBackColor = true;
			this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
			// 
			// animationList
			// 
			this.animationList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.animationList.FormattingEnabled = true;
			this.animationList.HorizontalExtent = 850;
			this.animationList.HorizontalScrollbar = true;
			this.animationList.Location = new System.Drawing.Point(12, 38);
			this.animationList.Name = "animationList";
			this.animationList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.animationList.Size = new System.Drawing.Size(434, 342);
			this.animationList.TabIndex = 2;
			this.animationList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.animationList_MouseDown);
			// 
			// fileNameLabel
			// 
			this.fileNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fileNameLabel.AutoSize = true;
			this.fileNameLabel.BackColor = System.Drawing.Color.Transparent;
			this.fileNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.75F);
			this.fileNameLabel.Location = new System.Drawing.Point(12, 22);
			this.fileNameLabel.Name = "fileNameLabel";
			this.fileNameLabel.Size = new System.Drawing.Size(46, 13);
			this.fileNameLabel.TabIndex = 3;
			this.fileNameLabel.Text = "filename";
			// 
			// exportToFile
			// 
			this.exportToFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.exportToFile.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.exportToFile.Enabled = false;
			this.exportToFile.Location = new System.Drawing.Point(235, 386);
			this.exportToFile.Name = "exportToFile";
			this.exportToFile.Size = new System.Drawing.Size(111, 23);
			this.exportToFile.TabIndex = 4;
			this.exportToFile.Text = "Export To File";
			this.toolTip1.SetToolTip(this.exportToFile, "Export names to a txt file");
			this.exportToFile.UseVisualStyleBackColor = true;
			this.exportToFile.Click += new System.EventHandler(this.exportToFile_Click);
			// 
			// refresh
			// 
			this.refresh.Location = new System.Drawing.Point(388, 9);
			this.refresh.Name = "refresh";
			this.refresh.Size = new System.Drawing.Size(58, 23);
			this.refresh.TabIndex = 6;
			this.refresh.Text = "Refresh";
			this.toolTip1.SetToolTip(this.refresh, "Refresh entries after changing settings");
			this.refresh.UseVisualStyleBackColor = true;
			this.refresh.Click += new System.EventHandler(this.refresh_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(458, 24);
			this.menuStrip1.TabIndex = 5;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.settingsToolStripMenuItem.Text = "Settings";
			this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Margin = new System.Windows.Forms.Padding(-2, 0, 0, 0);
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(458, 417);
			this.Controls.Add(this.refresh);
			this.Controls.Add(this.exportToFile);
			this.Controls.Add(this.fileNameLabel);
			this.Controls.Add(this.animationList);
			this.Controls.Add(this.loadButton);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "RDR2 Animation Name Finder";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button loadButton;
		private System.Windows.Forms.ListBox animationList;
		private System.Windows.Forms.Label fileNameLabel;
		private System.Windows.Forms.Button exportToFile;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.Button refresh;
	}
}

