using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_7
{
    public partial class Array2DPanel : UserControl
    {
        private Form1 ParentForm;

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
        }
    }
}
