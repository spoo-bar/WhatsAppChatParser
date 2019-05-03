# WhatsAppChatParser

A C# parser for exported WhatsApp chat histories

![Nuget](https://img.shields.io/nuget/v/WhatsAppChatParser.svg?style=for-the-badge)

## Usage

```
using WhatsAppChatParserLibrary;

static void Main(string[] args)
{
    IEnumerable<Message> chats = WhatsAppChat.Parse("WhatsApp Chat with John Doe.txt");

    foreach(var chat in chats)
        Console.WriteLine($"{chat.MessageBy} said {chat.Text} at {chat.TimeStamp}");
}

```