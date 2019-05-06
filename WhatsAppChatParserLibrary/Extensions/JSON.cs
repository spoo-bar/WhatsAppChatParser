using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace WhatsAppChatParser
{
    /// <summary>
    /// Extension method to get JSON string representation of messages
    /// </summary>
    public static class JSONExtensions
    {
        /// <summary>
        /// Serializes the specified object to a JSON string
        /// </summary>
        /// <param name="messages">Messages to serialize</param>
        /// <returns>A JSON string representation of the object.</returns>
        public static string ToJSON(this IEnumerable<Message> messages)
        {
            var jsonString = JsonConvert.SerializeObject(messages);
            return jsonString;
        }

        /// <summary>
        /// Serializes the specified object to a JSON string using formatting.
        /// </summary>
        /// <param name="messages">Messages to serialize</param>
        /// <param name="formatting">Indicates how the output should be formatted.</param>
        /// <returns>A JSON string representation of the object.</returns>
        public static string ToJSON(this IEnumerable<Message> messages, Formatting formatting)
        {
            var jsonString = JsonConvert.SerializeObject(messages, formatting);
            return jsonString;
        }

        /// <summary>
        /// Serializes the specified object to a JSON string using a collection of Newtonsoft.Json.JsonConverter.
        /// </summary>
        /// <param name="messages">Messages to serialize</param>
        /// <param name="converters">A collection of converters used while serializing.</param>
        /// <returns>A JSON string representation of the object.</returns>
        public static string ToJSON(this IEnumerable<Message> messages, params JsonConverter[] converters)
        {
            var jsonString = JsonConvert.SerializeObject(messages, converters);
            return jsonString;
        }

        /// <summary>
        /// Serializes the specified object to a JSON string using formatting and a collection of Newtonsoft.Json.JsonConverter.
        /// </summary>
        /// <param name="messages">Messages to serialize</param>
        /// <param name="formatting">Indicates how the output should be formatted.</param>
        /// <param name="converters">A collection of converters used while serializing.</param>
        /// <returns>A JSON string representation of the object.</returns>
        public static string ToJSON(this IEnumerable<Message> messages, Formatting formatting, params JsonConverter[] converters)
        {
            var jsonString = JsonConvert.SerializeObject(messages, formatting, converters);
            return jsonString;
        }

        /// <summary>
        /// Serializes the specified object to a JSON string using Newtonsoft.Json.JsonSerializerSettings.
        /// </summary>
        /// <param name="messages">Messages to serialize</param>
        /// <param name="jsonSerializerSettings">The Newtonsoft.Json.JsonSerializerSettings used to serialize the object. If this is null, default serialization settings will be used.</param>
        /// <returns>A JSON string representation of the object.</returns>
        public static string ToJSON(this IEnumerable<Message> messages, JsonSerializerSettings jsonSerializerSettings)
        {
            var jsonString = JsonConvert.SerializeObject(messages, jsonSerializerSettings);
            return jsonString;
        }

        /// <summary>
        /// Serializes the specified object to a JSON string using a type, formatting and Newtonsoft.Json.JsonSerializerSettings.
        /// </summary>
        /// <param name="messages">Messages to serialize</param>
        /// <param name="type">The type of the value being serialized. This parameter is used when Newtonsoft.Json.JsonSerializer.TypeNameHandling is Newtonsoft.Json.TypeNameHandling.Auto to write out the type name if the type of the value does not match. Specifying the type is optional.</param>
        /// <param name="jsonSerializerSettings">The Newtonsoft.Json.JsonSerializerSettings used to serialize the object. If this is null, default serialization settings will be used.</param>
        /// <returns>A JSON string representation of the object.</returns>
        public static string ToJSON(this IEnumerable<Message> messages, Type type, JsonSerializerSettings jsonSerializerSettings)
        {
            var jsonString = JsonConvert.SerializeObject(messages, type, jsonSerializerSettings);
            return jsonString;
        }

        /// <summary>
        /// Serializes the specified object to a JSON string using formatting and Newtonsoft.Json.JsonSerializerSettings.
        /// </summary>
        /// <param name="messages">Messages to serialize</param>
        /// <param name="formatting">Indicates how the output should be formatted.</param>
        /// <param name="jsonSerializerSettings">The Newtonsoft.Json.JsonSerializerSettings used to serialize the object. If this is null, default serialization settings will be used.</param>
        /// <returns>A JSON string representation of the object.</returns>
        public static string ToJSON(this IEnumerable<Message> messages, Formatting formatting, JsonSerializerSettings jsonSerializerSettings)
        {
            var jsonString = JsonConvert.SerializeObject(messages, formatting, jsonSerializerSettings);
            return jsonString;
        }

        /// <summary>
        /// Serializes the specified object to a JSON string using a type, formatting and Newtonsoft.Json.JsonSerializerSettings.
        /// </summary>
        /// <param name="messages">Messages to serialize</param>
        /// <param name="type">The type of the value being serialized. This parameter is used when Newtonsoft.Json.JsonSerializer.TypeNameHandling is Newtonsoft.Json.TypeNameHandling.Auto to write out the type name if the type of the value does not match. Specifying the type is optional.</param>
        /// <param name="formatting">Indicates how the output should be formatted.</param>
        /// <param name="jsonSerializerSettings">The Newtonsoft.Json.JsonSerializerSettings used to serialize the object. If this is null, default serialization settings will be used.</param>
        /// <returns>A JSON string representation of the object.</returns>
        public static string ToJSON(this IEnumerable<Message> messages, Type type, Formatting formatting, JsonSerializerSettings jsonSerializerSettings)
        {
            var jsonString = JsonConvert.SerializeObject(messages, type, formatting, jsonSerializerSettings);
            return jsonString;
        }
    }
}
