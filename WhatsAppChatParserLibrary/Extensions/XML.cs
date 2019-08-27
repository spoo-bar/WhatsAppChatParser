using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace WhatsAppChatParser
{
    /// <summary>
    /// Extension method to get XML string representation of messages
    /// </summary>
    public static class XMLExtensions
    {
        private const string XMLRootElement = "Messages";

        /// <summary>
        /// Serializes the specified object to a XML string
        /// </summary>
        /// <param name="messages">Messages to serialize</param>
        /// <returns>A XML string representation of the object.</returns>
        public static string ToXML(this IEnumerable<Message> messages)
        {
            using(var stringWriter = new StringWriter(new StringBuilder()))
            {
                var serializer = new XmlSerializer(typeof(List<Message>), new XmlRootAttribute(XMLRootElement));
                serializer.Serialize(stringWriter, messages.ToList());
                return stringWriter.ToString();
            }
        }
    }
}
