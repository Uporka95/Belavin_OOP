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
		public Book book_ret;
		BindingSource source = new BindingSource();
		public Form1()
		{
			InitializeComponent();
			mtAuthor.KeyDown += mtName_KeyDown;
			mtEditor.KeyDown += mtName_KeyDown;
		}

		private void bAdd_Click(object sender, EventArgs e)
		{
			if (!CheckAddFields())
			{
				MessageBox.Show("Форма не заполнена!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			book_ret = new Book(mtName.Text, mtAuthor.Text, mtEditor.Text, dtpFrom.Value);

			if (rbToBegin.Checked) Database.Add(book_ret, Position.ToBegin);
			if (rbToEnd.Checked) Database.Add(book_ret, Position.ToEnd);
			if (rbToPos.Checked) Database.Add(book_ret, Convert.ToInt32(numPos.Value));

			СlearAddFields();
			source.ResetBindings(false);

		
			
		}


		private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
			Database.ReadData(openFileDialog1.FileName);
		}


		private void Form1_Load(object sender, EventArgs e)
		{
			openFileDialog1.InitialDirectory = Application.StartupPath;
			saveFileDialog1.InitialDirectory = Application.StartupPath;

			source.DataSource = Database.database;
			dataGridView1.DataSource = source;

			source.ResetBindings(false);
		}

		private void bLoad_Click(object sender, EventArgs e)
		{
			openFileDialog1.ShowDialog();
			if (!Database.ReadData(openFileDialog1.FileName))
				MessageBox.Show("Файл пуст или содержит некорректные данные", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			source.DataSource = Database.database;
			source.ResetBindings(false);
		}

		private void bOverwrite_Click(object sender, EventArgs e)
		{
			saveFileDialog1.ShowDialog();
		}


		private bool CheckAddFields()
		{
			foreach (Control ctrl in gbData.Controls)
				if (ctrl is TextBox mt)
					if (mt.Text == "")
					{
						mt.Focus();
						return false;
					}

			return true;
		}
		private void СlearAddFields()
		{
			foreach (Control ctrl in gbData.Controls)
				if (ctrl is TextBox mt)
					mt.Clear();

		
		}

		private void mtName_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) this.SelectNextControl((Control)sender, true, true, true, true);
		}

		private void bDelByPos_Click(object sender, EventArgs e)
		{
			if (!Database.DeleteByPos(Convert.ToInt32(numDelByPos.Value)))
				MessageBox.Show("Такой позиции не существует!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			source.ResetBindings(false);
		}

		private void bDelByName_Click(object sender, EventArgs e)
		{
			if (!Database.DeleteByName(tbDelByName.Text))
				MessageBox.Show("Книга не найдена!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			source.ResetBindings(false);
		}

		private void bDelSelected_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dataGridView1.SelectedRows)
				dataGridView1.Rows.Remove(row);
			source.ResetBindings(false);
		}

		private void bSearchByTime_Click(object sender, EventArgs e)
		{
			var list = Database.FindByDate(dtpFrom.Value, dtpTo.Value);
			if (list == null)
			{
				MessageBox.Show("Книг изданных за указанный период не найдено!", "Печалька", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			source.DataSource = list;
			dataGridView1.DataSource = source;
			source.ResetBindings(false);
		}

		private void bSearchByAuthor_Click(object sender, EventArgs e)
		{
			var list = Database.FindByName(tbAuthorSearch.Text);
			if (list == null)
			{
				MessageBox.Show("Автор не найден!", "Печалька", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			source.DataSource = list;
			dataGridView1.DataSource = source;
			source.ResetBindings(false);
		}

		private void bSearchByName_Click(object sender, EventArgs e)
		{
			var list = Database.FindByName(tbBookSearch.Text);
			if (list == null)
			{
				MessageBox.Show("Книга не найдена!", "Печалька", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			source.DataSource = list;
			dataGridView1.DataSource = source;
			source.ResetBindings(false);
		}

		private void bSearchByEditor_Click(object sender, EventArgs e)
		{
			var list = Database.FindByName(tbEditorSearch.Text);
			if (list == null)
			{
				MessageBox.Show("Издательство не найдено!", "Печалька", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			source.DataSource = list;
			
			dataGridView1.DataSource = source;
			source.ResetBindings(false);
		}

		private void tabControl1_TabIndexChanged(object sender, EventArgs e)
		{
			if (tabControl1.SelectedTab.Text == "Данные")
			{
				source.DataSource = Database.database;
				dataGridView1.DataSource = source;
				source.ResetBindings(false);
			}
		}

		private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
		{
			Database.OverwriteData(saveFileDialog1.FileName);
		}
	}
}
