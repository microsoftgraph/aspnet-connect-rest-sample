/* 
*  Copyright (c) Microsoft. All rights reserved. Licensed under the MIT license. 
*  See LICENSE in the source repository root for complete license information. 
*/

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Resources;

namespace Microsoft_Graph_REST_ASPNET_Connect.Models
{
    public class GraphService
    {

        // Get the current user's email address from their profile.
        public async Task<string> GetMyEmailAddress(string accessToken)
        {

            // Get the current user. 
            // The app only needs the user's email address, so select the mail and userPrincipalName properties.
            // If the mail property isn't defined, userPrincipalName should map to the email for all account types. 
            string endpoint = "https://graph.microsoft.com/v1.0/me";
            string queryParameter = "?$select=mail,userPrincipalName";
            UserInfo me = new UserInfo();

            using (var client = new HttpClient())
            {
                using (var request = new HttpRequestMessage(HttpMethod.Get, endpoint + queryParameter))
                {
                    request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                    // This header has been added to identify our sample in the Microsoft Graph service. If extracting this code for your project please remove.
                    request.Headers.Add("SampleID", "aspnet-connect-rest-sample");
                    using (HttpResponseMessage response = await client.SendAsync(request))
                    {
                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            var json = JObject.Parse(await response.Content.ReadAsStringAsync());
                            me.Address = !string.IsNullOrEmpty(json.GetValue("mail").ToString()) ? json.GetValue("mail").ToString() : json.GetValue("userPrincipalName").ToString();
                        }
                        return me.Address?.Trim();
                    }
                }
            }
        }
        // Send an email message from the current user.
        public async Task<string> SendEmail(string accessToken, MessageRequest email)
        {
            string endpoint = "https://graph.microsoft.com/v1.0/me/sendMail";
            using (var client = new HttpClient())
            {
                using (var request = new HttpRequestMessage(HttpMethod.Post, endpoint))
                {
                    request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

                    // This header has been added to identify our sample in the Microsoft Graph service. If extracting this code for your project please remove.
                    request.Headers.Add("SampleID", "aspnet-connect-rest-sample");               
                    request.Content = new StringContent(JsonConvert.SerializeObject(email), Encoding.UTF8, "application/json");
                    using (HttpResponseMessage response = await client.SendAsync(request))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            return Resource.Graph_SendMail_Success_Result;
                        }
                        return response.ReasonPhrase;
                    }
                }
            }
        }

        // Create the email message.
        public MessageRequest BuildEmailMessage(string recipients, string subject)
        {

            // Prepare the recipient list.
            string[] splitter = { ";" };
            string[] splitRecipientsString = recipients.Split(splitter, StringSplitOptions.RemoveEmptyEntries);
            List<Recipient> recipientList = new List<Recipient>();
            foreach (string recipient in splitRecipientsString)
            {
                recipientList.Add(new Recipient
                {
                    EmailAddress = new UserInfo
                    {
                        Address = recipient.Trim()
                    }
                });
            }

            // Build the email message.
            Message message = new Message
            {
                Body = new ItemBody
                {
                    Content = Resource.Graph_SendMail_Body_Content,
                    ContentType = "HTML"
                },
                Subject = subject,
                ToRecipients = recipientList
            };

            return new MessageRequest
            {
                Message = message,
                SaveToSentItems = true
            };
        }
    }
}