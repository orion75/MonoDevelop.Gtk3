using System;
using Gtk;

namespace ${Namespace}
{
	public partial class ${EscapedIdentifier} : Gtk.Window
	{
		Builder builder;

		public static ${EscapedIdentifier} InitializeGui()
		{
			Builder bl = new Builder (null, "${Namespace}.${EscapedIdentifier}.glade", null);
			return new ${EscapedIdentifier} (bl, bl.GetObject ("window1").Handle);
		}

		protected ${EscapedIdentifier} (Builder builder, IntPtr handle): base (handle)
		{
			this.builder = builder;
			this.builder.Autoconnect (this);
			this.Resize (600, 400);

		}
	}
}