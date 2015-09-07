using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute; 

namespace ${Namespace}
{
	public partial class MainWindow: Gtk.Window
	{
		Builder builder;
		//[UI] Gtk.Button button1;
		//[UI] Gtk.Label label1;

		public static MainWindow Create()
		{
			Builder builder = new Builder (null, "${Namespace}.interfaces.MainWindow.glade", null);
			return new MainWindow (builder, builder.GetObject ("window1").Handle);
		}

		protected MainWindow (Builder builder, IntPtr handle): base (handle)
		{
			this.builder = builder;
			builder.Autoconnect (this);
			DeleteEvent += OnDeleteEvent;
			button1.Clicked += onButtonClick;
		}

		protected void OnDeleteEvent (object sender, DeleteEventArgs a)
		{
			Application.Quit ();
			a.RetVal = true;
		}
	}
}