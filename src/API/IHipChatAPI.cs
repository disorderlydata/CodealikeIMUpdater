using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API
{
    public interface IHipChatAPI
    {
        HipChatUser GetUser(string token, string emailAddress);
        bool UpdateUserStatus(string token, HipChatUser user);
    }
}
