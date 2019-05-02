using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace WhatsAppChatParserLibrary
{
    public static class WhatsAppChat
    {
        public static async Task<IEnumerable<Message>> ParseAsync(string filePath)
        {
            var messages = new List<Message>();

            var chatLog = await File.ReadAllLinesAsync(filePath);
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
