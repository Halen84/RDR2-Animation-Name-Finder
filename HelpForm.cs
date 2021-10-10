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
	public partial class HelpForm : Form
	{
		public HelpForm()
		{
			InitializeComponent();

			// What laziness does to a man...
			label1.Left = (this.ClientSize.Width - label1.Width) / 2;
			label2.Left = (this.ClientSize.Width - label2.Width) / 2;
			label3.Left = (this.ClientSize.Width - label3.Width) / 2;
			label4.Left = (this.ClientSize.Width - label4.Width) / 2;
			label5.Left = (this.ClientSize.Width - label5.Width) / 2;
			label6.Left = (this.ClientSize.Width - label6.Width) / 2;
			label7.Left = (this.ClientSize.Width - label7.Width) / 2;
		}
	}
}
