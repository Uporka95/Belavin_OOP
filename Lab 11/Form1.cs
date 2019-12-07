
using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_11
{
	public partial class Form1 : Form
	{
		Random rnd = new Random();
		SortedList sorted_list = new SortedList { 
		{ 0, new Library() },
		{ 1, new Library() },
		{ 2, new Library() },
		{ 3, new Library() },
		{ 4, new Library() }};

		List<Library> list = new List<Library> {new Library(), new Library(),new Library(),new Library(),new Library() };
		BindingSource bs_sorted_list = new BindingSource();
		BindingSource bs_list = new BindingSource();

		BindingSource TestCol1 = new BindingSource();
		BindingSource TestCol2 = new BindingSource();
		BindingSource TestCol3 = new BindingSource();
		BindingSource TestCol4 = new BindingSource();
		TestCollections test;
		public Form1()
		{
			InitializeComponent();
			
		}

		private void bDoAllTests_Click(object sender, EventArgs e)
		{
			rtTests1Col.Text = test.Test1Col();
			rtTests2Col.Text = test.Test2Col();
			rtTests3Col.Text = test.Test3Col();
			rtTests4Col.Text = test.Test4Col();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			test = new TestCollections(10);
			TestCol1.DataSource = test.queue_orgs;
			TestCol3.DataSource = test.sdict_orgs;
			TestCol4.DataSource = test.sdict_str;
			bs_sorted_list.DataSource = sorted_list;
			bs_list.DataSource = list;
			dataGridView1.DataSource = TestCol1;
			ExtractRows();
			dataGridView3.DataSource = TestCol3;
			dataGridView4.DataSource = TestCol4;

			dataGridView5.DataSource = bs_sorted_list;
			dataGridView6.DataSource = bs_list;
		}

		private void ExtractRows()
		{
			dataGridView2.Columns.Add("Value", "value");
			foreach (var item in test.queue_str)
			{
				dataGridView2.Rows.Add(item);
			}
			
		}

		private void bAdd_Click(object sender, EventArgs e)
		{
			sorted_list.Add(rnd.Next(0,10000),new Library());

			bs_sorted_list = new BindingSource();
			bs_sorted_list.DataSource = sorted_list;
			dataGridView5.DataSource = bs_sorted_list;
			bs_sorted_list.ResetBindings(false);
		}

		private void bDelSelected_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dataGridView5.SelectedRows)
			{
				sorted_list.Remove(row.Cells[0].Value);
				dataGridView5.Rows.Remove(row);
				
			}
			bs_sorted_list.ResetBindings(false);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			list.Add(new Library());
			bs_list.ResetBindings(false);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			foreach (DataGridViewRow row in dataGridView6.SelectedRows)
				dataGridView6.Rows.Remove(row);
			bs_list.ResetBindings(false);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			list.Sort();
			bs_list.ResetBindings(false);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			SortedList list_clone = (SortedList)sorted_list.Clone();
			BindingSource bs_cloned_list = new BindingSource();
			bs_cloned_list.DataSource = list_clone;
			dataGridView7.DataSource = bs_cloned_list;
			bs_cloned_list.ResetBindings(false);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			List<Library> list_clone = list.Select(item => (Library)item.Clone()).ToList();
			BindingSource bs_cloned_list = new BindingSource();
			bs_cloned_list.DataSource = list_clone;
			dataGridView8.DataSource = bs_cloned_list;
			bs_cloned_list.ResetBindings(false);
		}

		private IEnumerable<Library> SelectByRating(List<Library> collection, double min, double max) 
		{
			return (IEnumerable<Library>)collection.Where(item => { return item.Rating > min && item.Rating <= max; });
		}

		private SortedList SelectByRating(SortedList collection, double min, double max)
		{
			SortedList ret_list = new SortedList();
			Library lib;
			foreach (DictionaryEntry item in collection) { 
			lib = item.Value as Library;
				if (lib != null)
					if (lib.Rating > min && lib.Rating <= max)
						ret_list.Add(item.Key,item.Value);
					}
			return ret_list;
		}


		private void bFind1_Click(object sender, EventArgs e)
		{
			BindingSource bs_col = new BindingSource();
			bs_col.DataSource = SelectByRating(sorted_list, Convert.ToDouble(numMin1.Value), Convert.ToDouble(numMax1.Value));
			dataGridView7.DataSource = bs_col;
			bs_col.ResetBindings(false);
		}

		private void bFind2_Click(object sender, EventArgs e)
		{
			BindingSource bs_col = new BindingSource();
			bs_col.DataSource = SelectByRating(list, Convert.ToDouble(numMin2.Value), Convert.ToDouble(numMax2.Value));
			dataGridView8.DataSource = bs_col;
			bs_col.ResetBindings(false);
		}
	}
}
