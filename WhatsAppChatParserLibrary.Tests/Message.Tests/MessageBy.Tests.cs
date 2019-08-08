using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;

namespace WhatsAppChatParser.Tests
{
    [TestClass]
    public class MessageByTests
    {
        [TestMethod]
        public void Parse_ValidMessage_ValidMessageBy()
        {
            var validMessage = TestMessages.VALID_MESSAGE;
            var expectedMessageBy = "John Doe";

            var chatMessage = Message.Parse(validMessage, TestCultures.INDIAN_CULTURE);

            Assert.AreEqual(chatMessage.MessageBy, expectedMessageBy);
        }

        [TestMethod]
        public void Parse_WhatsAppMessage_NullMessageBy()
        {
            var whatsappMessage = TestMessages.WHATSAPP_MESSAGE;
            string expectedMessageBy = null;

            var chatMessage = Message.Parse(whatsappMessage, TestCultures.INDIAN_CULTURE);

            Assert.AreEqual(chatMessage.MessageBy, expectedMessageBy);
        }

        [TestMethod]
        public void Parse_OnlyMessageText_EmptyMessageBy()
        {
            var validMessage = TestMessages.VALID_MESSAGE_ON_NEW_LINE;

            var chatMessage = Message.Parse(validMessage, TestCultures.INDIAN_CULTURE);

            Assert.AreEqual(chatMessage.MessageBy, null);
        }

        [TestMethod]
        public void Parse_ValidMessageWithUrl_ValidMessageBy()
        {
            var validMessage = TestMessages.VALID_MESSAGE_WITH_URL;
            var expectedMessageBy = "John Doe";

            var chatMessage = Message.Parse(validMessage, TestCultures.INDIAN_CULTURE);

            Assert.AreEqual(chatMessage.MessageBy, expectedMessageBy);
        }

        [TestMethod]
        public void Parse_ValidMessageWithSmiley_ValidMessageBy()
        {
            var validMessage = TestMessages.VALID_MESSAGE_WITH_SMILEY;
            var expectedMessageBy = "John Doe";

            var chatMessage = Message.Parse(validMessage, TestCultures.INDIAN_CULTURE);

            Assert.AreEqual(chatMessage.MessageBy, expectedMessageBy);
        }        

        [TestMethod]
        public void Parse_ValidMessageWithHyphen_ValidMessageBy()
        {
            var validMessage = TestMessages.VALID_MESSAGE_WITH_HYPHEN;
            var expectedMessageBy = "John Doe";

            var chatMessage = Message.Parse(validMessage, TestCultures.INDIAN_CULTURE);

            Assert.AreEqual(chatMessage.MessageBy, expectedMessageBy);
        }
    }
}
