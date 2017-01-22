using System;

namespace Programming1
{
    public class Publisher
    {
        public delegate void MessagePublish();
        public MessagePublish publishmsg = null;

        public void PublishMessage()
        {
            publishmsg.Invoke();
        }
    }
}