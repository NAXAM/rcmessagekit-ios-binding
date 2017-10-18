using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using RCMessageKitQs.Models;
using UIKit;

namespace RCMessageKitQs.Sevices
{
    public class DataConversation
    {
		string[] write = {
			"What is your name?","Where are you from?","How old are you?","I am a big fan of jackie chan",
			"i love movie of stephen chow","i am not handsome but i am very tall","i play game very good","today, i feed very hot and i am tired",
			"i love naxam, naxam is a big company, this has 100000 developers"
		};

        public DBMessage NaxamAutoMessage()
        {
            Random rd = new Random();

            DBMessage message = new DBMessage
            {
                chatId = "RCMessageKit",
                objectId = "Naxam" + rd.Next(999999),
                senderId = "Naxam",
                senderName = "Naxam",
                senderInitials = "Naxam",
                senderPicture = "NaxamAvatar.png",
                recipientId = "Me",
                recipientName = "Me",
                recipientInitials = "Me",
                recipientPicture = "UserAvatar.png",
                type = "text",
                text = write[rd.Next(0, 100) % write.Length],
                status = "New",
                createdAt = DateTime.Now.Ticks,
                updatedAt = DateTime.Now.Ticks
            };

            return message;
        }

        public DBMessage UserMessage(string m_type, string m_text, string m_imagePath)
        {
            Random rd = new Random();

            DBMessage message = new DBMessage
            {
                chatId = "RCMessageKit",
                objectId = "Me" + rd.Next(999999),
                senderId = "Me",
                senderName = "Me",
                senderInitials = "Me",
                senderPicture = "UserAvatar.png",
                recipientId = "Naxam",
                recipientName = "Naxam",
                recipientInitials = "Naxam",
                recipientPicture = "NaxamAvatar.png",
                type = m_type,
                text = m_text != null ? m_text : "",
                picture = m_imagePath,
                picture_width = 320,
                picture_height = 210,
                video_path = "http://techslides.com/demos/sample-videos/small.mp4",
                video_image = UIImage.FromFile("ImageVideo.jpg"),
                video_duration = 5000,
                latitude = 21.0040095,
                longitude = 105.8476571,
                status = "New",
                createdAt = DateTime.Now.Ticks,
                updatedAt = DateTime.Now.Ticks
            };

            return message;
        }

        public DBMessage[] Start()
        {
            List<DBMessage> lst = new List<DBMessage>();

            DBMessage message = NaxamAutoMessage();

            lst.Add(message);
            return lst.ToArray();
        }

        public void SendMessage(string m_type, string m_text, string m_imagePath)
        {
            AppDelegate.dbmessages.Add(UserMessage(m_type, m_text, m_imagePath));

            AppDelegate.dbmessages.Add(NaxamAutoMessage());
        }
    }
}
