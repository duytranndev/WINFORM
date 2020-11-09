using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_Image
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void listbox_target_DoubleClick(object sender, EventArgs e)
		{
			OpenFileDialog opd = new OpenFileDialog();
			opd.Filter = "Images|*.JPG";
			opd.ShowDialog();
		}

		private void listbox_target_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(listbox_source.SelectedIndex != -1){
				this.pictureBox1.Image = this.imageList1.Images[this.listbox_target.SelectedIndex];
			}
		}

		private void btn_send_item_click_Click(object sender, EventArgs e)
		{
			if (this.listbox_source.SelectedIndex != -1)
			{
				this.listbox_target.Items.Add(this.listbox_source.SelectedItem.ToString());
				this.listbox_source.Items.RemoveAt(this.listbox_source.SelectedIndex);
			}
			else
			{
				String str = MessageBox.Show("Chon phan tu o tren ListBox", "C# Programming", 
					MessageBoxButtons.OKCancel, MessageBoxIcon.Information).ToString();
				if(str =="OK" && this.listbox_source.Items.Count > 0)
				{
					this.listbox_source.SelectedIndex = 0;
				}
			}
		}

		private void btn_back_item_click_Click(object sender, EventArgs e)
		{
			if (this.listbox_target.SelectedIndex != -1)
			{
				this.listbox_source.Items.Add(this.listbox_target.SelectedItem.ToString());
				this.listbox_target.Items.RemoveAt(this.listbox_target.SelectedIndex);
				
			}
			else
			{
				String str = MessageBox.Show("Chon phan tu o tren ListBox", "C# Programming",
					MessageBoxButtons.OKCancel, MessageBoxIcon.Information).ToString();
				if (str == "OK") this.listbox_target.SelectedIndex = 0;
				
			}
		}

		private void btn_send_items_click_Click(object sender, EventArgs e)
		{
			while (this.listbox_source.Items.Count > 0)
			{
				this.listbox_target.Items.Add(this.listbox_source.Items[0].ToString());
				this.listbox_source.Items.RemoveAt(0);
			}
		}

		private void btn_back_items_click_Click(object sender, EventArgs e)
		{
			while (this.listbox_target.Items.Count > 0)
			{
				this.listbox_source.Items.Add(this.listbox_target.Items[0].ToString());
				this.listbox_target.Items.RemoveAt(0);
			}
		}


	}
}
