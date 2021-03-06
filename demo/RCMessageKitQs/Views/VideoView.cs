// This file has been autogenerated from a class added in the UI designer.

using System;
using AVFoundation;
using AVKit;
using Foundation;
using UIKit;

namespace RCMessageKitQs.Views
{
	public partial class VideoView : UIViewController
	{
        public string pathVideo;

		public VideoView (IntPtr handle) : base (handle)
		{
		}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var url = NSUrl.FromString(pathVideo);
            var avp = new AVPlayer(url);
            var avpvc = new AVPlayerViewController();
            avpvc.Player = avp;
            this.AddChildViewController(avpvc);
            this.View.AddSubview(avpvc.View);
            avpvc.View.Frame = this.View.Frame;
            avp.Play();
        }
	}
}
