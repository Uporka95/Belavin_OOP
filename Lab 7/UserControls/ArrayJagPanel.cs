using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_7
{
    public partial class ArrayJagPanel : UserControl
    {
        private Form1 ParentForm;

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

        }

        private void bSaveIn_Click(object sender, EventArgs e)
        {

        }

        private void bLoadFrom_Click(object sender, EventArgs e)
        {
            
        }
    }
}
