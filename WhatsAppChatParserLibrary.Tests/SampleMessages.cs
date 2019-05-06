namespace WhatsAppChatParser.Tests
{
    internal class TestMessages
    {
        internal const string VALID_MESSAGE = "25/08/18, 5:29 pm - John Doe: This doesn't count";
        internal const string WHATSAPP_MESSAGE = "25/08/18, 5:28 pm - Messages to this chat and calls are now secured with end-to-end encryption. Tap for more info.";
        internal const string VALID_MESSAGE_WITH_EMOJI = "25/08/18, 5:48 pm - Jane Doe: 😂";
        internal const string VALID_MESSAGE_ON_NEW_LINE = "on em like \"This is why you shouldn't leave your phone unlocked\" and at the end, singed by your name";
        internal const string VALID_MESSAGE_WITH_URL = "28/08/18, 7:12 am - John Doe: https://abc.craigslist.co.in/cpg/d/play/6670480900.html";
        internal const string VALID_MESSAGE_WITH_SMILEY = "28/08/18, 8:55 am - John Doe: His back story :P";
        internal const string VALID_MESSAGE_WITH_COMMA = "28/08/18, 9:17 am - John Doe: Also, please check online if this idea isn't taken already";
        internal const string VALID_MESSAGE_WITH_HYPHEN = "28/08/18, 9:17 am - John Doe: Also- please check online if this idea isn't taken already";
    }
}
