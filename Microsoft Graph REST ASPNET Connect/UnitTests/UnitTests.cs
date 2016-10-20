/* 
*  Copyright (c) Microsoft. All rights reserved. Licensed under the MIT license. 
*  See LICENSE in the source repository root for complete license information. 
*/

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using Microsoft_Graph_REST_ASPNET_Connect.Models;

namespace UnitTests
{
    [TestClass]
    public class Tests
    {
        private static string accessToken = null;
        private static string clientId = Environment.GetEnvironmentVariable("test_client_id");
        private static string clientSecret = Environment.GetEnvironmentVariable("test_client_secret");
        private static string userName = Environment.GetEnvironmentVariable("test_user_name");
        private static string password = Environment.GetEnvironmentVariable("test_password");

        [TestMethod]
        // Get an access token to use for testing the sample calls.
        public void GetAccessTokenUsingPasswordGrant()
        {
            JObject jResult = null;
            String urlParameters = String.Format(
                    "grant_type={0}&resource={1}&client_id={2}&client_secret={3}&username={4}&password={5}",
                    "password",
                    "https%3A%2F%2Fgraph.microsoft.com%2F",
                    clientId,
                    clientSecret,
                    userName,
                    password
            );

            HttpClient client = new HttpClient();
            var body = new StringContent(urlParameters, System.Text.Encoding.UTF8, "application/x-www-form-urlencoded");
            Task<HttpResponseMessage> requestTask = client.PostAsync("https://login.microsoftonline.com/common/oauth2/token", body);
            requestTask.Wait();
            HttpResponseMessage response = requestTask.Result;

            if (response.IsSuccessStatusCode)
            {
                Task<string> responseTask = response.Content.ReadAsStringAsync();
                responseTask.Wait();
                string responseContent = responseTask.Result;
                jResult = JObject.Parse(responseContent);
                accessToken = (string)jResult["access_token"];
            }

            Assert.IsNotNull(accessToken, accessToken.Substring(0, 12));
        }

        [TestMethod]
        // Test GraphService.GetMyEmailAddress method. 
        // Gets the email address of the test account.
        // Success: Retrieved email address matches test account's email address.
        public async Task GetMyEmailAddress()
        {
            // Arrange
            GraphService graphService = new GraphService();
            string emailAddress = null;

            // Act
            emailAddress = await graphService.GetMyEmailAddress(accessToken);

            // Assert
            Assert.IsTrue(emailAddress.ToLower() == userName.ToLower(), emailAddress.ToString());
        }

        [TestMethod]
        // Test GraphService.SendEmail method. 
        // Sends an email to the test account from the test account.
        // Success: Response reason is expected.
        public async Task SendEmail()
        {
            // Arrange
            GraphService graphService = new GraphService();
            List<Recipient> recipientList = new List<Recipient>();
            recipientList.Add(new Recipient
            {
                EmailAddress = new UserInfo
                {
                    Address = userName
                }
            });
            Message message = new Message
            {
                Body = new ItemBody
                {
                    Content = "<html><body>The body of the test email.</body></html>",
                    ContentType = "HTML"
                },
                Subject = "Test email from ASP.NET 4.6 Connect sample",
                ToRecipients = recipientList
            };
            MessageRequest email = new MessageRequest
            {
                Message = message,
                SaveToSentItems = true
            };

            // Act
            string response = await graphService.SendEmail(accessToken, email);

            // Assert
            Assert.IsTrue(response == "Success! Your mail was sent.");
        }
    }
}
