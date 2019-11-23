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
	public partial class Form1 : Form
	{
        public Array1DPanel p1DArray;
        public Array2DPanel p2DArray;
        public ArrayJagPanel pJagArray;

        public Form1()
		{
        InitializeComponent();
        p1DArray = new Array1DPanel(this);
        p2DArray = new Array2DPanel(this);
        pJagArray = new ArrayJagPanel(this);
        this.Controls.Add(this.p1DArray);
        this.Controls.Add(this.p2DArray);
        this.Controls.Add(this.pJagArray);


        }

		private void button1_Click(object sender, EventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void bCreate1d_Click(object sender, EventArgs e)
		{

		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
            switch(comboBox1.SelectedIndex)
            {
                case 0:
                    p1DArray.Switch();
                    break;
                case 1:
                    p2DArray.Switch();
                    break;
                case 2:
                    pJagArray.Switch();
                    break;
            }
			
		}
	}
}
