using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace ITI.DSNTree.Tests
{
	[TestFixture]
	public class Test
	{
		static string GetThisFilePath([CallerFilePath]string path = null) => path;
		static string GetSolutionDirectory() => Path.GetDirectoryName(Path.GetDirectoryName(GetThisFilePath()));
		static string GetDataDirectory() => Path.Combine(GetSolutionDirectory(), "Data");

		[Test]
		public void T00_loading_simple_test_data()
		{
		}

		static void CheckFileEquals(string path1, string path2)
		{
			File.ReadAllText(path1).Should().Be(File.ReadAllText(path2));
		}
	}
}
