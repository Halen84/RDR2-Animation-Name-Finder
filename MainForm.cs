using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RDR2AnimationNameFinder
{
	public partial class MainForm : Form
	{
		private List<string> parsedAnims = new List<string>();
		private string path;
		private string fileContents;

		public MainForm()
		{
			InitializeComponent();
			fileNameLabel.Text = "";
		}

		private void PopulateList()
		{
			animationList.Items.Clear();
			parsedAnims.Clear();

			if (Properties.Settings.Default.matchAnim) { SearchForMatches("anim"); }
			if (Properties.Settings.Default.matchClip) { SearchForMatches("clip"); }
			if (Properties.Settings.Default.matchExpr) { SearchForMatches("expr"); }
			parsedAnims.Sort();

			if (parsedAnims.Count == 0)
			{
				exportToFile.Enabled = false;
				MessageBox.Show("No animations were found! Be sure to check your settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				foreach (string clipName in parsedAnims)
				{
					animationList.Items.Add(clipName);
				}
				exportToFile.Enabled = true;
			}
		}

		private void SearchForMatches(string fileType)
		{
			// Use Regex to find animation names
			Regex rx = new Regex(@"pack:/(.*?)\." + fileType);

			Cursor.Current = Cursors.WaitCursor;
			foreach (Match match in rx.Matches(fileContents))
			{
				if (Properties.Settings.Default.keepFileType)
				{
					// Remove "pack:/" before adding to the list.
					parsedAnims.Add(match.Value.Replace("pack:/", ""));
				}
				else
				{
					// Remove "pack:/" and fileType before adding to the list.
					parsedAnims.Add(match.Value.Replace("pack:/", "").Replace($".{fileType}", ""));
				}
			}
			Cursor.Current = Cursors.Default;
		}

		private void loadButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "System File|*.sys";
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				path = dialog.FileName;
				fileNameLabel.Text = Path.GetFileName(path);

				// Truncate text
				if (fileNameLabel.Text.Length > 64) { fileNameLabel.Text = fileNameLabel.Text.Substring(0, 63) + "..."; }

				try
				{
					fileContents = File.ReadAllText(path);
				} catch (Exception ex)
				{
					MessageBox.Show($"Unable to read file:\n\n{ex.ToString()}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				PopulateList();
			}
		}

		private void refresh_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(fileContents))
			{
				PopulateList();
			}
		}

		private void CreateContextMenu()
		{
			ContextMenu indexContextMenu = new ContextMenu();

			MenuItem deleteItem = indexContextMenu.MenuItems.Add("Copy");
			deleteItem.Click += new EventHandler(CopyItem_Click);
			animationList.ContextMenu = indexContextMenu;
			indexContextMenu.Show(animationList, animationList.PointToClient(Cursor.Position));
		}

		private void CopyItem_Click(object sender, EventArgs e)
		{
			string item = "";
			for (int i = 0; i < animationList.SelectedItems.Count; i++)
			{
				item += animationList.SelectedItems[i].ToString() + "\n";
			}
			Clipboard.SetText(item);
		}

		private void animationList_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Right && animationList.SelectedItem != null)
			{
				CreateContextMenu();
			}
		}

		private void exportToFile_Click(object sender, EventArgs e)
		{
			string fileName = Path.GetFileName(path);
			string file = path + ".txt";

			void write()
			{
				using (StreamWriter sw = File.CreateText(file))
				{
					sw.WriteLine(fileName);
					sw.WriteLine("\n");
					for (int i = 0; i < animationList.Items.Count; i++)
					{
						sw.WriteLine(animationList.Items[i].ToString());
					}

					DialogResult result = MessageBox.Show("Successfully exported file. Would you like to open file location?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
					if (result == DialogResult.Yes)
					{
						try
						{
							Process.Start(Path.GetDirectoryName(file.Replace(".txt", "")));
						}
						catch (Exception ex)
						{
							MessageBox.Show($"Unable to open file location:\n\n{ex.ToString()}");
						}
					}
				}
			}

			if (!File.Exists(file))
			{
				write();
			} else
			{
				DialogResult result = MessageBox.Show($"{fileName} has already been exported.\n\nWould you like to overwrite this file?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
				if (result == DialogResult.Yes)
				{
					write();
				}
			}
		}

		private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new SettingsForm().ShowDialog();
		}

		private void helpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new HelpForm().ShowDialog();
		}
	}
}
