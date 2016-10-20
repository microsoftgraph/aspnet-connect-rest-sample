using System;
using System.Collections.Generic;

namespace Microsoft_Graph_REST_ASPNET_Connect.Models
{
    public class UserInfo
    {
        public string Address { get; set; }
    }

    public class Message
    {
        public string Subject { get; set; }
        public ItemBody Body { get; set; }
        public List<Recipient> ToRecipients { get; set; }
    }

    public class Recipient
    {
        public UserInfo EmailAddress { get; set; }
    }

    public class ItemBody
    {
        public string ContentType { get; set; }
        public string Content { get; set; }
    }

    public class MessageRequest
    {
        public Message Message { get; set; }
        public bool SaveToSentItems { get; set; }
    }
}