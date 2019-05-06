using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace WhatsAppChatParser.Tests
{
    [TestClass]
    public class DateTimeTests
    {
        [TestMethod]
        public void Parse_ValidMessage_ValidTimeStamp()
        {
            var validMessage = TestMessages.VALID_MESSAGE;
            var expectedTimestamp = new DateTime(2018, 08, 25, 17, 29, 0);

            var chatMessage = Message.Parse(validMessage);

            Assert.AreEqual(chatMessage.TimeStamp, expectedTimestamp);
        }

        [TestMethod]
        public void Parse_WhatsAppMessage_ValidTimeStamp()
        {
            var whatsappMessage = TestMessages.WHATSAPP_MESSAGE;
            var expectedTimestamp = new DateTime(2018, 08, 25, 17, 28, 0);

            var chatMessage = Message.Parse(whatsappMessage);

            Assert.AreEqual(chatMessage.TimeStamp, expectedTimestamp);
        }

        [TestMethod]
        public void Parse_OnlyMessageText_EmptyTimeStamp()
        {
            var validMessage = TestMessages.VALID_MESSAGE_ON_NEW_LINE;

            var chatMessage = Message.Parse(validMessage);

            Assert.AreEqual(chatMessage.TimeStamp, default);
        }

        [TestMethod]
        public void Parse_ValidMessageWithComma_ValidTimeStamp()
        {
            var validMessage = TestMessages.VALID_MESSAGE_WITH_COMMA;
            var expectedTimestamp = new DateTime(2018, 08, 28, 9, 17, 0);

            var chatMessage = Message.Parse(validMessage);

            Assert.AreEqual(chatMessage.TimeStamp, expectedTimestamp);
        }
    }
}
