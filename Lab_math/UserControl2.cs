using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SFML.Graphics;
namespace Lab_math
{
	public partial class UserControl2 : UserControl
	{
		public RenderWindow renderwindow;
		public UserControl2()
		{
			InitializeComponent(); 
			renderwindow = new RenderWindow(this.Handle);
		}
	}
}
