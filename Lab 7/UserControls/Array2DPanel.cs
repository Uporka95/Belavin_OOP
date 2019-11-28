using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Lab_7
{
    public partial class Array2DPanel : UserControl
    {
        private Form1 ParentForm;
		public int[,] arr;
        public Array2DPanel(Form1 Mainform)
        {
            Visible = false;
            ParentForm = Mainform;
            Location = new Point(16, 41);
            InitializeComponent();
        }

        public void Switch()
        {
            Show();
            ParentForm.p1DArray.Hide();
            ParentForm.pJagArray.Hide();
			ParentForm.rtArrayView.Text = ArrayManager.PrintArray(arr); ;
        }

		private void bCreate1d_Click(object sender, EventArgs e)
		{
			Diag2D diag = new Diag2D();
			var result = diag.ShowDialog(ParentForm);
			if (result == DialogResult.OK)
				arr = diag.returnArr;
			if (!Null()) RefreshArr();
		}
		
		private void RefreshArr()
		{
			ParentForm.rtArrayView.Text = ArrayManager.PrintArray(arr);
		}

		private void bDelMean_Click(object sender, EventArgs e)
		{
			if (Null()) return;
			ArrayManager.AddCol2D(ref arr);
			if (!Null()) RefreshArr();
		}

		private bool Null()
		{
			if(arr == null)
			{
				MessageBox.Show("Массив пуст!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return true;
			}
			return false;
		}

		private void bClear_Click(object sender, EventArgs e)
		{
			arr = null;
			RefreshArr();
		}

		private void bSaveIn_Click(object sender, EventArgs e)
		{
			
			StreamWriter writer = new StreamWriter("2DArray.txt", false);
			writer.Write(ParentForm.rtArrayView.Text);
			writer.Close();
		}

		private void bLoadFrom_Click(object sender, EventArgs e)
		{
			string buf;
			
			StreamReader reader = new StreamReader("2DArray.txt");
			buf = reader.ReadToEnd();
			arr = ArrayManager.ParseAs2D(buf);
			reader.Close();
			RefreshArr();
		}
	}
}
