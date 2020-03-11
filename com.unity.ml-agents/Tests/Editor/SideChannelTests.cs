using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Text;
using MLAgents.SideChannels;

namespace MLAgents.Tests
{
    public class SideChannelTests
    {
        // This test side channel only deals in integers
        public class TestSideChannel : SideChannel
        {
            public List<int> messagesReceived = new List<int>();

            public TestSideChannel()
            {
                ChannelId = new Guid("6afa2c06-4f82-11ea-b238-784f4387d1f7");
            }

            public override void OnMessageReceived(byte[] data)
            {
                messagesReceived.Add(BitConverter.ToInt32(data, 0));
            }

            public void SendInt(int data)
            {
                QueueMessageToSend(BitConverter.GetBytes(data));
            }
        }

        [Test]
        public void TestIntegerSideChannel()
        {
            var intSender = new TestSideChannel();
            var intReceiver = new TestSideChannel();
            var dictSender = new Dictionary<Guid, SideChannel> { { intSender.ChannelId, intSender } };
            var dictReceiver = new Dictionary<Guid, SideChannel> { { intReceiver.ChannelId, intReceiver } };

            intSender.SendInt(4);
            intSender.SendInt(5);
            intSender.SendInt(6);

            byte[] fakeData = RpcCommunicator.GetSideChannelMessage(dictSender);
            RpcCommunicator.ProcessSideChannelData(dictReceiver, fakeData);

            Assert.AreEqual(intReceiver.messagesReceived[0], 4);
            Assert.AreEqual(intReceiver.messagesReceived[1], 5);
            Assert.AreEqual(intReceiver.messagesReceived[2], 6);
        }

        [Test]
        public void TestRawBytesSideChannel()
        {
            var str1 = "Test string";
            var str2 = "Test string, second";

            var strSender = new RawBytesChannel(new Guid("9a5b8954-4f82-11ea-b238-784f4387d1f7"));
            var strReceiver = new RawBytesChannel(new Guid("9a5b8954-4f82-11ea-b238-784f4387d1f7"));
            var dictSender = new Dictionary<Guid, SideChannel> { { strSender.ChannelId, strSender } };
            var dictReceiver = new Dictionary<Guid, SideChannel> { { strReceiver.ChannelId, strReceiver } };

            strSender.SendRawBytes(Encoding.ASCII.GetBytes(str1));
            strSender.SendRawBytes(Encoding.ASCII.GetBytes(str2));

            byte[] fakeData = RpcCommunicator.GetSideChannelMessage(dictSender);
            RpcCommunicator.ProcessSideChannelData(dictReceiver, fakeData);

            var messages = strReceiver.GetAndClearReceivedMessages();

            Assert.AreEqual(messages.Count, 2);
            Assert.AreEqual(Encoding.ASCII.GetString(messages[0]), str1);
            Assert.AreEqual(Encoding.ASCII.GetString(messages[1]), str2);
        }

        [Test]
        public void TestFloatPropertiesSideChannel()
        {
            var k1 = "gravity";
            var k2 = "length";
            int wasCalled = 0;

            var propA = new FloatPropertiesChannel();
            var propB = new FloatPropertiesChannel();
            var dictReceiver = new Dictionary<Guid, SideChannel> { { propA.ChannelId, propA } };
            var dictSender = new Dictionary<Guid, SideChannel> { { propB.ChannelId, propB } };

            propA.RegisterCallback(k1, f => { wasCalled++; });
            var tmp = propB.GetPropertyWithDefault(k2, 3.0f);
            Assert.AreEqual(tmp, 3.0f);
            propB.SetProperty(k2, 1.0f);
            tmp = propB.GetPropertyWithDefault(k2, 3.0f);
            Assert.AreEqual(tmp, 1.0f);

            byte[] fakeData = RpcCommunicator.GetSideChannelMessage(dictSender);
            RpcCommunicator.ProcessSideChannelData(dictReceiver, fakeData);

            tmp = propA.GetPropertyWithDefault(k2, 3.0f);
            Assert.AreEqual(tmp, 1.0f);

            Assert.AreEqual(wasCalled, 0);
            propB.SetProperty(k1, 1.0f);
            Assert.AreEqual(wasCalled, 0);
            fakeData = RpcCommunicator.GetSideChannelMessage(dictSender);
            RpcCommunicator.ProcessSideChannelData(dictReceiver, fakeData);
            Assert.AreEqual(wasCalled, 1);
        }
    }
}
