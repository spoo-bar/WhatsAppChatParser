using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WhatsAppChatParserLibrary
{
    /// <summary>
    /// A provider to parse WhatsApp chats
    /// </summary>
    public static class WhatsAppChat
    {
        /// <summary>
        /// Parses the exported WhatsApp chat and return a list of messages
        /// </summary>
        /// <param name="filePath">Path to the WhatsApp chat</param>
        /// <returns>An enumerable of messages</returns>
        public static IEnumerable<Message> Parse(string filePath)
        {
            var messages = new List<Message>();

            var chatLog = File.ReadAllLines(filePath);
            foreach(var chatLine in chatLog)
            {
                var message = Message.Parse(chatLine);
                if(message.TimeStamp == default && message.MessageBy == null)
                {
                    var lastMessage = messages.Last();
                    message.TimeStamp = lastMessage.TimeStamp;
                    message.MessageBy = lastMessage.MessageBy;
                }
                messages.Add(message);
            }

            return messages;
        }
    }
}
