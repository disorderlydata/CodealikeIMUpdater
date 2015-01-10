using API.Impl;
using NUnit.Framework;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace API.Specs
{
    [TestFixture]
    public class HipChatAPISpecs2
    {
        [Test]
        public void Should_get_HipChat_user()
        {
            string email = "";
            string token = "";

            IHipChatAPI api = new HipChatAPI();
            var user = api.GetUser(token, email);

            Assert.IsNotNull(user);
            Assert.AreEqual(email, user.email);
        }
    }
    
    [TestFixture]
    public class HipChatAPISpecs
    {
        private const string EndpointHost = "api.hipchat.com";
        private const string Token = "";
        private const string Email = "";

        [Test]
        public void Should_get_hipchat_capabilities()
        {
            var url = string.Format("https://{0}/v2", EndpointHost);

            var client = new RestClient(url);
            var request = new RestRequest("/capabilities", Method.GET);

            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-type", "application/json");
            request.AddHeader("Accept", "application/json");
            var response = client.Execute(request);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        [Test]
        public void Should_get_users_status()
        {
            var url = string.Format("https://{0}/v2", EndpointHost);

            var client = new RestClient(url);
            var request = new RestRequest("/user/" + RestSharp.Contrib.HttpUtility.UrlEncode(Email), Method.GET);
            request.AddQueryParameter("auth_token", Token);

            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-type", "application/json");
            request.AddHeader("Accept", "application/json");
            var response = client.Execute(request);
            var obj = SimpleJson.DeserializeObject(response.Content);
            var obj2 = SimpleJson.DeserializeObject<HipChatUser>(response.Content);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
        }

        private class HipChatUser
        {
            public string name { get; set; }
            public string status { get; set; }
            public string show { get; set; }
            public string email { get; set; }
            public Presence presence { get; set; }

            public string mention_name { get; set; }
        }

        private class Presence
        {
            public int idle { get; set; }
            public bool is_online { get; set; }
            public string show { get; set; } //chat, away, dnd
            public string status { get; set; } //status message
        }

        [Test]
        public void Should_update_users_status()
        {
            var url = string.Format("https://{0}/v2", EndpointHost);

            var client = new RestClient(url);
            var request = new RestRequest("/user/" + RestSharp.Contrib.HttpUtility.UrlEncode(Email), Method.PUT);
            request.AddQueryParameter("auth_token", Token);

            var user = new HipChatUser()
            {
                name = "",
                email = Email,
                presence = new Presence()
                {
                    status = "blah",
                    show = "away"
                },
                mention_name = ""
            };

            request.AddJsonBody(user);

            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-type", "application/json");
            request.AddHeader("Accept", "application/json");
            var response = client.Execute(request);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

        }
    }
}
