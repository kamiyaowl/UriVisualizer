using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UriVisualizer;

namespace VisualizerTest {
	class Program {
		static void Main(string[] args) {
			var hoge = @"http://kamiya.hatenadiary.jp/";
			var uri = new Uri(hoge);
			UriVisualizerDebugger.TestShowVisualizer(uri);
		}
	}
}
