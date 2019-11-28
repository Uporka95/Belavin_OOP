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
	public partial class Diag2D : Form
	{
		public Random rnd = new Random();
		public int[,] returnArr;
		private int cur_str = 0;
        public Diag2D()
        {
            InitializeComponent();
		}

		private void numStr_ValueChanged(object sender, EventArgs e)
		{

		}

		private void bBeginEntry_Click(object sender, EventArgs e)
		{
			pSizeEntry.Enabled = false;
			pArrayEntry.Enabled = true;
			returnArr = new int[Convert.ToInt32(numCol.Value), Convert.ToInt32(numStr.Value)];

			StringBuilder mask = new StringBuilder("0");

			for (int i = 1; i < Convert.ToInt32(numCol.Value); i++)
			{
				mask.Append(" 0");
			}

			lStrNum.Text = String.Format($"Строка {cur_str}");
			mtStringEntry.Mask = mask.ToString();
			mtStringEntry.Focus();
			pSizeEntry.Enabled = false;
			pArrayEntry.Enabled = true;

		}

		private void bStrEnter_Click(object sender, EventArgs e)
		{
			if (mtStringEntry.MaskCompleted)
			{

				string[] arr = mtStringEntry.Text.Split(' ');

				if (cur_str + 1 > Convert.ToInt32(numStr.Value))
				{
					DialogResult = DialogResult.OK;
					this.Close();
					return;
				}

				for (int i = 0; i < arr.Length; i++)
				{
					returnArr[cur_str, i] = Convert.ToInt32(arr[i]);
				}
				
				
				cur_str++;
				mtStringEntry.Clear();
				mtStringEntry.Focus();
				lStrNum.Text = String.Format($"Строка {cur_str}");
			}
			else
			{
				MessageBox.Show("Форма не заполнена!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				mtStringEntry.Focus();
			}
		}

		private void mtStringEntry_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) bStrEnter_Click(sender, e);
		}

		private void bRandom_Click(object sender, EventArgs e)
		{
			returnArr = ArrayManager.Create2DArr(Convert.ToInt32(numCol.Value), Convert.ToInt32(numStr.Value));
			DialogResult = DialogResult.OK;
			this.Close();
		}

		private void pArrayEntry_Paint(object sender, PaintEventArgs e)
		{

		}
	}
}
