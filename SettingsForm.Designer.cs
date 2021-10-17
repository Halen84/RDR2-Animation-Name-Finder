
namespace RDR2AnimationNameFinder
{
	partial class SettingsForm
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
			this.file_matchAnim = new System.Windows.Forms.CheckBox();
			this.file_matchClip = new System.Windows.Forms.CheckBox();
			this.file_matchExpr = new System.Windows.Forms.CheckBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.misc_showFileType = new System.Windows.Forms.CheckBox();
			this.fileTypesGB = new System.Windows.Forms.GroupBox();
			this.exportGB = new System.Windows.Forms.GroupBox();
			this.export_exportAsArray = new System.Windows.Forms.CheckBox();
			this.export_includeTypeInExport = new System.Windows.Forms.CheckBox();
			this.miscGB = new System.Windows.Forms.GroupBox();
			this.misc_includeFileTypeInCopy = new System.Windows.Forms.CheckBox();
			this.applyChanges = new System.Windows.Forms.Button();
			this.fileTypesGB.SuspendLayout();
			this.exportGB.SuspendLayout();
			this.miscGB.SuspendLayout();
			this.SuspendLayout();
			// 
			// file_matchAnim
			// 
			this.file_matchAnim.AutoSize = true;
			this.file_matchAnim.Checked = true;
			this.file_matchAnim.CheckState = System.Windows.Forms.CheckState.Checked;
			this.file_matchAnim.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.file_matchAnim.Location = new System.Drawing.Point(6, 19);
			this.file_matchAnim.Name = "file_matchAnim";
			this.file_matchAnim.Size = new System.Drawing.Size(84, 17);
			this.file_matchAnim.TabIndex = 0;
			this.file_matchAnim.Text = "Match .anim";
			this.toolTip1.SetToolTip(this.file_matchAnim, "Choose whether to match .anim files in dictionaries");
			this.file_matchAnim.UseVisualStyleBackColor = true;
			this.file_matchAnim.CheckedChanged += new System.EventHandler(this.file_matchAnim_CheckedChanged);
			// 
			// file_matchClip
			// 
			this.file_matchClip.AutoSize = true;
			this.file_matchClip.Checked = true;
			this.file_matchClip.CheckState = System.Windows.Forms.CheckState.Checked;
			this.file_matchClip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.file_matchClip.Location = new System.Drawing.Point(6, 42);
			this.file_matchClip.Name = "file_matchClip";
			this.file_matchClip.Size = new System.Drawing.Size(78, 17);
			this.file_matchClip.TabIndex = 1;
			this.file_matchClip.Text = "Match .clip";
			this.toolTip1.SetToolTip(this.file_matchClip, "Choose whether to match .clip files in dictionaries");
			this.file_matchClip.UseVisualStyleBackColor = true;
			this.file_matchClip.CheckedChanged += new System.EventHandler(this.file_matchClip_CheckedChanged);
			// 
			// file_matchExpr
			// 
			this.file_matchExpr.AutoSize = true;
			this.file_matchExpr.Checked = true;
			this.file_matchExpr.CheckState = System.Windows.Forms.CheckState.Checked;
			this.file_matchExpr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.file_matchExpr.Location = new System.Drawing.Point(6, 65);
			this.file_matchExpr.Name = "file_matchExpr";
			this.file_matchExpr.Size = new System.Drawing.Size(82, 17);
			this.file_matchExpr.TabIndex = 2;
			this.file_matchExpr.Text = "Match .expr";
			this.toolTip1.SetToolTip(this.file_matchExpr, "Choose whether to match .expr files in dictionaries");
			this.file_matchExpr.UseVisualStyleBackColor = true;
			this.file_matchExpr.CheckedChanged += new System.EventHandler(this.file_matchExpr_CheckedChanged);
			// 
			// misc_showFileType
			// 
			this.misc_showFileType.AutoSize = true;
			this.misc_showFileType.Checked = true;
			this.misc_showFileType.CheckState = System.Windows.Forms.CheckState.Checked;
			this.misc_showFileType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.misc_showFileType.Location = new System.Drawing.Point(6, 19);
			this.misc_showFileType.Name = "misc_showFileType";
			this.misc_showFileType.Size = new System.Drawing.Size(92, 17);
			this.misc_showFileType.TabIndex = 3;
			this.misc_showFileType.Text = "Show file type";
			this.toolTip1.SetToolTip(this.misc_showFileType, "Show file type in entry list");
			this.misc_showFileType.UseVisualStyleBackColor = true;
			this.misc_showFileType.CheckedChanged += new System.EventHandler(this.misc_showFileType_CheckedChanged);
			// 
			// fileTypesGB
			// 
			this.fileTypesGB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fileTypesGB.Controls.Add(this.file_matchAnim);
			this.fileTypesGB.Controls.Add(this.file_matchClip);
			this.fileTypesGB.Controls.Add(this.file_matchExpr);
			this.fileTypesGB.Location = new System.Drawing.Point(12, 5);
			this.fileTypesGB.Name = "fileTypesGB";
			this.fileTypesGB.Size = new System.Drawing.Size(204, 87);
			this.fileTypesGB.TabIndex = 4;
			this.fileTypesGB.TabStop = false;
			this.fileTypesGB.Text = "File Types";
			// 
			// exportGB
			// 
			this.exportGB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.exportGB.Controls.Add(this.export_exportAsArray);
			this.exportGB.Controls.Add(this.export_includeTypeInExport);
			this.exportGB.Location = new System.Drawing.Point(12, 98);
			this.exportGB.Name = "exportGB";
			this.exportGB.Size = new System.Drawing.Size(204, 64);
			this.exportGB.TabIndex = 5;
			this.exportGB.TabStop = false;
			this.exportGB.Text = "Export Settings";
			// 
			// export_exportAsArray
			// 
			this.export_exportAsArray.AutoSize = true;
			this.export_exportAsArray.Location = new System.Drawing.Point(6, 42);
			this.export_exportAsArray.Name = "export_exportAsArray";
			this.export_exportAsArray.Size = new System.Drawing.Size(141, 17);
			this.export_exportAsArray.TabIndex = 7;
			this.export_exportAsArray.Text = "Export as array elements";
			this.export_exportAsArray.UseVisualStyleBackColor = true;
			this.export_exportAsArray.CheckedChanged += new System.EventHandler(this.export_exportAsArray_CheckedChanged);
			// 
			// export_includeTypeInExport
			// 
			this.export_includeTypeInExport.AutoSize = true;
			this.export_includeTypeInExport.Checked = true;
			this.export_includeTypeInExport.CheckState = System.Windows.Forms.CheckState.Checked;
			this.export_includeTypeInExport.Location = new System.Drawing.Point(6, 19);
			this.export_includeTypeInExport.Name = "export_includeTypeInExport";
			this.export_includeTypeInExport.Size = new System.Drawing.Size(143, 17);
			this.export_includeTypeInExport.TabIndex = 6;
			this.export_includeTypeInExport.Text = "Include file type in export";
			this.export_includeTypeInExport.UseVisualStyleBackColor = true;
			this.export_includeTypeInExport.CheckedChanged += new System.EventHandler(this.export_includeTypeInExport_CheckedChanged);
			// 
			// miscGB
			// 
			this.miscGB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.miscGB.Controls.Add(this.misc_includeFileTypeInCopy);
			this.miscGB.Controls.Add(this.misc_showFileType);
			this.miscGB.Location = new System.Drawing.Point(12, 168);
			this.miscGB.Name = "miscGB";
			this.miscGB.Size = new System.Drawing.Size(204, 64);
			this.miscGB.TabIndex = 6;
			this.miscGB.TabStop = false;
			this.miscGB.Text = "Miscellaneous";
			// 
			// misc_includeFileTypeInCopy
			// 
			this.misc_includeFileTypeInCopy.AutoSize = true;
			this.misc_includeFileTypeInCopy.Location = new System.Drawing.Point(6, 42);
			this.misc_includeFileTypeInCopy.Name = "misc_includeFileTypeInCopy";
			this.misc_includeFileTypeInCopy.Size = new System.Drawing.Size(137, 17);
			this.misc_includeFileTypeInCopy.TabIndex = 7;
			this.misc_includeFileTypeInCopy.Text = "Include file type in copy";
			this.misc_includeFileTypeInCopy.UseVisualStyleBackColor = true;
			this.misc_includeFileTypeInCopy.CheckedChanged += new System.EventHandler(this.misc_includeFileTypeInCopy_CheckedChanged);
			// 
			// applyChanges
			// 
			this.applyChanges.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.applyChanges.Location = new System.Drawing.Point(76, 236);
			this.applyChanges.Name = "applyChanges";
			this.applyChanges.Size = new System.Drawing.Size(75, 23);
			this.applyChanges.TabIndex = 7;
			this.applyChanges.Text = "Apply";
			this.toolTip1.SetToolTip(this.applyChanges, "Apply changes");
			this.applyChanges.UseVisualStyleBackColor = true;
			this.applyChanges.Click += new System.EventHandler(this.applyChanges_Click);
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(228, 265);
			this.Controls.Add(this.applyChanges);
			this.Controls.Add(this.miscGB);
			this.Controls.Add(this.exportGB);
			this.Controls.Add(this.fileTypesGB);
			this.Name = "SettingsForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Settings";
			this.fileTypesGB.ResumeLayout(false);
			this.fileTypesGB.PerformLayout();
			this.exportGB.ResumeLayout(false);
			this.exportGB.PerformLayout();
			this.miscGB.ResumeLayout(false);
			this.miscGB.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.CheckBox file_matchAnim;
		private System.Windows.Forms.CheckBox file_matchClip;
		private System.Windows.Forms.CheckBox file_matchExpr;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.CheckBox misc_showFileType;
		private System.Windows.Forms.GroupBox fileTypesGB;
		private System.Windows.Forms.GroupBox exportGB;
		private System.Windows.Forms.CheckBox export_exportAsArray;
		private System.Windows.Forms.CheckBox export_includeTypeInExport;
		private System.Windows.Forms.GroupBox miscGB;
		private System.Windows.Forms.CheckBox misc_includeFileTypeInCopy;
		private System.Windows.Forms.Button applyChanges;
	}
}