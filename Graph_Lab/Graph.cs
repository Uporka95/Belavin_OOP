//using System;
//using System.Collections.Generic;
//using System.Collections;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Graph_Lab
//{

//	interface Node : IComparable
//	{
//		public object Content { get; set; }

//		public Node(object cont)
//		{
//			Content = cont;
//		}

//		public int Mark { get; set; }
//		public bool Fixed { get; set; }

//		public override bool Equals(object obj)
//		{
//			return (obj as Node).Content == Content;
//		}

		
//	}

//	class Edge : IComparable
//	{
//		public Node Begin { get; set; }
//		public Node End { get; set; }

//		public int Weight { get; set; }
//		public Edge(Node begin, Node end, int weight = 1)
//		{
//			Begin = begin;
//			End = end;
//			Weight = weight;
//		}

//		public override bool Equals(object obj)
//		{
//			Edge edge = obj as Edge;
//			return edge.Begin == Begin && edge.End == End;
//		}

//		public int CompareTo(object obj)
//		{
//			return Weight.CompareTo((obj as Edge).Weight);
//		}
//	}

//	class Graph
//	{
//		Dictionary<Node, List<Edge>> _graph = new Dictionary<Node, List<Edge>>();

//		public bool AddNode(object node_name)
//		{
//			Node new_node = new Node(node_name);
//			if (NodeExists(node_name)) return false;

//			_graph.Add(new_node, null);
//			return true;
//		}

//		public bool AddEdge(object begin, object end, int weight = 1)
//		{
//			Edge new_edge = new Edge(begin, end, weight);

//			if (EdgeExists(begin, end)) return false;

//			GetNodesEdges(begin).Add(new_edge);
//			return true;

//		}

//		public bool GetMinPath(object from, object to, out Stack<object> path)
//		{
//			if (!NodeExists(from) || !NodeExists(to)) {  path = null; return false; }
//			RefreshNodesMarks();
//			Node start = GetNode(from);
//			Node dest = GetNode(from);

//			while (!dest.Fixed) 
//			{
				
//			}
			
//		}

//		public void Relax(Node node)
//		{
//			foreach (Edge edge in _graph[node])
//			{
//				GetNode(edge.End).Mark = edge.Weight + node.Mark;
//			}

//		}

//		public object GetNearestNode(object from_node)
//		{
//			return GetNearestNode()
//		}

//		public Node GetNearestNode(Node from)
//		{
//			return _graph[_graph[from].Min()];
//		}
		
//		bool NodeExists(object name)
//		{
//			if (_graph.ContainsKey(new Node(name))) return true;
//			return false;
//		}

//		public bool EdgeExists(object begin, object end)
//		{
//			if (!NodeExists(begin) || !NodeExists(end)) return false;
//			if (!_graph[b.Contains(new Edge(begin, end))) return false;
//			return true;
//		}


//		Node GetNode(object name)
//		{
//			return _graph.FirstOrDefault(x => x.Key.Name == name).Key;
//		}

//		void RefreshNodesMarks()
//		{
//			foreach (Node node in _graph.Keys)
//			{
//				node.Fixed = false;
//				node.Mark = int.MaxValue;
//			}
//		}
//}
//}
