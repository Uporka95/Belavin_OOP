using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_WPF
{

	public class Node
	{

		private int mark;
		private bool entered;
		private object source;

		public Graph Container { get; set; }
		public event EventHandler OnRemove;
		public event EventHandler OnEntered;
		public event EventHandler OnMarkChanged;
		public event EventHandler OnSourceChanged;
		public object Source
		{
			get => source;
			set
			{
				source = value;
				if (OnSourceChanged != null) OnSourceChanged(this, new EventArgs());
			}
		}



		public Node(object source)
		{
			Source = source;
			Mark = int.MaxValue;
		}

		public void RemoveFromGraph()
		{
			Container.RemoveNode(this);
			OnRemove(this, new EventArgs());
		}

		public int Mark
		{
			get => mark;
			set
			{
				mark = value;
				if(OnMarkChanged != null) OnMarkChanged(this, new EventArgs());
			}
		}
		public bool Entered
		{
			get => entered;
			set
			{
				entered = value;
				OnEntered(this, new EventArgs());
			}
		}

		public override bool Equals(object obj)
		{
			return (obj as Node).Source == Source;
		}


	}


	public class Edge : IComparable
	{
		private object begin;
		private object end;
		private int weight;

		public event EventHandler OnRemove;
		public event EventHandler OnWeightChanged;

		public object Begin { get; set; }
		public object End { get; set; }

		public int Weight { get => weight; set { weight = value; OnWeightChanged(this, new EventArgs()); } }
		public Edge(object begin, object end, int weight = 1)
		{
			Begin = begin;
			End = end;
			Weight = weight;
		}

		public override bool Equals(object obj)
		{
			Edge edge = obj as Edge;
			return edge.Begin == Begin && edge.End == End;
		}

		public int CompareTo(object obj)
		{
			return Weight.CompareTo((obj as Edge).Weight);
		}

		~Edge()
		{
			
		}
	}

	public class Graph
	{
		Dictionary<Node, List<Edge>> _graph = new Dictionary<Node, List<Edge>>();

		public bool AddNode(object node_name)
		{
			Node new_node = new Node(node_name);
			if (NodeExists(node_name)) return false;

			_graph.Add(new_node, null);
			return true;
		}

		public bool AddNode(Node node)
		{
			if (NodeExists(node)) return false;

			_graph.Add(node, null);
			node.Container = this;
			return true;
		}

		internal void RemoveNode(Node node)
		{
			_graph.Remove(node);
			
		}

		bool NodeExists(object name)
		{
			if (_graph.ContainsKey(new Node(name))) return true;
			return false;
		}

		bool NodeExists(Node node)
		{
			if (_graph.ContainsKey(node)) return true;
			return false;
		}
		//public bool AddEdge(object begin, object end, int weight = 1)
		//{
		//	Edge new_edge = new Edge(begin, end, weight);

		//	if (EdgeExists(begin, end)) return false;

		//	//GetNodesEdges(begin).Add(new_edge);
		//	return true;

	}

	//public bool GetMinPath(object from, object to, out Stack<object> path)
	//{
	//	if (!NodeExists(from) || !NodeExists(to)) {  path = null; return false; }
	//	RefreshNodesMarks();
	//	Node start = GetNode(from);
	//	Node dest = GetNode(from);

	//	while (!dest.Fixed) 
	//	{

	//	}

	//}

	//public void Relax(Node node)
	//{
	//	foreach (Edge edge in _graph[node])
	//	{
	//		GetNode(edge.End).Mark = edge.Weight + node.Mark;
	//	}

	//}

	//public object GetNearestNode(object from_node)
	//{
	//	return GetNearestNode()
	//}

	//public Node GetNearestNode(Node from)
	//{
	//	return _graph[_graph[from].Min()];
	//}

	

	//public bool EdgeExists(object begin, object end)
	//{
	//	if (!NodeExists(begin) || !NodeExists(end)) return false;
	//	if (!_graph[b.Contains(new Edge(begin, end))) return false;
	//	return true;
	//}


	//Node GetNode(object name)
	//{
	//	return _graph.FirstOrDefault(x => x.Key.Name == name).Key;
	//}

	//void RefreshNodesMarks()
	//{
	//	foreach (Node node in _graph.Keys)
	//	{
	//		node.Fixed = false;
	//		node.Mark = int.MaxValue;
	//	}
	//}
}

