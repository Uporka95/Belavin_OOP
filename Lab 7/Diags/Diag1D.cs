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
    public partial class MasEntryDiag : Form
    {
		StringBuilder mask = new StringBuilder("0");

		public int[] returnArr;
		public MasEntryDiag()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

		private void button1_Click(object sender, EventArgs e)
		{
			returnArr = ArrayManager.Create1DArr();
			DialogResult = DialogResult.OK;
			this.Close();
		}

		private void bStrEnter_Click(object sender, EventArgs e)
		{
			string[] arr = mtStrEntry.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			returnArr = new int[arr.Length];
			for (int i = 0; i < arr.Length; i++)
			{
				returnArr[i] = Convert.ToInt32(arr[i]);
			}
			if (returnArr.Length == 0) returnArr = null;
			DialogResult = DialogResult.OK;
			this.Close();
		}

		private void mtStrEntry_TextChanged(object sender, EventArgs e)
		{
			if (mtStrEntry.MaskCompleted)
			{
				mask.Append(" 0");
				mtStrEntry.Mask = mask.ToString();
			}
		}

		private void MasEntryDiag_Load(object sender, EventArgs e)
		{
			mtStrEntry.Mask = mask.ToString();
		}

		private void mtStrEntry_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.KeyCode == Keys.Enter) bStrEnter_Click(sender, e);
		}

		private void MasEntryDiag_Shown(object sender, EventArgs e)
		{
			mtStrEntry.Focus();
		}
	}
}
