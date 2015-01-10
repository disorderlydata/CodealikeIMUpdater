using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace API.Specs
{
    [TestFixture]
    public class CodealikeAPISpecs
    {
        [Test]
        public void Should_get_users_status()
        {
            string userName = "kzhen";

            ICodealikeAPI api = new API.Impl.CodealikeAPI();

            var response = api.GetUsersStatus(userName);

            Assert.AreEqual(CodealikeStatus.CannotInterrupt, response);
        }
    }
}
