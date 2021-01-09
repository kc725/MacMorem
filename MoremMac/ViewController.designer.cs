// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace MoremMac
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField ConnectionLabel { get; set; }

		[Action ("ClickedConnect:")]
		partial void ClickedConnect (Foundation.NSObject sender);

		[Action ("ClickedDisconnect:")]
		partial void ClickedDisconnect (Foundation.NSObject sender);

		[Action ("ClickedExit:")]
		partial void ClickedExit (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (ConnectionLabel != null) {
				ConnectionLabel.Dispose ();
				ConnectionLabel = null;
			}
		}
	}
}
