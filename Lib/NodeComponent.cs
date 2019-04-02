using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
	public abstract class NodeComponent
	{
		public abstract List<Node> Children { get; }
		public abstract Node Parent { get; set; }
		public abstract string Id { get; }
		public abstract string Label { get; }
	}
}
