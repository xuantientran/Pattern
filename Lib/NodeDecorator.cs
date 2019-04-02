using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
	public abstract class NodeDecorator : NodeComponent
	{
		NodeComponent _node = null;

		protected NodeDecorator(NodeComponent node)
		{
			_node = node;
		}

		public override List<Node> Children => _node.Children;

		public override Node Parent
		{
			get => _node.Parent;
			set => _node.Parent = value;
		}

		public override string Id => _node.Id;
		public override string Label => _node.Label;
	}
}
