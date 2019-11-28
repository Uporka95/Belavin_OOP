using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_7.Diags
{
	
	public partial class DiagJag : Form
    {
		StringBuilder mask = new StringBuilder("0");
		public Random rnd = new Random();
		public int[][] returnArr;
		private int cur_str = 0;

		public DiagJag()
        {
            InitializeComponent();
        }

		private void bBeginEntry_Click(object sender, EventArgs e)
		{
			pSizeEntry.Enabled = false;
			pArrayEntry.Enabled = true;
			returnArr = new int[Convert.ToInt32(numStr.Value)][];

			lStrNum.Text = String.Format($"Строка {cur_str}");
			mtStringEntry.Mask = mask.ToString();
			mtStringEntry.Focus();
			pSizeEntry.Enabled = false;
			pArrayEntry.Enabled = true;
		}

		private void bStrEnter_Click(object sender, EventArgs e)
		{
			string[] arr = mtStringEntry.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

			if (arr.Length != 0)
			{
				if (cur_str + 1 > Convert.ToInt32(numStr.Value))
				{
					DialogResult = DialogResult.OK;
					this.Close();
					return;
				}

				returnArr[cur_str] = new int[arr.Length];
				for (int i = 0; i < arr.Length; i++)
				{
					returnArr[cur_str][i] = Convert.ToInt32(arr[i]);
				}


				cur_str++;
				mtStringEntry.Clear();
				mtStringEntry.Focus();
				lStrNum.Text = String.Format($"Строка {cur_str}");
			}
			else
			{
				MessageBox.Show("Строка пуста!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				mtStringEntry.Focus();
			}
		}


		private void mtStringEntry_TextChanged(object sender, EventArgs e)
		{
			if (mtStringEntry.MaskCompleted)
			{
				mask.Append(" 0");
				mtStringEntry.Mask = mask.ToString();
			}
		}

		private void bRandom_Click(object sender, EventArgs e)
		{
			returnArr = ArrayManager.CreateJagArr(Convert.ToInt32(numStr.Value));
			DialogResult = DialogResult.OK;
			this.Close();
			return;
		}
		private void mtStringEntry_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) bStrEnter_Click(sender, e);
		}
	}
}
