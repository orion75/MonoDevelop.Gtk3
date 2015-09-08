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
			/*
			ProgramName = "ProgramName";
			Version = "1.0.0.0";
			Copyright = "Copyright © 2015";
			Comments = "Este es el comentaria para del programa";
			Website = "https://github.com/orion75/MonoDevelop.Gtk3";
			WebsiteLabel = "Visitar la Página de MonoDevelop.Gtk3 addin";
			Authors = new string[] { "Harold alfonso Reina Herrera" };
			*/
		}
	}
}

