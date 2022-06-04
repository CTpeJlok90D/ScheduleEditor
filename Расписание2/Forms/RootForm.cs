using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Расписание2.Forms
{
	public partial class RootForm : Form
	{
		public RootForm()
		{
			InitializeComponent();
		}

		private void кабинетамиToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new ClassRoomsManager().ShowDialog();
		}
	}
}
