using System;
using Gtk;
using UI = Gtk.Builder.ObjectAttribute;

namespace ${Namespace}
{
	public partial class ${EscapedIdentifier} : Dialog
	{
		Builder builder;

		public static ${EscapedIdentifier} InitializeGui(Window parent = null)
		{
			Builder bl = new Builder ("${Namespace}.${EscapedIdentifier}.glade");
			return new ${EscapedIdentifier} (parent, bl, bl.GetObject ("dialog1").Handle);
		}

		protected ${EscapedIdentifier} (Window parent, Builder builder, IntPtr handle): base (handle)
		{
			this.builder = builder;
			this.builder.Autoconnect (this);
			if (parent != null)
				this.TransientFor = parent;

			this.Title = "${ProjectName} - ${EscapedIdentifier}";
		}
	}
}