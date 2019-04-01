using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lib
{
	public class Tree
	{
		string _version;
		TreeType _type;
		int _count;
		bool _loaded = false;
		Node _root;
		string _path;
		StringBuilder _log;
		protected Dictionary<string, Node> _dsnNodes;
		TimeSpan _loadTime;

		/// <summary>
		/// On obtient la version et le type
		/// </summary>
		/// <param name="path"></param>
		public Tree(string path)
		{
			_path = path;
			_dsnNodes = new Dictionary<string, Node>();
		}

		public void Unload()
		{
			_version = string.Empty;
			_type = TreeType.Non;
			_count = 0;
			_loaded = false;
			_root = null;
			_dsnNodes.Clear();
			_loadTime = TimeSpan.Zero;
		}

		public void Load()
		{
			Stopwatch muniteur = new Stopwatch();
			muniteur.Start();
			LoadTree();
			muniteur.Stop();
			_loadTime = muniteur.Elapsed;
		}

		void LoadTree()
		{
			string exp = @"(.+)\s+\(([0-9]),([0-9]|\*)\)$";
			//On trouve toujours le parent au sommet de la pile
			Stack<Node> parentStack = new Stack<Node>();
			Node current;
			Node parent;
			//Il faut ajouter la racine artificielement
			_root = new Node("S00.G00.00", null, "Root", 0, new Cardinality(1, 1));

			_dsnNodes.Add(_root.Id, _root);

			current = _root;
			parent = _root;

			//Toutes les rubriques se trouvent dans le fichiers envoi doivent augement un niveau
			int baseLevel = 1;
			int lastLevel = 0;
			string line;
			int nline = 0;
			int level = 0;
			int min;
			int max;
			//Traitement de la S10
			//, Encoding.GetEncoding("iso-8859-1")
			using (StreamReader lecture = new StreamReader(_path))
			{
				while ((line = lecture.ReadLine()) != null)
				{
					nline++;
					//On ne traite pas les lignes vides
					if (string.IsNullOrEmpty(line))
						continue;

					string[] cv = line.Split('-');

					//On ne traite pas les lignes sans avoir le caratère '-'
					if (cv.Length == 1)
						continue;

					//On compte le nombre de tab pour calculer le niveau de la rubrique
					level = 0;
					for (int i = 0; i < cv[0].Length; i++)
					{
						if (cv[0][i] == '\t')
							level = i + 1;
						else
							break;
					}
					//Le niveau doit être absolu
					level += baseLevel;

					//On enlève tous les caratères \t pour trouver la rubrique
					string cle = cv[0].Trim();

					//On récupère le reste comme valeur
					cv[0] = "";
					string valeur = string.Join("-", cv).Substring(1).Trim();

					//la rubrique doit se trouver dans le dictionaire
					//alimanté des rubriques auparavant
					//if (dsn.NoeudBlocs.ContainsKey(cle))
					//	continue;

					int sautArriere = lastLevel - level;

					//si le niveau augmente par rapport au dernier niveau
					//Alors on met la dernier bloc dans la pile des parents
					//S10.G01.00 - Emetteur (1,1)
					//	S10.G01.01 - Contacts Emetteur(1, *)
					//sautArriere = -1
					if (sautArriere < 0)
					{
						parent = current;
						parentStack.Push(parent);
					}
					//Si le niveau déminue alors enlève autant de parents que néscessaire
					//pour trouver le bon parent.
					//			S70.G10.15 - Rémunérations (0,*)
					//	S80.G01.00 - Identification INSEE des établissements(1, *)
					//sautArriere = 2;
					else if (sautArriere > 0)
					{
						for (int i = 0; i < sautArriere; i++)
						{
							parent = parentStack.Pop();
						}
						parent = parent.Parent;
					}

					//On cherche les informations dans la ligne pour alimenter le noeu
					Match m = Regex.Match(valeur, exp);
					if (m.Success)
					{
						string label = m.Groups[1].Value;
						min = int.Parse(m.Groups[2].Value);
						if (string.Compare(m.Groups[3].Value, "*") == 0)
							max = 0;
						else
							max = int.Parse(m.Groups[3].Value);

						//on crée un noeu et spécise son parent
						current = new Node(cle, parent, label, level, new Cardinality(min, max));
						//On ajoute le noeu dans le dictionaire
						_dsnNodes.Add(cle, current);
						_count++;
						lastLevel = level;
					}
				}
			}
			if (_count > 1)
				_loaded = true;
		}

		public HashSet<string> GetPathToNode(string id)
		{
			HashSet<string> nodeList = new HashSet<string>();
			_dsnNodes.TryGetValue(id, out Node node);
			if (node == null)
				return null;

			while (node.Parent != null)
			{
				nodeList.Add(node.Id);
				node = node.Parent;
			}
			nodeList.Add(_root.Id);
			return nodeList;
		}

		/// <summary>
		/// Retourner une liste des clés de node
		/// </summary>
		/// <param name="id">La clé de node racine d'une brache</param>
		/// <returns></returns>
		public HashSet<string> GetNodeSegment(string startId, string endId = "")
		{

			HashSet<string> nodeList = new HashSet<string>();

			_dsnNodes.TryGetValue(startId, out Node current);
			if (current == null)
				current = _root;

			Stack<Node> stack = new Stack<Node>();

			stack.Push(current);
			if (string.IsNullOrEmpty(endId))
				while (stack.Count > 0)
				{
					current = stack.Pop();

					for (var i = current.Children.Count - 1; i >= 0; i--)
						stack.Push(current.Children[i]);

					nodeList.Add(current.Id);
				}
			else
				while (stack.Count > 0)
				{
					current = stack.Pop();

					for (var i = current.Children.Count - 1; i >= 0; i--)
						stack.Push(current.Children[i]);

					nodeList.Add(current.Id);
					if (string.Compare(current.Id, endId) == 0)
						break;
				}
			return nodeList;
		}

		public List<string> GetDownSiblings(string startId, string endId)
		{
			List<string> nodeList = new List<string>();
			_dsnNodes.TryGetValue(startId, out Node node);
			Node parent = node.Parent;
			int startIndex = _count;
			int endIndex = 0;
			for (var i = 0; i < parent.Children.Count; i++)
			{
				//Compare(A, B): -1
				//Compare(B, A):  1
				if (string.Compare(parent.Children[i].Id, startId) == 0)
					startIndex = i;
				if (string.Compare(parent.Children[i].Id, endId) == 0)
					endIndex = i;
			}
			if (endIndex >= startIndex)
			{
				for (var i = startIndex; i <= endIndex; i++)
					nodeList.Add(parent.Children[i].Id);
			}
			return nodeList;
		}

		public Dictionary<string, Node> DsnNodes => _dsnNodes;

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			List<Node> nodes = new List<Node>();
			Node current = _root;
			Node node = _root;

			Stack<Node> stack = new Stack<Node>();

			stack.Push(current);

			while (stack.Count > 0)
			{
				current = stack.Pop();

				for (var i = current.Children.Count - 1; i >= 0; i--)
					stack.Push(current.Children[i]);

				if (current != _root)
					sb.AppendLine((new string('\t', current.Level - 1)) + current.Id + " - " + current.Label + " (" + current.Cardinality.Min + "," + ((current.Cardinality.Max == 0) ? "*" : current.Cardinality.Max.ToString()) + ")");
			}

			return sb.ToString().Trim();
		}

		public int Count => _count;

		public Node Root => _root;

		public string Version { get => _version; }

		public bool Loaded => _loaded;

		public TreeType Type => _type;

		public TimeSpan LoadTime => _loadTime;

		public Node Find(string id)
		{
			_dsnNodes.TryGetValue(id, out Node node);
			return node;
		}

		public string GetBlockLabel(string key)
		{
			_dsnNodes.TryGetValue(key, out Node node);
			return (node == null) ? "" : node.Label;
		}

		public void AppendLog(string msg) => _log.Append(msg);

		public string Log => _log.ToString();
	}
}
