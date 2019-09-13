# WhatsAppChatParser

A C# parser for exported WhatsApp chat histories

[![Nuget Version](https://img.shields.io/nuget/v/WhatsAppChatParser.svg?style=for-the-badge)](https://www.nuget.org/packages/WhatsAppChatParser/)  [![Nuget](https://img.shields.io/nuget/dt/WhatsAppChatParser.svg?color=9cf&style=for-the-badge)](https://www.nuget.org/packages/WhatsAppChatParser/)

![GitHub last commit](https://img.shields.io/github/last-commit/spoon611/WhatsAppChatParser.svg?color=red&style=for-the-badge) ![GitHub Release Date](https://img.shields.io/github/release-date/spoon611/WhatsAppChatParser.svg?style=for-the-badge)  ![GitHub](https://img.shields.io/github/license/spoon611/WhatsAppChatParser.svg?style=for-the-badge)

## Usage

### Parsing

```
using WhatsAppChatParser;

static void Main(string[] args)
{

    private readonly string filePath = @"C:\..\..WhatsApp Chat with John Doe.txt";

    // Read from file path
    IEnumerable<Message> chats = WhatsAppChat.Parse(filePath);

    // Read from stream
    chats = WhatsAppChat.Parse(new FileStream(filePath, FileMode.Open));

    foreach(var chat in chats)
        Console.WriteLine($"{chat.MessageBy} said {chat.Text} at {chat.TimeStamp}");
}

```

### Data Serialization

WhatsAppChatParser exposes extension methods to serialize the chat list. 


#### To JSON 
JSON serialization is handled internally using Newtonsoft.Json. All the `JsonConvert.SerializeObject` overloads are supported.

```
using Newtonsoft.Json;
using WhatsAppChatParser;

static void Main(string[] args)
{

    private readonly string filePath = @"C:\..\..WhatsApp Chat with John Doe.txt";
    var chats = WhatsAppChat.Parse(filePath);

    var json = chats.ToJSON(); 
    var indentedJson = chats.ToJSON(Formatting.Indented);
}

```

#### To XML 
XML serialization is handled internally using System.Xml.Serialization.XmlSerializer.

```
using WhatsAppChatParser;

static void Main(string[] args)
{

    private readonly string filePath = @"C:\..\..WhatsApp Chat with John Doe.txt";
    var chats = WhatsAppChat.Parse(filePath);

    var xml = chats.ToXML(); 
}

```

## TODO

- Implement ToCSV
- Support exported media
