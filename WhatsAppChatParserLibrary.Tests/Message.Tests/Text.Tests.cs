using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;

namespace WhatsAppChatParser.Tests
{
    [TestClass]
    public class TextTests
    {
        [TestMethod]
        public void Parse_ValidMessage_ValidMessage()
        {
            var validMessage = TestMessages.VALID_MESSAGE;
            var expectedMessage = "This doesn't count";

            var chatMessage = Message.Parse(validMessage, TestCultures.INDIAN_CULTURE);

            Assert.AreEqual(chatMessage.Text, expectedMessage);
        }

        [TestMethod]
        public void Parse_ValidMessageWithEmoji_ValidMessage()
        {
            var validMessage = TestMessages.VALID_MESSAGE_WITH_EMOJI;
            var expectedMessage = "😂";

            var chatMessage = Message.Parse(validMessage, TestCultures.INDIAN_CULTURE);

            Assert.AreEqual(chatMessage.Text, expectedMessage);
        }

        [TestMethod]
        public void Parse_WhatsAppMessage_ValidMessage()
        {
            var whatsappMessage = TestMessages.WHATSAPP_MESSAGE;
            var expectedMessage = "Messages to this chat and calls are now secured with end-to-end encryption. Tap for more info.";

            var chatMessage = Message.Parse(whatsappMessage, TestCultures.INDIAN_CULTURE);

            Assert.AreEqual(chatMessage.Text, expectedMessage);
        }

        [TestMethod]
        public void Parse_OnlyMessageText_ValidMessage()
        {
            var validMessage = TestMessages.VALID_MESSAGE_ON_NEW_LINE;
            var expectedMessage = "on em like \"This is why you shouldn't leave your phone unlocked\" and at the end, singed by your name";

            var chatMessage = Message.Parse(validMessage, TestCultures.INDIAN_CULTURE);

            Assert.AreEqual(chatMessage.Text, expectedMessage);
        }

        [TestMethod]
        public void Parse_ValidMessageWithUrl_ValidMessage()
        {
            var validMessage = TestMessages.VALID_MESSAGE_WITH_URL;
            var expectedMessage = "https://abc.craigslist.co.in/cpg/d/play/6670480900.html";

            var chatMessage = Message.Parse(validMessage, TestCultures.INDIAN_CULTURE);

            Assert.AreEqual(chatMessage.Text, expectedMessage);
        }

        [TestMethod]
        public void Parse_ValidMessageWithSmiley_ValidMessage()
        {
            var validMessage = TestMessages.VALID_MESSAGE_WITH_SMILEY;
            var expectedMessage = "His back story :P";

            var chatMessage = Message.Parse(validMessage, TestCultures.INDIAN_CULTURE);

            Assert.AreEqual(chatMessage.Text, expectedMessage);
        }

        [TestMethod]
        public void Parse_ValidMessageWithComma_ValidMessage()
        {
            var validMessage = TestMessages.VALID_MESSAGE_WITH_COMMA;
            var expectedMessage = "Also, please check online if this idea isn't taken already";

            var chatMessage = Message.Parse(validMessage, TestCultures.INDIAN_CULTURE);

            Assert.AreEqual(chatMessage.Text, expectedMessage);
        }

        [TestMethod]
        public void Parse_ValidMessageWithHyphen_ValidMessage()
        {
            var validMessage = TestMessages.VALID_MESSAGE_WITH_HYPHEN;
            var expectedMessage = "Also- please check online if this idea isn't taken already";

            var chatMessage = Message.Parse(validMessage, TestCultures.INDIAN_CULTURE);

            Assert.AreEqual(chatMessage.Text, expectedMessage);
        }

    }
}
