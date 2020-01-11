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
	/// Логика взаимодействия для GraphView.xaml
	/// </summary>
	public partial class GraphView : UserControl
	{
		public Graph graph = new Graph();
		public GraphView()
		{
			InitializeComponent();
		}

		private void graphCanvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			GraphNode new_node = new GraphNode();
			Canvas.SetLeft(new_node, e.GetPosition(graphCanvas).X);
			Canvas.SetTop(new_node, e.GetPosition(graphCanvas).Y);
			graphCanvas.Children.Add(new_node);
			new_node.NodeContainer = this;
			Node node = new Node("A");
			new_node.SourceNode = node;

			graph.AddNode(node);
		}
	}
}
