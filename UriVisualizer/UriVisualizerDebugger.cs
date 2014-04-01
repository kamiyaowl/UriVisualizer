using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.DebuggerVisualizers;

[assembly:System.Diagnostics.DebuggerVisualizer(
	typeof(UriVisualizer.UriVisualizerDebugger),
	typeof(VisualizerObjectSource),
	Target = typeof(System.Uri),
	Description = "Uri Open")]

namespace UriVisualizer
{
    public class UriVisualizerDebugger : DialogDebuggerVisualizer
    {
		protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider) {
			System.Diagnostics.Process.Start(objectProvider.GetObject().ToString());
		}

		public static void TestShowVisualizer(object objectToVisualize) {
			var vHost = new VisualizerDevelopmentHost(objectToVisualize, typeof(UriVisualizerDebugger));
			vHost.ShowVisualizer();
		}
	}
}
