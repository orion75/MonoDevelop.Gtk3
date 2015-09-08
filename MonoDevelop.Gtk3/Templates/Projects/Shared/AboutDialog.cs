using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace ${Namespace}
{
	public class AboutDialog: Gtk.AboutDialog
	{

		Builder builder;

		public static AboutDialog InitializeGui(Window parent = null)
		{
			Builder bl = new Builder ("${Namespace}.Dialogs.AboutDialog.glade");
			return new AboutDialog (parent, bl, bl.GetObject ("aboutdialog1").Handle);
		}

		protected AboutDialog (Window parent, Builder builder, IntPtr handle): base (handle)
		{
			this.builder = builder;
			this.builder.Autoconnect (this);
			if (parent != null)
				this.TransientFor = parent;

			ProgramName = "ProgramName";
			Version = "1.0.0.0";
			Copyright = "(c) Copyright Copyright Copyright";
			Comments = "Comments Comments Comments Comments Comments Comments Comments Comments";
			Website = "http://www.zetcode.com";
		}
	}
}

