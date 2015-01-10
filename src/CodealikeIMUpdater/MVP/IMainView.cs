using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodealikeIMUpdater.MVP
{
    public interface IMainView
    {
        event Action<string> TestCodealike;
        event Action<string, string> TestHipChat;
        event Action<IMUpdaterSettings> Save;
        event Action<int> SetUpdateInterval;

        void ShowMessage(string message);
        void ShowError(string message);
        void SetIconFromStatus(API.CodealikeStatus currentStatus);
    }
}
