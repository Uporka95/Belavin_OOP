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
using SFML.Window;
namespace Lab_math
{
	public partial class SFMLControl : UserControl
	{
		public RenderWindow renderwindow;

		public SFMLControl()
		{
			InitializeComponent();
			renderwindow = new RenderWindow(this.Handle);
		}
		protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
		{
			System.Windows.Forms.Application.DoEvents();
			renderwindow.DispatchEvents();
			renderwindow.Clear(SFML.Graphics.Color.Green);
			renderwindow.Display();
		}
		protected override void OnPaintBackground(System.Windows.Forms.PaintEventArgs pevent)
		{

		}
	}
}
