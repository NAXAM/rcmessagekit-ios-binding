// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace RCMessageKitQs.Views
{
	[Register ("ChatView")]
	partial class ChatView
	{
		[Outlet]
		UIKit.UIButton btnRCMessageSend { get; set; }

		[Outlet]
		UIKit.UITextField myTextField { get; set; }

		[Outlet]
		UIKit.UIView viewToolBar { get; set; }

		[Action ("btnAdd:")]
		partial void btnAdd (Foundation.NSObject sender);

		[Action ("btnPlay:")]
		partial void btnPlay (Foundation.NSObject sender);

		[Action ("btnSend:")]
		partial void btnSend (Foundation.NSObject sender);

		[Action ("RCMessageAttach:")]
		partial void RCMessageAttach (Foundation.NSObject sender);

		[Action ("RCMessageSend:")]
		partial void RCMessageSend (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (myTextField != null) {
				myTextField.Dispose ();
				myTextField = null;
			}

			if (viewToolBar != null) {
				viewToolBar.Dispose ();
				viewToolBar = null;
			}

			if (btnRCMessageSend != null) {
				btnRCMessageSend.Dispose ();
				btnRCMessageSend = null;
			}
		}
	}
}
