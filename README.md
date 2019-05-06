# WhatsAppChatParser

A C# parser for exported WhatsApp chat histories

![Nuget](https://img.shields.io/nuget/v/WhatsAppChatParser.svg?style=for-the-badge) 

![GitHub last commit](https://img.shields.io/github/last-commit/spoon611/WhatsAppChatParser.svg?color=red&style=for-the-badge) ![GitHub Release Date](https://img.shields.io/github/release-date/spoon611/WhatsAppChatParser.svg?style=for-the-badge)  ![GitHub](https://img.shields.io/github/license/spoon611/WhatsAppChatParser.svg?style=for-the-badge)

## Usage

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