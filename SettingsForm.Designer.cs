
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
			this.mAnim = new System.Windows.Forms.CheckBox();
			this.mClip = new System.Windows.Forms.CheckBox();
			this.mExpr = new System.Windows.Forms.CheckBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.keepFileType = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// mAnim
			// 
			this.mAnim.AutoSize = true;
			this.mAnim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.mAnim.Location = new System.Drawing.Point(12, 12);
			this.mAnim.Name = "mAnim";
			this.mAnim.Size = new System.Drawing.Size(94, 19);
			this.mAnim.TabIndex = 0;
			this.mAnim.Text = "Match .anim";
			this.toolTip1.SetToolTip(this.mAnim, "Choose whether to match .anim files in dictionaries");
			this.mAnim.UseVisualStyleBackColor = true;
			this.mAnim.CheckedChanged += new System.EventHandler(this.mAnim_CheckedChanged);
			// 
			// mClip
			// 
			this.mClip.AutoSize = true;
			this.mClip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.mClip.Location = new System.Drawing.Point(12, 35);
			this.mClip.Name = "mClip";
			this.mClip.Size = new System.Drawing.Size(85, 19);
			this.mClip.TabIndex = 1;
			this.mClip.Text = "Match .clip";
			this.toolTip1.SetToolTip(this.mClip, "Choose whether to match .clip files in dictionaries");
			this.mClip.UseVisualStyleBackColor = true;
			this.mClip.CheckedChanged += new System.EventHandler(this.mClip_CheckedChanged);
			// 
			// mExpr
			// 
			this.mExpr.AutoSize = true;
			this.mExpr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.mExpr.Location = new System.Drawing.Point(12, 58);
			this.mExpr.Name = "mExpr";
			this.mExpr.Size = new System.Drawing.Size(90, 19);
			this.mExpr.TabIndex = 2;
			this.mExpr.Text = "Match .expr";
			this.toolTip1.SetToolTip(this.mExpr, "Choose whether to match .expr files in dictionaries");
			this.mExpr.UseVisualStyleBackColor = true;
			this.mExpr.CheckedChanged += new System.EventHandler(this.mExpr_CheckedChanged);
			// 
			// keepFileType
			// 
			this.keepFileType.AutoSize = true;
			this.keepFileType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.keepFileType.Location = new System.Drawing.Point(12, 81);
			this.keepFileType.Name = "keepFileType";
			this.keepFileType.Size = new System.Drawing.Size(110, 19);
			this.keepFileType.TabIndex = 3;
			this.keepFileType.Text = "Include file type";
			this.toolTip1.SetToolTip(this.keepFileType, "Show file type in entry list");
			this.keepFileType.UseVisualStyleBackColor = true;
			this.keepFileType.CheckedChanged += new System.EventHandler(this.keepFileType_CheckedChanged);
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(196, 113);
			this.Controls.Add(this.keepFileType);
			this.Controls.Add(this.mExpr);
			this.Controls.Add(this.mClip);
			this.Controls.Add(this.mAnim);
			this.Name = "SettingsForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Settings";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.CheckBox mAnim;
		private System.Windows.Forms.CheckBox mClip;
		private System.Windows.Forms.CheckBox mExpr;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.CheckBox keepFileType;
	}
}