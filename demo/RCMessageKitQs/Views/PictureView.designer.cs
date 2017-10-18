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
	[Register ("PictureView")]
	partial class PictureView
	{
		[Outlet]
		UIKit.UIImageView myImageView { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (myImageView != null) {
				myImageView.Dispose ();
				myImageView = null;
			}
		}
	}
}
