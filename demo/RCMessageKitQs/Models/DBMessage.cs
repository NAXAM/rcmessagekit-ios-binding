using System;
using UIKit;

namespace RCMessageKitQs.Models
{
    public class DBMessage
    {
        public string objectId { get; set; }

        public string chatId { get; set; }
        public string members { get; set; }

        public string senderId { get; set; }
        public string senderName { get; set; }
        public string senderInitials { get; set; }
        public string senderPicture { get; set; }

        public string recipientId { get; set; }
        public string recipientName { get; set; }
        public string recipientInitials { get; set; }
        public string recipientPicture { get; set; }

        public string type { get; set; }
        public string text { get; set; }

        public string picture { get; set; }
        public int picture_width { get; set; }
        public int picture_height { get; set; }
        public string picture_md5 { get; set; }

        public string video_path { get; set; }
        public UIImage video_image { get; set; }
        public int video_duration { get; set; }

        public double latitude { get; set; }
        public double longitude { get; set; }

        public string status { get; set; }

        public long createdAt { get; set; }
        public long updatedAt { get; set; }
    }
}
