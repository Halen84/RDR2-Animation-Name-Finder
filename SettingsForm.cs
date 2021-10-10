using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RDR2AnimationNameFinder
{
	public partial class SettingsForm : Form
	{
		public SettingsForm()
		{
			InitializeComponent();
			mAnim.Checked = Properties.Settings.Default.matchAnim;
			mClip.Checked = Properties.Settings.Default.matchClip;
			mExpr.Checked = Properties.Settings.Default.matchExpr;
			keepFileType.Checked = Properties.Settings.Default.keepFileType;
		}

		private void mAnim_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.matchAnim = mAnim.Checked;
			Properties.Settings.Default.Save();
		}

		private void mClip_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.matchClip = mClip.Checked;
			Properties.Settings.Default.Save();
		}

		private void mExpr_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.matchExpr = mExpr.Checked;
			Properties.Settings.Default.Save();
		}

		private void keepFileType_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.keepFileType = keepFileType.Checked;
			Properties.Settings.Default.Save();
		}
	}
}
