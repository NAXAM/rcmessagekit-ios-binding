using System;

namespace RCMessageKit
{
    public enum MessageStatus {
        Default = 0,
        Loading = 1,
        Succeed = 2,
        Manual = 3
    }

    public enum MessageType {
        Status = 1,
        Text = 2,
        Emoji = 3,
        Picture = 4,
        Video = 5,
        Audio = 6,
        Location = 7
    }
}