using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Microsoft_Graph_REST_ASPNET_Connect.Models
{
    public class UserInfo
    {
        public string Address { get; set; }
    }

    public class FileInfo
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string SharingLink { get; set; }
    }

    public class Message
    {
        public string Subject { get; set; }
        public ItemBody Body { get; set; }
        public List<Recipient> ToRecipients { get; set; }
        public List<Attachment> Attachments { get; set; }
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

    public class Attachment
    {
        [JsonProperty(PropertyName = "@odata.type")]
        public string ODataType { get; set; }
        public byte[] ContentBytes { get; set; }
        public string Name { get; set; }
    }

    public class PermissionInfo
    {
        public SharingLinkInfo Link { get; set; }
    }

    public class SharingLinkInfo
    {
        public SharingLinkInfo(string type)
        {
            Type = type;
        }

        public string Type { get; set; }
        public string WebUrl { get; set; }
    }
}