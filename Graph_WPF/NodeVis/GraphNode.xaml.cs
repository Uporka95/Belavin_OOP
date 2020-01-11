using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Graph_WPF
{
	/// <summary>
	/// Логика взаимодействия для GraphNode.xaml
	/// </summary>
	public partial class GraphNode : UserControl
	{
		public GraphView NodeContainer;
		private bool moving = false;

		private Node source_node;
		public Node SourceNode
		{
			get { return source_node; }
			set
			{

				source_node = value;
				NodeButton.Name = source_node.Source.ToString();
				Mark.Text = source_node.Mark.ToString();
				SubscribeOnSource(value);
			}
		}

		public GraphNode()
		{
			InitializeComponent();

		}

		private void SubscribeOnSource(Node node)
		{
			node.OnSourceChanged += (source, e) => NodeButton.Name = (source as Node).Source.ToString();
			node.OnMarkChanged += (source, e) => Mark.Text = (source as Node).Mark.ToString();
			node.OnRemove += (source, e) => Dispatcher.Invoke(() => (Parent as Canvas).Children.Remove(this));
		}

		private void Button_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			moving = true;
		}

		private void Button_PreviewMouseLeftButtonUp(object sender, MouseButtonEventArgs e)
		{
			moving = false;
		}

		private void Button_PreviewMouseMove(object sender, MouseEventArgs e)
		{
			if (moving)
			{
				Canvas.SetTop(this, e.GetPosition(Parent as Canvas).Y);
				Canvas.SetLeft(this, e.GetPosition(Parent as Canvas).X);
			}
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			//if ((Parent as Canvas).F)
			//	foreach (var item in (Parent as Canvas).Children)
			//	{
			//		if(item is GraphNode gn && gn.IsFocused)

			//	}
			
		}

		private void NodeButton_Click(object sender, RoutedEventArgs e)
		{
			source_node.Mark++;
			Line line = new Line();
			//line.SetBinding(Mouse.GetPosition(Parent).X);
		}

		private void NodeButton_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
		{
			source_node.RemoveFromGraph();
		}
	}
}
