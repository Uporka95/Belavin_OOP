using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_7
{
	public partial class EnterK : Form
	{
		public int K;
		public EnterK()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			K = Convert.ToInt32(numericUpDown1.Value);
			DialogResult = DialogResult.OK;
			this.Close();
		}
	}
}
