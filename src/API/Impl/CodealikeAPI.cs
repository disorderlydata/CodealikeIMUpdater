using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Impl
{
    public class CodealikeAPI : ICodealikeAPI
    {
        public CodealikeStatus GetUsersStatus(string userName)
        {
            var client = new RestClient("https://codealike.com/api/v2/public");

            var request = new RestRequest("CanInterruptUser", Method.POST);
            request.AddParameter("UserNames", userName);

            var response = client.Execute(request);

            var obj2 = SimpleJson.DeserializeObject<RawResponse[]>(response.Content);

            if (obj2 == null || obj2.FirstOrDefault() == null)
            {
                return CodealikeStatus.NoActivity;
            }
            else if (obj2.FirstOrDefault().m_Item2.Equals("CanInterrupt", StringComparison.CurrentCultureIgnoreCase))
            {
                return CodealikeStatus.CanInterrupt;
            }
            else if (obj2.FirstOrDefault().m_Item2.Equals("CannotInterrupt", StringComparison.CurrentCultureIgnoreCase))
            {
                return CodealikeStatus.CannotInterrupt;
            }

            return CodealikeStatus.Unknown;
        }

        private class RawResponse
        {
            public string m_Item1 { get; set; }
            public string m_Item2 { get; set; }
        }
    }
}
