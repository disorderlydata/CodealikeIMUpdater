using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodealikeIMUpdater.MVP
{
    public class IMUpdaterSettings
    {
        public string CodealikeUsername { get; set; }
        public string HipChatToken { get; set; }
        public string HipChatEmail { get; set; }
        public int UpdateInterval { get; set; }

        public List<HipChatStatusMapping> HipChatStatusMappings { get; set; }
    }

    public class HipChatStatusMapping
    {
        public API.CodealikeStatus CodealikeStatus { get; set; }
        public string HipChatStatus { get; set; }
        public string HipChatMessage { get; set; }
    }
}
