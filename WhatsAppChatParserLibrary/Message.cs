using System;

namespace WhatsAppChatParserLibrary
{
    public class Message
    {
        public DateTime TimeStamp { get; set; }

        public string MessageBy { get; set; }

        public string Text { get; set; }

        internal static Message Parse(string chatLine)
        {
            var message = new Message();
            if(chatLine.Split('-').Length >= 2)
            {
                var dateTimeString = chatLine.Split('-')[0].Trim();
                var chatString = chatLine.Replace(chatLine.Split('-')[0], string.Empty).Trim('-').Trim();

                message.TimeStamp = GetMessageTimeStamp(dateTimeString);
                message.MessageBy = GetMessageBy(chatString);
                message.Text = GetMessageText(chatString, message.MessageBy);
            }
            message.Text = chatLine;
            return message;
        }

        private static string GetMessageText(string chatString, string messageBy)
        {
            string messageText = null;

            if(!string.IsNullOrEmpty(chatString))
            {
                if (string.IsNullOrEmpty(messageBy))
                    messageText = chatString;
                else
                    messageText = chatString.Replace(messageBy, string.Empty).Trim(':').Trim();
            }

            return messageText;
        }

        private static string GetMessageBy(string chatString)
        {
            string messageBy = null;

            if(!string.IsNullOrEmpty(chatString) && chatString.Split(':').Length >= 2)
            {
                messageBy = chatString.Split(':')[0].Trim();
            }

            return messageBy;
        }

        private static DateTime GetMessageTimeStamp(string dateTimeString)
        {
            var timeStamp = default(DateTime);

            if(!string.IsNullOrEmpty(dateTimeString))
            {
                timeStamp = DateTime.Parse(dateTimeString);
            }

            return timeStamp;
        }
    }
}
