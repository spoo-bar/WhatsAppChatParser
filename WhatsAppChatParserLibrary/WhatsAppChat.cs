using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WhatsAppChatParserLibrary
{
    /// <summary>
    /// 
    /// </summary>
    public static class WhatsAppChat
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
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
