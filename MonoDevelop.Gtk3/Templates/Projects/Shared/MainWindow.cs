using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute; 

namespace ${Namespace}
{
	public partial class MainWindow: Gtk.Window
	{
		Builder builder;

		[UI] Gtk.MenuBar menubar1;
		//[UI] Gtk.ImageMenuItem about_menu_item;

		//[UI] Gtk.Button button1;
		//[UI] Gtk.Label label1;

		public static MainWindow InitializeGui()
		{
			Builder bl = new Builder (null, "${Namespace}.MainWindow.glade", null);
			return new MainWindow (bl, bl.GetObject ("window1").Handle);
		}

		protected MainWindow (Builder builder, IntPtr handle): base (handle)
		{
			this.builder = builder;
			this.builder.Autoconnect (this);
			this.Resize (600, 400);

		}

		protected void OnAboutMenuItemActivate (object sender, EventArgs a) {
			var about = GtkBorrar.AboutDialog.InitializeGui (this);
			about.Run ();
			about.Destroy ();
		}

		protected void OnDeleteEvent (object sender, DeleteEventArgs a)
		{
			Application.Quit ();
			a.RetVal = true;
		}
	}
}