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
        public Diag2D()
        {
            InitializeComponent();
            flowLayoutPanel1.Controls.Add(new MaskedTextBox());
        }
    }
}
