/// This code was generated by
/// \ / _    _  _|   _  _
///  | (_)\/(_)(_|\/| |(/_  v1.0.0
///       /       /

using NUnit.Framework;
using System;
using Twilio.Converters;
using Twilio.TwiML;
using Twilio.TwiML.Messaging;

namespace Twilio.Tests.TwiML 
{

    [TestFixture]
    public class MessagingResponseTest : TwilioTest 
    {
        [Test]
        public void TestEmptyElement()
        {
            var elem = new MessagingResponse();

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Response></Response>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithExtraAttributes()
        {
            var elem = new MessagingResponse();
            elem.SetOption("newParam1", "value");
            elem.SetOption("newParam2", 1);

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Response newParam1=\"value\" newParam2=\"1\"></Response>",
                elem.ToString()
            );
        }

        [Test]
        public void TestNestElement()
        {
            var elem = new MessagingResponse();
            var child = new Message();
            elem.Nest(child).Body();

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Response>" + Environment.NewLine +
                "  <Message>" + Environment.NewLine +
                "    <Body></Body>" + Environment.NewLine +
                "  </Message>" + Environment.NewLine +
                "</Response>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithChildren()
        {
            var elem = new MessagingResponse();

            elem.Message(
                "body",
                "to",
                "from",
                new Uri("https://example.com"),
                Twilio.Http.HttpMethod.Get,
                new Uri("https://example.com")
            );

            elem.Redirect(new Uri("https://example.com"), Twilio.Http.HttpMethod.Get);

            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Response>" + Environment.NewLine +
                "  <Message to=\"to\" from=\"from\" action=\"https://example.com\" method=\"GET\" statusCallback=\"https://example.com\">body</Message>" + Environment.NewLine +
                "  <Redirect method=\"GET\">https://example.com</Redirect>" + Environment.NewLine +
                "</Response>",
                elem.ToString()
            );
        }

        [Test]
        public void TestElementWithTextNode()
        {
            var elem = new MessagingResponse();

            elem.AddText("Here is the content");
            
            Assert.AreEqual(
                "<?xml version=\"1.0\" encoding=\"utf-8\"?>" + Environment.NewLine +
                "<Response>Here is the content</Response>",
                elem.ToString()
            );
        }
    }
}
