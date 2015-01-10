using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API
{
    public class HipChatUser
    {
        public string name { get; set; }
        public string email { get; set; }
        public string mention_name { get; set; }
        public Presence presence { get; set; }

    }

    public class Presence
    {
        /// <summary>
        /// available, away, dnd
        /// </summary>
        public string show { get; set; } //chat, away, dnd
        /// <summary>
        /// The status message shown in HipChat
        /// </summary>
        public string status { get; set; } //status message
    }
}