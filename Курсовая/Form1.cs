using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсовая
{
	public partial class Form1 : Form
	{
		BindingSource source;
		List<PrintEdition> list;
		
		public Form1()
		{
			InitializeComponent();
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			list = new List<PrintEdition>();
			for (int i = 0; i < 5; i++)
			{
				list.Add(new Textbook(list));
			}

			for (int i = 0; i < 5; i++)
			{
				list.Add(new Magazine(list));
			}

			for (int i = 0; i < 5; i++)
			{
				list.Add(new Fiction(list));
			}

			for (int i = 0; i < 5; i++)
			{
				list.Add(new Newspaper(list));
			}

			foreach (var item in list)
			{
				var r = item.GetType(); 
				var rd = this.GetType().BaseType;
			}
			source = new BindingSource();
			source.DataSource = list;
			
			
			dataGridView1.DataSource = source;
			
		}
	}
}
