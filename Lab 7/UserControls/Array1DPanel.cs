using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab_7
{
    public partial class Array1DPanel : UserControl
    {
		public int[] arr;
		private Form1 ParentForm;

        public Array1DPanel(Form1 Mainform)
        {
            Visible = false;
            ParentForm = Mainform;
            Location = new Point(16, 41);
            InitializeComponent();
        }

        public void Switch()
        {
            Show();
            ParentForm.p2DArray.Hide();
            ParentForm.pJagArray.Hide();
			ParentForm.rtArrayView.Text = ArrayManager.PrintArray(arr); ;
		}

		private void bCreate_Click(object sender, EventArgs e)
		{
			MasEntryDiag diag = new MasEntryDiag();
			var result = diag.ShowDialog(ParentForm);
			if (result == DialogResult.OK)
				arr = diag.returnArr;
			if (!Null()) RefreshArr();
		}
		private void RefreshArr()
		{
			ParentForm.rtArrayView.Text = ArrayManager.PrintArray(arr);
		}

		private bool Null()
		{
			if (arr == null)
			{
				MessageBox.Show("Массив пуст!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return true;
			}
			return false;
		}

		private void bSaveIn_Click(object sender, EventArgs e)
		{
			StreamWriter writer = new StreamWriter("1DArray.txt");
			writer.Write(ParentForm.rtArrayView.Text);
			writer.Close();
		}
		private void bLoadFrom_Click(object sender, EventArgs e)
		{
			StreamReader reader = new StreamReader("1DArray.txt");
			arr = ArrayManager.ParseAs1D(reader.ReadToEnd());
			reader.Close();
			RefreshArr();
		}

		private void bClearArr_Click(object sender, EventArgs e)
		{
			arr = null;
			RefreshArr();
		}

		private void bDelMean_Click(object sender, EventArgs e)
		{
			if(Null()) return;
			ArrayManager.DeleteMean(ref arr);
			RefreshArr();
		}
	}
}
