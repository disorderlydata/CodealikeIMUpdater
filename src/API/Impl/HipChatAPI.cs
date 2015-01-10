using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Impl
{
    public class HipChatAPI : IHipChatAPI
    {
        private const string EndpointHost = "https://api.hipchat.com/v2/";

        public HipChatUser GetUser(string token, string emailAddress)
        {
            var encodedEmail = RestSharp.Contrib.HttpUtility.UrlEncode(emailAddress);
            var resourceUrl = string.Format("user/{0}", encodedEmail);

            var client = new RestClient(EndpointHost);
            var request = new RestRequest(resourceUrl);

            request.AddQueryParameter("auth_token", token);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-type", "application/json");
            request.AddHeader("Accept", "application/json");
            var response = client.Execute(request);

            var user = SimpleJson.DeserializeObject<HipChatUser>(response.Content);
            return user;
        }

        public bool UpdateUserStatus(string token, HipChatUser user)
        {
            if (user == null || user.presence == null || string.IsNullOrWhiteSpace(user.name) 
                || string.IsNullOrWhiteSpace(user.email) || string.IsNullOrWhiteSpace(user.mention_name))
            {
                throw new ArgumentException("user");
            }

            var encodedEmail = RestSharp.Contrib.HttpUtility.UrlEncode(user.email);
            var resourceUrl = string.Format("user/{0}", encodedEmail);

            var client = new RestClient(EndpointHost);
            var request = new RestRequest(resourceUrl, Method.PUT);
            request.AddQueryParameter("auth_token", token);

            request.AddJsonBody(user);

            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-type", "application/json");
            request.AddHeader("Accept", "application/json");

            IRestResponse response;
            try
            {
                response = client.Execute(request);
            }
            catch (Exception)
            {
                return false;
            }

            if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
            {
                return true;
            }

            return false;
        }
    }
}