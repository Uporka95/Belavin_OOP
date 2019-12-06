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
	public partial class FindDiag : Form
	{
		BindingSource source = new BindingSource();
		public FindDiag()
		{
			InitializeComponent();
		}

		private void bOK_Click(object sender, EventArgs e)
		{
			
			if (rbFindByAuthor.Checked) source.DataSource = Database.FindByAuthor(mtName.Text);
			if (rbFindByTime.Checked) source.DataSource = Database.FindByDate(dtpFrom.Value, dtpTo.Value);
			dataGridView1.DataSource = source;
			source.ResetBindings(false);
		}
	}
}
