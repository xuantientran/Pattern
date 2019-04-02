using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
	public class Node : NodeComponent
	{
		string _id;
		int _level;
		Cardinality _cardinality;
		string _label;
		Node _parent;
		List<Node> _children;

		public Node(string id, Node parent, string label, int level, Cardinality cardinality)
		{
			_id = id;
			_parent = parent;
			_label = label;
			_level = level;
			_cardinality = cardinality;
			_children = new List<Node>();
			if (_parent != null)
				_parent.Children.Add(this);
		}

		public override string Id => _id;

		public int Level => _level;

		public Cardinality Cardinality => _cardinality;

		public override string Label => _label;

		public override Node Parent { get => _parent; set => _parent = value; }

		public override List<Node> Children { get => _children; }

		public bool CheckCardinality()
		{
			throw new NotImplementedException();
		}
	}
}
