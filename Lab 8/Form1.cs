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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void bAdd_Click(object sender, EventArgs e)
		{
			DataAddDiag diag = new DataAddDiag();
			diag.Show();
			if (diag.DialogResult == DialogResult.OK)
			{
				if (diag.rbToBegin.Checked) Database.Add(diag.book_ret, Position.ToBegin);
				if (diag.rbToEnd.Checked) Database.Add(diag.book_ret, Position.ToEnd);
				if (diag.rbToPos.Checked) Database.Add(diag.book_ret, Convert.ToInt32(diag.numPos.Value));
			}
		}

		private void bFind_Click(object sender, EventArgs e)
		{
			FindDiag diag = new FindDiag();
			diag.Show();
			if (diag.DialogResult == DialogResult.OK)
			{
				if (diag.rbFindByAuthor.Checked) Database.FindByAuthor(diag.mtName.Text);
				if (diag.rbFindByTime.Checked) Database.FindByDate(diag.dtpFrom.Value, diag.dtpTo.Value);
			}
		}

		private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
			Database.ReadData(openFileDialog1.FileName);
		}
	}
}
