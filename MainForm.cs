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

		public void PopulateList()
		{
			if (string.IsNullOrEmpty(fileContents)) { return; }

			animationList.Items.Clear();
			parsedAnims.Clear();

			if (Properties.Settings.Default.file_matchAnim) { SearchForMatches("anim"); }
			if (Properties.Settings.Default.file_matchClip) { SearchForMatches("clip"); }
			if (Properties.Settings.Default.file_matchExpr) { SearchForMatches("expr"); }
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
					if (Properties.Settings.Default.misc_showFileType)
					{
						animationList.Items.Add(clipName);
					} else
					{
						animationList.Items.Add(clipName.Replace(".anim", "").Replace(".clip", "").Replace(".expr", ""));
					}
				}
				exportToFile.Enabled = true;
			}
		}

		private void SearchForMatches(string fileType)
		{
			// Use Regex to find animation names
			Regex rx = new Regex(@"pack:/(.*?)\." + fileType);

			if (!string.IsNullOrEmpty(fileContents)) // redundant check
			{
				Cursor.Current = Cursors.WaitCursor;
				foreach (Match match in rx.Matches(fileContents))
				{
					// Remove "pack:/" before adding to list
					parsedAnims.Add(match.Value.Replace("pack:/", ""));
				}
				Cursor.Current = Cursors.Default;
			}
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
					fileContents = File.ReadAllText(path, System.Text.Encoding.UTF8);
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

		#region Context Menu Handling
		private void CreateContextMenu()
		{
			ContextMenu indexContextMenu = new ContextMenu();

			MenuItem copy = indexContextMenu.MenuItems.Add("Copy");
			copy.Click += new EventHandler(CopyItem_Click);
			MenuItem copy2 = indexContextMenu.MenuItems.Add("Copy as array element");
			copy2.Click += new EventHandler(CopyAsArrayElement_Click);

			animationList.ContextMenu = indexContextMenu;
			indexContextMenu.Show(animationList, animationList.PointToClient(Cursor.Position));
		}

		private void CopyItem_Click(object sender, EventArgs e)
		{
			string item = "";
			bool includeFileType = Properties.Settings.Default.misc_includeFileTypeInCopy;

			for (int i = 0; i < animationList.SelectedItems.Count; i++)
			{
				int index = animationList.Items.IndexOf(animationList.SelectedItems[i]);

				if (i + 1 == animationList.SelectedItems.Count)
				{
					// Dont add a newline if item is last
					if (includeFileType)
						item += parsedAnims[index].ToString();
					else
						item += parsedAnims[index].ToString().Substring(0, parsedAnims[index].ToString().Length - 5);
				}
				else
				{
					if (includeFileType)
						item += parsedAnims[index].ToString() + "\n";
					else
						item += parsedAnims[index].ToString().Substring(0, parsedAnims[index].ToString().Length - 5) + "\n";
				}
			}
			Clipboard.SetText(item);
		}

		private void CopyAsArrayElement_Click(object sender, EventArgs e)
		{
			string item = "";
			bool includeFileType = Properties.Settings.Default.misc_includeFileTypeInCopy;

			for (int i = 0; i < animationList.SelectedItems.Count; i++)
			{
				int index = animationList.Items.IndexOf(animationList.SelectedItems[i]);

				if (i + 1 == animationList.SelectedItems.Count)
				{
					// Dont add a comma if item is last
					if (includeFileType)
						item += $"\"{parsedAnims[index].ToString()}\"";
					else
						item += $"\"{parsedAnims[index].ToString().Substring(0, parsedAnims[index].ToString().Length - 5)}\"";
				}
				else
				{
					if (includeFileType)
						item += $"\"{parsedAnims[index].ToString()}\", ";
					else
						item += $"\"{parsedAnims[index].ToString().Substring(0, parsedAnims[index].ToString().Length - 5)}\", ";
				}
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
		#endregion

		private void exportToFile_Click(object sender, EventArgs e)
		{
			string fileName = Path.GetFileName(path);
			string file = path + ".txt";
			bool includeFileType = Properties.Settings.Default.export_includeTypeInExport;
			bool exportAsArray = Properties.Settings.Default.export_exportAsArray;

			bool isFileTypeInName(string input)
			{
				string sub = input.Substring(input.Length - 4);
				if (sub == "anim" || sub == "clip" || sub == "expr") { return true; }
				return false;
			}

			void write()
			{
				try
				{
					// What a ugly mess...

					using (StreamWriter sw = File.CreateText(file))
					{
						sw.WriteLine(fileName);
						sw.WriteLine("\n");
						for (int i = 0; i < parsedAnims.Count; i++)
						{
							string animName = parsedAnims[i].ToString();
							bool typeInName = isFileTypeInName(animName);

							if (includeFileType && exportAsArray)
							{
								if (i + 1 == parsedAnims.Count)
									sw.Write("\"" + animName + "\"");
								else
									sw.Write("\"" + animName + "\", ");
							}

							else if (includeFileType && !exportAsArray)
							{
								sw.WriteLine(animName);
							}

							else if (!includeFileType && exportAsArray)
							{
								if (i + 1 == parsedAnims.Count)
								{
									if (typeInName)
										sw.Write("\"" + animName.Substring(0, animName.Length - 5) + "\"");
									else
										sw.Write("\"" + animName + "\"");
								}
								else
								{
									if (typeInName)
										sw.Write("\"" + animName.Substring(0, animName.Length - 5) + "\", ");
									else
										sw.Write("\"" + animName + "\", ");
								}
							}

							else if (!includeFileType && !exportAsArray)
							{
								if (typeInName)
									sw.WriteLine(animName.Substring(0, animName.Length - 5));
								else
									sw.WriteLine(animName);
							}
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
				catch (Exception ex)
				{
					MessageBox.Show($"There was an error while processing the file:\n\n{ex.ToString()}");
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
