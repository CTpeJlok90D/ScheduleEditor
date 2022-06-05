using System;
using Classes;
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
	public partial class ClassRoomsManager : Form
	{
		public ClassRoomsManager()
		{
			InitializeComponent();
		}

		private void UpdateListBox(ListBox _listBox, List<Info> _list) 
		{
			_listBox.Items.Clear();
			foreach (Info var in _list)
			{
				_listBox.Items.Add(var.GetName());
			}
		}
		private void ClassRoomsManager_Load(object sender, EventArgs e)
		{
			UpdateListBox(classRooms_ListBox, ClassRoom.storage);
		}
	}
}
