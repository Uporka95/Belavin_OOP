using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Lab_7
{
    public partial class ArrayJagPanel : UserControl
    {
        private Form1 ParentForm;
		public int[][] arr;
        public ArrayJagPanel(Form1 Mainform)
        {
            Visible = false;
            ParentForm = Mainform;
            Location = new Point(16, 41);
            InitializeComponent();
        }

        public void Switch()
        {
            Visible = true;
            ParentForm.p1DArray.Hide();
            ParentForm.p2DArray.Hide();
        }

        private void bCreate1d_Click(object sender, EventArgs e)
        {
			Diags.DiagJag diag = new Diags.DiagJag();
			var result = diag.ShowDialog(ParentForm);
			if (result == DialogResult.OK)
				arr = diag.returnArr;
			if (!Null()) RefreshArr();
		}

        private void bSaveIn_Click(object sender, EventArgs e)
        {
			StreamWriter writer = new StreamWriter("JagArray.txt", false);
			writer.Write(ParentForm.rtArrayView.Text);
			writer.Close();
		}

        private void bLoadFrom_Click(object sender, EventArgs e)
        {
			string buf;

			StreamReader reader = new StreamReader("JagArray.txt");
			buf = reader.ReadToEnd();
			arr = ArrayManager.ParseAsJag(buf);
			reader.Close();
			RefreshArr();
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
		private void bClearArr_Click(object sender, EventArgs e)
		{
			arr = null;
			RefreshArr();
		}

		private void bDelMean_Click(object sender, EventArgs e)
		{
			EnterK diag = new EnterK();
			var result = diag.ShowDialog(ParentForm);
			if (result == DialogResult.OK)
				if (!Null()) ArrayManager.DelStrJag(ref arr, diag.K);
			RefreshArr();
		}
	}
}
