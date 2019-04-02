using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
	public class Utility
	{
		static Dictionary<string, TreeType> _treeTypes = new Dictionary<string, TreeType>
		{
			{"S10.G01.00.011", TreeType.Dadsu},
			{"S10.G00.00.006", TreeType.Dsn},
		};
		static string GetThisFilePath([CallerFilePath]string path = null) => path;
		static string GetSolutionDirectory() => Path.GetDirectoryName(Path.GetDirectoryName(GetThisFilePath()));

		public static string GetDataDirectory() => Path.Combine(GetSolutionDirectory(), "Data");

		public static TreeType GetTreeType(string key)
		{
			if (_treeTypes.ContainsKey(key))
				return _treeTypes[key];
			return TreeType.Non;
		}

		public static Tuple<string, TreeType> FindVersion(string path)
		{
			if (!File.Exists(path))
				throw new FileNotFoundException(path + " does not exist");
			TreeType treeType;
			string[] kv;
			string ligne;
			string rubrique;
			string valeur;
			int nligne = 0;
			using (StreamReader reader = new StreamReader(path, Encoding.GetEncoding("iso-8859-1")))
			{
				while ((ligne = reader.ReadLine()) != null)
				{
					nligne++;
					kv = ligne.Split(',');

					if (kv.Length != 2)
						continue;

					if ((kv[0].Length == 0) || (kv[1].Length == 0) || (nligne >= 50))
						break;

					kv[0] = kv[0].Trim();
					kv[1] = kv[1].Trim();
					kv[1] = kv[1].Substring(1, kv[1].Length - 2);
					rubrique = kv[0];
					valeur = kv[1];

					treeType = GetTreeType(rubrique);
					if (treeType != TreeType.Non)
						return Tuple.Create(valeur, treeType);

				}
			}
			return null;
		}

	}
}