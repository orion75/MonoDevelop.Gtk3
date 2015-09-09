
using System;
using Gtk;

namespace ${Namespace}
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = MainWindow.InitializeGui();
			win.Show ();
			Application.Run ();
		}
	}
}