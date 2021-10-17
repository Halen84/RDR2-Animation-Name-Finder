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
		private MainForm mainForm = (MainForm)Application.OpenForms["MainForm"];

		public SettingsForm()
		{
			InitializeComponent();

			// File Type Settings
			file_matchAnim.Checked = Properties.Settings.Default.file_matchAnim;
			file_matchClip.Checked = Properties.Settings.Default.file_matchClip;
			file_matchExpr.Checked = Properties.Settings.Default.file_matchExpr;

			// Export Settings
			export_includeTypeInExport.Checked = Properties.Settings.Default.export_includeTypeInExport;
			export_exportAsArray.Checked = Properties.Settings.Default.export_exportAsArray;

			// Misc Settings
			misc_showFileType.Checked = Properties.Settings.Default.misc_showFileType;
			misc_includeFileTypeInCopy.Checked = Properties.Settings.Default.misc_includeFileTypeInCopy;
		}

		private void applyChanges_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.Save();
			mainForm.PopulateList();
		}


		// File Types
		private void file_matchAnim_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.file_matchAnim = file_matchAnim.Checked;
		}

		private void file_matchClip_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.file_matchClip = file_matchClip.Checked;
		}

		private void file_matchExpr_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.file_matchExpr = file_matchExpr.Checked;
		}


		// Export
		private void export_includeTypeInExport_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.export_includeTypeInExport = export_includeTypeInExport.Checked;
		}

		private void export_exportAsArray_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.export_exportAsArray = export_exportAsArray.Checked;
		}


		// Misc
		private void misc_showFileType_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.misc_showFileType = misc_showFileType.Checked;
		}

		private void misc_includeFileTypeInCopy_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.misc_includeFileTypeInCopy = misc_includeFileTypeInCopy.Checked;
		}
	}
}
