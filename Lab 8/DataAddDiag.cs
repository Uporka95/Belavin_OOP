using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8
{
	public partial class DataAddDiag : Form
	{
		public Book book_ret;
		public DataAddDiag()
		{
			InitializeComponent();
			mtAuthor.KeyDown += mtName_KeyDown;
			mtEditor.KeyDown += mtName_KeyDown;
			Load += delegate { mtName.Select(); };
		}

		private void bInput_Click(object sender, EventArgs e)
		{
			if (!CheckFields())
			{
				MessageBox.Show("Форма не заполнена!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			book_ret = new Book(mtName.Text, mtAuthor.Text, mtEditor.Text, dtpFrom.Value);
		
			DialogResult = DialogResult.OK;
			this.Close();
		}

		private bool CheckFields()
		{
			foreach (Control ctrl in gbData.Controls)
				if (ctrl is MaskedTextBox mt)
					if (!mt.MaskCompleted) 
						{
						mt.Focus();
						return false; 
						}

			return true;
		}

		private void mtName_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) this.SelectNextControl((Control)sender, true,true,true,true);
		}

	}
}
